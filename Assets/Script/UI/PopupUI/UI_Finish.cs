using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UI_Finish : UI_Popup
{
    enum GameObjects
    {
        FinishPannel,
        RecordImage,
        ScoreImage,
        FinishButton
    }

    private void Start()
    {
        Init();
    }

    protected override void Init()
    {
        base.Init();

        Bind<GameObject>(typeof(GameObjects));

        GameObject button = Get<GameObject>((int)GameObjects.FinishButton);

        button.BindEvent(OnClickedEvent);
    }

    void OnClickedEvent(PointerEventData evt)
    {
        GameManager.Scene.LoadScene(Define.Scene.MainScene);
    }

    public void SetScore(int score, int maxCarNum)
    {
        float result = (float)score / (float)maxCarNum;

        Bind<GameObject>(typeof(GameObjects));
        Image scoreImage = Get<GameObject>((int)GameObjects.ScoreImage).GetComponent<Image>();

        if (result > 0.8f)
        {
            scoreImage.sprite = GameManager.Resource.Load<Sprite>("Graphic/Clear_Score3");
        }
        else if (result > 0.6f)
        {
            scoreImage.sprite = GameManager.Resource.Load<Sprite>("Graphic/Clear_Score2");
        }
        else if (result > 0.4f)
        {
            scoreImage.sprite = GameManager.Resource.Load<Sprite>("Graphic/Clear_Score1");
        }
        else
        {
            scoreImage.sprite = GameManager.Resource.Load<Sprite>("Graphic/Clear_Score0");
        }
    }
}

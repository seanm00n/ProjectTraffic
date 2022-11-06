using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UI_Finish : UI_Popup
{

    Image scoreSprite;
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

        GameObject scoreImage = Get<GameObject>((int)GameObjects.ScoreImage);
        scoreSprite = scoreImage.GetComponent<Image>();
    }

    void OnClickedEvent(PointerEventData evt)
    {
        GameManager.Scene.LoadScene(Define.Scene.MainScene);
    }

    public void SetScore(int score, int maxCarNum)
    {
        float result = (float)score / (float)maxCarNum;

        if (result > 0.8f)
        {
            scoreSprite.sprite = GameManager.Resource.Load<Sprite>("Graphic/Clear_Score3");
        }
        else if (result > 0.6f)
        {
            scoreSprite.sprite = GameManager.Resource.Load<Sprite>("Graphic/Clear_Score2");
        }
        else if (result > 0.4f)
        {
            scoreSprite.sprite = GameManager.Resource.Load<Sprite>("Graphic/Clear_Score1");
        }
        else
        {
            scoreSprite.sprite = GameManager.Resource.Load<Sprite>("Graphic/Clear_Score0");
        }
    }
}

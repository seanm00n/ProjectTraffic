using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

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
}

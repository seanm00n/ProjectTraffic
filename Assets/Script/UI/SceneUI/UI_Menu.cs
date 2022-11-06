using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class UI_Menu : UI_Scene
{
    enum GameObjects
    {
        MainPannel,
        MenuPannel,
        StageButton1,
        StageButton2,
        StageButton3,
    }

    private void Start()
    {
        Init();
    }

    protected override void Init()
    {
        Bind<GameObject>(typeof(GameObjects));

        Get<GameObject>((int)GameObjects.StageButton1).BindEvent(GoStage1);
        Get<GameObject>((int)GameObjects.StageButton2).BindEvent(GoStage2);
        Get<GameObject>((int)GameObjects.StageButton3).BindEvent(GoStage3);
    }

    void GoStage1(PointerEventData evt)
    {
        GameManager.Scene.LoadScene(Define.Scene.Stage1);
    }
    void GoStage2(PointerEventData evt)
    {
        GameManager.Scene.LoadScene(Define.Scene.Stage2);
    }
    void GoStage3(PointerEventData evt)
    {
        GameManager.UI.ShowPopupUI<UI_Ready>();
    }
}

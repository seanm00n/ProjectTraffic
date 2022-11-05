using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class UI_StageButton : UI_Base
{
    enum GameObjects
    {
        StageButton
    }

    private void Start()
    {
        Init();
    }

    protected override void Init()
    {
        Bind<GameObject>(typeof(GameObjects));

        Get<GameObject>((int)GameObjects.StageButton).BindEvent(OnButtonClicked);
    }

    void OnButtonClicked(PointerEventData evt)
    {
        GameManager.Scene.LoadScene(Define.Scene.Stage2);
    }
}
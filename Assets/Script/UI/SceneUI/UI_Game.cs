using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UI_Game : UI_Scene
{
    enum GameObjects
    {
        PauseButton,
    }

    private void Start()
    {
        Init();
    }

    protected override void Init()
    {
        base.Init();

        Bind<GameObject>(typeof(GameObjects));

        Get<GameObject>((int)GameObjects.PauseButton).BindEvent(OnPopupMenuEvenet);
    }


    void OnPopupMenuEvenet(PointerEventData evt)
    {
        Time.timeScale = 0;
        GameManager.UI.ClosePopupUI();
        GameManager.UI.ShowPopupUI<UI_PopupMenu>();
    }
}

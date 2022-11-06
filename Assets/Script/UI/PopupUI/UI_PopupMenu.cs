using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class UI_PopupMenu : UI_Popup
{
    enum GameObjects
    {
        MenuPannel,
        MenuImage,
        ContinueButton,
        GoToMenuButton,
        GoToTitleButton
    }

    private void Start()
    {
        Init();
    }

    protected override void Init()
    {
        base.Init();

        Bind<GameObject>(typeof(GameObjects));

        Get<GameObject>((int)GameObjects.ContinueButton).BindEvent(OnContinueClicked);
        Get<GameObject>((int)GameObjects.GoToMenuButton).BindEvent(OnMenuButtonClicked);
        Get<GameObject>((int)GameObjects.GoToTitleButton).BindEvent(OnTitleButtonClicked);
    }

    void OnContinueClicked(PointerEventData evt)
    {
        GameManager.UI.ClosePopupUI();
    }
    void OnMenuButtonClicked(PointerEventData evt)
    {
        GameManager.Scene.LoadScene(Define.Scene.MainScene);
    }
    void OnTitleButtonClicked(PointerEventData evt)
    {
        GameManager.Scene.LoadScene(Define.Scene.TitleScene);
    }
}

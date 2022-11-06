using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UI_Title : UI_Scene
{
    enum GameObjects
    {
        BackGroundImage,
        StartButton,
        SettingButton,
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

        Get<GameObject>((int)GameObjects.StartButton).BindEvent(OnStartButtonClicked);
        Get<GameObject>((int)GameObjects.FinishButton).BindEvent(OnFinishButtonClicked);
    }

    void OnStartButtonClicked(PointerEventData evt)
    {
        GameManager.Scene.LoadScene(Define.Scene.MainScene);
    }
    void OnFinishButtonClicked(PointerEventData evt)
    {
        Application.Quit();
    }
}

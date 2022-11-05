using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainScene : BaseScene
{
    override protected void Init()
    {
        base.Init();

        SceneType = Define.Scene.MainScene;

        UI_Menu MenuUI = GameManager.UI.ShowSceneUI<UI_Menu>();

        GameManager.UI.MakeSubItem<UI_StageButton>(MenuUI.transform);
    }
}

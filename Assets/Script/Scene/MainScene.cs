using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainScene : BaseScene
{
    override protected void Init()
    {
        base.Init();

        SceneType = Define.Scene.MainScene;

        GameManager.UI.ShowSceneUI<UI_Menu>();
    }
}

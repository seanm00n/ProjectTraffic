using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleScene : BaseScene
{
    override protected void Init()
    {
        base.Init();

        SceneType = Define.Scene.TitleScene;

        GameManager.UI.ShowSceneUI<UI_Title>();
    }
}

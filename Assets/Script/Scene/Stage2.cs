using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage2 : BaseScene
{
    override protected void Init()
    {
        base.Init();

        SceneType = Define.Scene.GameScene;

        GameManager.UI.ShowSceneUI<UI_Game>();

        
    }


}


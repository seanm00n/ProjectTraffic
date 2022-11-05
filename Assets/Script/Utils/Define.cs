using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Define
{
    public enum clickEvent
    {
        Down,
        Drag,
        Up
    }

    public enum UIEvent
    {
        Click
    }

    public enum Scene
    {
        Unknown,
        TitleScene,
        MainScene,
        GameScene
    }

    public enum Sound
    {
        Bgm,
        Effect,
        MaxCount
    }
}

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
        Stage1,
        Stage2
    }

    public enum Sound
    {
        Bgm,
        Effect,
        MaxCount
    }
}

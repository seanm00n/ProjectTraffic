using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Define
{
    public enum clickEvent
    {
        Down,
    }

    public enum KeyEvent
    {
        Up,
        Down
    }

    public enum UIEvent
    {
        Click
    }

    public enum Layer
    {
        Car = 6,
        FinishLine = 7,
    }

    public enum Scene
    {
        Unknown,
        TitleScene,
        MainScene,
        Stage1,
        Stage2,
        Stage3,
    }

    public enum Sound
    {
        Bgm,
        Effect,
        MaxCount
    }

    public enum CarType
    {
        SmallCar,
        Truc
    }

    public enum CarDir
    {
        None,
        Straight,
        Left,
        Right,
    }

    public enum Lain
    {
        None,
        First,
        Seceond,
    }
}

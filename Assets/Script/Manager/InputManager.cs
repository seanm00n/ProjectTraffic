using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.EventSystems;

public class InputMnager
{
    public Action<Define.clickEvent> mouseAction;

    bool mousePressed;

    public void OnUpdate()
    {
        if (EventSystem.current.IsPointerOverGameObject())
        {
            if (mouseAction != null)
            {
                if (Input.GetMouseButtonDown(0))
                {
                    mouseAction.Invoke(Define.clickEvent.Down);
                    mousePressed = true;
                }
                if (Input.GetMouseButtonDown(0) && mousePressed)
                {
                    mouseAction.Invoke(Define.clickEvent.Drag);
                }
                if (Input.GetMouseButtonUp(0))
                {
                    mouseAction.Invoke(Define.clickEvent.Up);
                }
            }
        }
    }
}


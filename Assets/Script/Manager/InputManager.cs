using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.EventSystems;

public class InputMnager
{
    public Action<Define.clickEvent> MouseAction;

    bool mousePressed;

    public void OnUpdate()
    {
        // 입력이 있는지 체크
        if (EventSystem.current.IsPointerOverGameObject())
        {
            return;
        }
        // 마우스 이벤트가 있는지 체크
        if (MouseAction != null)
        {
            // 다운
            if (Input.GetMouseButtonDown(0))
            {
                MouseAction.Invoke(Define.clickEvent.Down);
                mousePressed = true;
            }
            // 드래그
            if (Input.GetMouseButtonDown(0) && mousePressed)
            {
                MouseAction.Invoke(Define.clickEvent.Drag);
            }
            // 업
            if (Input.GetMouseButtonUp(0))
            {
                MouseAction.Invoke(Define.clickEvent.Up);
            }
        }
    }
}



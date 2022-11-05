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
        // 입력이 있는지 체크
        if (EventSystem.current.IsPointerOverGameObject())
        {
            // 마우스 이벤트가 있는지 체크
            if (mouseAction != null)
            {
                // 다운
                if (Input.GetMouseButtonDown(0))
                {
                    mouseAction.Invoke(Define.clickEvent.Down);
                    mousePressed = true;
                }
                // 드래그
                if (Input.GetMouseButtonDown(0) && mousePressed)
                {
                    mouseAction.Invoke(Define.clickEvent.Drag);
                }
                // 업
                if (Input.GetMouseButtonUp(0))
                {
                    mouseAction.Invoke(Define.clickEvent.Up);
                }
            }
        }
    }
}


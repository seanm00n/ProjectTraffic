using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.EventSystems;

public class InputMnager
{
    public Action KeyAction;
    public Action<Define.clickEvent> MouseAction;

    public void OnUpdate()
    {
        // 입력이 있는지 체크
        if (EventSystem.current.IsPointerOverGameObject())
        {
            return;
        }

        // 키보드 이벤트
        if (Input.anyKey && KeyAction != null)
            KeyAction.Invoke();

        // 마우스 이벤트
        if (MouseAction != null && Input.GetMouseButtonDown(0))
        {
            MouseAction.Invoke(Define.clickEvent.Down);
        }
    }
}



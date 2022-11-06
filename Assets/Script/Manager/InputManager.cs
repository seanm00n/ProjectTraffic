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
        // �Է��� �ִ��� üũ
        if (EventSystem.current.IsPointerOverGameObject())
        {
            return;
        }

        // Ű���� �̺�Ʈ
        if (Input.anyKey && KeyAction != null)
            KeyAction.Invoke();

        // ���콺 �̺�Ʈ
        if (MouseAction != null && Input.GetMouseButtonDown(0))
        {
            MouseAction.Invoke(Define.clickEvent.Down);
        }
    }
}



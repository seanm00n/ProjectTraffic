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
        // �Է��� �ִ��� üũ
        if (EventSystem.current.IsPointerOverGameObject())
        {
            return;
        }
        // ���콺 �̺�Ʈ�� �ִ��� üũ
        if (MouseAction != null)
        {
            // �ٿ�
            if (Input.GetMouseButtonDown(0))
            {
                MouseAction.Invoke(Define.clickEvent.Down);
                mousePressed = true;
            }
            // �巡��
            if (Input.GetMouseButtonDown(0) && mousePressed)
            {
                MouseAction.Invoke(Define.clickEvent.Drag);
            }
            // ��
            if (Input.GetMouseButtonUp(0))
            {
                MouseAction.Invoke(Define.clickEvent.Up);
            }
        }
    }
}



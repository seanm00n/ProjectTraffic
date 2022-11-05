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
        // �Է��� �ִ��� üũ
        if (EventSystem.current.IsPointerOverGameObject())
        {
            // ���콺 �̺�Ʈ�� �ִ��� üũ
            if (mouseAction != null)
            {
                // �ٿ�
                if (Input.GetMouseButtonDown(0))
                {
                    mouseAction.Invoke(Define.clickEvent.Down);
                    mousePressed = true;
                }
                // �巡��
                if (Input.GetMouseButtonDown(0) && mousePressed)
                {
                    mouseAction.Invoke(Define.clickEvent.Drag);
                }
                // ��
                if (Input.GetMouseButtonUp(0))
                {
                    mouseAction.Invoke(Define.clickEvent.Up);
                }
            }
        }
    }
}


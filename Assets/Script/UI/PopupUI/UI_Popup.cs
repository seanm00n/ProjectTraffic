using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Popup : UI_Base
{
    protected void ClosePopupUI()
    {
        GameManager.UI.ClosePopupUI();
    }
    protected void CloseAllPopupUI()
    {
        GameManager.UI.CloseAllPopupUI();
    }

    protected override void Init()
    {
        
    }
}

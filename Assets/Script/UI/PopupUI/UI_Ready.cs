using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Ready : UI_Popup
{
    private void Start()
    {
        Destroy(gameObject, 3);
    }
}

using UnityEngine;
using System;
using Unity.PlasticSCM.Editor.WebApi;

public class CarCtrl : MonoBehaviour
{
    float moveCoolTime = 0f;
    bool isArrived = false;
    private void Start()
    {
        
    }
    private void Update()
    {
        if (!isArrived)
        {
            moveCoolTime = Time.time;
            transform.position = new Vector3((float)Math.Truncate(moveCoolTime), 0, 0);
        }
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        isArrived = true;   
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Car : MonoBehaviour
{
    public Define.CarDir carDir;
    public Define.CarType carType;
    public float speed = 0;
    public bool moving = true;

    private void Update()
    {
        
        if(moving)
        {
            speed += Time.deltaTime;
            //transform.Translate(Vector3.right * (float)Math.Truncate(speed)*0.01f);
            transform.position = new Vector3(((float)Math.Truncate(speed)*1.6f)-8,transform.position.y,transform.position.z);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == (int)Define.Layer.Car || collision.gameObject.layer == (int)Define.Layer.FinishLine)
            moving = false;
    }

    public void SetDir(Define.CarDir _carDir)
    {
        carDir = _carDir;
    }
}
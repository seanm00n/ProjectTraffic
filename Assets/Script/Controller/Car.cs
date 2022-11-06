using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Timeline;
using UnityEngine;

public class Car : MonoBehaviour
{
    Define.CarDir carDir;
    Define.CarType carType;
    float speed;

    public bool moving = true;

    private void Update()
    {
        speed += Time.deltaTime;
        if(moving)
        {
            //transform.Translate(Vector3.right * Time.deltaTime * 1.5f);
            transform.position = new Vector3
                ((float)Math.Truncate(speed), transform.position.y, transform.position.z);
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
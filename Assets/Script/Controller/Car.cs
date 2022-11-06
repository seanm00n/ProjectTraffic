using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    Define.CarDir carDir;
    Define.CarType carType;

    public bool moving = true;

    private void Update()
    {
        if(moving)
        {
            transform.Translate(Vector3.right * Time.deltaTime * 1.5f);
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
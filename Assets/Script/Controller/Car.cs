using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    public Define.CarDir carDir;
    public Define.CarType carType;
    public float speed = 0;
    public bool moving = true;

    private void Start()
    {
        Init();
    }

    void Init()
    {
        switch (carDir)
        {
            case Define.CarDir.Straight:
                transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = GameManager.Resource.Load<Sprite>("Graphic/Arrow_R");
                break;
            case Define.CarDir.Left:
                transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = GameManager.Resource.Load<Sprite>("Graphic/Arrow_U");
                break;
            case Define.CarDir.Right:
                transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = GameManager.Resource.Load<Sprite>("Graphic/Arrow_D");
                break;
        }
    }

    private void Update()
    {
        if(moving)
        {
            speed += Time.deltaTime;
            //transform.Translate(Vector3.right * Time.deltaTime * 1.5f);
            transform.position = new Vector3(((float)Math.Truncate(speed) * 1.6f) - 8, transform.position.y, transform.position.z);
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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 6 && collision.GetComponent<Car>().moving)
        {
            
        }
    }
}
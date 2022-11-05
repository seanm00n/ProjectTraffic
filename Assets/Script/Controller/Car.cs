using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    Define.CarDir carDir;
    Define.CarType carType;

    private void Update()
    {
        transform.Translate(Vector3.right * Time.deltaTime);
    }
}
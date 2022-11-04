using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CarData;
public class CarCtrl : MonoBehaviour
{
    Car car;
    [SerializeField] 
    int number;

    void Start()
    {
        car = new Car();
    }
    void Update()
    {
        
    }
}

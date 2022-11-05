using CarData;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarManager : MonoBehaviour
{
    Destination destination = Destination.front; //차 방향
    Species species = Species.mini; //차 종류
    Car[] car; //객체 배열
    int m_currentCarNum = 0;
    public int MAX_CAR_NUM = 10;


    void Start()
    {
        car = new Car[MAX_CAR_NUM];
        GenerateCar(m_currentCarNum);
    }
    void GenerateCar(int p_currentCarNum)
    {
        car[p_currentCarNum] = new Car(p_currentCarNum, destination, species);
        GameObject prefab = GameManager.Resource.Instantiate("Object/Car");
        m_currentCarNum++;
    }
}

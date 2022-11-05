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

    [SerializeField]
    GameObject prefab;//테스트용 프리펩
    private void Start()
    {
        car = new Car[MAX_CAR_NUM];
        GenerateCar(m_currentCarNum);
    }
    void GenerateCar(int p_currentCarNum)
    {
        car[p_currentCarNum] = new Car(p_currentCarNum, destination, species);
        Instantiate(prefab,transform.position ,Quaternion.identity);
        m_currentCarNum++;
    }
}

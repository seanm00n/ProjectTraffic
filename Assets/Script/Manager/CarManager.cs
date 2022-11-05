using CarData;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarManager : MonoBehaviour
{
    public Destination destination = Destination.front; //�� ����
    public Species species = Species.mini; //�� ����
    public Car[] car; //��ü �迭
    public int m_currentCarNum = 0;
    public int carNumber;
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

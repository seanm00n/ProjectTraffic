using Newtonsoft.Json.Linq;
using ObjectData;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;

public class GameController01 : MonoBehaviour
{
    Destination destination = Destination.front; //차 방향
    Species species = Species.Car; //차 종류

    Car[] car; //객체 배열

    [SerializeField]
    int MAX_CAR_NUM;

    private void Start()
    {
        car = new Car[MAX_CAR_NUM];
        
        Init();
        StartCoroutine(Car1());
        StartCoroutine(Car2());
        StartCoroutine(Car3());
        StartCoroutine(Car4());
        StartCoroutine(Car5());
        StartCoroutine(Car6());
        StartCoroutine(Car7());
        StartCoroutine(Car8());

    }
    private void Update()
    {
        
    }
    //게임 승리,패배 조건
    void Init()
    {
        car[0].setDestination(Destination.front);
        car[0].setPosition(0);
        car[1].setDestination(Destination.up);
        car[1].setPosition(1);
        car[2].setDestination(Destination.front);
        car[2].setPosition(0);
        car[3].setDestination(Destination.down);
        car[3].setPosition(0);
        car[4].setDestination(Destination.up);
        car[4].setPosition(1);
        car[5].setDestination(Destination.up);
        car[5].setPosition(0);
        car[6].setDestination(Destination.front);
        car[6].setPosition(1);
        car[7].setDestination(Destination.down);
        car[7].setPosition(0);
    }

    IEnumerator Car1()
    {
        yield return new WaitForSeconds(1f);
        car[0].Instanting();
    }

    IEnumerator Car2()
    {
        yield return new WaitForSeconds(12f);
        car[1].Instanting();
    }

    IEnumerator Car3()
    {
        yield return new WaitForSeconds(18f);
        car[2].Instanting();
    }

    IEnumerator Car4()
    {
        yield return new WaitForSeconds(19f);
        car[3].Instanting();
    }

    IEnumerator Car5()
    {
        yield return new WaitForSeconds(24f);
        car[4].Instanting();
    }

    IEnumerator Car6()
    {
        yield return new WaitForSeconds(27f);
        car[5].Instanting();
    }

    IEnumerator Car7()
    {
        yield return new WaitForSeconds(27f);
        car[6].Instanting();
    }

    IEnumerator Car8()
    {
        yield return new WaitForSeconds(30f);
        car[7].Instanting();
    }
}

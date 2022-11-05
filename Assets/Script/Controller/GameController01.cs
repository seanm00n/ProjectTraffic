using Newtonsoft.Json.Linq;
using ObjectData;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;

public class GameController01 : MonoBehaviour
{
    [SerializeField]
    int MAX_CAR_NUM;
    CAR[] cars;
    float timer;
    [SerializeField]
    GameObject carPref;
    public struct CAR
    {
        public int number;
        public Vector3 pos;
        public float genTime;
        public Destination destination;
        public Species species;
        public GameObject obj;
    }
    private void Start()
    {
        cars = new CAR[MAX_CAR_NUM];
        for (int i = 0; i < MAX_CAR_NUM; i++)
        {
            cars[i].number = i;
            cars[i].pos = new Vector3(i,0,0);
            cars[i].species = Species.Car;
        }
        cars[0].destination = Destination.front;
        cars[0].genTime = 1;
    }
    private void Update()
    {
        timer += Time.deltaTime;
        if(timer < cars[0].genTime)
        {
            //cars[0].obj = GameManager.Resource.Instantiate("Prefab/Object/Car", cars[0].pos);
            cars[0].obj = Instantiate(carPref, cars[0].pos, Quaternion.identity);
        }
        
    }

}

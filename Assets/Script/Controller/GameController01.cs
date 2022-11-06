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
    [SerializeField]
    GameObject carPref;
    [SerializeField]
    Transform start1; 
    [SerializeField]
    Transform start2;

    CAR[] cars;
    float timer;

    public struct CAR
    {
        public int number;
        public Vector3 pos;
        public float genTime;
        public Destination destination;
        public Species species;
        public GameObject obj;
        public bool isRun;
    }
    private void Start()
    {
        cars = new CAR[MAX_CAR_NUM];
        for (int i = 0; i < MAX_CAR_NUM; i++)
        {
            cars[i].number = i;
            cars[i].pos = new Vector3(-8,(i%2==0)?start2.position.y:start1.position.y,0);
            cars[i].species = Species.Car;
            cars[i].isRun = false;
        }
        cars[0].destination = Destination.front;
        cars[0].genTime = 3;
    }
    private void Update()
    {
        timer += Time.deltaTime;
        if(cars[0].genTime < timer)
        {
            if (!cars[0].isRun)
            {
                cars[0].obj = Instantiate(carPref, cars[0].pos, Quaternion.identity);
                cars[0].isRun = true;
            }
            
            
        }
        
    }

}

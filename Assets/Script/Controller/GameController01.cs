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
    public struct CAR
    {
        public int number;
        public Vector3 vec3;
        public int genTime;
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
            cars[i].vec3 = new Vector3(i,0,0);
            cars[i].species = Species.Car;
            cars[i].obj = GameManager.Resource.Instantiate("Prefab/Car");
        }
        cars[0].destination = Destination.front;
        cars[0].genTime = 1;
    }
    private void Update()
    {
         // = cars[0].xPos;
    }

}

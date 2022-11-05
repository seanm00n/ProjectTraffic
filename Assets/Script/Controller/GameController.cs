using Newtonsoft.Json.Linq;
using ObjectData;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    Destination destination = Destination.front; //�� ����
    Species species = Species.Car; //�� ����

    Car[] car; //��ü �迭
    Lane[,] lane;

    [SerializeField]
    int MAX_LINE_NUM;

    [SerializeField]
    int MAX_LANE_NUM;

    [SerializeField]
    int MAX_CAR_NUM;

    Dictionary<int, Dict> dic = new Dictionary<int, Dict>()
    {
        {0,Dict.front}//~30
    };

    private void Start()
    {
        car = new Car[MAX_CAR_NUM];
        lane = new Lane[MAX_LINE_NUM, MAX_LANE_NUM];
        
    }

    void Generate(float time)
    {
        for(int i = 0; i < dic.Count; i++)
        {
            if (dic[i] == Dict.none)
            {
                return;
            }
            if(dic[i] == Dict.front)
            {

            }
        }

    }
    //���� �¸�,�й� ����
}

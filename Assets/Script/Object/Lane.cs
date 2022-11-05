using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using CarData;
namespace LaneData
{
    public class Lane
    {
        public bool[] lane;
        public Lane(int Max_Lane_Num)
        {
            lane = Enumerable.Repeat(false, Max_Lane_Num).ToArray();
        }
        void SetLaneTrue(int index)
        {
            lane[index] = true;
        }
        void SetLaneFalse(int index)
        {
            lane[index] = false;
        }
    }
}


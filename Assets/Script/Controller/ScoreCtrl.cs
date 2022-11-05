using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCtrl : MonoBehaviour
{
    void CheackArray(bool[][] _lail)
    {
        // 래일의 갯수만큼 반복
        for (int curentLail = 0; curentLail < _lail.Length; curentLail++)
        {
            // 게임 오버 체크(배열이 전부 true)
            bool GameOver = true;
            for (int i = 0; i < _lail[curentLail].Length; ++i)
            {
                if (!_lail[curentLail][i])
                {
                    GameOver = false;
                }
            }

            if (GameOver)
            {
                // 게임 오버
            }

            // 점수 체크
            // 1. true인 칸의 car를 가져옴
            for (int i = 0; i < _lail[curentLail].Length; ++i)
            {
                if (_lail[curentLail][i])
                {
                    // 2. 그 car가 배열의 방향과 같은 방향인지 체크

                }
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCtrl : MonoBehaviour
{
    void CheackArray(bool[][] _lail)
    {
        // ������ ������ŭ �ݺ�
        for (int curentLail = 0; curentLail < _lail.Length; curentLail++)
        {
            // ���� ���� üũ(�迭�� ���� true)
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
                // ���� ����
            }

            // ���� üũ
            // 1. true�� ĭ�� car�� ������
            for (int i = 0; i < _lail[curentLail].Length; ++i)
            {
                if (_lail[curentLail][i])
                {
                    // 2. �� car�� �迭�� ����� ���� �������� üũ

                }
            }
        }
    }
}

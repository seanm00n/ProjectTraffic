using UnityEngine;
using System;
using Unity.PlasticSCM.Editor.WebApi;

public class CarCtrl : MonoBehaviour
{
    public Transform tr; //오브젝트 transform
    public Vector3 trPos = new Vector3(0, 0, 0); //오브젝트 position vector
    public float moveCoolTime = 0f; //이동 거리 계산용 변수
    public bool m_isArrived = false; //도착 확인용 변수

    void Start()
    {
        tr = GetComponent<Transform>();
    }
    void Update()
    {
        CarMove(m_isArrived);
    }
    void CarMove(bool p_isArrived)
    {
        if (!p_isArrived)
        {
            moveCoolTime += Time.deltaTime;
            trPos.x = (float)Math.Truncate(moveCoolTime);
            tr.position = trPos;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        m_isArrived = true;
        Debug.Log("Arriaved");
    }
}

using UnityEngine;
using System;
using Unity.PlasticSCM.Editor.WebApi;

public class CarCtrl : MonoBehaviour
{
    public Transform tr; //������Ʈ transform
    public Vector3 trPos = new Vector3(0, 0, 0); //������Ʈ position vector
    public float moveCoolTime = 0f; //�̵� �Ÿ� ���� ����
    public bool m_isArrived = false; //���� Ȯ�ο� ����

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

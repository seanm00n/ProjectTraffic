using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Des
{
    front, up, down
}
public class Car
{
    int m_number;
    Des m_destination;
    Car(int p_number, Des p_destination)
    {
        m_number = p_number;
        m_destination = p_destination;
    }
    void ChangeDestination(Des p_destination)
    {
        m_destination = p_destination;
    }
}

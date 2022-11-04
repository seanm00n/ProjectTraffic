using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace CarData{                                                                                                     {
    public enum Des
    {
        front, up, down
    }
    public enum Species
    {
        truck, mini
    }

    public class Car
    {
        int m_number;
        Des m_destination;
        Species m_species;

        public Car(int p_number, Des p_destination, Species p_species)
        {
            m_number = p_number;
            m_destination = p_destination;
        }
        public void ChangeDestination(Des p_destination)
        {
            m_destination = p_destination;
        }
    }
}



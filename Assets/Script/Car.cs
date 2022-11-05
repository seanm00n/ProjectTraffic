using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CarData 
{
    public enum Destination
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
        Destination m_destination;
        Species m_species;

        public Car(int p_number, Destination p_destination, Species p_species)
        {
            m_number = p_number;
            m_destination = p_destination;
        }
        public void ChangeDestination(Destination p_destination)
        {
            m_destination = p_destination;
        }
    }
}




using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Unity.VisualScripting;
using UnityEngine;

namespace ObjectData
{
    public enum Destination
    {
        none, front, up, down
    }
    public enum Species
    {
        Car, Truck
    }
    public class Car
    {
        int m_number;
        int m_position;
        Destination m_destination;
        Species m_species;
        GameObject obj;

        public Car(int p_number, Destination p_destination, Species p_species)
        {
            m_number = p_number;
            m_destination = p_destination;
        }
        public void setDestination(Destination p_destination)
        {
            m_destination = p_destination;
        }
        public void setPosition(int pos)
        {
            m_position = pos;
        }
        public void Instanting()
        {
            obj = GameManager.Resource.Instantiate("Prefab/Car");
        }
        public GameObject GetObject()
        {
            return obj;
        }
        
    }
}


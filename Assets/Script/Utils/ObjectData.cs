using System.Linq;
using Unity.VisualScripting;

namespace ObjectData
{
    public enum Destination
    {
        front, up, down
    }
    public enum Species
    {
        Car, Truck
    }
    public enum Dict { 
        none,front,up,down
    }
    
    public class Lane
    {
        int raw, colon;
        public Lane(int raw, int colon)
        {
            this.raw = raw;
            this.colon = colon; 
        }
    }

    public class Car
    {
        int m_number;
        int m_position;
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
        public void setPosition(int pos)
        {
            m_position = pos;
        }

    }
}


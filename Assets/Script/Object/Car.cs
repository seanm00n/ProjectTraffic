using StatusData;
namespace CarData
{ 
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




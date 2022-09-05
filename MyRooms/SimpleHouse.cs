namespace MyRooms
{
    internal class SimpleHouse
    {
        public char PersonsRoom { get; private set; }

        public SimpleHouse()
        {
            PersonsRoom = 'A';
        }

        public void Move(char newRoom)
        {
            if (PersonsRoom == 'A' && newRoom is 'B' or 'D')
            {
                PersonsRoom = newRoom;
            }
            else if (PersonsRoom == 'B' && newRoom is 'A' or 'C' or 'E')
            {
                PersonsRoom = newRoom;
            }
            else if (PersonsRoom == 'C' && newRoom is 'B')
            {
                PersonsRoom = newRoom;
            }
            else if (PersonsRoom == 'D' && newRoom is 'A')
            {
                PersonsRoom = newRoom;
            }
            else if (PersonsRoom == 'E' && newRoom is 'B' or 'F')
            {
                PersonsRoom = newRoom;
            }
            else if (PersonsRoom == 'F' && newRoom is 'E')
            {
                PersonsRoom = newRoom;
            }
        }
    }
}

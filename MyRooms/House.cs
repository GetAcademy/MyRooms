namespace MyRooms
{
    internal class House
    {
        public char Room { get; private set; }

        public House()
        {
            Room = 'A';
        }

        public void Move(char newRoom)
        {
            if (Room == 'A' && newRoom is 'B' or 'D')
            {
                Room = newRoom;
            }
            else if (Room == 'B' && newRoom is 'A' or 'C' or 'E')
            {
                Room = newRoom;
            }
            else if (Room == 'C' && newRoom is 'B')
            {
                Room = newRoom;
            }
            else if (Room == 'D' && newRoom is 'A')
            {
                Room = newRoom;
            }
            else if (Room == 'E' && newRoom is 'B' or 'F')
            {
                Room = newRoom;
            }
            else if (Room == 'F' && newRoom is 'E')
            {
                Room = newRoom;
            }
        }
    }
}

namespace MyRooms
{
    internal class Room
    {
        public char Name { get; }
        private List<Door> _doors;

        public Room(char name)
        {
            Name = name;
            _doors = new List<Door>();
        }

        public void AddDoor(Door door)
        {
            _doors.Add(door);
        }

        public Room FindDoorTo(char newRoom)
        {
            foreach (var door in _doors)
            {
                if (door.Room1.Name == newRoom)
                {
                    return door.Room1;
                }
                else if(door.Room2.Name == newRoom)
                {
                    return door.Room2;
                }
            }

            return null;
        }
    }
}

namespace MyRooms
{
    internal class Door
    {
        public Room Room1 { get; }
        public Room Room2 { get; }

        public Door(Room room1, Room room2)
        {
            Room1 = room1;
            Room2 = room2;
            Room1.AddDoor(this);
            Room2.AddDoor(this);
        }
    }
}

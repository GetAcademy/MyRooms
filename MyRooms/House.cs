namespace MyRooms
{
    internal class House
    {
        public Room PersonsRoom { get; private set; }

        public House()
        {
            var roomA = new Room('A');
            var roomB = new Room('B');
            var roomC = new Room('C');
            var roomD = new Room('D');
            var roomE = new Room('E');
            var roomF = new Room('F');

            PersonsRoom = roomA;

            new Door(roomA, roomD);
            new Door(roomA, roomB);
            new Door(roomB, roomC);
            new Door(roomB, roomE);
            new Door(roomE, roomF);
        }

        public void Move(char newRoom)
        {
            var room = PersonsRoom.FindDoorTo(newRoom);
            if (room != null)
            {
                PersonsRoom = room;
            }
        }
    }
}

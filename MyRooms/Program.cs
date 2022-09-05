using MyRooms;

// pause til 

var house = new House();

while (true)
{
    Console.WriteLine($"Du er i rom {house.Room}");
    Console.Write("Hvor vil du gå? ");
    var roomStr = Console.ReadLine();
    var newRoom = roomStr[0];
    house.Move(newRoom);
}

/*
var room = 'A';

while (true)
{
    Console.WriteLine($"Du er i rom {room}");
    Console.Write("Hvor vil du gå? ");
    var roomStr = Console.ReadLine();
    var newRoom = roomStr[0];
    if (room == 'A' && newRoom is 'B' or 'D')
    {
        room = newRoom;
    }
    else if (room == 'B' && newRoom is 'A' or 'C' or 'E')
    {
        room = newRoom;
    }
    else if (room == 'C' && newRoom is 'B')
    {
        room = newRoom;
    }
    else if (room == 'D' && newRoom is 'A')
    {
        room = newRoom;
    }
    else if (room == 'E' && newRoom is 'B' or 'F')
    {
        room = newRoom;
    }
    else if (room == 'F' && newRoom is 'E')
    {
        room = newRoom;
    }
}

 
 */
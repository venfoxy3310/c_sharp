int floor, room, roomNum;
Console.Write("Enter full number of the room: ");
roomNum = int.Parse(Console.ReadLine());
floor = roomNum / 100;
room = roomNum % 100;
Console.WriteLine("Floor: " + floor);
Console.WriteLine("room: " + room);

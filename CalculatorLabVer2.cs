//===========================================================
// Title:         Deliverable 2 C# 
//  Author :      Earle Fox>
//  Date :        01/09/2022
//  Description : Room Calculator 
//===========================================================



{
    Console.WriteLine("This is a calculator to figure out the perimeter and area of a room.  Please enter the length:  ");
    double room_length = double.Parse(Console.ReadLine());
    Console.WriteLine("Please enter the width of the room:  ");
    double room_width = double.Parse(Console.ReadLine());
    Console.WriteLine("Please enter the height of the room:  ");
    double room_height = double.Parse(Console.ReadLine());
    double room_perimeter = (room_width * 2 + room_length * 2);
    double square_footage = (room_length * room_width);
    double room_volume = (room_length * room_width * room_height);
    double surface_area = (room_height * room_width * 2 + room_width * room_length * 4);
    if (square_footage <= 250)
    {
        Console.WriteLine("Your total square footage is: " + square_footage);
        Console.WriteLine("You have a small room");        
    }
    else if (square_footage <= 650)
    {
        Console.WriteLine("Your total square footage is: " + square_footage);
        Console.WriteLine("You have a medium room");              
    }
    else 
    {
        Console.WriteLine("Your total square footage is: " + square_footage);
        Console.WriteLine("You have a large room");
    }
    Console.WriteLine("The total room volume is " + room_volume);
    Console.WriteLine("The total room perimeter is " + room_perimeter);
    Console.WriteLine("The total room surface area is " + surface_area);
}




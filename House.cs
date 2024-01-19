/*********************************************************************************
Name: Almaz Buran
Date: Jan 19, 2024
Assignment: CIS317 Week 5 Final Practical Exam

This class represents a House object, derived from the Building class. It includes
properties for the number of rooms, front door, and main kitchen. The constructor
initializes these properties, and the overridden GetRooms and ToString methods
provide information about the number of rooms and a formatted string representation
of the house, respectively.
*/
public class House : Building
{
    private int NumRooms;
    public Door FrontDoor;
    public Kitchen MainKitchen;

    // Constructor
    public House(int numRooms, Door frontDoor, Kitchen mainKitchen) : base("House")
    {
        NumRooms = numRooms;
        FrontDoor = frontDoor;
        MainKitchen = mainKitchen;
    }

    // Override GetRooms method
    public override int GetRooms()
    {
        return NumRooms;
    }

    // Override ToString method
     public override string ToString()
    {
        return base.ToString() + " It has " + NumRooms + " rooms.\n" + FrontDoor + "\n" + MainKitchen;
    }
}


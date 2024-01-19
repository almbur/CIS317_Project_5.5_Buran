
/*********************************************************************************
Name: Almaz Buran
Date: Jan 19, 2024
Assignment: CIS317 Week 5 Final Practical Exam

This class is the ultimate base class in this example and provides 
GetRooms() methods for getting House' int numRooms, Door frontDoor, Kitchen mainKitchen. The
class also provides a constructor for use by child classes and
provides an override of ToString() for formatted shape information
*/
public abstract class Building
{   
    //local member
    private string BuildingType;

    // Constructor
    protected Building(string type)
    {
        BuildingType = type;
    }

    // Abstract method
    public abstract int GetRooms();

    // Override ToString method
    //to print it out
    public override string ToString()
    {
        return "This is a/an " + BuildingType + ".";
    }
}


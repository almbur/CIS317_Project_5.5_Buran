/*********************************************************************************
Name: Almaz Buran
Date: Jan 19, 2024
Assignment: CIS317 Week 5 Final Practical Exam

This class represents a Door object in the context of the House class. It stores
information about the door's width and color. The constructor initializes these
properties, and the overridden ToString() method provides a formatted string
representation of the door.
*/
public class Door
{
    private int Width;   // Width of the door in inches
    private string Color;  // Color of the door

    public Door(int width, string color)
    {
        Width = width;
        Color = color;
    }

    // Override ToString method
    public override string ToString()
    {
        return "The Door is " + Width + " inches wide and is " + Color + " in color.";
    }
}
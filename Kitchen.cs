/*********************************************************************************
Name: Almaz Buran
Date: Jan 19, 2024
Assignment: CIS317 Week 5 Final Practical Exam

This class represents a Kitchen object in the context of the House class. It stores
information about the kitchen's style and primary appliance brand. The constructor
initializes these properties, and the overridden ToString() method provides a
formatted string representation of the kitchen.
*/
public class Kitchen
{   
    //Local Members
    private string Style;  
    private string ApplianceBrand;  
    //Constructor
    public Kitchen(string style, string applianceBrand)
    {
        Style = style;
        ApplianceBrand = applianceBrand;
    }
    // Override ToString method
    public override string ToString()
    {
        return "The kitchen is a " + Style + " styled kitchen with " + ApplianceBrand + " appliances.";
    }
}

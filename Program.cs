/*********************************************************************************
 * Author: Almaz Buran
 * Date: Jan 19, 2024
 * Assignment: CIS317 Week 5 Final Practical Exam
 *
 * Main application class.
 */

public class Program
{
    // File path for log
    private const string LOG_FILE_PATH = "almbur048_log.txt";

    // Main method
    public static void Main()
    {
        Console.WriteLine("\nAlmaz Buran - Week 5 Final Practical Exam\n");
        LogStatus("Starting the application.");
        Console.WriteLine(WriteToFile());
        Console.WriteLine(ReadFromFile());

        // Create a List of type Building
        List<Building> buildings = new List<Building>();

        // Add 5 House objects to the list with different characteristics
        buildings.Add(new House(5, new Door(55, "Wooden"), new Kitchen("Modern", "Samsung")));
        buildings.Add(new House(4, new Door(50, "White"), new Kitchen("Classic", "LG")));
        buildings.Add(new House(8, new Door(34, "Blue"), new Kitchen("Contemporary", "Whirlpool")));
        buildings.Add(new House(9, new Door(110, "Black"), new Kitchen("Rustic", "Bosch")));
        buildings.Add(new House(3, new Door(88, "Gray"), new Kitchen("Industrial", "KitchenAid")));

        // Print the list of buildings iteratively
        PrintBuildingsIteratively(buildings);

        // Print the list of buildings recursively
        PrintBuildingsRecursively(buildings);
    }

    // Write to a log file - return a message indicating success
    private static string WriteToFile()
    {
        using (StreamWriter writer = new StreamWriter(LOG_FILE_PATH, append: true))
        {
            // Writing lines to the log file
            writer.WriteLine("Hello Almaz Buran!");
            writer.WriteLine("2 lines of text!");
        }

        return "Successfully wrote to the log file.";
    }

    // Read from a log file - return a message indicating the file contents were
    // printed
    private static string ReadFromFile()
    {
        // Read all the lines from the named file into a string array
        string[] readText = File.ReadAllLines(LOG_FILE_PATH);

        // Print each line from the file to the console
        foreach (string s in readText)
        {
            Console.WriteLine(s);
        }

        return "All lines from log file printed!";
    }

    // Function to print the list of buildings iteratively
    private static void PrintBuildingsIteratively(List<Building> buildings)
    {
        LogStatus("Iterative Printing of Buildings");

        foreach (var building in buildings)
        {
            Console.WriteLine(building);
        }
    }

    // Function to print the list of buildings recursively
    private static void PrintBuildingsRecursively(List<Building> buildings)
    {
        LogStatus("Recursive Printing of Buildings");

        foreach (var building in buildings)
        {
            PrintBuildingRecursively(building);
        }
    }

    // Recursive function to print a building
    private static void PrintBuildingRecursively(Building building)
    {
        Console.WriteLine(building);

        if (building is House house)
        {
            Console.WriteLine(house.GetRooms());
            Console.WriteLine(house.FrontDoor);
            Console.WriteLine(house.MainKitchen);
        }
    }

    // Function to log status updates
    private static void LogStatus(string status)
    {
        Console.WriteLine(status);

        using (StreamWriter writer = new StreamWriter(LOG_FILE_PATH, append: true))
        {
            // Logging the status with timestamp
            writer.WriteLine($"{DateTime.Now} - {status}");
        }
    }
}

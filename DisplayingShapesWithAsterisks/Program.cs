class DisplayingShapesWithAsterisks
{
    static void Main(string [] args)
    {
        DisplayingShapesWithAsterisks displayingShapesWithAsterisks = new DisplayingShapesWithAsterisks();

        displayingShapesWithAsterisks.displayBox();

        Console.WriteLine();    // just for spacing purpose

        displayingShapesWithAsterisks.displayOval();

        Console.WriteLine();    // just for spacing purpose


    }
    // end of Main method

    void displayBox()
    {
        Console.WriteLine("Displaying Diamond\n");

        Console.WriteLine("*********");
        Console.WriteLine("*       *");
        Console.WriteLine("*       *");
        Console.WriteLine("*       *");
        Console.WriteLine("*       *");
        Console.WriteLine("*       *");
        Console.WriteLine("*       *");
        Console.WriteLine("*       *");
        Console.WriteLine("*********");
    }
    // end of displayDiamond method

    void displayOval()
    {
        Console.WriteLine("Displaying Oval\n");

        Console.WriteLine("   ***   ");
        Console.WriteLine(" *     * ");
        Console.WriteLine("*       *");
        Console.WriteLine("*       *");
        Console.WriteLine("*       *");
        Console.WriteLine("*       *");
        Console.WriteLine("*       *");
        Console.WriteLine(" *     * ");
        Console.WriteLine("   ***   ");
    }
    // end of displayOval method

    void displayArrow()
    {

    }
    // end of displayArrow method

    void displayDiamond() 
    {

    }
    // end of displayDiamond method

}
// end of DisplayingShapesWithAsterisks class

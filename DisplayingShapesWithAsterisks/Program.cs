﻿class DisplayingShapesWithAsterisks
{
    static void Main(string [] args)
    {
        DisplayingShapesWithAsterisks displayingShapesWithAsterisks = new DisplayingShapesWithAsterisks();

        displayingShapesWithAsterisks.displayBox();

        Console.WriteLine();    // just for spacing purpose

        displayingShapesWithAsterisks.displayOval();

        Console.WriteLine();    // just for spacing purpose

        displayingShapesWithAsterisks.displayArrow();

        Console.WriteLine();    // just for spacing purpose

        displayingShapesWithAsterisks.displayDiamond();

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
        Console.WriteLine("Displaying Arrow\n");

        Console.WriteLine("  *  ");
        Console.WriteLine(" *** ");
        Console.WriteLine("*****");
        Console.WriteLine("  *  ");
        Console.WriteLine("  *  ");
        Console.WriteLine("  *  ");
        Console.WriteLine("  *  ");
        Console.WriteLine("  *  ");
        Console.WriteLine("  *  ");
    }
    // end of displayArrow method

    void displayDiamond() 
    {
        Console.WriteLine("Displaying Diamond\n");

        Console.WriteLine("     *     ");
        Console.WriteLine("    * *    ");
        Console.WriteLine("   *   *   ");
        Console.WriteLine("  *     *  ");
        Console.WriteLine(" *       * ");
        Console.WriteLine("*         *");
        Console.WriteLine(" *       * ");
        Console.WriteLine("  *     *  ");
        Console.WriteLine("   *   *   ");
        Console.WriteLine("    * *    ");
        Console.WriteLine("     *     ");

    }
    // end of displayDiamond method

}
// end of DisplayingShapesWithAsterisks class

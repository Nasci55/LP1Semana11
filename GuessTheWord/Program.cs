using System;
using System.Collections.Generic;
using GuessTheWord;

public class Program
{
    private static void Main(string[] args)
    {

        IView view = new View();
        Controller controller = new Controller(view, args[0]);

        controller.Start();

    }
}

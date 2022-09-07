using System;
using System.Diagnostics;

//simple prompt
Console.WriteLine("Hello!\nThis is a TEMPORARY personal program of mine to quickly setup my pc!\n");
Console.WriteLine("note: this program has a chance of becoming a full-blown app instead of a CLI.\n");
Console.WriteLine("what would you like to do today?\nanimation - a setup consisting of chrome and pencil2d.");
Console.WriteLine("pixel art - a setup that boots up a yt tutorial playlist and libresprite.\nyoutube - just youtube and chill.");
SimpleSetup();
static void SimpleSetup()
{
    string userInput = Console.ReadLine();
    if (userInput == "animation")
    {
        //this block executes the batch file
        System.Diagnostics.Process pros = new System.Diagnostics.Process();
        pros.StartInfo.FileName = "D:\\SimpleSetup\\BatchFIles\\animation.bat";
        pros.StartInfo.WorkingDirectory = "D:\\SimpleSetup\\BatchFIles\\workdir";
        pros.Start();
    }
    else if (userInput == "pixel art")
    {
        System.Diagnostics.Process pros = new System.Diagnostics.Process();
        pros.StartInfo.FileName = "D:\\SimpleSetup\\BatchFIles\\pixel art.bat";
        pros.StartInfo.WorkingDirectory = "D:\\SimpleSetup\\BatchFIles\\workdir";
        pros.Start();
    }
    else if (userInput == "youtube")
    {
        System.Diagnostics.Process pros = new System.Diagnostics.Process();
        pros.StartInfo.FileName = "D:\\SimpleSetup\\BatchFIles\\youtube.bat";
        pros.StartInfo.WorkingDirectory = "D:\\SimpleSetup\\BatchFIles\\workdir";
        pros.Start();
    }
    else
    {
        Console.WriteLine("please enter everything very precisely");
        //Recursion
        SimpleSetup();
    }
}
Console.WriteLine("Press any key to exit.");
Console.ReadKey();
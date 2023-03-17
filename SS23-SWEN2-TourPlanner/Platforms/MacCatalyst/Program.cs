using ObjCRuntime;
using UIKit;

namespace SS23_SWEN2_TourPlanner;

public class Program
{
    // This is the main entry point of the application.
    static void Main(string[] args)
    {
        Thread.Sleep(3000);
        // if you want to use a different Application Delegate class from "AppDelegate"
        // you can specify it here.
        UIApplication.Main(args, null, typeof(AppDelegate));
    }
}
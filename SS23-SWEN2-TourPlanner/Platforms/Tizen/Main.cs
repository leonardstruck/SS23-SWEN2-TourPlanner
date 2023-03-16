using System;
using Microsoft.Maui;
using Microsoft.Maui.Hosting;

namespace SS23_SWEN2_TourPlanner;

class Program : MauiApplication
{
	protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

	static void Main(string[] args)
	{
		var app = new Program();
		app.Run(args);
	}
}

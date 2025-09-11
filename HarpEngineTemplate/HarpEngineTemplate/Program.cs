using HarpEngine;

// Engine initialization lives here

EngineSettings settings = new()
{
	WindowWidth = 800,
	WindowHeight = 600,
	WindowName = "Hello Game",
	GameWidth = 800,
	GameHeight = 600,
};
Engine.Initialize(settings);
HelloGame helloGame = new();
Engine.Start(helloGame);
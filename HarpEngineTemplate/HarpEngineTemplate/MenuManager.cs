using HarpEngine;
using HarpEngine.Graphics;
using HarpEngine.Input;

// Entity control and properties live here

internal class MenuManager : Entity
{
	public MenuManager(Scene scene) : base(scene)
	{

	}

	public override void Update(float frameTime)
	{
		if (Keyboard.IsKeyPressed(KeyboardKey.Enter)) HelloGame.Instance.Start();
	}

	public override void Draw()
	{
		string text = "ENTER to Start Game";
		const int fontSize = 50;
		int width = Text.MeasureWidth(text, fontSize);
		int x = Engine.HalfGameWidth - width / 2;
		int yOffset = (int)(float.Sin(scene.Time) * (fontSize / 2f));
		int y = Engine.HalfGameHeight - fontSize / 2 + yOffset;
		Text.Draw(text, x, y, fontSize, Colors.White);
	}
}

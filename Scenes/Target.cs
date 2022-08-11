using Godot;
using System;

public class Target : Sprite
{
	private void _on_Target_input_event(object viewport, InputEvent @event, int shape_idx)
	{
		// Check if target is clicked on
		if (@event is InputEventMouseButton btn && btn.ButtonIndex == (int)ButtonList.Left && @event.IsPressed())
		{
			GD.Print("Clicked");
			// Increment score
			// Change target location
		}
	}
}

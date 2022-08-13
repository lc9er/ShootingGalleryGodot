using Godot;
using System;

public class Target : Sprite
{
	private void _on_Target_input_event(object viewport, InputEvent @event, int shape_idx)
	{
		// If target clicked, move target and increment score
		if (@event is InputEventMouseButton btn         &&
				btn.ButtonIndex == (int)ButtonList.Left &&
				@event.IsPressed())
		{
			GetTree().CallGroup("MoveTargetGroup", "MoveTarget");
			// Increment score
		}
	}
}

using Godot;
using System;

public class Target : Sprite
{
	[Signal]
	public delegate void Hit();

	private void _on_Target_input_event(object viewport, InputEvent @event, int shape_idx)
	{
		// If target clicked, move target and increment score
		if (@event is InputEventMouseButton btn         &&
				btn.ButtonIndex == (int)ButtonList.Left &&
				@event.IsPressed())
		{
			// Move target and increment score
			EmitSignal(nameof(Hit));
		}
	}
}

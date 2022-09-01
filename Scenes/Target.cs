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
			// Emit signal, to move target and increment score.
			// Play hit sound.
			var hitAudio = GetNode<AudioStreamPlayer2D>("HitAudio");
			hitAudio.Play();
			EmitSignal(nameof(Hit));
		}
	}
}

using Godot;
using System;

public class TargetBackground : Area2D
{
	private bool audioEnabled = true;

	private void _on_TargetBackground_input_event(object viewport, InputEvent @event, int shape_idx)
	{
			// If target clicked, move target and increment score
		if (@event is InputEventMouseButton btn         &&
				btn.ButtonIndex == (int)ButtonList.Left &&
				@event.IsPressed() 						&&
				audioEnabled)
		{
			// Emit signal, to move target and increment score.
			// Play hit sound.
			var missAudio = GetNode<AudioStreamPlayer2D>("MissAudio");
			missAudio.Play();
		}
	}
	
	private void _on_GameTimer_timeout()
	{
		// disable shot audio when game over
		audioEnabled = false;
	}
}


using Godot;
using System;

public class ShootingGallery : Node2D
{
	public int Score;

	public override void _Ready()
	{
		Score = 0;
	}	

	private void _on_TargetArea2D_TargetHit()
	{
		// Update score on hit signal
		Score += 1;
		var updateScore = GetNode<Label>("ScoreLabel");
		updateScore.Text = "Score: " + Score.ToString();
	}
}




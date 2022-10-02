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

	private void ResetScore()
	{
		Score = 0;
		var updateScore = GetNode<Label>("ScoreLabel");
		updateScore.Text = "Score: " + Score.ToString();
	}
	private void _on_HUD_StartGame()
	{
		// 1. Hide message
		// 2. Enable target collision
		// 3. Start game timer
		// 4. Enable shooty noise
		// 5. Reset score to 0.
		GetNode<Label>("HUD/Message").Hide();
		GetNode<CollisionShape2D>("TargetArea2D/CollisionShape2D").Disabled = false;
		GetNode<Timer>("TimerLabel/GameTimer").Start();
		GetTree().CallGroup("EnableAudio", "EnableAudio");
		ResetScore();
	}
}

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
		Score += 1;
		GD.Print(Score);
	}
}

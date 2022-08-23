using Godot;
using System;

public class TargetArea2D : Area2D
{
	private int screenXLeft  = 50;
	private int screenXRight = 925;
	private int screenYLeft  = 50;
	private int screenYRight = 500;

	[Signal]
	public delegate void TargetHit();

	public override void _Ready()
	{
		GD.Randomize();
		MoveTarget();
	}	

	private void _on_Target_Hit()
	{
		MoveTarget();
		EmitSignal(nameof(TargetHit));
	}

	private void MoveTarget()
	{
		var posX = (float)GD.RandRange(screenXLeft, screenXRight);
		var posY = (float)GD.RandRange(screenYLeft, screenYRight); 
		Vector2 newPos = new Vector2(posX, posY); 

		Position = newPos;
	}
}



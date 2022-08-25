using Godot;
using System;

public class GameTimer : Timer
{
   // Called when the node enters the scene tree for the first time.
   public override void _Ready()
   {

   }

   // Called every frame. 'delta' is the elapsed time since the previous frame.
   public override void _Process(float delta)
   {
	  // Display countdown
	  var timerLabel = GetNode<Label>("..");	
	  int currentTime = (int)TimeLeft;
	  timerLabel.Text = "Time: " + currentTime.ToString();
   }
}

using Godot;
using System;

public class HUD : CanvasLayer
{
	[Signal]
	public delegate void StartGame();

	public void ShowMessage(string text)
	{
		var message = GetNode<Label>("Message");
		message.Text = text;
		message.Show();        

		GetNode<Timer>("MessageTimer").Start();
	}

	async public void ShowGameOver()
	{
		ShowMessage("Game Over!");

		var messageTimer = GetNode<Timer>("MessageTimer");
		await ToSignal(messageTimer, "timeout");

		var message = GetNode<Label>("Message");
		message.Text = "Shoot the Target!";
		message.Show();

		await ToSignal(GetTree().CreateTimer(1), "timeout");
		GetNode<Button>("StartButton").Show();
	}

	async private void OnStartButtonPressed()
	{
		GetNode<Button>("StartButton").Hide();
		await ToSignal(GetTree().CreateTimer(2), "timeout");
		EmitSignal("StartGame");
	}

	private void OnMessageTimerTimeout()
	{
		GetNode<Label>("Message").Hide();
	}
}
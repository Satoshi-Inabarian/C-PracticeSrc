using Android.OS;
using Microsoft.Maui.Controls;
using static System.Net.Mime.MediaTypeNames;

namespace MauiApp1;

public partial class MainPage : ContentPage
{
	int count = 0;
    public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;
		
		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}

	private void OnCounterRandom(object sender, EventArgs e)
	{
        int NumLimit = 10;
		var random1 = new Random();
		int num = random1.Next(0, 100);
		RandomBtn.Text = num.ToString();
		if (num <=NumLimit)
		{
			JudgeLabel.Text = "Congratulation!!";
            }
		else
		{
			JudgeLabel.Text = "Try Next";
		}
        SemanticScreenReader.Announce(RandomBtn.Text);

    }
}

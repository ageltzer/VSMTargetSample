using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace VSMTargetSample
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
		string _currentColorState = "Normal";

		public MainPage()
        {
            InitializeComponent();

			CurrentState.Text = $"Current state: {_currentColorState}";
		}

		void ToggleValid_OnClicked(object sender, EventArgs e)
		{
			if (_currentColorState == "Normal")
			{
				_currentColorState = "Invalid";
			}
			else
			{
				_currentColorState = "Normal";
			}

			CurrentState.Text = $"Current state: {_currentColorState}";
			VisualStateManager.GoToState(MyStackLayout, _currentColorState);
			VisualStateManager.GoToState(WelcomeLabel, _currentColorState);
			VisualStateManager.GoToState(ToggleValidButton, _currentColorState);
		}
	}
}
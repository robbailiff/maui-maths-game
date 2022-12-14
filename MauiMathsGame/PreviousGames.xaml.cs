namespace MauiMathsGame;

public partial class PreviousGames : ContentPage
{
	public PreviousGames()
	{
		InitializeComponent();
        App.GameRepository.GetAllGames();
        gamesList.ItemsSource = App.GameRepository.GetAllGames();
	}

	private void OnDelete(object sender, EventArgs e)
	{
		Button button = (Button)sender;

        App.GameRepository.Delete((int)button.BindingContext);

        gamesList.ItemsSource = App.GameRepository.GetAllGames();
    }
}
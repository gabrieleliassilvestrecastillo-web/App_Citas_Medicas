namespace App_Citas_Medicas.Views;

public partial class Menu : ContentPage
{
	public Menu()
	{
		InitializeComponent();
	}

    private async void VerEspecialidades(object? sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new Especialidades());
    }

    private async void VerMisCitas(object? sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new Mis_Citas());
    }
}
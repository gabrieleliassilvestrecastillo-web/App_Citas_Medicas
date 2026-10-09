namespace App_Citas_Medicas.Views;

public partial class MainPage : ContentPage
{

    public MainPage()
    {
        InitializeComponent();
    }
    private async void loginBtn(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Menu());
    }
    private async void IrRegistro(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Registro());
    }

}

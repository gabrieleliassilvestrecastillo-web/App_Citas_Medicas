using App_Citas_Medicas.Data;
namespace App_Citas_Medicas.Views;

public partial class Doctores : ContentPage
{
	public List<DoctoresGroup> doctores { get; set; } = new List<DoctoresGroup>();
	public Doctores()
	{
		InitializeComponent();
        doctores.Add(new DoctoresGroup("Doctores", new List<DoctoresLista>
        {
            new DoctoresLista
            {
                Nombre = "Enrique",
                Imagen = "login.png",
                Especialidad= "Cardiologo",
                DiasConsultas = "Lunes, martes" ,
                Horario = "8 AM : 2 PM",
            },
             new DoctoresLista
            {
                Nombre = "Maria",
                Imagen = "login.png",
                Especialidad= "Cardiologo",
                DiasConsultas = "Lunes, Miercoles" ,
                Horario = "8 AM : 2 PM",
            }
        }));
        BindingContext = this;
    }
    private async void RealizarCitas(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Realizar_Citas());
    }
}
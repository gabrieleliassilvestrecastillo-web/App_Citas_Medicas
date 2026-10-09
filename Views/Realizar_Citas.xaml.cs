using App_Citas_Medicas.Data;

namespace App_Citas_Medicas.Views;

public partial class Realizar_Citas : ContentPage
{
	public List<CitasGroup> citas { get; set; } = new List<CitasGroup>();
    public Realizar_Citas()
	{
		InitializeComponent();
		citas.Add(new CitasGroup("Citas", new List<CitasLista>
		{
			new CitasLista
			{
				Dia = "Martes 13 Octubre",
				Hora="8 AM:12 PM ",
				Estado="Disponible"
            },
            new CitasLista
            {
                Dia = "Miercoles 14 Octubre",
                Hora="8 AM:12 PM ",
                Estado="Disponible"
            }

        }));
		BindingContext = this;
    }
}
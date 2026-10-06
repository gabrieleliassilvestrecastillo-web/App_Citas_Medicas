using App_Citas_Medicas.Data;

namespace App_Citas_Medicas.Views;

public partial class Especialidades : ContentPage
{
    public List<EspecialidadesGroup> especialidades { get; set; } = new List<EspecialidadesGroup>();
    public Especialidades()
	{
		InitializeComponent();
        
        especialidades.Add(new EspecialidadesGroup("Especialidades", new List<Especialidad>
        {
            new Especialidad
            {
                Nombre = "Medicina General",
                Imagen = "general.png",
                ColorFondo = "#f1f5f9",
            },
            new Especialidad
            {
                Nombre = "Cardiología",
                Imagen = "corazon.jpg",
                ColorFondo = "#fee2e2",
            },
            new Especialidad
            {
                Nombre = "Neurología",
                Imagen = "neurologia.png",
                ColorFondo = "#e0f2fe",
            },
            new Especialidad
            {
                Nombre = "Psicología",
                Imagen = "psicologia.jpg",
                ColorFondo = "#fef3c7",
            },
            new Especialidad
            {
                Nombre = "Neumología",
                Imagen = "neumologia.jpg",
                ColorFondo = "#cffafe",
            },
                    
            new Especialidad
            {
                Nombre = "Pediatría",
                Imagen = "pediatria.png",
                ColorFondo = "#dcdce7",
            },
            new Especialidad
            {
                Nombre = "Oftalmología",
                Imagen = "oftalmologia.png",
                ColorFondo = "#ccfbf1",
            },
            new Especialidad
            {
                Nombre = "Ginecología",
                Imagen = "ginecologia.png",
                ColorFondo = "#fce7f3",
            },
            new Especialidad
            {
                Nombre = "Oncología",
                Imagen = "oncologia.png",
                ColorFondo = "#f3e8ff",
            }
        }));
        BindingContext = this;
    }
    
}
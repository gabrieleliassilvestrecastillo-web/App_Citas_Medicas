using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App_Citas_Medicas.Views;

namespace App_Citas_Medicas.Data
{
    public class EspecialidadesGroup: List<Especialidad>
    {
        public string Name { get; set; }
        public EspecialidadesGroup(string name, List<Especialidad> especialidades): base (especialidades)
        {
            Name = name;
        }
    }
}

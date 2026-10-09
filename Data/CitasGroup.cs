using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Citas_Medicas.Data
{
    public class CitasGroup : List<CitasLista>
    {
        public string Name { get; set; }

        public CitasGroup(string name, List<CitasLista> citas) : base (citas)
        {
            Name = name;
        }   
    }
}

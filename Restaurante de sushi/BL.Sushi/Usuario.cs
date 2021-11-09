using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BL.Sushi.FoodMenuBL;
namespace BL.Sushi
{

    public class Usuario
    {
        internal string contraseña;

        public string Contraseña { get; set; }
        public string Nombre { get; set; }
    }
}


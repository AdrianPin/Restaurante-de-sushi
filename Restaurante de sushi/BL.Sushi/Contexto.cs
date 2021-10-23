using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BL.Sushi.FoodMenuBL;

namespace BL.Sushi
{
    class Contexto:DbContext
    {
  

        public Contexto(): base()
            {

        }
    
            public DbSet<foodmenu> FoodMenu { get; set; }
    }
}

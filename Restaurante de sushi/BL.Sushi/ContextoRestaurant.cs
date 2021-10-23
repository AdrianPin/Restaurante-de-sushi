using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BL.Sushi.FoodMenuBL;

namespace BL.Sushi
{
    public class ContextoRestaurant: DbContext
    {
        public ContextoRestaurant(): base()
        {
                
        }
        public DbSet<FoodMenu> foodmenu  { get; set; }
    }
}

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
    class Contexto : DbContext
    {


        public Contexto() : base(@"Data Source=(LocalDb)\MSSQLLocalDB;AttachDBFilename=" +
            Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\SushiDB.mdf")
        {

        }
         protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            Database.SetInitializer(new DatosdeInicio());//Agrega Datos de inicio a la base de datos despues de eliminar
        }


        public DbSet<foodmenu> foodmenu { get; set; }
        public DbSet<categoria> Categorias { get; set; }
        public DbSet<categoria> Tipos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}
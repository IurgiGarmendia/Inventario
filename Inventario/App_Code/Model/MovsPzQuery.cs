namespace Inventario.App_Code.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data;
    using System.Data.Entity;
    using System.Data.Entity.Core.EntityClient;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.ModelConfiguration.Conventions;
    using System.Linq;

    public class MovsPzQuery : DbContext
    {
        // El contexto se ha configurado para usar una cadena de conexión 'MovsPzQuery' del archivo 
        // de configuración de la aplicación (App.config o Web.config). De forma predeterminada, 
        // esta cadena de conexión tiene como destino la base de datos 'Inventario.App_Code.Model.MovsPzQuery' de la instancia LocalDb. 
        // 
        // Si desea tener como destino una base de datos y/o un proveedor de base de datos diferente, 
        // modifique la cadena de conexión 'MovsPzQuery'  en el archivo de configuración de la aplicación.
        public MovsPzQuery()
            : base("name=MovsPzQuery")
        {
           
        }


        //public MovsPzQuery(String entityConnection)
        ////: base("name=MovsPzQuery")
        //{
        //    //https://www.entityframeworktutorial.net/Querying-with-EDM.aspx
        //    //tutorial : https://www.entityframeworktutorial.net/code-first/what-is-code-first.aspx
        //    using (var con = new EntityConnection(entityConnection))
        //    {
        //        con.Open();
        //        EntityCommand cmd = con.CreateCommand();
        //        cmd.CommandText = "SELECT * from movspz";
        //        Dictionary<int, string> dict = new Dictionary<int, string>();
        //        using (EntityDataReader rdr = cmd.ExecuteReader(CommandBehavior.SequentialAccess | CommandBehavior.CloseConnection))
        //        {
        //            while (rdr.Read())
        //            {
        //                int a = rdr.GetInt32(0);
        //                var b = rdr.GetString(1);
        //                dict.Add(a, b);
        //            }
        //        }
        //    }
        //}




        // Agregue un DbSet para cada tipo de entidad que desee incluir en el modelo. Para obtener más información 
        // sobre cómo configurar y usar un modelo Code First, vea http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<MOVSPZ> DBMovspz { get; set; }

        protected override void OnModelCreating(DbModelBuilder dbModelBuilder)
        {
            dbModelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            dbModelBuilder.Conventions.Remove<IncludeMetadataConvention>();
        }
    }

    public class MOVSPZ
    {
        [Key, Column(Order = 0)]
        public int CODIGO { get; set; }
        public string USUARIO { get; set; }
    }
}
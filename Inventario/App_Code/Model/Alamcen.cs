namespace Inventario.App_Code.Model
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.ModelConfiguration.Conventions;
    using System.Linq;

    public class Alamcen : DbContext
    {
        // El contexto se ha configurado para usar una cadena de conexión 'Alamcen' del archivo 
        // de configuración de la aplicación (App.config o Web.config). De forma predeterminada, 
        // esta cadena de conexión tiene como destino la base de datos 'Inventario.App_Code.Model.Alamcen' de la instancia LocalDb. 
        // 
        // Si desea tener como destino una base de datos y/o un proveedor de base de datos diferente, 
        // modifique la cadena de conexión 'Alamcen'  en el archivo de configuración de la aplicación.
        public Alamcen()
            : base("name=Alamcen")
        {
        }

        // Agregue un DbSet para cada tipo de entidad que desee incluir en el modelo. Para obtener más información 
        // sobre cómo configurar y usar un modelo Code First, vea http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<ENTRADAALM> DBEntradaAlmas { get; set; }

        protected override void OnModelCreating(DbModelBuilder dbModelBuilder)
        {
            dbModelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            dbModelBuilder.Conventions.Remove<IncludeMetadataConvention>();
        }
    }

    public class ENTRADAALM
    {
        [Key, Column(Order = 0)]
        public int CODIGO { get; set; }
        public string LOTE { get; set; }
        //https://stackoverflow.com/questions/10710393/nullable-property-to-entity-field-entity-framework-through-code-first
        public int? PEDIDOALM { get; set; }
    }
}
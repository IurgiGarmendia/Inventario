namespace Inventario.App_Code.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.ModelConfiguration.Conventions;
    using System.Linq;

    public class QueryInner : DbContext
    {
        // El contexto se ha configurado para usar una cadena de conexión 'QueryInner' del archivo 
        // de configuración de la aplicación (App.config o Web.config). De forma predeterminada, 
        // esta cadena de conexión tiene como destino la base de datos 'Inventario.App_Code.Model.QueryInner' de la instancia LocalDb. 
        // 
        // Si desea tener como destino una base de datos y/o un proveedor de base de datos diferente, 
        // modifique la cadena de conexión 'QueryInner'  en el archivo de configuración de la aplicación.
        public QueryInner()
            : base("name=QueryInner")
        {
        }

        // Agregue un DbSet para cada tipo de entidad que desee incluir en el modelo. Para obtener más información 
        // sobre cómo configurar y usar un modelo Code First, vea http://go.microsoft.com/fwlink/?LinkId=390109.

         public virtual DbSet<LOTES> DBLotes { get; set; }
        public virtual DbSet<ALMACENESCH> DBAlmacenesch { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<IncludeMetadataConvention>();

            //modelBuilder.Entity<LOTES>()
            //  .Map(map =>
            //  {
            //      map.Properties(p => new
            //      {
            //          p.COD_LOTE,
            //          p.LOTE,
            //          p.CODALMACEN
            //      });
            //      map.ToTable("LOTES");
            //  })
            //  // Map to the Users table  
            //  .Map(map =>
            //  {
            //      map.Properties(p => new
            //      {
            //          p.IDENT
            //      });
            //      map.ToTable("ALMACENESCH");
            //  });
        }

    }

    public class LOTES
    {
        [Key, Column(Order = 0)]
        public int COD_LOTE { get; set; }
        public string LOTE { get; set; }
        //[ForeignKey("ALMACENESCH")]
        public string CODALMACEN { get; set; }

        [Key, Column(Order = 1)]
        public int COD_EMPRESA { get; set; }

        //public virtual ALMACENESCH ALMACENESCH { get; set; }

        //public string IDENT { get; set; }//Tabla almacenesch
    }


    public class ALMACENESCH
    {
        [Key, Column(Order = 0)]
        public string CODALMACEN { get; set; }
        public string IDENT { get; set; }//Tabla almacenesch

        //public ICollection<LOTES> LOTES { get; set; }

        //public virtual LOTES LOTES { get; set; }
    }



}
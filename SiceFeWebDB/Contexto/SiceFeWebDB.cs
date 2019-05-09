using SiceFeWebModel.Document;
using SiceFeWebModel.OnQueue;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiceFeWebDB.Contexto
{
    public class SiceFeWebDB : DbContext
    {
        public SiceFeWebDB() : base("SiceFeWebDB")
        {
            Database.SetInitializer<SiceFeWebDB>(null);
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }

        public DbSet<Document> Document { get; set; }
        public DbSet<OnQueue> OnQueue { get; set; }

        #region FluentApi
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Para no pluralizar los nombres
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            //Para evitar el borrado en cascada
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            modelBuilder.Entity<Document>().Property(x => x.RucEmisor)
                .HasColumnType("varchar")
                .HasMaxLength(11)
                .IsRequired();


        }

        #endregion
    }
}

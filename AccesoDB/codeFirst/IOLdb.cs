namespace AccesoDB.codeFirst
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class IOLdb : DbContext
    {
        public IOLdb()
            : base("name=IOLdb")
        {
        }

        public virtual DbSet<ITEM_TITULO> ITEM_TITULO { get; set; }
        public virtual DbSet<ITEM_TITULO_TYPE> ITEM_TITULO_TYPE { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ITEM_TITULO>()
                .Property(e => e.Simbolo)
                .IsUnicode(false);

            modelBuilder.Entity<ITEM_TITULO>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<ITEM_TITULO>()
                .Property(e => e.PrecioApertura)
                .HasPrecision(18, 3);

            modelBuilder.Entity<ITEM_TITULO>()
                .Property(e => e.Minimo)
                .HasPrecision(18, 3);

            modelBuilder.Entity<ITEM_TITULO>()
                .Property(e => e.Maximo)
                .HasPrecision(18, 3);

            modelBuilder.Entity<ITEM_TITULO>()
                .Property(e => e.UltimoCierre)
                .HasPrecision(18, 3);

            modelBuilder.Entity<ITEM_TITULO_TYPE>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<ITEM_TITULO_TYPE>()
                .HasMany(e => e.ITEM_TITULO)
                .WithRequired(e => e.ITEM_TITULO_TYPE)
                .HasForeignKey(e => e.FK_Item_Titulo_Type)
                .WillCascadeOnDelete(false);
        }
    }
}

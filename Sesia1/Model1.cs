namespace Sesia1
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Заказ> Заказ { get; set; }
        public virtual DbSet<Заказные_изделия> Заказные_изделия { get; set; }
        public virtual DbSet<Изделия> Изделия { get; set; }
        public virtual DbSet<Пользователи> Пользователи { get; set; }
        public virtual DbSet<Склад_ткани> Склад_ткани { get; set; }
        public virtual DbSet<Склад_фурнитуры> Склад_фурнитуры { get; set; }
        public virtual DbSet<Ткань> Ткань { get; set; }
        public virtual DbSet<Фурнитура> Фурнитура { get; set; }
        public virtual DbSet<Фурнитура_изделия> Фурнитура_изделия { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Заказ>()
                .Property(e => e.Стоимость)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Заказ>()
                .HasMany(e => e.Заказные_изделия)
                .WithRequired(e => e.Заказ)
                .HasForeignKey(e => e.Номер_заказа)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Изделия>()
                .HasMany(e => e.Заказные_изделия)
                .WithRequired(e => e.Изделия)
                .HasForeignKey(e => e.Артикул_изделия)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Изделия>()
                .HasMany(e => e.Фурнитура_изделия)
                .WithRequired(e => e.Изделия)
                .HasForeignKey(e => e.Артикул_изделия)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Изделия>()
                .HasMany(e => e.Ткань)
                .WithMany(e => e.Изделия)
                .Map(m => m.ToTable("Ткани изделия").MapLeftKey("Артикул_изделия").MapRightKey("Артикул_ткани"));

            modelBuilder.Entity<Пользователи>()
                .HasMany(e => e.Заказ)
                .WithRequired(e => e.Пользователи)
                .HasForeignKey(e => e.Заказчик)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Пользователи>()
                .HasMany(e => e.Заказ1)
                .WithOptional(e => e.Пользователи1)
                .HasForeignKey(e => e.Менеджер);

            modelBuilder.Entity<Ткань>()
                .HasMany(e => e.Склад_ткани)
                .WithRequired(e => e.Ткань)
                .HasForeignKey(e => e.Артикул_ткани)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Фурнитура>()
                .Property(e => e.Цена)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Фурнитура>()
                .HasMany(e => e.Склад_фурнитуры)
                .WithRequired(e => e.Фурнитура)
                .HasForeignKey(e => e.Артикул_фурнитуры)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Фурнитура>()
                .HasMany(e => e.Фурнитура_изделия)
                .WithRequired(e => e.Фурнитура)
                .HasForeignKey(e => e.Артикул_фурнитуры)
                .WillCascadeOnDelete(false);
        }
    }
}

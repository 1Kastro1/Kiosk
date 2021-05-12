using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Kiosk.Формы
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Авторизация> Авторизация { get; set; }
        public virtual DbSet<Заказ> Заказ { get; set; }
        public virtual DbSet<Клиент> Клиент { get; set; }
        public virtual DbSet<Корзина> Корзина { get; set; }
        public virtual DbSet<Поставщики> Поставщики { get; set; }
        public virtual DbSet<Продукты> Продукты { get; set; }
        public virtual DbSet<Сотрудники> Сотрудники { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Авторизация>()
                .Property(e => e.Логин)
                .IsFixedLength();

            modelBuilder.Entity<Авторизация>()
                .Property(e => e.Пароль)
                .IsFixedLength();

            modelBuilder.Entity<Заказ>()
                .Property(e => e.СтоимостьЗаказа)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Заказ>()
                .Property(e => e.срокВыполнения)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Корзина>()
                .Property(e => e.Количество)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Корзина>()
                .Property(e => e.Цена)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Поставщики>()
                .Property(e => e.Телефон)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Поставщики>()
                .HasMany(e => e.Продукты)
                .WithOptional(e => e.Поставщики)
                .HasForeignKey(e => e.КодПоставщика);

            modelBuilder.Entity<Продукты>()
                .Property(e => e.КоличествоПродукта)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Продукты>()
                .Property(e => e.СтоимостьПродукции)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Продукты>()
                .Property(e => e.Калории)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Продукты>()
                .HasMany(e => e.Корзина)
                .WithOptional(e => e.Продукты)
                .HasForeignKey(e => e.КодПродукта);

            modelBuilder.Entity<Сотрудники>()
                .Property(e => e.Номер)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Сотрудники>()
                .Property(e => e.Зарплата)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Сотрудники>()
                .HasMany(e => e.Заказ)
                .WithOptional(e => e.Сотрудники)
                .HasForeignKey(e => e.КодСотрудника);
        }
    }
}

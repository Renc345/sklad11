﻿

//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------


namespace sklad.Classes
{

using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;


public partial class SkladEntities : DbContext
{
        private static SkladEntities _Context;

       

        public SkladEntities()
        : base("name=SkladEntities")
    {

    }
 public static SkladEntities GetContext()
        {
            if (_Context == null)
                _Context = new SkladEntities();
            return _Context;
        }
    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        throw new UnintentionalCodeFirstException();
    }


    public virtual DbSet<Application> Application { get; set; }

    public virtual DbSet<Manufacturer> Manufacturer { get; set; }

    public virtual DbSet<Medicament> Medicament { get; set; }

    public virtual DbSet<Phaemacy> Phaemacy { get; set; }

    public virtual DbSet<Purchase> Purchase { get; set; }

    public virtual DbSet<Type> Type { get; set; }

    public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }

    public virtual DbSet<Basket> Basket { get; set; }

    public virtual DbSet<Order> Order { get; set; }

}

}


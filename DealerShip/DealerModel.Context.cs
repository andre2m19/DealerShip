﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DealerShip
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DealerModelContainer : DbContext
    {
        public DealerModelContainer()
            : base("name=DealerModelContainer")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Cliente> ClienteSet { get; set; }
        public virtual DbSet<Venda> VendaSet { get; set; }
        public virtual DbSet<Aluguer> AluguerSet { get; set; }
        public virtual DbSet<Carro> CarroSet { get; set; }
        public virtual DbSet<Servico> ServicoSet { get; set; }
        public virtual DbSet<Parcela> ParcelaSet { get; set; }
    }
}

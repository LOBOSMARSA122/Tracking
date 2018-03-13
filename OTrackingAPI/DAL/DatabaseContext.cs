﻿using BE.Comun;
using System.Data.Entity;

namespace DAL
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("name=BDOTracking") {}
        public DbSet<Persona> Personas  { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Colaborador> Colaboradores { get; set; }
        public DbSet<Diagnostico> Diagnosticos { get; set; }
        public DbSet<Servicio> Servicios { get; set; }
        public DbSet<Componente> Componentes { get; set; }
        public DbSet<ComponenteDiagnostico> ComponenteDiagnosticos { get; set; }
        public DbSet<ServicioComponente> ServicioComponentes { get; set; }
        public DbSet<ComponenteCampo> ComponenteCampos { get; set; }
    }
}

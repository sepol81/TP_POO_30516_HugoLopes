


using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EMS.models.Equiments;
using EMS.models.Events;
using EMS.models.Persons;
using EMS.models.Vehicles;
using EMS.models;
using EMS.models.Teams;


namespace EMS.Data
{
    public class EmergenciesDBContext : DbContext
    {
        public DbSet<Equipment> Equipments { get; set; }
       

        public DbSet<Event> Events { get; set; }
        public DbSet<CatastropheEvent> Catastrophes_Event { get; set; }
        public DbSet<FireEvent> Fire_Events { get; set; }
        public DbSet<MedicalEvent> Medical_Events { get; set; }

        
        public DbSet<Person> Persons { get; set; }
        public DbSet<Nurse> Nurses { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Paramedic> Paramedics { get; set; }
        public DbSet<FireFighter> FireFighters { get; set; }

               
        public DbSet<FireStation> Fire_Station { get; set; }


       
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Ambulance> Ambulances { get; set; }
        public DbSet<FireTruck> FireTrucks { get; set; }
        public DbSet<Helicopter> Helicopters { get; set; }
        public DbSet<MotorBike> MotorBikes { get; set; }

        public DbSet<Team> Teams { get; set; }
        



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configuração de tabelas e chaves primárias
            modelBuilder.Entity<Equipment>()
                .ToTable("Equipments")
                .HasKey(e => e.Id);

           
                

            modelBuilder.Entity<FireStation>()
                .ToTable("Fire_Station")
                .HasKey(e => e.Id);



           
            modelBuilder.Entity<Event>()
                .ToTable("Events")
                .HasKey(e => e.Id);

           

            modelBuilder.Entity<CatastropheEvent>()
                .ToTable("Catastrophe_Events")
                .HasBaseType<Event>();

            modelBuilder.Entity<FireEvent>()
                .ToTable("Fire_Events")
                .HasBaseType<Event>();

            modelBuilder.Entity<MedicalEvent>()
                .ToTable("Medical_Events")
                .HasBaseType<Event>();



            
                

            modelBuilder.Entity<Person>()
                .ToTable("Persons")
                .HasKey(p => p.Id);

            modelBuilder.Entity<Nurse>()
                .ToTable("Nurses")
                .HasBaseType<Person>();

            modelBuilder.Entity<Patient>()
                .ToTable("Patients")
                .HasBaseType<Person>();

            modelBuilder.Entity<Doctor>()
                .ToTable("Doctors")
                .HasBaseType<Person>();

            modelBuilder.Entity<Paramedic>()
                .ToTable("Paramedics")
                .HasBaseType<Person>();

            modelBuilder.Entity<FireFighter>()
                .ToTable("FireFighters")
                .HasBaseType<Person>();

                       


         
            modelBuilder.Entity<Vehicle>()
                .ToTable("Vehicles")
                .HasKey(v => v.CarRegist);

            modelBuilder.Entity<Ambulance>()
                .ToTable("Ambulances")
                .HasBaseType<Vehicle>();

            modelBuilder.Entity<FireTruck>()
                .ToTable("FireTrucks")
                .HasBaseType<Vehicle>();

            modelBuilder.Entity<Helicopter>()
                .ToTable("Helicopters")
                .HasBaseType<Vehicle>();

            modelBuilder.Entity<MotorBike>()
                .ToTable("MotorBikes")
                .HasBaseType<Vehicle>();

            modelBuilder.Entity<Team>()
               .ToTable("Teams")
               .HasKey(v => v.Id);

           
             

        }
           
            
           
                

           

           

           

            



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAPTOPHUGOLOPES\\SQLEXPRESS;Database=EMS;Trusted_Connection=True;Encrypt=False");
        }
    }
}

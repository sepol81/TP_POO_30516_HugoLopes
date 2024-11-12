﻿// <auto-generated />
using System;
using EMS.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EMS.Migrations
{
    [DbContext(typeof(EmergenciesDBContext))]
    partial class EmergenciesDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EMS.models.Equiments.Equipment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("EventId")
                        .HasColumnType("int");

                    b.Property<int?>("FireStationId")
                        .HasColumnType("int");

                    b.Property<DateOnly>("MaintenanceDate")
                        .HasColumnType("date");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EventId");

                    b.HasIndex("FireStationId");

                    b.ToTable("Equipments", (string)null);
                });

            modelBuilder.Entity("EMS.models.Events.Event", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndEventDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("SeverityLevel")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartEventDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Events", (string)null);

                    b.UseTptMappingStrategy();
                });

            modelBuilder.Entity("EMS.models.FireStation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Fire_Station", (string)null);
                });

            modelBuilder.Entity("EMS.models.Persons.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateOnly>("Birthday")
                        .HasColumnType("date");

                    b.Property<string>("CitCard")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("EventId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Profession")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int?>("TeamId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EventId");

                    b.HasIndex("TeamId");

                    b.ToTable("Persons", (string)null);

                    b.UseTptMappingStrategy();
                });

            modelBuilder.Entity("EMS.models.Teams.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("EventId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EventId");

                    b.ToTable("Teams", (string)null);
                });

            modelBuilder.Entity("EMS.models.Vehicles.Vehicle", b =>
                {
                    b.Property<string>("CarRegist")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("EventId")
                        .HasColumnType("int");

                    b.Property<int?>("FireStationId")
                        .HasColumnType("int");

                    b.Property<int?>("FireStationId1")
                        .HasColumnType("int");

                    b.Property<int?>("FireStationId2")
                        .HasColumnType("int");

                    b.Property<int?>("FireStationId3")
                        .HasColumnType("int");

                    b.Property<DateOnly>("InspDate")
                        .HasColumnType("date");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<DateOnly>("YearOfRegist")
                        .HasColumnType("date");

                    b.HasKey("CarRegist");

                    b.HasIndex("EventId");

                    b.HasIndex("FireStationId");

                    b.HasIndex("FireStationId1");

                    b.HasIndex("FireStationId2");

                    b.HasIndex("FireStationId3");

                    b.ToTable("Vehicles", (string)null);

                    b.UseTptMappingStrategy();
                });

            modelBuilder.Entity("EMS.models.Events.CatastropheEvent", b =>
                {
                    b.HasBaseType("EMS.models.Events.Event");

                    b.Property<double>("AffectedArea")
                        .HasColumnType("float");

                    b.Property<int>("NumberOfVictims")
                        .HasColumnType("int");

                    b.Property<int>("TypeCat")
                        .HasColumnType("int");

                    b.ToTable("Catastrophe_Events", (string)null);
                });

            modelBuilder.Entity("EMS.models.Events.FireEvent", b =>
                {
                    b.HasBaseType("EMS.models.Events.Event");

                    b.Property<double>("AffectedArea")
                        .HasColumnType("float");

                    b.Property<string>("FireIntensity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TypeOfFire")
                        .HasColumnType("int");

                    b.ToTable("Fire_Events", (string)null);
                });

            modelBuilder.Entity("EMS.models.Events.MedicalEvent", b =>
                {
                    b.HasBaseType("EMS.models.Events.Event");

                    b.Property<int>("NumberOfVictims")
                        .HasColumnType("int");

                    b.Property<int>("TypeOfEmergency")
                        .HasColumnType("int");

                    b.ToTable("Medical_Events", (string)null);
                });

            modelBuilder.Entity("EMS.models.Persons.Doctor", b =>
                {
                    b.HasBaseType("EMS.models.Persons.Person");

                    b.Property<string>("CardNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("FireStationId")
                        .HasColumnType("int");

                    b.Property<string>("Specialty")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasIndex("FireStationId");

                    b.ToTable("Doctors", (string)null);
                });

            modelBuilder.Entity("EMS.models.Persons.FireFighter", b =>
                {
                    b.HasBaseType("EMS.models.Persons.Person");

                    b.Property<string>("Certifications")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("FireStationId")
                        .HasColumnType("int");

                    b.Property<int>("Rank")
                        .HasColumnType("int");

                    b.Property<string>("Skills")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("YearsOfExp")
                        .HasColumnType("int");

                    b.HasIndex("FireStationId");

                    b.ToTable("FireFighters", (string)null);
                });

            modelBuilder.Entity("EMS.models.Persons.Nurse", b =>
                {
                    b.HasBaseType("EMS.models.Persons.Person");

                    b.Property<string>("AreaOfActivity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CardNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("FireStationId")
                        .HasColumnType("int");

                    b.HasIndex("FireStationId");

                    b.ToTable("Nurses", (string)null);
                });

            modelBuilder.Entity("EMS.models.Persons.Paramedic", b =>
                {
                    b.HasBaseType("EMS.models.Persons.Person");

                    b.Property<int?>("FireStationId")
                        .HasColumnType("int");

                    b.Property<string>("TechnicalNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasIndex("FireStationId");

                    b.ToTable("Paramedics", (string)null);
                });

            modelBuilder.Entity("EMS.models.Persons.Patient", b =>
                {
                    b.HasBaseType("EMS.models.Persons.Person");

                    b.Property<DateTime>("AdmissionDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Condition")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("FireStationId")
                        .HasColumnType("int");

                    b.Property<string>("MedicalRecordNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasIndex("FireStationId");

                    b.ToTable("Patients", (string)null);
                });

            modelBuilder.Entity("EMS.models.Vehicles.Ambulance", b =>
                {
                    b.HasBaseType("EMS.models.Vehicles.Vehicle");

                    b.Property<int>("CrewCapacity")
                        .HasColumnType("int");

                    b.ToTable("Ambulances", (string)null);
                });

            modelBuilder.Entity("EMS.models.Vehicles.FireTruck", b =>
                {
                    b.HasBaseType("EMS.models.Vehicles.Vehicle");

                    b.Property<int>("CrewCapacity")
                        .HasColumnType("int");

                    b.Property<int>("WaterTankCapacity")
                        .HasColumnType("int");

                    b.ToTable("FireTrucks", (string)null);
                });

            modelBuilder.Entity("EMS.models.Vehicles.Helicopter", b =>
                {
                    b.HasBaseType("EMS.models.Vehicles.Vehicle");

                    b.Property<int>("CrewCapacity")
                        .HasColumnType("int");

                    b.Property<bool>("HasMedicalEquipment")
                        .HasColumnType("bit");

                    b.Property<int>("MaxAltitude")
                        .HasColumnType("int");

                    b.Property<int>("MaxRange")
                        .HasColumnType("int");

                    b.ToTable("Helicopters", (string)null);
                });

            modelBuilder.Entity("EMS.models.Vehicles.MotorBike", b =>
                {
                    b.HasBaseType("EMS.models.Vehicles.Vehicle");

                    b.Property<int>("EngineCapacity")
                        .HasColumnType("int");

                    b.Property<bool>("HasFirstAidKit")
                        .HasColumnType("bit");

                    b.Property<bool>("HasSiren")
                        .HasColumnType("bit");

                    b.ToTable("MotorBikes", (string)null);
                });

            modelBuilder.Entity("EMS.models.Equiments.Equipment", b =>
                {
                    b.HasOne("EMS.models.Events.Event", null)
                        .WithMany("EquipmentUsed")
                        .HasForeignKey("EventId");

                    b.HasOne("EMS.models.FireStation", null)
                        .WithMany("Equipment")
                        .HasForeignKey("FireStationId");
                });

            modelBuilder.Entity("EMS.models.Persons.Person", b =>
                {
                    b.HasOne("EMS.models.Events.Event", null)
                        .WithMany("PeopleInvolved")
                        .HasForeignKey("EventId");

                    b.HasOne("EMS.models.Teams.Team", null)
                        .WithMany("Members")
                        .HasForeignKey("TeamId");
                });

            modelBuilder.Entity("EMS.models.Teams.Team", b =>
                {
                    b.HasOne("EMS.models.Events.Event", null)
                        .WithMany("TeamsInvolved")
                        .HasForeignKey("EventId");
                });

            modelBuilder.Entity("EMS.models.Vehicles.Vehicle", b =>
                {
                    b.HasOne("EMS.models.Events.Event", null)
                        .WithMany("VehiclesInvolved")
                        .HasForeignKey("EventId");

                    b.HasOne("EMS.models.FireStation", null)
                        .WithMany("Ambulance")
                        .HasForeignKey("FireStationId");

                    b.HasOne("EMS.models.FireStation", null)
                        .WithMany("FireTrucks")
                        .HasForeignKey("FireStationId1");

                    b.HasOne("EMS.models.FireStation", null)
                        .WithMany("Helicopter")
                        .HasForeignKey("FireStationId2");

                    b.HasOne("EMS.models.FireStation", null)
                        .WithMany("MotorBike")
                        .HasForeignKey("FireStationId3");
                });

            modelBuilder.Entity("EMS.models.Events.CatastropheEvent", b =>
                {
                    b.HasOne("EMS.models.Events.Event", null)
                        .WithOne()
                        .HasForeignKey("EMS.models.Events.CatastropheEvent", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EMS.models.Events.FireEvent", b =>
                {
                    b.HasOne("EMS.models.Events.Event", null)
                        .WithOne()
                        .HasForeignKey("EMS.models.Events.FireEvent", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EMS.models.Events.MedicalEvent", b =>
                {
                    b.HasOne("EMS.models.Events.Event", null)
                        .WithOne()
                        .HasForeignKey("EMS.models.Events.MedicalEvent", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EMS.models.Persons.Doctor", b =>
                {
                    b.HasOne("EMS.models.FireStation", null)
                        .WithMany("Doctors")
                        .HasForeignKey("FireStationId");

                    b.HasOne("EMS.models.Persons.Person", null)
                        .WithOne()
                        .HasForeignKey("EMS.models.Persons.Doctor", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EMS.models.Persons.FireFighter", b =>
                {
                    b.HasOne("EMS.models.FireStation", null)
                        .WithMany("FireFighters")
                        .HasForeignKey("FireStationId");

                    b.HasOne("EMS.models.Persons.Person", null)
                        .WithOne()
                        .HasForeignKey("EMS.models.Persons.FireFighter", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EMS.models.Persons.Nurse", b =>
                {
                    b.HasOne("EMS.models.FireStation", null)
                        .WithMany("Nurses")
                        .HasForeignKey("FireStationId");

                    b.HasOne("EMS.models.Persons.Person", null)
                        .WithOne()
                        .HasForeignKey("EMS.models.Persons.Nurse", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EMS.models.Persons.Paramedic", b =>
                {
                    b.HasOne("EMS.models.FireStation", null)
                        .WithMany("Paramedics")
                        .HasForeignKey("FireStationId");

                    b.HasOne("EMS.models.Persons.Person", null)
                        .WithOne()
                        .HasForeignKey("EMS.models.Persons.Paramedic", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EMS.models.Persons.Patient", b =>
                {
                    b.HasOne("EMS.models.FireStation", null)
                        .WithMany("Patients")
                        .HasForeignKey("FireStationId");

                    b.HasOne("EMS.models.Persons.Person", null)
                        .WithOne()
                        .HasForeignKey("EMS.models.Persons.Patient", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EMS.models.Vehicles.Ambulance", b =>
                {
                    b.HasOne("EMS.models.Vehicles.Vehicle", null)
                        .WithOne()
                        .HasForeignKey("EMS.models.Vehicles.Ambulance", "CarRegist")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EMS.models.Vehicles.FireTruck", b =>
                {
                    b.HasOne("EMS.models.Vehicles.Vehicle", null)
                        .WithOne()
                        .HasForeignKey("EMS.models.Vehicles.FireTruck", "CarRegist")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EMS.models.Vehicles.Helicopter", b =>
                {
                    b.HasOne("EMS.models.Vehicles.Vehicle", null)
                        .WithOne()
                        .HasForeignKey("EMS.models.Vehicles.Helicopter", "CarRegist")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EMS.models.Vehicles.MotorBike", b =>
                {
                    b.HasOne("EMS.models.Vehicles.Vehicle", null)
                        .WithOne()
                        .HasForeignKey("EMS.models.Vehicles.MotorBike", "CarRegist")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EMS.models.Events.Event", b =>
                {
                    b.Navigation("EquipmentUsed");

                    b.Navigation("PeopleInvolved");

                    b.Navigation("TeamsInvolved");

                    b.Navigation("VehiclesInvolved");
                });

            modelBuilder.Entity("EMS.models.FireStation", b =>
                {
                    b.Navigation("Ambulance");

                    b.Navigation("Doctors");

                    b.Navigation("Equipment");

                    b.Navigation("FireFighters");

                    b.Navigation("FireTrucks");

                    b.Navigation("Helicopter");

                    b.Navigation("MotorBike");

                    b.Navigation("Nurses");

                    b.Navigation("Paramedics");

                    b.Navigation("Patients");
                });

            modelBuilder.Entity("EMS.models.Teams.Team", b =>
                {
                    b.Navigation("Members");
                });
#pragma warning restore 612, 618
        }
    }
}
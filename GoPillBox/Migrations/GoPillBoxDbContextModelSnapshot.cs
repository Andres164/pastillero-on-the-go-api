﻿// <auto-generated />
using System;
using GoPillBox.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace GoPillBox.Migrations
{
    [DbContext(typeof(GoPillBoxDbContext))]
    partial class GoPillBoxDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("GoPillBox.Models.AlarmEvent", b =>
                {
                    b.Property<int>("AlarmEventId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("alarm_event_id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("AlarmEventId"));

                    b.Property<int>("CurrentState")
                        .HasColumnType("integer")
                        .HasColumnName("current_state");

                    b.Property<DateTime>("EventTimeStamp")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("event_time_stamp");

                    b.Property<int>("PostponedForInMinutes")
                        .HasColumnType("integer")
                        .HasColumnName("postponed_for_in_minutes");

                    b.Property<int>("UserMedicationId")
                        .HasColumnType("integer")
                        .HasColumnName("user_medication_id");

                    b.HasKey("AlarmEventId");

                    b.ToTable("alarm_events");
                });

            modelBuilder.Entity("GoPillBox.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("user_id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("UserId"));

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("character varying(50)")
                        .HasColumnName("password");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("character varying(50)")
                        .HasColumnName("user_name");

                    b.HasKey("UserId");

                    b.ToTable("users");
                });

            modelBuilder.Entity("GoPillBox.Models.UserMedication", b =>
                {
                    b.Property<int>("UserMedicationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("user_medication_id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("UserMedicationId"));

                    b.Property<float>("Dose")
                        .HasColumnType("real")
                        .HasColumnName("dose");

                    b.Property<string>("DoseUnitOfMesure")
                        .IsRequired()
                        .HasColumnType("character varying(20)")
                        .HasColumnName("dose_unit_of_mesure");

                    b.Property<float>("DosingFrequencyInHours")
                        .HasColumnType("real")
                        .HasColumnName("dosing_frequency_in_hours");

                    b.Property<string>("MedicNotes")
                        .IsRequired()
                        .HasColumnType("character varying(350)")
                        .HasColumnName("medic_notes");

                    b.Property<string>("MedicationName")
                        .IsRequired()
                        .HasColumnType("character varying(70)")
                        .HasColumnName("medication_name");

                    b.Property<int>("TimeInTreatmentInDays")
                        .HasColumnType("integer")
                        .HasColumnName("time_in_treatment_in_days");

                    b.Property<int>("UserId")
                        .HasColumnType("integer")
                        .HasColumnName("user_id");

                    b.HasKey("UserMedicationId");

                    b.ToTable("user_medications");
                });
#pragma warning restore 612, 618
        }
    }
}

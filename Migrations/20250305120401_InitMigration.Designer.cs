﻿// <auto-generated />
using System;
using MCPowerlifting.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MCPowerlifting.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20250305120401_InitMigration")]
    partial class InitMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("MCPowerlifting.Models.Entities.Equipment", b =>
                {
                    b.Property<int>("EquipmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("equipmeint_id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("EquipmentId"));

                    b.Property<float>("BarWeight")
                        .HasColumnType("float")
                        .HasColumnName("bar_weight");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("updated_at");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("user_id");

                    b.HasKey("EquipmentId");

                    b.HasIndex("UserId");

                    b.ToTable("equipment");
                });

            modelBuilder.Entity("MCPowerlifting.Models.Entities.Exercise", b =>
                {
                    b.Property<int>("ExerciseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("exercise_id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("ExerciseId"));

                    b.Property<string>("ExerciseName")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("varchar(70)")
                        .HasColumnName("exercise_name");

                    b.Property<float>("Increment")
                        .HasColumnType("float")
                        .HasColumnName("increment");

                    b.Property<bool>("IsSuccessful")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("is_successful");

                    b.Property<int>("Reps")
                        .HasColumnType("int")
                        .HasColumnName("reps");

                    b.Property<int>("Sets")
                        .HasColumnType("int")
                        .HasColumnName("sets");

                    b.Property<float>("Weight")
                        .HasColumnType("float")
                        .HasColumnName("weight");

                    b.Property<int>("WorkoutId")
                        .HasColumnType("int")
                        .HasColumnName("workout_id");

                    b.HasKey("ExerciseId");

                    b.HasIndex("WorkoutId");

                    b.ToTable("exercises");
                });

            modelBuilder.Entity("MCPowerlifting.Models.Entities.Plate", b =>
                {
                    b.Property<int>("PlateId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("plate_id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("PlateId"));

                    b.Property<int>("EquipmentId")
                        .HasColumnType("int")
                        .HasColumnName("equipment_id");

                    b.Property<int>("PlateCount")
                        .HasColumnType("int")
                        .HasColumnName("plate_count");

                    b.Property<float>("PlateWeight")
                        .HasColumnType("float")
                        .HasColumnName("plate_weight");

                    b.HasKey("PlateId");

                    b.HasIndex("EquipmentId");

                    b.ToTable("plates");
                });

            modelBuilder.Entity("MCPowerlifting.Models.Entities.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("user_id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("UserId"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("email");

                    b.Property<string>("Passwordhash")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("passwordhash");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("varchar(25)")
                        .HasColumnName("role");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("username");

                    b.HasKey("UserId");

                    b.ToTable("user_accounts");
                });

            modelBuilder.Entity("MCPowerlifting.Models.Entities.Workout", b =>
                {
                    b.Property<int>("WorkoutId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("workout_id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("WorkoutId"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("date");

                    b.Property<int>("Load")
                        .HasColumnType("int")
                        .HasColumnName("load");

                    b.Property<string>("Notes")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("TEXT");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("user_id");

                    b.HasKey("WorkoutId");

                    b.HasIndex("UserId");

                    b.ToTable("workouts");
                });

            modelBuilder.Entity("MCPowerlifting.Models.Entities.WorkoutProgram", b =>
                {
                    b.Property<int>("ProgramId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("program_id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("ProgramId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("varchar(1000)")
                        .HasColumnName("description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("name");

                    b.Property<float>("StartingWeight")
                        .HasColumnType("float")
                        .HasColumnName("starting_weight");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("user_id");

                    b.HasKey("ProgramId");

                    b.HasIndex("UserId");

                    b.ToTable("programs");
                });

            modelBuilder.Entity("MCPowerlifting.Models.Entities.Equipment", b =>
                {
                    b.HasOne("MCPowerlifting.Models.Entities.User", "User")
                        .WithMany("Equipments")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("MCPowerlifting.Models.Entities.Exercise", b =>
                {
                    b.HasOne("MCPowerlifting.Models.Entities.Workout", "Workout")
                        .WithMany("Exercises")
                        .HasForeignKey("WorkoutId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Workout");
                });

            modelBuilder.Entity("MCPowerlifting.Models.Entities.Plate", b =>
                {
                    b.HasOne("MCPowerlifting.Models.Entities.Equipment", "Equipment")
                        .WithMany("Plates")
                        .HasForeignKey("EquipmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Equipment");
                });

            modelBuilder.Entity("MCPowerlifting.Models.Entities.Workout", b =>
                {
                    b.HasOne("MCPowerlifting.Models.Entities.User", "User")
                        .WithMany("Workouts")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("MCPowerlifting.Models.Entities.WorkoutProgram", b =>
                {
                    b.HasOne("MCPowerlifting.Models.Entities.User", "User")
                        .WithMany("WorkoutPrograms")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("MCPowerlifting.Models.Entities.Equipment", b =>
                {
                    b.Navigation("Plates");
                });

            modelBuilder.Entity("MCPowerlifting.Models.Entities.User", b =>
                {
                    b.Navigation("Equipments");

                    b.Navigation("WorkoutPrograms");

                    b.Navigation("Workouts");
                });

            modelBuilder.Entity("MCPowerlifting.Models.Entities.Workout", b =>
                {
                    b.Navigation("Exercises");
                });
#pragma warning restore 612, 618
        }
    }
}

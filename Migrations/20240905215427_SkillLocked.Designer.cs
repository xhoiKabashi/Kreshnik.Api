﻿// <auto-generated />
using System;
using Kreshnik.Api.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Kreshnik.Api.Migrations
{
    [DbContext(typeof(GameDbContext))]
    [Migration("20240905215427_SkillLocked")]
    partial class SkillLocked
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.7");

            modelBuilder.Entity("Kreshnik.Api.Models.Hero", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Ability1")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Ability2")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Ability3")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Armor")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Dmg")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Exp")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ExpThreshold")
                        .HasColumnType("INTEGER");

                    b.Property<int>("HeavyCrashDmg")
                        .HasColumnType("INTEGER");

                    b.Property<int>("HeavyCrashLevel")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Hp")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Level")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MilkRegeLevel")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MilkRegeStats")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int?>("Points")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Speed")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Story1")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Story2")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Story3")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Story4")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Story5")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Story6")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Story7")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Story8")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TearHealHp")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TearHealLevel")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("UserPin")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Wins")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Wounds")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Heroes");
                });
#pragma warning restore 612, 618
        }
    }
}

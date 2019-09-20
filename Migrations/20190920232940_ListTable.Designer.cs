﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using api.DBContext;

namespace api.Migrations
{
    [DbContext(typeof(AppDBContext))]
    [Migration("20190920232940_ListTable")]
    partial class ListTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity("api.Models.Lista", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataCriacao");

                    b.Property<DateTime>("DataFinalizacao");

                    b.Property<string>("Descricao");

                    b.HasKey("ID");

                    b.ToTable("Listas");
                });
#pragma warning restore 612, 618
        }
    }
}
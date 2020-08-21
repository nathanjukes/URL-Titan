﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using URL_Shortener.DatabaseContexts;

namespace URL_Shortener.Migrations
{
    [DbContext(typeof(URLContext))]
    [Migration("20200821155036_changePropertyAttributes")]
    partial class changePropertyAttributes
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("URL_Shortener.Models.URL", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("BaseURL")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ExternalIP")
                        .HasColumnType("text");

                    b.Property<string>("ShortenedIdentifier")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("UrlSet");
                });
#pragma warning restore 612, 618
        }
    }
}

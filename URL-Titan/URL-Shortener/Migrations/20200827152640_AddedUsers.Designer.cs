﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using URL_Shortener.DatabaseContexts;

namespace URL_Shortener.Migrations
{
    [DbContext(typeof(URLContext))]
    [Migration("20200827152640_AddedUsers")]
    partial class AddedUsers
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

            modelBuilder.Entity("URL_Shortener.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CountryCode")
                        .HasColumnType("text");

                    b.Property<DateTime>("DateInitialised")
                        .HasColumnType("datetime");

                    b.Property<string>("IpAddress")
                        .HasColumnType("text");

                    b.Property<DateTime>("LastUsedTime")
                        .HasColumnType("datetime");

                    b.Property<int?>("URLId")
                        .HasColumnType("int");

                    b.Property<int>("UseCount")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("URLId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("URL_Shortener.Models.User", b =>
                {
                    b.HasOne("URL_Shortener.Models.URL", null)
                        .WithMany("Users")
                        .HasForeignKey("URLId");
                });
#pragma warning restore 612, 618
        }
    }
}

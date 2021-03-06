﻿// <auto-generated />
using FluentlyHttpClient.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FluentlyHttpClient.Entity.Migrations
{
    [DbContext(typeof(FluentHttpClientDbContext))]
    [Migration("20190315104244_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FluentlyHttpClient.Entity.HttpResponseEntity", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(70);

                    b.Property<string>("Content")
                        .IsRequired();

                    b.Property<string>("ContentHeaders")
                        .IsRequired()
                        .HasMaxLength(1500);

                    b.Property<string>("Hash")
                        .IsRequired()
                        .HasMaxLength(1500);

                    b.Property<string>("Headers")
                        .IsRequired()
                        .HasMaxLength(1500);

                    b.Property<string>("Name")
                        .HasMaxLength(70);

                    b.Property<string>("ReasonPhrase")
                        .IsRequired()
                        .HasMaxLength(70);

                    b.Property<string>("RequestMessage")
                        .IsRequired();

                    b.Property<int>("StatusCode");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasMaxLength(1500);

                    b.Property<string>("Version")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.HasKey("Id");

                    b.ToTable("HttpResponses","cache");
                });
#pragma warning restore 612, 618
        }
    }
}

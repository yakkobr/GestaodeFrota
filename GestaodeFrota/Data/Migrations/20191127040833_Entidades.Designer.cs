﻿// <auto-generated />
using System;
using GestaodeFrota.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GestaodeFrota.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20191127040833_Entidades")]
    partial class Entidades
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("GestaodeFrota.Models.Abastecimento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AutomovelId");

                    b.Property<DateTime>("DataAbaste");

                    b.Property<int>("Litros");

                    b.Property<int?>("PostoId");

                    b.Property<double>("ValorAbaste");

                    b.Property<double>("ValorLitro");

                    b.HasKey("Id");

                    b.HasIndex("AutomovelId");

                    b.HasIndex("PostoId");

                    b.ToTable("Abastecimento");
                });

            modelBuilder.Entity("GestaodeFrota.Models.Apolice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descricao");

                    b.Property<int?>("SeguroId");

                    b.Property<string>("Tipo");

                    b.HasKey("Id");

                    b.HasIndex("SeguroId");

                    b.ToTable("Apolice");
                });

            modelBuilder.Entity("GestaodeFrota.Models.Automovel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Alugado");

                    b.Property<DateTime>("Ano");

                    b.Property<int?>("ApoliceId");

                    b.Property<bool>("Disponivel");

                    b.Property<string>("Marca");

                    b.Property<string>("Modelo");

                    b.Property<string>("Placa");

                    b.Property<int>("Quilometragem");

                    b.HasKey("Id");

                    b.HasIndex("ApoliceId");

                    b.ToTable("Automovel");
                });

            modelBuilder.Entity("GestaodeFrota.Models.Locacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AutomovelId");

                    b.Property<DateTime>("DataDevolucao");

                    b.Property<DateTime>("DataLocacao");

                    b.Property<bool>("Devolvido");

                    b.Property<double>("ValorLocacao");

                    b.HasKey("Id");

                    b.HasIndex("AutomovelId");

                    b.ToTable("Locacao");
                });

            modelBuilder.Entity("GestaodeFrota.Models.Manutencao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AutomovelId");

                    b.Property<DateTime>("DataManutencao");

                    b.Property<DateTime>("DataProxManu");

                    b.Property<int?>("OficinaId");

                    b.Property<string>("Servico");

                    b.Property<string>("Tipo");

                    b.Property<double>("Valor");

                    b.HasKey("Id");

                    b.HasIndex("AutomovelId");

                    b.HasIndex("OficinaId");

                    b.ToTable("Manutencao");
                });

            modelBuilder.Entity("GestaodeFrota.Models.Motorista", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AutomovelId");

                    b.Property<string>("CNH");

                    b.Property<DateTime>("DataNasc");

                    b.Property<bool>("Disponivel");

                    b.Property<string>("NomeMotorista");

                    b.Property<DateTime>("ValidadeCNH");

                    b.HasKey("Id");

                    b.HasIndex("AutomovelId");

                    b.ToTable("Motorista");
                });

            modelBuilder.Entity("GestaodeFrota.Models.Multa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AutomovelId");

                    b.Property<string>("CodIfracao");

                    b.Property<DateTime>("DataMulta");

                    b.Property<string>("Gravidade");

                    b.Property<string>("LocalMulta");

                    b.Property<int>("Pontos");

                    b.Property<double>("Valor");

                    b.HasKey("Id");

                    b.HasIndex("AutomovelId");

                    b.ToTable("Multa");
                });

            modelBuilder.Entity("GestaodeFrota.Models.Oficina", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Endereco");

                    b.Property<string>("NomeOficina");

                    b.HasKey("Id");

                    b.ToTable("Oficina");
                });

            modelBuilder.Entity("GestaodeFrota.Models.Posto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("EnderecoPosto");

                    b.Property<string>("NomePosto");

                    b.HasKey("Id");

                    b.ToTable("Posto");
                });

            modelBuilder.Entity("GestaodeFrota.Models.Seguro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome");

                    b.Property<DateTime>("Validade");

                    b.Property<double>("ValorSeguro");

                    b.HasKey("Id");

                    b.ToTable("Seguro");
                });

            modelBuilder.Entity("GestaodeFrota.Models.Viagem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AutomovelId");

                    b.Property<DateTime>("DataChegada");

                    b.Property<DateTime>("DataSaida");

                    b.Property<string>("DescriçaoViagem");

                    b.Property<string>("DestinoChegada");

                    b.Property<string>("DestinoSaida");

                    b.Property<int?>("MotoristaId");

                    b.Property<int>("OdodmetroChegada");

                    b.Property<int>("OdometroSaida");

                    b.HasKey("Id");

                    b.HasIndex("AutomovelId");

                    b.HasIndex("MotoristaId");

                    b.ToTable("Viagem");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasMaxLength(128);

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("GestaodeFrota.Models.Abastecimento", b =>
                {
                    b.HasOne("GestaodeFrota.Models.Automovel", "Automovel")
                        .WithMany("Abastecimento")
                        .HasForeignKey("AutomovelId");

                    b.HasOne("GestaodeFrota.Models.Posto", "Posto")
                        .WithMany("Abastecimento")
                        .HasForeignKey("PostoId");
                });

            modelBuilder.Entity("GestaodeFrota.Models.Apolice", b =>
                {
                    b.HasOne("GestaodeFrota.Models.Seguro", "Seguro")
                        .WithMany("Apolice")
                        .HasForeignKey("SeguroId");
                });

            modelBuilder.Entity("GestaodeFrota.Models.Automovel", b =>
                {
                    b.HasOne("GestaodeFrota.Models.Apolice", "Apolice")
                        .WithMany("Automovel")
                        .HasForeignKey("ApoliceId");
                });

            modelBuilder.Entity("GestaodeFrota.Models.Locacao", b =>
                {
                    b.HasOne("GestaodeFrota.Models.Automovel", "Automovel")
                        .WithMany()
                        .HasForeignKey("AutomovelId");
                });

            modelBuilder.Entity("GestaodeFrota.Models.Manutencao", b =>
                {
                    b.HasOne("GestaodeFrota.Models.Automovel", "Automovel")
                        .WithMany("Manutencao")
                        .HasForeignKey("AutomovelId");

                    b.HasOne("GestaodeFrota.Models.Oficina", "Oficina")
                        .WithMany("Manutencao")
                        .HasForeignKey("OficinaId");
                });

            modelBuilder.Entity("GestaodeFrota.Models.Motorista", b =>
                {
                    b.HasOne("GestaodeFrota.Models.Automovel")
                        .WithMany("Motorista")
                        .HasForeignKey("AutomovelId");
                });

            modelBuilder.Entity("GestaodeFrota.Models.Multa", b =>
                {
                    b.HasOne("GestaodeFrota.Models.Automovel", "Automovel")
                        .WithMany("Multa")
                        .HasForeignKey("AutomovelId");
                });

            modelBuilder.Entity("GestaodeFrota.Models.Viagem", b =>
                {
                    b.HasOne("GestaodeFrota.Models.Automovel", "Automovel")
                        .WithMany("Viagem")
                        .HasForeignKey("AutomovelId");

                    b.HasOne("GestaodeFrota.Models.Motorista", "Motorista")
                        .WithMany()
                        .HasForeignKey("MotoristaId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}

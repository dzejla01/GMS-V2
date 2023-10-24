﻿// <auto-generated />
using System;
using GMS.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GMS.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("GMS.Entities.Models.Administrator", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Administrator");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Password = "admin",
                            Username = "admin"
                        },
                        new
                        {
                            ID = 2,
                            Password = "host",
                            Username = "host"
                        });
                });

            modelBuilder.Entity("GMS.Entities.Models.Clanarina", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<float>("Cijena")
                        .HasColumnType("real");

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Clanarina");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Cijena = 50f,
                            Naziv = "Basic"
                        },
                        new
                        {
                            ID = 2,
                            Cijena = 40f,
                            Naziv = "Studentska"
                        },
                        new
                        {
                            ID = 3,
                            Cijena = 30f,
                            Naziv = "Parovi"
                        },
                        new
                        {
                            ID = 4,
                            Cijena = 25f,
                            Naziv = "Djeca"
                        },
                        new
                        {
                            ID = 5,
                            Cijena = 25f,
                            Naziv = "Penzioneri"
                        });
                });

            modelBuilder.Entity("GMS.Entities.Models.Dobavljac", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Dobavljac");
                });

            modelBuilder.Entity("GMS.Entities.Models.FAQ", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Odgovor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pitanje")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("FAQ");
                });

            modelBuilder.Entity("GMS.Entities.Models.Grad", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Grad");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Naziv = "Banja Luka"
                        },
                        new
                        {
                            ID = 2,
                            Naziv = "Bihać"
                        },
                        new
                        {
                            ID = 3,
                            Naziv = "Bijeljina"
                        },
                        new
                        {
                            ID = 4,
                            Naziv = "Bosnaska Krupa"
                        },
                        new
                        {
                            ID = 5,
                            Naziv = "Cazin"
                        },
                        new
                        {
                            ID = 6,
                            Naziv = "Čapljina"
                        },
                        new
                        {
                            ID = 7,
                            Naziv = "Drventa"
                        },
                        new
                        {
                            ID = 8,
                            Naziv = "Doboj"
                        },
                        new
                        {
                            ID = 9,
                            Naziv = "Goražde"
                        },
                        new
                        {
                            ID = 10,
                            Naziv = "Gračanica"
                        },
                        new
                        {
                            ID = 11,
                            Naziv = "Gradačac"
                        },
                        new
                        {
                            ID = 12,
                            Naziv = "Gradiška"
                        },
                        new
                        {
                            ID = 13,
                            Naziv = "Konjic"
                        },
                        new
                        {
                            ID = 14,
                            Naziv = "Laktaši"
                        },
                        new
                        {
                            ID = 15,
                            Naziv = "Livno"
                        },
                        new
                        {
                            ID = 16,
                            Naziv = "Lukavac"
                        },
                        new
                        {
                            ID = 17,
                            Naziv = "Ljubuški"
                        },
                        new
                        {
                            ID = 18,
                            Naziv = "Mostar"
                        },
                        new
                        {
                            ID = 19,
                            Naziv = "Orašje"
                        },
                        new
                        {
                            ID = 20,
                            Naziv = "Prijedor"
                        },
                        new
                        {
                            ID = 21,
                            Naziv = "Prnjavor"
                        },
                        new
                        {
                            ID = 22,
                            Naziv = "Sarajevo"
                        },
                        new
                        {
                            ID = 23,
                            Naziv = "Srebrenik"
                        },
                        new
                        {
                            ID = 24,
                            Naziv = "Stolac"
                        },
                        new
                        {
                            ID = 25,
                            Naziv = "Široki Brijeg"
                        },
                        new
                        {
                            ID = 26,
                            Naziv = "Travnik"
                        },
                        new
                        {
                            ID = 27,
                            Naziv = "Tuzla"
                        },
                        new
                        {
                            ID = 28,
                            Naziv = "Visoko"
                        },
                        new
                        {
                            ID = 29,
                            Naziv = "Zavidovići"
                        },
                        new
                        {
                            ID = 30,
                            Naziv = "Zenica"
                        },
                        new
                        {
                            ID = 31,
                            Naziv = "Zvornik"
                        },
                        new
                        {
                            ID = 32,
                            Naziv = "Živinice"
                        });
                });

            modelBuilder.Entity("GMS.Entities.Models.Korisnik", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("BrojTelefona")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GradID")
                        .HasColumnType("int");

                    b.Property<string>("Ime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prezime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SpolID")
                        .HasColumnType("int");

                    b.Property<int>("TeretanaID")
                        .HasColumnType("int");

                    b.Property<float>("Tezina")
                        .HasColumnType("real");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Visina")
                        .HasColumnType("real");

                    b.HasKey("ID");

                    b.HasIndex("GradID");

                    b.HasIndex("SpolID");

                    b.HasIndex("TeretanaID");

                    b.ToTable("Korisnik");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            BrojTelefona = "0644076290",
                            GradID = 18,
                            Ime = "Vedad",
                            Password = "bayern123",
                            Prezime = "Keskin",
                            SpolID = 1,
                            TeretanaID = 2,
                            Tezina = 80f,
                            Username = "vedadke",
                            Visina = 170f
                        },
                        new
                        {
                            ID = 2,
                            BrojTelefona = "062709689",
                            GradID = 26,
                            Ime = "Džejla",
                            Password = "fit2023",
                            Prezime = "Palalić",
                            SpolID = 2,
                            TeretanaID = 2,
                            Tezina = 57f,
                            Username = "dzejlap",
                            Visina = 164f
                        });
                });

            modelBuilder.Entity("GMS.Entities.Models.Korisnik_Clanarina", b =>
                {
                    b.Property<int>("ClanarinaID")
                        .HasColumnType("int");

                    b.Property<int>("KorisnikID")
                        .HasColumnType("int");

                    b.Property<DateTime>("DatumUplate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DatumIsteka")
                        .HasColumnType("datetime2");

                    b.HasKey("ClanarinaID", "KorisnikID", "DatumUplate");

                    b.HasIndex("KorisnikID");

                    b.ToTable("Korisnik_Clanarina");

                    b.HasData(
                        new
                        {
                            ClanarinaID = 2,
                            KorisnikID = 1,
                            DatumUplate = new DateTime(2023, 9, 1, 9, 15, 0, 0, DateTimeKind.Unspecified),
                            DatumIsteka = new DateTime(2023, 10, 1, 9, 15, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ClanarinaID = 2,
                            KorisnikID = 2,
                            DatumUplate = new DateTime(2023, 9, 1, 9, 15, 0, 0, DateTimeKind.Unspecified),
                            DatumIsteka = new DateTime(2023, 10, 1, 9, 15, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ClanarinaID = 2,
                            KorisnikID = 1,
                            DatumUplate = new DateTime(2023, 10, 1, 7, 15, 0, 0, DateTimeKind.Unspecified),
                            DatumIsteka = new DateTime(2023, 11, 1, 7, 15, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ClanarinaID = 2,
                            KorisnikID = 2,
                            DatumUplate = new DateTime(2023, 10, 1, 7, 15, 0, 0, DateTimeKind.Unspecified),
                            DatumIsteka = new DateTime(2023, 11, 1, 7, 15, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("GMS.Entities.Models.Korisnik_Nutricionist", b =>
                {
                    b.Property<int>("KorisnikID")
                        .HasColumnType("int");

                    b.Property<int>("NutricionistID")
                        .HasColumnType("int");

                    b.Property<DateTime>("DatumTermina")
                        .HasColumnType("datetime2");

                    b.HasKey("KorisnikID", "NutricionistID", "DatumTermina");

                    b.HasIndex("NutricionistID");

                    b.ToTable("Korisnik_Nutricionst");
                });

            modelBuilder.Entity("GMS.Entities.Models.Korisnik_Suplement", b =>
                {
                    b.Property<int>("SuplementID")
                        .HasColumnType("int");

                    b.Property<int>("KorisnikID")
                        .HasColumnType("int");

                    b.Property<DateTime>("DatumVrijemeNarudzbe")
                        .HasColumnType("datetime2");

                    b.Property<int>("Kolicina")
                        .HasColumnType("int");

                    b.HasKey("SuplementID", "KorisnikID", "DatumVrijemeNarudzbe");

                    b.HasIndex("KorisnikID");

                    b.ToTable("Korisnik_Suplement");
                });

            modelBuilder.Entity("GMS.Entities.Models.Korisnik_Trener", b =>
                {
                    b.Property<int>("KorisnikID")
                        .HasColumnType("int");

                    b.Property<int>("TrenerID")
                        .HasColumnType("int");

                    b.Property<DateTime>("DatumTermina")
                        .HasColumnType("datetime2");

                    b.Property<int>("OdrzanoSati")
                        .HasColumnType("int");

                    b.HasKey("KorisnikID", "TrenerID", "DatumTermina");

                    b.HasIndex("TrenerID");

                    b.ToTable("Korisnik_Trener");
                });

            modelBuilder.Entity("GMS.Entities.Models.Nutricionist", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("BrojTelefona")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prezime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Nutricionist");
                });

            modelBuilder.Entity("GMS.Entities.Models.Nutricionist_Seminar", b =>
                {
                    b.Property<int>("NutricionistID")
                        .HasColumnType("int");

                    b.Property<int>("SeminarID")
                        .HasColumnType("int");

                    b.HasKey("NutricionistID", "SeminarID");

                    b.HasIndex("SeminarID");

                    b.ToTable("Nutricionist_Seminar");
                });

            modelBuilder.Entity("GMS.Entities.Models.Recenzija", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Ime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prezime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tekst")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Zanimanje")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Recenzija");
                });

            modelBuilder.Entity("GMS.Entities.Models.Seminar", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<DateTime>("Datum")
                        .HasColumnType("datetime2");

                    b.Property<string>("Predavac")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tema")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Seminar");
                });

            modelBuilder.Entity("GMS.Entities.Models.Spol", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Spol");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Naziv = "Muški"
                        },
                        new
                        {
                            ID = 2,
                            Naziv = "Ženski"
                        });
                });

            modelBuilder.Entity("GMS.Entities.Models.Suplement", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<float>("Cijena")
                        .HasColumnType("real");

                    b.Property<int>("DobavljacID")
                        .HasColumnType("int");

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("DobavljacID");

                    b.ToTable("Suplement");
                });

            modelBuilder.Entity("GMS.Entities.Models.Teretana", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Adresa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GradID")
                        .HasColumnType("int");

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("GradID");

                    b.ToTable("Teretana");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Adresa = "Patriotske lige bb",
                            GradID = 22,
                            Naziv = "ProGym Fitness Centar"
                        },
                        new
                        {
                            ID = 2,
                            Adresa = "Novo naselje Zalik bb",
                            GradID = 18,
                            Naziv = "Bodyline Mostar"
                        },
                        new
                        {
                            ID = 3,
                            Adresa = "Turalibegova 25a",
                            GradID = 27,
                            Naziv = "Body Control"
                        },
                        new
                        {
                            ID = 4,
                            Adresa = "Veljka Mlađenovića bb",
                            GradID = 1,
                            Naziv = "Blue Line Fitness"
                        },
                        new
                        {
                            ID = 5,
                            Adresa = "Trg Alije Izetbegovića 86",
                            GradID = 30,
                            Naziv = "ZEFIT Gym"
                        },
                        new
                        {
                            ID = 6,
                            Adresa = "Sarajevska k-1",
                            GradID = 2,
                            Naziv = "Reflex Gym"
                        },
                        new
                        {
                            ID = 7,
                            Adresa = "Željeznička 2, Konjic",
                            GradID = 13,
                            Naziv = "No Limits Gym"
                        });
                });

            modelBuilder.Entity("GMS.Entities.Models.Trener", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("BrojTelefona")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prezime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Trener");
                });

            modelBuilder.Entity("GMS.Entities.Models.Trener_Seminar", b =>
                {
                    b.Property<int>("TrenerID")
                        .HasColumnType("int");

                    b.Property<int>("SeminarID")
                        .HasColumnType("int");

                    b.HasKey("TrenerID", "SeminarID");

                    b.HasIndex("SeminarID");

                    b.ToTable("Trener_Seminar");
                });

            modelBuilder.Entity("GMS.Entities.Models.Korisnik", b =>
                {
                    b.HasOne("GMS.Entities.Models.Grad", "Grad")
                        .WithMany()
                        .HasForeignKey("GradID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GMS.Entities.Models.Spol", "Spol")
                        .WithMany()
                        .HasForeignKey("SpolID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GMS.Entities.Models.Teretana", "Teretana")
                        .WithMany()
                        .HasForeignKey("TeretanaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Grad");

                    b.Navigation("Spol");

                    b.Navigation("Teretana");
                });

            modelBuilder.Entity("GMS.Entities.Models.Korisnik_Clanarina", b =>
                {
                    b.HasOne("GMS.Entities.Models.Clanarina", "Clanarina")
                        .WithMany()
                        .HasForeignKey("ClanarinaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GMS.Entities.Models.Korisnik", "Korisnik")
                        .WithMany()
                        .HasForeignKey("KorisnikID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Clanarina");

                    b.Navigation("Korisnik");
                });

            modelBuilder.Entity("GMS.Entities.Models.Korisnik_Nutricionist", b =>
                {
                    b.HasOne("GMS.Entities.Models.Korisnik", "Korisnik")
                        .WithMany()
                        .HasForeignKey("KorisnikID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GMS.Entities.Models.Nutricionist", "Nutricionist")
                        .WithMany()
                        .HasForeignKey("NutricionistID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Korisnik");

                    b.Navigation("Nutricionist");
                });

            modelBuilder.Entity("GMS.Entities.Models.Korisnik_Suplement", b =>
                {
                    b.HasOne("GMS.Entities.Models.Korisnik", "Korisnik")
                        .WithMany()
                        .HasForeignKey("KorisnikID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GMS.Entities.Models.Suplement", "Suplement")
                        .WithMany()
                        .HasForeignKey("SuplementID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Korisnik");

                    b.Navigation("Suplement");
                });

            modelBuilder.Entity("GMS.Entities.Models.Korisnik_Trener", b =>
                {
                    b.HasOne("GMS.Entities.Models.Korisnik", "Korisnik")
                        .WithMany()
                        .HasForeignKey("KorisnikID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GMS.Entities.Models.Trener", "Trener")
                        .WithMany()
                        .HasForeignKey("TrenerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Korisnik");

                    b.Navigation("Trener");
                });

            modelBuilder.Entity("GMS.Entities.Models.Nutricionist_Seminar", b =>
                {
                    b.HasOne("GMS.Entities.Models.Nutricionist", "Nutricionist")
                        .WithMany()
                        .HasForeignKey("NutricionistID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GMS.Entities.Models.Seminar", "Seminar")
                        .WithMany()
                        .HasForeignKey("SeminarID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Nutricionist");

                    b.Navigation("Seminar");
                });

            modelBuilder.Entity("GMS.Entities.Models.Suplement", b =>
                {
                    b.HasOne("GMS.Entities.Models.Dobavljac", "Dobavljac")
                        .WithMany()
                        .HasForeignKey("DobavljacID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Dobavljac");
                });

            modelBuilder.Entity("GMS.Entities.Models.Teretana", b =>
                {
                    b.HasOne("GMS.Entities.Models.Grad", "Grad")
                        .WithMany()
                        .HasForeignKey("GradID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Grad");
                });

            modelBuilder.Entity("GMS.Entities.Models.Trener_Seminar", b =>
                {
                    b.HasOne("GMS.Entities.Models.Seminar", "Seminar")
                        .WithMany()
                        .HasForeignKey("SeminarID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GMS.Entities.Models.Trener", "Trener")
                        .WithMany()
                        .HasForeignKey("TrenerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Seminar");

                    b.Navigation("Trener");
                });
#pragma warning restore 612, 618
        }
    }
}

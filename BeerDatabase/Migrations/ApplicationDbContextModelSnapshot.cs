﻿// <auto-generated />
using System;
using BeerDatabase.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BeerDatabase.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BeerDatabase.Model.Beer", b =>
                {
                    b.Property<int>("BeerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BeerId"), 1L, 1);

                    b.Property<double?>("AlcoholContent")
                        .HasColumnType("float");

                    b.Property<int>("BreweryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImgSrc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImgTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("KindId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("PricePerHalfLitre")
                        .HasColumnType("float");

                    b.HasKey("BeerId");

                    b.HasIndex("BreweryId");

                    b.HasIndex("KindId");

                    b.ToTable("Beers");

                    b.HasData(
                        new
                        {
                            BeerId = 1,
                            AlcoholContent = 4.4000000000000004,
                            BreweryId = 1,
                            Description = "Tajemství chuti legendárního spodně kvašeného ležáku s obsahem alkoholu 4,4 % leží především ve vysoce kvalitních surovinách a zachováním původního výrobního postupu. Charakteristickou vůni sladových zrn a vyváženou karamelovou chuť získává pivo trojitým rmutováním, měkká plzeňská voda mu propůjčuje unikátní jemnou chuť, žatecký chmel sametovou hořkost. Vlastní slad pak dodává pivu zlatavou barvu.",
                            ImgSrc = "https://www.prazdroj.cz/cospospohzeg/uploads/2016/03/Asset__2-1080x1080.png",
                            ImgTitle = "Pilsner Urquell",
                            KindId = 1,
                            Name = "Pilsner Urquell",
                            PricePerHalfLitre = 28.899999999999999
                        },
                        new
                        {
                            BeerId = 2,
                            AlcoholContent = 4.0999999999999996,
                            BreweryId = 2,
                            Description = "I mimo hospodu naše desítka spolehlivě osvěží. V každé várce vyvažujeme ten správný poměr vlastního českého sladu a chmelové odrůdy Sládek, aby chutnala stejně od prvního do posledního doušku a vybízela k dalšímu napití.",
                            ImgSrc = "https://www.prazdroj.cz/cospospohzeg/uploads/2021/08/Asset__8-1080x1080.png",
                            ImgTitle = "Originál 10°",
                            KindId = 1,
                            Name = "Originál 10°",
                            PricePerHalfLitre = 17.899999999999999
                        },
                        new
                        {
                            BeerId = 3,
                            AlcoholContent = 4.7999999999999998,
                            BreweryId = 3,
                            Description = "Kozel Mistrův ležák je světlý ležák s plnějším tělem a vyšším podílem karamelových sladů. Obsahuje 4,8% obj.",
                            ImgSrc = "https://www.prazdroj.cz/cospospohzeg/uploads/2021/08/Asset__18-1080x1080.png",
                            ImgTitle = "Mistrův ležák",
                            KindId = 1,
                            Name = "Mistrův ležák",
                            PricePerHalfLitre = 18.899999999999999
                        },
                        new
                        {
                            BeerId = 4,
                            AlcoholContent = 5.0999999999999996,
                            BreweryId = 4,
                            Description = "Radegast Ryze Hořká 12 je třikrát chmelený prémiový světlý ležák, s 5,1% obsahem alkoholu, který vyniká plnou hořkou chutí (36 IBU) a výrazným chmelovým aroma. Vaří se ze tří vybraných druhů moravského chmele. Kromě odrůd Žatecký poloraný červeňák a Sládek obsahuje i českou odrůdu Žatecký pozdní, která je díky své vysoké kvalitě považována za budoucnost českého pivovarnictví.",
                            ImgSrc = "https://www.prazdroj.cz/cospospohzeg/uploads/2016/03/ryze-horka-12-1080x1080.png",
                            ImgTitle = "Ryze hořká 12",
                            KindId = 1,
                            Name = "Ryze hořká 12",
                            PricePerHalfLitre = 20.899999999999999
                        },
                        new
                        {
                            BeerId = 5,
                            AlcoholContent = 0.5,
                            BreweryId = 5,
                            Description = "Světlý Birell okouzluje plností chuti i příjemnou hořkostí dosahující podmanivé chuti alkoholických piv. Od svého zrodu posbíral Birell celou řadu pivních cen, mezi nimi i ocenění Nejlepší nealkoholické pivo roku na World Beer Awards 2012. V Česku byl v roce 2015 oceněn 1. místem v soutěži Zlatý pohár PIVEX 2015 v kategorii nealkoholické pivo. Neobsahuje konzervanty, umělá barviva ani umělá sladidla.",
                            ImgSrc = "https://www.prazdroj.cz/cospospohzeg/uploads/2021/08/Asset__30-1080x1080.png",
                            ImgTitle = "Světlý",
                            KindId = 1,
                            Name = "Světlý",
                            PricePerHalfLitre = 15.9
                        },
                        new
                        {
                            BeerId = 6,
                            AlcoholContent = 4.7000000000000002,
                            BreweryId = 6,
                            Description = "Excelentní jedenáctistupňový ležák byl poprvé uvařen v Plzni v roce 2008. Obsahuje 4,7 % alkoholu a díky unikátnímu trojitému chmelení, při němž plzeňští sládci používají odrůdu toho nejkvalitnějšího žateckého chmele – Žatecký poloraný červeňák, vyniká plnou chmelovou chutí. Každý doušek tak ve vás oživí chuť se napít znovu.",
                            ImgSrc = "https://www.prazdroj.cz/cospospohzeg/uploads/2021/08/Asset__66-1080x1080.png",
                            ImgTitle = "Excelent",
                            KindId = 1,
                            Name = "Excelent",
                            PricePerHalfLitre = 16.899999999999999
                        });
                });

            modelBuilder.Entity("BeerDatabase.Model.BeerPub", b =>
                {
                    b.Property<int>("BeerId")
                        .HasColumnType("int");

                    b.Property<int>("PubId")
                        .HasColumnType("int");

                    b.HasKey("BeerId", "PubId");

                    b.HasIndex("PubId");

                    b.ToTable("BeerPubs", (string)null);

                    b.HasData(
                        new
                        {
                            BeerId = 1,
                            PubId = 1
                        },
                        new
                        {
                            BeerId = 2,
                            PubId = 2
                        },
                        new
                        {
                            BeerId = 3,
                            PubId = 2
                        },
                        new
                        {
                            BeerId = 4,
                            PubId = 2
                        },
                        new
                        {
                            BeerId = 6,
                            PubId = 2
                        },
                        new
                        {
                            BeerId = 1,
                            PubId = 3
                        },
                        new
                        {
                            BeerId = 3,
                            PubId = 3
                        },
                        new
                        {
                            BeerId = 5,
                            PubId = 3
                        },
                        new
                        {
                            BeerId = 1,
                            PubId = 4
                        },
                        new
                        {
                            BeerId = 1,
                            PubId = 5
                        },
                        new
                        {
                            BeerId = 5,
                            PubId = 5
                        },
                        new
                        {
                            BeerId = 1,
                            PubId = 6
                        },
                        new
                        {
                            BeerId = 5,
                            PubId = 6
                        },
                        new
                        {
                            BeerId = 1,
                            PubId = 7
                        },
                        new
                        {
                            BeerId = 5,
                            PubId = 7
                        },
                        new
                        {
                            BeerId = 1,
                            PubId = 8
                        });
                });

            modelBuilder.Entity("BeerDatabase.Model.Brewery", b =>
                {
                    b.Property<int>("BreweryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BreweryId"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImgSrc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImgTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BreweryId");

                    b.ToTable("Breweries");

                    b.HasData(
                        new
                        {
                            BreweryId = 1,
                            Email = "info@prazdroj.cz",
                            ImgSrc = "https://www.prazdroj.cz/cospospohzeg/uploads/2016/03/Logo-Assets-1.png",
                            ImgTitle = "Pilsner Urquell logo",
                            Location = "U Prazdroje 64/7, 301 00 Plzeň",
                            Name = "Pilsner Urquell",
                            PhoneNumber = "+420 377 062 111"
                        },
                        new
                        {
                            BreweryId = 2,
                            Email = "info@prazdroj.cz",
                            ImgSrc = "https://www.prazdroj.cz/cospospohzeg/uploads/2021/08/Logo-Assets_3.png",
                            ImgTitle = "Gambrinus logo",
                            Location = "U Prazdroje 64/7, 301 00 Plzeň",
                            Name = "Gambrinus",
                            PhoneNumber = "+420 377 062 111"
                        },
                        new
                        {
                            BreweryId = 3,
                            Email = "info@prazdroj.cz",
                            ImgSrc = "https://www.prazdroj.cz/cospospohzeg/uploads/2021/08/Logo-Assets_4.png",
                            ImgTitle = "Velkopopovický Kozel logo",
                            Location = "Ringhofferova 1, 251 69 Velké Popovice",
                            Name = "Velkopopovický Kozel",
                            PhoneNumber = "+420 377 066 088"
                        },
                        new
                        {
                            BreweryId = 4,
                            Email = "info@prazdroj.cz",
                            ImgSrc = "https://www.prazdroj.cz/cospospohzeg/uploads/2021/08/Logo-Assets_5.png",
                            ImgTitle = "Radegast logo",
                            Location = "Nošovice 238, 739 51 Nošovice",
                            Name = "Radegast",
                            PhoneNumber = "+420 558 602 566"
                        },
                        new
                        {
                            BreweryId = 5,
                            Email = "info@prazdroj.cz",
                            ImgSrc = "https://www.prazdroj.cz/cospospohzeg/uploads/2021/08/Logo-Assets_6.png",
                            ImgTitle = "Birell logo",
                            Location = "Nošovice 238, 739 51 Nošovice",
                            Name = "Birell",
                            PhoneNumber = "+420 558 602 566"
                        },
                        new
                        {
                            BreweryId = 6,
                            Email = "info@prazdroj.cz",
                            ImgSrc = "https://www.prazdroj.cz/cospospohzeg/uploads/2021/08/Logo-Assets_10.png",
                            ImgTitle = "Excelent logo",
                            Location = "U Prazdroje 64/7, 301 00 Plzeň",
                            Name = "Excelent",
                            PhoneNumber = "+420 377 062 111"
                        });
                });

            modelBuilder.Entity("BeerDatabase.Model.Kind", b =>
                {
                    b.Property<int>("KindId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KindId"), 1L, 1);

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("KindId");

                    b.ToTable("Kinds");

                    b.HasData(
                        new
                        {
                            KindId = 1,
                            Type = "světlé"
                        },
                        new
                        {
                            KindId = 2,
                            Type = "polotmavé"
                        },
                        new
                        {
                            KindId = 3,
                            Type = "tmavé"
                        },
                        new
                        {
                            KindId = 4,
                            Type = "řezané"
                        },
                        new
                        {
                            KindId = 5,
                            Type = "jiný"
                        });
                });

            modelBuilder.Entity("BeerDatabase.Model.Pub", b =>
                {
                    b.Property<int>("PubId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PubId"), 1L, 1);

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Rating")
                        .HasColumnType("float");

                    b.HasKey("PubId");

                    b.ToTable("Pubs");

                    b.HasData(
                        new
                        {
                            PubId = 1,
                            Location = "U Prazdroje 64/7, 301 00 Plzeň",
                            Name = "Na Spilce",
                            PhoneNumber = "+420 724 617 355",
                            Rating = 3.6000000000000001
                        },
                        new
                        {
                            PubId = 2,
                            Location = "Moskevská 13, 460 01 Liberec",
                            Name = "Restaurace Plzeňka - Duli",
                            PhoneNumber = "+420 485 100 738",
                            Rating = 3.5
                        },
                        new
                        {
                            PubId = 3,
                            Location = "Vinohradská 35/25, 120 00 Praha",
                            Name = "Restaurant Hajnovka",
                            PhoneNumber = "+420 224 218 386",
                            Rating = 4.2000000000000002
                        },
                        new
                        {
                            PubId = 4,
                            Location = "Československé armády 3654/7, 466 05 Jablonec nad Nisou",
                            Name = "Motorest H & H Hušek",
                            PhoneNumber = "+420 483 305 408",
                            Rating = 4.7999999999999998
                        },
                        new
                        {
                            PubId = 5,
                            Location = "Liberec XIX-Horní Hanychov 153, 46008 Liberec XIX-Horní Hanychov",
                            Name = "Hotel Ještěd",
                            PhoneNumber = "+420 485 104 291",
                            Rating = 4.7999999999999998
                        },
                        new
                        {
                            PubId = 6,
                            Location = "Janov nad Nisou 524, 46811 Janov nad Nisou",
                            Name = "Restaurace Prezidentská chata",
                            PhoneNumber = "+420 604 551 469",
                            Rating = 4.2999999999999998
                        },
                        new
                        {
                            PubId = 7,
                            Location = "Nádražní 60/114, 15000 Praha 5 - Smíchov",
                            Name = "Plzeňský restaurant Anděl",
                            PhoneNumber = "+420 608 181 852",
                            Rating = 3.8999999999999999
                        },
                        new
                        {
                            PubId = 8,
                            Location = "náměstí Republiky 97/9, 30100 Plzeň 3 - Vnitřní Město",
                            Name = "Šenk a restaurace Lékárna",
                            PhoneNumber = "+420 735 123 648",
                            Rating = 4.5999999999999996
                        });
                });

            modelBuilder.Entity("BeerDatabase.Model.Beer", b =>
                {
                    b.HasOne("BeerDatabase.Model.Brewery", "Brewery")
                        .WithMany("Beers")
                        .HasForeignKey("BreweryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BeerDatabase.Model.Kind", "Kind")
                        .WithMany("Beers")
                        .HasForeignKey("KindId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brewery");

                    b.Navigation("Kind");
                });

            modelBuilder.Entity("BeerDatabase.Model.BeerPub", b =>
                {
                    b.HasOne("BeerDatabase.Model.Beer", "Beer")
                        .WithMany()
                        .HasForeignKey("BeerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BeerDatabase.Model.Pub", "Pub")
                        .WithMany()
                        .HasForeignKey("PubId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Beer");

                    b.Navigation("Pub");
                });

            modelBuilder.Entity("BeerDatabase.Model.Brewery", b =>
                {
                    b.Navigation("Beers");
                });

            modelBuilder.Entity("BeerDatabase.Model.Kind", b =>
                {
                    b.Navigation("Beers");
                });
#pragma warning restore 612, 618
        }
    }
}

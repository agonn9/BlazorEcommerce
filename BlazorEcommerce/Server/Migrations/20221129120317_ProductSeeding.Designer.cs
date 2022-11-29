﻿// <auto-generated />
using BlazorEcommerce.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace BlazorEcommerce.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20221129120317_ProductSeeding")]
    partial class ProductSeeding
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("BlazorEcommerce.Shared.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,1)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Cattle (Bos taurus) are large, domesticated, cloven-hooved, herbivores. They are a prominent modern member of the subfamily Bovinae and the most widespread species of the genus Bos. Adult females are referred to as cows and adult males are referred to as bulls.",
                            ImageUrl = "https://en.wikipedia.org/wiki/Cattle#/media/File:Cow_(Fleckvieh_breed)_Oeschinensee_Slaunger_2009-07-07.jpg",
                            Price = 9.99m,
                            Title = "Cow"
                        },
                        new
                        {
                            Id = 2,
                            Description = "The chicken (Gallus gallus domesticus) is a domesticated junglefowl species, with attributes of wild species such as the grey and the Ceylon junglefowl[1] that are originally from Southeastern Asia. Rooster or cock is a term for an adult male bird, and a younger male may be called a cockerel. A male that has been castrated is a capon. An adult female bird is called a hen and a sexually immature female is called a pullet.",
                            ImageUrl = "https://en.wikipedia.org/wiki/Chicken#/media/File:Male_and_female_chicken_sitting_together.jpg",
                            Price = 7.99m,
                            Title = "Chicken"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Apes (collectively Hominoidea /hɒmɪˈnɔɪdi.ə/) are a clade of Old World simians native to sub-Saharan Africa and Southeast Asia (though they were more widespread in Africa, most of Asia, and as well as Europe in prehistory), which together with its sister group Cercopithecidae form the catarrhine clade, cladistically making them monkeys (though this is the subject of much debate). Apes do not have tails due to a mutation of the TBXT gene.[2] In traditional and non-scientific use, the term \"ape\" can include tailless primates taxonomically considered Cercopithecidae (such as the Barbary ape and black ape)",
                            ImageUrl = "https://en.wikipedia.org/wiki/Ape#/media/File:Man_of_the_woods.JPG",
                            Price = 8.99m,
                            Title = "Ape"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
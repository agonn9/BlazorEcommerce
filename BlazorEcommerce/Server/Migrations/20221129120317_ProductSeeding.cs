using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorEcommerce.Server.Migrations
{
    /// <inheritdoc />
    public partial class ProductSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "Cattle (Bos taurus) are large, domesticated, cloven-hooved, herbivores. They are a prominent modern member of the subfamily Bovinae and the most widespread species of the genus Bos. Adult females are referred to as cows and adult males are referred to as bulls.", "https://en.wikipedia.org/wiki/Cattle#/media/File:Cow_(Fleckvieh_breed)_Oeschinensee_Slaunger_2009-07-07.jpg", 9.99m, "Cow" },
                    { 2, "The chicken (Gallus gallus domesticus) is a domesticated junglefowl species, with attributes of wild species such as the grey and the Ceylon junglefowl[1] that are originally from Southeastern Asia. Rooster or cock is a term for an adult male bird, and a younger male may be called a cockerel. A male that has been castrated is a capon. An adult female bird is called a hen and a sexually immature female is called a pullet.", "https://en.wikipedia.org/wiki/Chicken#/media/File:Male_and_female_chicken_sitting_together.jpg", 7.99m, "Chicken" },
                    { 3, "Apes (collectively Hominoidea /hɒmɪˈnɔɪdi.ə/) are a clade of Old World simians native to sub-Saharan Africa and Southeast Asia (though they were more widespread in Africa, most of Asia, and as well as Europe in prehistory), which together with its sister group Cercopithecidae form the catarrhine clade, cladistically making them monkeys (though this is the subject of much debate). Apes do not have tails due to a mutation of the TBXT gene.[2] In traditional and non-scientific use, the term \"ape\" can include tailless primates taxonomically considered Cercopithecidae (such as the Barbary ape and black ape)", "https://en.wikipedia.org/wiki/Ape#/media/File:Man_of_the_woods.JPG", 8.99m, "Ape" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}

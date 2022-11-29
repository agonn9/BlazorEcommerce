using System;
namespace BlazorEcommerce.Server.Data
{
	public class DataContext : DbContext
	{
		public DataContext(DbContextOptions<DataContext> options) : base(options)
		{

		}


		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "Cow",
                    Description = "Cattle (Bos taurus) are large, domesticated, cloven-hooved, herbivores. They are a prominent modern member of the subfamily Bovinae and the most widespread species of the genus Bos. Adult females are referred to as cows and adult males are referred to as bulls.",
                    ImageUrl = "https://en.wikipedia.org/wiki/Cattle#/media/File:Cow_(Fleckvieh_breed)_Oeschinensee_Slaunger_2009-07-07.jpg",
                    Price = 9.99m
                },
                new Product
                {
                    Id = 2,
                    Title = "Chicken",
                    Description = "The chicken (Gallus gallus domesticus) is a domesticated junglefowl species, with attributes of wild species such as the grey and the Ceylon junglefowl[1] that are originally from Southeastern Asia. Rooster or cock is a term for an adult male bird, and a younger male may be called a cockerel. A male that has been castrated is a capon. An adult female bird is called a hen and a sexually immature female is called a pullet.",
                    ImageUrl = "https://en.wikipedia.org/wiki/Chicken#/media/File:Male_and_female_chicken_sitting_together.jpg",
                    Price = 7.99m
                },
                new Product
                {
                    Id = 3,
                    Title = "Ape",
                    Description = "Apes (collectively Hominoidea /hɒmɪˈnɔɪdi.ə/) are a clade of Old World simians native to sub-Saharan Africa and Southeast Asia (though they were more widespread in Africa, most of Asia, and as well as Europe in prehistory), which together with its sister group Cercopithecidae form the catarrhine clade, cladistically making them monkeys (though this is the subject of much debate). Apes do not have tails due to a mutation of the TBXT gene.[2] In traditional and non-scientific use, the term \"ape\" can include tailless primates taxonomically considered Cercopithecidae (such as the Barbary ape and black ape)",
                    ImageUrl = "https://en.wikipedia.org/wiki/Ape#/media/File:Man_of_the_woods.JPG",
                    Price = 8.99m
                }
                );
		}

		public DbSet<Product> Products { get; set; }
	}
}

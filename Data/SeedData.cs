using Microsoft.EntityFrameworkCore;
using FinalProject.Models;

namespace FinalProject.Data
{
	public class SeedData
	{
		public static void InitializeEvent(IServiceProvider serviceProvider)
		{
			using var context = new FinalProjectContext(
				serviceProvider.GetRequiredService<
					DbContextOptions<FinalProjectContext>>());

			if (context == null || context.EventItem == null)
			{
				throw new NullReferenceException(
					"Null FinalProjectContext or EventItem DbSet");
			}

			if (context.EventItem.Any())
			{
				return; // DB has been seeded
			}

			context.EventItem.AddRange(
				new EventItem
				{
					Title = "Mall Sale!",
					Description = "Our adoption centers will be bringing their dogs to the mall! This will be our best showing for a new owner.",
					Date = "01/05/2025",
					TimeStart = "1:00pm",
					TimeEnd = "4:00pm"
				},
				new EventItem
				{
					Title = "Happy Tails Dog Adoption Event",
					Description = "Join us at Happy Tails Rescue for a dog adoption event featuring lovable dogs of all sizes looking for their forever homes. Meet our furry friends, ask questions to adoption specialists, and find your perfect companion. All dogs are vaccinated, microchipped, and ready to go home with you!",
					Date = "03/10/2025",
					TimeStart = "9:00am",
					TimeEnd = "2:00pm"
				},
				new EventItem
				{
					Title = "Paws for Service: Volunteer Day",
					Description = "Give back to the community by volunteering. We're looking for passionate individuals to help with tasks such as walking dogs, cleaning kennels, assisting with event setup, and spreading the word about adoption. Whether you're experienced with animals or just want to help out, we welcome volunteers of all backgrounds. Join us for a rewarding day of service and make a difference in the lives of rescue dogs!",
					Date = "06/17/2025",
					TimeStart = "8:00am",
					TimeEnd = "5:00pm"
				}
			);

			context.SaveChanges();
		}

		public static void InitializeListing(IServiceProvider serviceProvider)
		{
			using var context = new FinalProjectContext(
				serviceProvider.GetRequiredService<
					DbContextOptions<FinalProjectContext>>());

			if (context == null || context.Listing == null)
			{
				throw new NullReferenceException(
					"Null FinalProjectContext or Listing DbSet");
			}

			if (context.Listing.Any())
			{
				return; // DB has been seeded
			}

			context.Listing.AddRange(
				new Listing
				{
					Id = 1,
					Name = "Confuscious",
					Breed = "Dachshund",
					Age = 3,
					Size = "Small",
					Location = "FurEver Friends Animal Shelter",
					Description = "Confuscious is a charming, intelligent, and spunky Dachshund looking for his forever home. With his short legs, long body, and playful personality, Confuscious is a classic example of why Dachshunds are one of the most beloved dog breeds in the world. Rescued from a tough situation, he has shown nothing but unconditional love and kindness toward everyone he meets...",
					ImageUrl = "https://www.boredpanda.com/blog/wp-content/uploads/2023/04/644a230e3f5d4_l7ink8py2vta1__700.jpg",
					Temperance = "Shy",
					Health = "Healthy, Shots up to date"
				},
				new Listing
				{
					Id = 2,
					Name = "Chiquito",
					Breed = "Terrier Mix",
					Age = 3,
					Size = "Small",
					Location = "Culiacán, Sinaloa",
					Description = "A sweet and resilient terrier mix who has overcome a challenging past. Chiquito is ready for a stable and loving forever home.",
					ImageUrl = "https://images.saymedia-content.com/.image/ar_4:3%2Cc_fill%2Ccs_srgb%2Cfl_progressive%2Cq_auto:eco%2Cw_1200/MjA2NjY5MjQ4Mzg1MjYyNzk2/why-would-a-house-trained-dog-start-pooping-in-the-house.jpg",
					Temperance = "Forlorn",
					Health = "Somewhat Healthy, shot record unknown"
				},
				new Listing
				{
					Id = 3,
					Name = "Pubert",
					Breed = "Mixed Breed",
					Age = 2,
					Size = "Medium",
					Location = "The Barking Lot Animal Rescue",
					Description = "Pubert is a playful and curious dog with a knack for making everyone smile. Pubert is ready for his forever family.",
					ImageUrl = "https://images.squarespace-cdn.com/content/v1/597cbe61f14aa1fbe78b4821/1567103219792-B73ICD6B7HE0G7QZXDN9/dog+trainer+norman+oklahoma.jpg",
					Temperance = "Extremely Aggressive",
					Health = "Health and shot record unknown"
				},
				new Listing
				{
					Id = 4,
					Name = "Luna",
					Breed = "Great Dane",
					Age = 4,
					Size = "Large",
					Location = "Whiskers & Tails Animal Shelter",
					Description = "A gentle giant with a heart of gold. Luna is perfect for a family looking for a calm and affectionate companion.",
					ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTBT4XTcjm-fRc1Ok8jD9wPL__wV8JN2Cag9Q&s",
					Temperance = "Calm",
					Health = "Healthy, shots up to date"
				},
				new Listing
				{
					Id = 5,
					Name = "Max",
					Breed = "Border Collie Mix",
					Age = 2,
					Size = "Medium",
					Location = "Whiskers & Tails Animal Shelter",
					Description = "An adventurous and intelligent dog who loves the outdoors. Max is ideal for an active family or individual.",
					ImageUrl = "https://i.pinimg.com/474x/a2/c7/92/a2c7926fa6145019e9fe45c21aee888f.jpg",
					Temperance = "Energetic",
					Health = "Healthy, shots up to date"
				},
				new Listing
				{
					Id = 6,
					Name = "Bella",
					Breed = "Labrador Retriever",
					Age = 2,
					Size = "Medium",
					Location = "FurEver Friends Animal Shelter",
					Description = "A social butterfly who loves making friends with everyone she meets. Bella is playful, loyal, and ready for her forever home.",
					ImageUrl = "https://cdn.britannica.com/82/232782-050-8062ACFA/Black-labrador-retriever-dog.jpg",
					Temperance = "Friendly",
					Health = "Healthy, shots up to date"
				},
				new Listing
				{
					Id = 7,
					Name = "Rocky",
					Breed = "German Shepherd",
					Age = 5,
					Size = "Large",
					Location = "The Barking Lot Animal Rescue",
					Description = "A courageous survivor with a loyal heart. Rocky is ready to bond with a family who appreciates his protective and loving nature.",
					ImageUrl = "https://image.petmd.com/files/inline-images/german-shepherd-3.jpg?VersionId=QrldSoaj4srcfCInIahiKcoLSh5D0gh8",
					Temperance = "Loyal",
					Health = "Healthy, shots up to date"
				},
				new Listing
				{
					Id = 8,
					Name = "Daisy \"The Golden Wiener\"",
					Breed = "Golden Retriever Dachshund Mix",
					Age = 1,
					Size = "Medium",
					Location = "FurEver Friends Animal Shelter",
					Description = "A playful and affectionate pup with a sunny disposition. Daisy is perfect for anyone looking for a joyful companion.",
					ImageUrl = "https://hips.hearstapps.com/hmg-prod/images/golden-retriever-mixes-golden-dox-667b3c3226576.jpg?crop=0.537xw:1.00xh;0.119xw,0&resize=980:*",
					Temperance = "Affectionate",
					Health = "Healthy, shots up to date"
				}
			);

			context.SaveChanges();
		}
	}
}

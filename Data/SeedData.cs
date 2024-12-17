using Microsoft.EntityFrameworkCore;
using FinalProject.Models;

namespace FinalProject.Data
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
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
                return;
            }

            context.EventItem.AddRange(
                new EventItem
                {
                    Title = "Mall Sale!",
                    Description = "Our adoption centers will be bringing their dogs to the mall! This will be our best showing for a new owner",
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
                    Date = "6/17/2025",
                    TimeStart = "8:00am",
                    TimeEnd = "5:00pm"
                }
                );

            context.SaveChanges();
        }
    }
}

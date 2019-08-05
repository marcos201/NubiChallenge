using NubiChallengeApi.Data;
using NubiChallengeApi.Models;
using System;

namespace NubiChallengeApi.IntegrationTests.Controllers
{
    public static class SeedData
    {
        public static void PopulateTestData(NubiChallengeContext dbContext)
        {
            dbContext.User.Add(new User(new Guid("A0000000-0000-0000-0000-000000000001"), "Luke", "Skywalker", "luke@mail.com", "luke123"));
            dbContext.User.Add(new User(new Guid("A0000000-0000-0000-0000-000000000002"), "Anakin", "Skywalker", "Anakin@mail.com", "Anakin123"));
            dbContext.SaveChanges();
        }
    }
}
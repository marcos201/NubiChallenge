using NubiChallengeApi.Core.Interfaces.Repositories;
using NubiChallengeApi.Models;

namespace NubiChallengeApi.Data.Repositories
{
    internal sealed class UserRepository : EfRepository<User>, IUserRepository
    {
        public UserRepository(NubiChallengeContext nubiChallengeContext) : base(nubiChallengeContext)
        {
        }
    }
}

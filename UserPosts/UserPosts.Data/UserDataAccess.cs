using UserPosts.Domain;
using UserPosts.Services;

namespace UserPosts.Data
{
    public class UserDataAccess : BaseDataAccess<User>, IUserRepository
    {
        protected override string GetFile()
        {
            return @"C:\Users\Mihai\source\repos\Wantsome-Week-11\UserPosts\UserPosts.Data\Files\users.json";
        }
    }
}

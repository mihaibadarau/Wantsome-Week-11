using UserPosts.Data;
using UserPosts.Domain;
using UserPosts.Services;

namespace UserPosts.App
{
    public class Program
    {
        static void Main(string[] args)
        {
            IPostRepository postRepository = new PostDataAccess();
            IUserRepository userRepository = new UserDataAccess();
            ICommentRepository commentRepository = new CommentDataAccess();

            var userService = new UserService(userRepository, postRepository);

            var userServiceResponse = userService.GetUserActiveRespose(2);

            var userCommentsService = new UserCommentsService(userRepository, commentRepository);
            var userCommentsServiceResponse = userCommentsService.GetUserComments(5);

        }
    }
}
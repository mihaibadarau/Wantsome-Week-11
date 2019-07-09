using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserPosts.Domain;

namespace UserPosts.Services
{
    public class UserCommentsService
    {
        private readonly IUserRepository userRepository;
        private readonly ICommentRepository commentRepository;

        public UserCommentsService(IUserRepository userRepository, ICommentRepository commentRepository)
        {
            this.userRepository = userRepository;
            this.commentRepository = commentRepository;
        }

        public UserComments GetUserComments(int userId)
        {
            var user = userRepository.GetById(userId);
            var comments = commentRepository.GetAll();

            return new UserComments
            {
                User = user,
                Comments = comments.Where(c => c.UserId == user.Id).ToList()
            };
        }
    }

    public class UserComments
    {
        public User User { get; set; }
        public IList<Comment> Comments { get; set; }
    }
}

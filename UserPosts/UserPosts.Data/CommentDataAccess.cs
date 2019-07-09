﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserPosts.Domain;
using UserPosts.Services;

namespace UserPosts.Data
{
    public class CommentDataAccess : BaseDataAccess<Comment>, ICommentRepository
    {
        protected override string GetFile()
        {
            return @"C:\Users\Mihai\source\repos\Wantsome-Week-11\UserPosts\UserPosts.Data\Files\comments.json";
        }
    }
}

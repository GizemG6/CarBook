﻿using CarBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Interfaces.BlogInterfaces
{
    public interface IBlogRepository
    {
        public List<Blog> GetLast3BlogsWithAuthors();
        public List<Blog> GetAllBlogWithAuthors();
        public List<Blog> GetBlogByAuthorId(int id);
    }
}

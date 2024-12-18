﻿using CarBook.Application.Interfaces.BlogInterfaces;
using CarBook.Domain.Entities;
using CarBook.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Persistence.Repositories.BlogRepositories
{
    public class BlogRepository : IBlogRepository
    {
        private readonly CarBookContext _carBookContext;

        public BlogRepository(CarBookContext carBookContext)
        {
            _carBookContext = carBookContext;
        }

        public List<Blog> GetAllBlogWithAuthors()
        {
            var values = _carBookContext.Blogs.Include(b => b.Author).ToList();
            return values;
        }

        public List<Blog> GetBlogByAuthorId(int id)
        {
            var value = _carBookContext.Blogs.Include(x => x.Author).Where(x => x.BlogId == id).ToList();
            return value;
        }

        public List<Blog> GetLast3BlogsWithAuthors()
        {
            var values = _carBookContext.Blogs.Include(x => x.Author).OrderByDescending(x => x.BlogId).Take(3).ToList();
            return values;
        }
    }
}

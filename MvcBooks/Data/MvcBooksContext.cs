using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcBooks.Models;

namespace MvcBooks.Data
{
    public class MvcBooksContext : DbContext
    {
        public MvcBooksContext (DbContextOptions<MvcBooksContext> options)
            : base(options)
        {
        }

        public DbSet<MvcBooks.Models.Book> Book { get; set; }
    }
}

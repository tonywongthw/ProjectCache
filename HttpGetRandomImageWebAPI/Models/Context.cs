using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace HttpGetRandomImageWebAPI.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options)
            : base(options)
        {
        }

        public DbSet<Item> TodoItems { get; set; } = null!;
    }
}

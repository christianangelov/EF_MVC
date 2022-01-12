using EFMFC_Basic.Models;
using Microsoft.EntityFrameworkCore;

namespace EFMFC_Basic.Context
{
    public class MVCContext : DbContext
    {
        public MVCContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Subject> Subjects { get; set; }
    }
}

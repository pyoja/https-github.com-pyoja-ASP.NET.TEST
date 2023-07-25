using System.Data.Entity;

namespace WebApplication6.Models
{
    public class DocumentsDbContext : DbContext
    {
        public DbSet<Document> Documents { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;
using System.Xml;

namespace Meerchat.Api.Infastructure
{
    public class MeerchatContext : DbContext
    {
        public MeerchatContext(DbContextOptions<MeerchatContext> options)
            : base(options)
        { }

        public DbSet<MeerchatContext> MyEntities { get; set; }

    }
}

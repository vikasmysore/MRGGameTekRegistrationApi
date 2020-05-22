using Microsoft.EntityFrameworkCore;
using MRGGameTekRegistrationApi.Models;

namespace MRGGameTekRegistrationApi.DataContext
{
    public class MRGGameTekDataContext : DbContext
    {
        public DbSet<MrGreenRegistration> MrGreenRegistrationDbSet { get; set; }
        public DbSet<RedBetRegistration> RedBetRegistrationDbSet { get; set; }

        public MRGGameTekDataContext(DbContextOptions<MRGGameTekDataContext> options)
        : base(options)
        {
            
        }
    }
}
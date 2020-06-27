using Microsoft.EntityFrameworkCore;
using PowerliftingREST.Models;

namespace PowerliftingREST.Data
{
    public class CommanderContext : DbContext
    {
        public CommanderContext(DbContextOptions<CommanderContext> options) : base(options)
        {
        }

        public DbSet<Command> Commands { get; set; }
    }

    // public class PowerliftingContext : DbContext
    // {
    //     public PowerliftingContext(DbContextOptions<CommanderContext> options) : base(options)
    //     {
    //     }
    //     
    //     public DbSet<Powerlifting> PowerliftingMeets { get; set; }
    // }
}
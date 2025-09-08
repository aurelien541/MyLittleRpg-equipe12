using APIv1_ControleurMonster.Models;
using Microsoft.EntityFrameworkCore;

namespace ControleurMonster_APIv1.Data.Context
{
    public class MonsterContext : DbContext
    {
        public DbSet<Monster> Monster { get; set; }
        public MonsterContext(DbContextOptions<MonsterContext> options) : base(options) { }
    }
}

using APIv1_ControleurMonster.Models;
using ControleurMonster_APIv1.Models;
using Microsoft.EntityFrameworkCore;

namespace ControleurMonster_APIv1.Data.Context
{
    public class MonsterContext : DbContext
    {
        public DbSet<Monster> Monster { get; set; }
        public DbSet<Tuile> Tuiles { get; set; }
        public MonsterContext(DbContextOptions<MonsterContext> options) : base(options) { }
    }
}

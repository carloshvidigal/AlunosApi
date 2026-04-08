using AlunosApi.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AlunosApi.Context
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Aluno> Alunos { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Aluno>().HasData(
        //        new Aluno { Id = 1, Nome = "Januário", Email = "js@teste.com", Idade = 20 },
        //        new Aluno { Id = 2, Nome = "Zé das Couves", Email = "couve@teste.com", Idade = 22 });
        //}
    }
}

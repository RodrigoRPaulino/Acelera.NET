using LivrariaBackend.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace LivrariaBackend.DAO
{
    public class LivrariaContext: DbContext
    {
        public DbSet<UsuarioModel> Usuarios { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                string connect = "server=193.203.175.59;port=3306;database=u123648597_livraria;user=u123648597_livraria;password=Livraria#123";
                optionsBuilder.UseMySql(connect, ServerVersion.AutoDetect(connect));

                optionsBuilder.LogTo(Console.WriteLine);
            }
        }
        
    }
}

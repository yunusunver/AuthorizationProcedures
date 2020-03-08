using authorizationProcedures.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
namespace authorizationProcedures.Context
{
    public class AuthorizationProceduresDB:DbContext
    {
        private IConfiguration _configuration;
        //DI
        public AuthorizationProceduresDB(IConfiguration configuration)
        {
            _configuration=configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            var connectionString = _configuration.GetValue<string>("AuthorizationProceduresConnStr");
            optionsBuilder.UseNpgsql(connectionString);


        }
        public DbSet<User> User{get;set;}
        public DbSet<Campaign> Campaign{get;set;}
        public DbSet<Company> Company{get;set;}
        public DbSet<Lookup> Lookup{get;set;}
    }
}
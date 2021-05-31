using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UserService.Database.Entities;
using System.Data;
using System.Data.SqlClient;


namespace UserService.Database
{
    //public class DatabaseContext:DbContext
    //{

    //    public DbSet<User> Users { get; set; }

    //    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //    {
    //        optionsBuilder.UseSqlServer(@"Data Source = usermicroservice.c5i2wbbfnjp8.us-east-1.rds.amazonaws.com, 1433;Initial Catalog=UserMicroService;User ID = SA; Password =Daylights#123; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
    //    }
    //}



    public class DatabaseContext
    {
        private static string _connectionString;
        private List<User> userList;
        public DatabaseContext()
        {
            _connectionString = @"Data Source = usersmicroservice.c5i2wbbfnjp8.us-east-1.rds.amazonaws.com,1433;Initial Catalog=UserMicroService;User ID = SA; Password =Daylights#123; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
        }

        public List<User> GetUsers()
        {

            string CS = _connectionString;
            userList = new List<User>();
            User u = new User();
            u.Name = "Nag Rotte";
            u.Email = "nag.rotte@gmail.com";
            userList.Add(u);
            u.Name = "John Doe";
            u.Email = "john.Doe@gmail.com";
            userList.Add(u);
            return userList;

        }
    }
}

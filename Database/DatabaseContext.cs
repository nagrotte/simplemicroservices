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
            User u1 = new User();
            u1.Name = "Nag Rotte";
            u1.Email = "nag.rotte@gmail.com";
            userList.Add(u1);
            
            User u2 = new User();

            u2.Name = "Lalita Rotte";
            u2.Email = "Lalita.Rotte@gmail.com";
            userList.Add(u2);
            User u3 = new User();

            u3.Name = "Zoya Khan";
            u3.Email = "Zoya.khan@gmail.com";
            userList.Add(u3);

            return userList;

        }
    }
}

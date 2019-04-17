using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using BookStore.Models;

namespace BookStore.DatabaseContext
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base()
        {
            string databasename = "BookStoreDB";
            this.Database.Connection.ConnectionString = "Data Source=TAM\\SQLEXPRESS;Initial Catalog=" + databasename + ";Trusted_Connection=Yes";
        }
        public DbSet<Book> TbBook { get; set; }
        public DbSet<BookInformation> TbBookInfo { get; set; }
        public DbSet<User> TbUser { get; set; }
        public DbSet<Accessories> TbAcces { get; set; }
        public DbSet<Comment> TbComment { get; set; }
        public DbSet<Order> TbOrder { get; set; }
        public DbSet<Author> TbAuthor { get; set; }
        public DbSet<Publisher> TbPublisher { get; set; }
        public DbSet<Genre> TbGenre { get; set; }
        public DbSet<BookInformation_Author> BookInfo_Author { get; set; }
        public DbSet<BookInformation_Publisher> BookInfo_Pub { get; set; }
        public DbSet<BookInformation_Genre> BookInfo_Genre { get; set; }

    }
}
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.EntityFrameworkCore;
using RESTful_Web_API.Models;

namespace RESTful_Web_API.Data
{
    public class Context : DbContext
    {
        public DbSet<Person> Person { get; set; }
        public DbSet<Hobby> Hobby { get; set; }
        public DbSet<Link> Link { get; set; }
        public DbSet<PersonHobby> PersonHobby { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Person>().HasData(new Person { PersonID = 1, FirstName = "Arne",LastName = "Trampo", Phone = 123483723});
            modelBuilder.Entity<Person>().HasData(new Person { PersonID = 2, FirstName = "Börje",LastName = "Severinsson", Phone = 124383723});
            modelBuilder.Entity<Person>().HasData(new Person { PersonID = 3, FirstName = "Sara",LastName = "Palmqvist", Phone = 123443723});
            modelBuilder.Entity<Person>().HasData(new Person { PersonID = 3, FirstName = "Reidar",LastName = "Folkesson", Phone = 123543723});
            modelBuilder.Entity<Person>().HasData(new Person { PersonID = 5, FirstName = "Elina", LastName = "Johansson", Phone = 125483723 });
            modelBuilder.Entity<Person>().HasData(new Person { PersonID = 6, FirstName = "Hans", LastName = "Gustavsson", Phone = 126383723 });
            modelBuilder.Entity<Person>().HasData(new Person { PersonID = 7, FirstName = "Lena", LastName = "Karlsson", Phone = 127443723 });
            modelBuilder.Entity<Person>().HasData(new Person { PersonID = 8, FirstName = "Mikael", LastName = "Lindgren", Phone = 128543723 });
            modelBuilder.Entity<Person>().HasData(new Person { PersonID = 9, FirstName = "Pernilla", LastName = "Ekström", Phone = 129483723 });
            modelBuilder.Entity<Person>().HasData(new Person { PersonID = 10, FirstName = "Oscar", LastName = "Nilsson", Phone = 130383723 });


            modelBuilder.Entity<Hobby>().HasData(new Hobby { HobbyID = 1, HobbyName = "Fishing", HobbyDescription = "Fishing club"});
            modelBuilder.Entity<Hobby>().HasData(new Hobby { HobbyID = 2, HobbyName = "Racing", HobbyDescription = "Racing with motorized vehicles."});
            modelBuilder.Entity<Hobby>().HasData(new Hobby { HobbyID = 3, HobbyName = "Gardening", HobbyDescription = "Plant flowers."});
            modelBuilder.Entity<Hobby>().HasData(new Hobby { HobbyID = 4, HobbyName = "Skiing", HobbyDescription = "Skiing down steep slopes."});

            modelBuilder.Entity<Link>().HasData(new Link { LinkID = 1, LinkName = "Google", LinkURL = "http://www.google.com" });
            modelBuilder.Entity<Link>().HasData(new Link { LinkID = 2, LinkName = "YouTube", LinkURL = "http://www.youtube.com" });
            modelBuilder.Entity<Link>().HasData(new Link { LinkID = 3, LinkName = "Facebook", LinkURL = "http://www.facebook.com" });
            modelBuilder.Entity<Link>().HasData(new Link { LinkID = 4, LinkName = "Twitter", LinkURL = "http://www.twitter.com" });
            modelBuilder.Entity<Link>().HasData(new Link { LinkID = 5, LinkName = "Instagram", LinkURL = "http://www.instagram.com" });
            modelBuilder.Entity<Link>().HasData(new Link { LinkID = 6, LinkName = "LinkedIn", LinkURL = "http://www.linkedin.com" });
            modelBuilder.Entity<Link>().HasData(new Link { LinkID = 7, LinkName = "Reddit", LinkURL = "http://www.reddit.com" });
            modelBuilder.Entity<Link>().HasData(new Link { LinkID = 8, LinkName = "Pinterest", LinkURL = "http://www.pinterest.com" });
            modelBuilder.Entity<Link>().HasData(new Link { LinkID = 9, LinkName = "Tumblr", LinkURL = "http://www.tumblr.com" });
            modelBuilder.Entity<Link>().HasData(new Link { LinkID = 10, LinkName = "Snapchat", LinkURL = "http://www.snapchat.com" });
           
            modelBuilder.Entity<PersonHobby>().HasData(new Link { LinkID = 10, LinkName = "Snapchat", LinkURL = "http://www.snapchat.com" });


        }
    }
}

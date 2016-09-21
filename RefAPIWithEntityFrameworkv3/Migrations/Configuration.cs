namespace RefAPIWithEntityFrameworkv3.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<RefAPIWithEntityFrameworkv3.Models.RefAPIWithEntityFrameworkv3Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(RefAPIWithEntityFrameworkv3.Models.RefAPIWithEntityFrameworkv3Context context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Teams.AddOrUpdate(x => x.Id,
                new Team() { Id = 1, Name = "Tigers" },
                new Team() { Id = 2, Name = "Wolves" },
                new Team() { Id = 3, Name = "Bears" }
            );

            context.GamePlayers.AddOrUpdate(x => x.Id,
                new GamePlayer() { Id = 1, TeamId = 1, FirstName = "Jim", LastName = "Williams", IsCaptain = true, IsStartingSubstitute = false },
                new GamePlayer() { Id = 2, TeamId = 1, FirstName = "Doug", LastName = "Benson", IsCaptain = false, IsStartingSubstitute = true },
                new GamePlayer() { Id = 5, TeamId = 1, FirstName = "Jon", LastName = "Ronson", IsCaptain = false, IsStartingSubstitute = false },
                new GamePlayer() { Id = 6, TeamId = 1, FirstName = "Dave", LastName = "Paul", IsCaptain = false, IsStartingSubstitute = false },
                new GamePlayer() { Id = 3, TeamId = 2, FirstName = "Phil", LastName = "Hendry", IsCaptain = true, IsStartingSubstitute = false },
                new GamePlayer() { Id = 4, TeamId = 2, FirstName = "Bob", LastName = "Newman", IsCaptain = false, IsStartingSubstitute = true },
                new GamePlayer() { Id = 7, TeamId = 2, FirstName = "Jeremy", LastName = "Cook", IsCaptain = false, IsStartingSubstitute = false },
                new GamePlayer() { Id = 8, TeamId = 2, FirstName = "Tim", LastName = "Simons", IsCaptain = false, IsStartingSubstitute = false }
                );
        }
    }
}

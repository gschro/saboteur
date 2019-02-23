using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using saboteur.Models;
using saboteur.Models.Game;
using saboteur.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace saboteur.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<EpisodePlayer>()
            .HasKey(t => new { t.EpisodeId, t.PlayerId });

            builder.Entity<EpisodePlayer>()
                .HasOne(p => p.Episode)
                .WithMany(p => p.EpisodePlayers)
                .HasForeignKey(p => p.EpisodeId);

            builder.Entity<EpisodePlayer>()
                .HasOne(p => p.Player)
                .WithMany(p => p.EpisodePlayers)
                .HasForeignKey(p => p.PlayerId);

            builder.Entity<MissionPlayer>()
            .HasKey(t => new { t.MissionId, t.PlayerId });

            builder.Entity<MissionPlayer>()
                .HasOne(p => p.Mission)
                .WithMany(p => p.MissionPlayers)
                .HasForeignKey(p => p.MissionId);

            builder.Entity<MissionPlayer>()
                .HasOne(p => p.Player)
                .WithMany(p => p.MissionPlayers)
                .HasForeignKey(p => p.PlayerId);

            builder.Entity<PlayerPenalty>()
            .HasKey(t => new { t.PlayerId, t.PenaltyId });

            builder.Entity<PlayerPenalty>()
                .HasOne(p => p.Penalty)
                .WithMany(p => p.PlayerPenalties)
                .HasForeignKey(p => p.PenaltyId);

            builder.Entity<PlayerPenalty>()
                .HasOne(p => p.Player)
                .WithMany(p => p.PlayerPenalties)
                .HasForeignKey(p => p.PlayerId);

            #region DocumentTypeSeed
            builder.Entity<DocumentType>().HasData(
                new DocumentType() { DocumentTypeId = 1, Type = "Season" }
                );
            #endregion

            #region HostSeed
            builder.Entity<Host>().HasData(
                new Host() { HostId = 1, Name = "Anderson Cooper" });
            #endregion

            #region PlayerStatusSeed
            builder.Entity<PlayerStatus>().HasData(
                new PlayerStatus() { PlayerStatusId = 1, status = "Executed"},
                new PlayerStatus() { PlayerStatusId = 2, status = "Bribed" },
                new PlayerStatus() { PlayerStatusId = 3, status = "Winner" },
                new PlayerStatus() { PlayerStatusId = 4, status = "The Mole" });
            #endregion


            #region LocationSeed
            builder.Entity<Location>().HasData(
                new Location() { LocationId = 1, City = "Newton", State = "New Jersey", StateAbbrev = "NJ", Country = "USA" },
                new Location() { LocationId = 2, City = "Colorado Springs", State = "Colorado", StateAbbrev = "CO", Country = "USA" },
                new Location() { LocationId = 3, City = "Denver", State = "Colorado", StateAbbrev = "CO", Country = "USA" },
                new Location() { LocationId = 4, City = "New York", State = "New York", StateAbbrev = "NY", Country = "USA" },
                new Location() { LocationId = 5, City = "Cedar Rapids", State = "Iowa", StateAbbrev = "IA", Country = "USA" },
                new Location() { LocationId = 6, City = "Oxnard", State = "California", StateAbbrev = "CA", Country = "USA" },
                new Location() { LocationId = 7, City = "Cincinnatti", State = "Ohio", StateAbbrev = "OH", Country = "USA" },
                new Location() { LocationId = 8, City = "Chicago", State = "Illinois", StateAbbrev = "IL", Country = "USA" },
                new Location() { LocationId = 9, City = "San Jose", State = "California", StateAbbrev = "CA", Country = "USA" },
                new Location() { LocationId = 10, City = "Miami", State = "Florida", StateAbbrev = "FL", Country = "USA" });
            #endregion

            #region SeasonSeed
            builder.Entity<Season>().HasData(
                new Season() { SeasonId = 1, Country = "USA", Title = "The Mole", CountrySeasonNum = 1, HostId = 1, Station = "ABC", StartDate = new DateTime(2001, 1, 9), EndDate = new DateTime(2001, 2, 28), MaxPot = 1000000, EarnedPot = 510000, PublicUrl = "https://www.youtube.com/watch?v=F3tgJwpCFWo&list=PL09numCPHqBQLU0q7VY1PsOBmrF860gt3", PurchaseUrl = "https://www.amazon.com/Mole-Complete-First-Season/dp/B0007GAEXK" });

            builder.Entity<Reference>().HasData(
                new Reference() { ReferenceId = 1, Url = "https://en.wikipedia.org/wiki/The_Mole_(U.S._season_1)", DateRetrieved = new DateTime(2019, 2, 6), DocumentId = 1, DocumentTypeId = 1 });
            #endregion

            #region EpisodeSeed
            builder.Entity<Episode>().HasData(
                new Episode() { EpisodeId = 1, SeasonId = 1, Title = "Episode 1", EpisodeNum = 1, AirDate = new DateTime(2001, 1 ,9), FullEpisodePublicUrl = "https://www.youtube.com/watch?v=F3tgJwpCFWo", PreQuizPublicUrl = "https://www.youtube.com/embed/F3tgJwpCFWo?start=1&end=2168&version=3", PostQuizPublicUrl = "https://www.youtube.com/embed/F3tgJwpCFWo?start=2167&end=2596&version=3" });
            #endregion

            #region PlayerSeed
            builder.Entity<Player>().HasData(
                new Player() { PlayerId = 1, FirstName = "Jim", Age = 29, Occupation = "Helicopter Pilot", LocationId = 1, FinalPlayerEpisodeId = 10 },
                new Player() { PlayerId = 2, FirstName = "Afi", Age = 23, Occupation = "Med School Applicant", LocationId = 2, FinalPlayerEpisodeId = 1 },
                new Player() { PlayerId = 3, FirstName = "Steven", Age = 30, Occupation = "Undercover Cop", LocationId = 3, FinalPlayerEpisodeId = 10 },
                new Player() { PlayerId = 4, FirstName = "Charlie", Age = 63, Occupation = "Retired Police Detective", LocationId = 4, FinalPlayerEpisodeId = 9 },
                new Player() { PlayerId = 5, FirstName = "Wendi", Age = 29, Occupation = "Visual Display Artist", LocationId = 5, FinalPlayerEpisodeId = 1 },
                new Player() { PlayerId = 6, FirstName = "Manuel", Age = 42, Occupation = "Event Coordinator", LocationId = 6, FinalPlayerEpisodeId = 1 },
                new Player() { PlayerId = 7, FirstName = "Kate", Age = 55, Occupation = "Real Estate Investor", LocationId = 7, FinalPlayerEpisodeId = 1 },
                new Player() { PlayerId = 8, FirstName = "Kathryn", Age = 28, Occupation = "Law School Lecturer", LocationId = 8, FinalPlayerEpisodeId = 10 },
                new Player() { PlayerId = 9, FirstName = "Jennifer", Age = 35, Occupation = "Field Communication Manager", LocationId = 9, FinalPlayerEpisodeId = 1 },
                new Player() { PlayerId = 10, FirstName = "Henry", Age = 23, Occupation = "Bartender", LocationId = 10, FinalPlayerEpisodeId = 1 }
                );
            #endregion

            #region PlayerEpisodeSeed
            #endregion

            #region QuizSeed
            builder.Entity<Quiz>().HasData(
                    new Quiz() { QuizId = 1, EpisodeId = 1, Title = "Execution 1 Quiz" });
            #endregion

            #region QuizQuestion
                builder.Entity<QuizQuestion>().HasData(
                    new QuizQuestion() { QuizQuestionId = 1, QuizId = 1, EpisodeId = 1, Order = 1, Question = "Is the Mole Male or Female?" });
            #endregion

            #region QuizQuestionChoice
            builder.Entity<QuizQuestionChoice>().HasData(
                new QuizQuestionChoice() { QuizQuestionChoiceId = 1, QuizQuestionId = 1, Choice = "Male", Correct = false },
                new QuizQuestionChoice() { QuizQuestionChoiceId = 2, QuizQuestionId = 1, Choice = "Female", Correct = true });
            #endregion
        }

        public DbSet<Episode> Episodes { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Mission> Missions { get; set; }
        public DbSet<MissionPlayer> MissionPlayers { get; set; }
        public DbSet<Penalty> Penalties { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<PlayerStatus> PlayerStatuses { get; set; }
        public DbSet<QuizQuestion> QuizQuestions { get; set; }
        public DbSet<QuizQuestionChoice> QuizQuestionChoices { get; set; }
        public DbSet<Reference> References { get; set; }
        public DbSet<Season> Seasons { get; set; }
        public DbSet<UserQuiz> UserQuizzes { get; set; }
        public DbSet<UserQuizAnswer> UserQuizAnswers { get; set; }
        public DbSet<Host> Hosts { get; set; }
        public DbSet<Quiz> Quizzes { get; set; }
        public DbSet<MissionSort> MissionSorts { get; set; }
        public DbSet<MissionRole> MissionRoles { get; set; }
        public DbSet<EpisodePlayer> EpisodePlayers { get; set; }
    }
}
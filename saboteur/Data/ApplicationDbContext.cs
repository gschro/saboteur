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
            //builder.Entity<Player>().HasData(
            //    new Player() { });
            #endregion

            #region QuizSeed
                builder.Entity<Quiz>().HasData(new Quiz() { QuizId = 1, EpisodeId = 1, Title = "Execution 1 Quiz" });
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
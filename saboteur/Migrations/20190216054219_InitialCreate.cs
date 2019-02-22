using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace saboteur.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    First = table.Column<string>(maxLength: 20, nullable: true),
                    Last = table.Column<string>(maxLength: 20, nullable: true),
                    Timezone = table.Column<string>(maxLength: 40, nullable: true),
                    Age = table.Column<int>(nullable: false),
                    Occupation = table.Column<string>(maxLength: 60, nullable: true),
                    LastLogin = table.Column<DateTime>(nullable: false),
                    LoginCount = table.Column<int>(nullable: false),
                    SubscriptionId = table.Column<string>(nullable: true),
                    BillingId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DocumentType",
                columns: table => new
                {
                    DocumentTypeId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Type = table.Column<string>(maxLength: 60, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentType", x => x.DocumentTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Hosts",
                columns: table => new
                {
                    HostId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Name = table.Column<string>(maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hosts", x => x.HostId);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    LocationId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    City = table.Column<string>(maxLength: 40, nullable: true),
                    State = table.Column<string>(maxLength: 40, nullable: true),
                    Country = table.Column<string>(maxLength: 40, nullable: true),
                    Description = table.Column<string>(maxLength: 200, nullable: true),
                    PlayerLocation = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.LocationId);
                });

            migrationBuilder.CreateTable(
                name: "MissionRoles",
                columns: table => new
                {
                    MissionRoleId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Role = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MissionRoles", x => x.MissionRoleId);
                });

            migrationBuilder.CreateTable(
                name: "MissionSorts",
                columns: table => new
                {
                    MissionSortId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Sort = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MissionSorts", x => x.MissionSortId);
                });

            migrationBuilder.CreateTable(
                name: "PlayerStatuses",
                columns: table => new
                {
                    PlayerStatusId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    status = table.Column<string>(maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerStatuses", x => x.PlayerStatusId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Seasons",
                columns: table => new
                {
                    SeasonId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Title = table.Column<string>(maxLength: 60, nullable: true),
                    HostId = table.Column<int>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: true),
                    EndDate = table.Column<DateTime>(nullable: true),
                    Station = table.Column<string>(maxLength: 20, nullable: true),
                    Country = table.Column<string>(maxLength: 20, nullable: true),
                    CountrySeasonNum = table.Column<int>(nullable: false),
                    MaxPot = table.Column<int>(nullable: false),
                    EarnedPot = table.Column<int>(nullable: false),
                    PublicUrl = table.Column<string>(maxLength: 200, nullable: true),
                    PurchaseUrl = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seasons", x => x.SeasonId);
                    table.ForeignKey(
                        name: "FK_Seasons_Hosts_HostId",
                        column: x => x.HostId,
                        principalTable: "Hosts",
                        principalColumn: "HostId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Episodes",
                columns: table => new
                {
                    EpisodeId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    SeasonId = table.Column<int>(nullable: false),
                    EpisodeNum = table.Column<int>(nullable: false),
                    Title = table.Column<string>(maxLength: 60, nullable: false),
                    Description = table.Column<string>(maxLength: 2000, nullable: true),
                    FullEpisodePublicUrl = table.Column<string>(maxLength: 200, nullable: true),
                    PreQuizPublicUrl = table.Column<string>(maxLength: 200, nullable: true),
                    PostQuizPublicUrl = table.Column<string>(maxLength: 200, nullable: true),
                    AirDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Episodes", x => x.EpisodeId);
                    table.ForeignKey(
                        name: "FK_Episodes_Seasons_SeasonId",
                        column: x => x.SeasonId,
                        principalTable: "Seasons",
                        principalColumn: "SeasonId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Missions",
                columns: table => new
                {
                    MissionId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    EpisodeId = table.Column<int>(nullable: false),
                    Title = table.Column<string>(maxLength: 60, nullable: true),
                    Description = table.Column<string>(maxLength: 1000, nullable: true),
                    PossibleEarnings = table.Column<int>(nullable: false),
                    AmountWon = table.Column<int>(nullable: false),
                    LocationId = table.Column<int>(nullable: false),
                    MissionPublicUrl = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Missions", x => x.MissionId);
                    table.ForeignKey(
                        name: "FK_Missions_Episodes_EpisodeId",
                        column: x => x.EpisodeId,
                        principalTable: "Episodes",
                        principalColumn: "EpisodeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Missions_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "LocationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    PlayerId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    FirstName = table.Column<string>(maxLength: 20, nullable: false),
                    LastName = table.Column<string>(maxLength: 20, nullable: true),
                    Age = table.Column<int>(nullable: false),
                    Occupation = table.Column<string>(maxLength: 40, nullable: true),
                    LocationId = table.Column<int>(nullable: false),
                    FinalPlayerStatusId = table.Column<int>(nullable: false),
                    PlayerStatusEpisodeId = table.Column<int>(nullable: false),
                    TotalEarnings = table.Column<int>(nullable: false),
                    PicutreUrl = table.Column<string>(nullable: true),
                    PlayerStatusId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.PlayerId);
                    table.ForeignKey(
                        name: "FK_Players_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "LocationId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Players_Episodes_PlayerStatusEpisodeId",
                        column: x => x.PlayerStatusEpisodeId,
                        principalTable: "Episodes",
                        principalColumn: "EpisodeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Players_PlayerStatuses_PlayerStatusId",
                        column: x => x.PlayerStatusId,
                        principalTable: "PlayerStatuses",
                        principalColumn: "PlayerStatusId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Quizzes",
                columns: table => new
                {
                    QuizId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Title = table.Column<string>(maxLength: 60, nullable: false),
                    EpisodeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quizzes", x => x.QuizId);
                    table.ForeignKey(
                        name: "FK_Quizzes_Episodes_EpisodeId",
                        column: x => x.EpisodeId,
                        principalTable: "Episodes",
                        principalColumn: "EpisodeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserQuizzes",
                columns: table => new
                {
                    UserQuizId = table.Column<Guid>(nullable: false),
                    UserId = table.Column<string>(nullable: true),
                    EpisodeId = table.Column<int>(nullable: false),
                    QuestionsCorrect = table.Column<int>(nullable: false),
                    TotalQuestions = table.Column<int>(nullable: false),
                    TotalSeconds = table.Column<int>(nullable: false),
                    StartDateTime = table.Column<DateTime>(nullable: false),
                    EndDateTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserQuizzes", x => x.UserQuizId);
                    table.ForeignKey(
                        name: "FK_UserQuizzes_Episodes_EpisodeId",
                        column: x => x.EpisodeId,
                        principalTable: "Episodes",
                        principalColumn: "EpisodeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserQuizzes_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Penalties",
                columns: table => new
                {
                    PenaltyId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Amount = table.Column<int>(nullable: false),
                    MissionId = table.Column<int>(nullable: false),
                    EpisodeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Penalties", x => x.PenaltyId);
                    table.ForeignKey(
                        name: "FK_Penalties_Episodes_EpisodeId",
                        column: x => x.EpisodeId,
                        principalTable: "Episodes",
                        principalColumn: "EpisodeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Penalties_Missions_MissionId",
                        column: x => x.MissionId,
                        principalTable: "Missions",
                        principalColumn: "MissionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EpisodePlayers",
                columns: table => new
                {
                    EpisodeId = table.Column<int>(nullable: false),
                    PlayerId = table.Column<int>(nullable: false),
                    PlayerStatusId1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EpisodePlayers", x => new { x.EpisodeId, x.PlayerId });
                    table.ForeignKey(
                        name: "FK_EpisodePlayers_Episodes_EpisodeId",
                        column: x => x.EpisodeId,
                        principalTable: "Episodes",
                        principalColumn: "EpisodeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EpisodePlayers_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "PlayerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EpisodePlayers_PlayerStatuses_PlayerStatusId1",
                        column: x => x.PlayerStatusId1,
                        principalTable: "PlayerStatuses",
                        principalColumn: "PlayerStatusId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MissionPlayers",
                columns: table => new
                {
                    MissionId = table.Column<int>(nullable: false),
                    PlayerId = table.Column<int>(nullable: false),
                    MissionSortId = table.Column<int>(nullable: false),
                    MissionRoleId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MissionPlayers", x => new { x.MissionId, x.PlayerId });
                    table.ForeignKey(
                        name: "FK_MissionPlayers_Missions_MissionId",
                        column: x => x.MissionId,
                        principalTable: "Missions",
                        principalColumn: "MissionId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MissionPlayers_MissionRoles_MissionRoleId",
                        column: x => x.MissionRoleId,
                        principalTable: "MissionRoles",
                        principalColumn: "MissionRoleId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MissionPlayers_MissionSorts_MissionSortId",
                        column: x => x.MissionSortId,
                        principalTable: "MissionSorts",
                        principalColumn: "MissionSortId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MissionPlayers_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "PlayerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "References",
                columns: table => new
                {
                    ReferenceId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    DocumentId = table.Column<int>(nullable: false),
                    DocumentTypeId = table.Column<int>(nullable: false),
                    DateRetrieved = table.Column<DateTime>(nullable: false),
                    Url = table.Column<string>(maxLength: 200, nullable: true),
                    Title = table.Column<string>(maxLength: 60, nullable: true),
                    PlayerId = table.Column<int>(nullable: true),
                    EpisodeId = table.Column<int>(nullable: true),
                    MissionId = table.Column<int>(nullable: true),
                    SeasonId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_References", x => x.ReferenceId);
                    table.ForeignKey(
                        name: "FK_References_DocumentType_DocumentTypeId",
                        column: x => x.DocumentTypeId,
                        principalTable: "DocumentType",
                        principalColumn: "DocumentTypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_References_Episodes_EpisodeId",
                        column: x => x.EpisodeId,
                        principalTable: "Episodes",
                        principalColumn: "EpisodeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_References_Missions_MissionId",
                        column: x => x.MissionId,
                        principalTable: "Missions",
                        principalColumn: "MissionId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_References_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "PlayerId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_References_Seasons_SeasonId",
                        column: x => x.SeasonId,
                        principalTable: "Seasons",
                        principalColumn: "SeasonId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "QuizQuestions",
                columns: table => new
                {
                    QuizQuestionId = table.Column<Guid>(nullable: false),
                    EpisodeId = table.Column<int>(nullable: false),
                    Order = table.Column<int>(nullable: false),
                    Question = table.Column<string>(maxLength: 200, nullable: true),
                    QuizId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuizQuestions", x => x.QuizQuestionId);
                    table.ForeignKey(
                        name: "FK_QuizQuestions_Episodes_EpisodeId",
                        column: x => x.EpisodeId,
                        principalTable: "Episodes",
                        principalColumn: "EpisodeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_QuizQuestions_Quizzes_QuizId",
                        column: x => x.QuizId,
                        principalTable: "Quizzes",
                        principalColumn: "QuizId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PlayerPenalty",
                columns: table => new
                {
                    PlayerId = table.Column<int>(nullable: false),
                    PenaltyId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerPenalty", x => new { x.PlayerId, x.PenaltyId });
                    table.ForeignKey(
                        name: "FK_PlayerPenalty_Penalties_PenaltyId",
                        column: x => x.PenaltyId,
                        principalTable: "Penalties",
                        principalColumn: "PenaltyId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlayerPenalty_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "PlayerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "QuizQuestionChoices",
                columns: table => new
                {
                    QuizQuestionChoiceId = table.Column<Guid>(nullable: false),
                    QuizQuestionId = table.Column<Guid>(nullable: false),
                    Choice = table.Column<string>(maxLength: 200, nullable: true),
                    Correct = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuizQuestionChoices", x => x.QuizQuestionChoiceId);
                    table.ForeignKey(
                        name: "FK_QuizQuestionChoices_QuizQuestions_QuizQuestionId",
                        column: x => x.QuizQuestionId,
                        principalTable: "QuizQuestions",
                        principalColumn: "QuizQuestionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserQuizAnswers",
                columns: table => new
                {
                    UserQuizAnswerId = table.Column<Guid>(nullable: false),
                    UserQuizId = table.Column<string>(nullable: true),
                    QuizQuestionId = table.Column<Guid>(nullable: false),
                    QuizQuestionChoiceId = table.Column<Guid>(nullable: false),
                    QuizAnswerCorrect = table.Column<bool>(nullable: false),
                    TotalSeconds = table.Column<int>(nullable: false),
                    StartDateTime = table.Column<DateTime>(nullable: false),
                    EndDateTime = table.Column<DateTime>(nullable: false),
                    UserQuizId1 = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserQuizAnswers", x => x.UserQuizAnswerId);
                    table.ForeignKey(
                        name: "FK_UserQuizAnswers_QuizQuestionChoices_QuizQuestionChoiceId",
                        column: x => x.QuizQuestionChoiceId,
                        principalTable: "QuizQuestionChoices",
                        principalColumn: "QuizQuestionChoiceId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserQuizAnswers_QuizQuestions_QuizQuestionId",
                        column: x => x.QuizQuestionId,
                        principalTable: "QuizQuestions",
                        principalColumn: "QuizQuestionId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserQuizAnswers_UserQuizzes_UserQuizId1",
                        column: x => x.UserQuizId1,
                        principalTable: "UserQuizzes",
                        principalColumn: "UserQuizId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "DocumentType",
                columns: new[] { "DocumentTypeId", "Type" },
                values: new object[] { 1, "Season" });

            migrationBuilder.InsertData(
                table: "Hosts",
                columns: new[] { "HostId", "Name" },
                values: new object[] { 1, "Anderson Cooper" });

            migrationBuilder.InsertData(
                table: "References",
                columns: new[] { "ReferenceId", "DateRetrieved", "DocumentId", "DocumentTypeId", "EpisodeId", "MissionId", "PlayerId", "SeasonId", "Title", "Url" },
                values: new object[] { 1, new DateTime(2019, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, null, null, null, null, null, "https://en.wikipedia.org/wiki/The_Mole_(U.S._season_1)" });

            migrationBuilder.InsertData(
                table: "Seasons",
                columns: new[] { "SeasonId", "Country", "CountrySeasonNum", "EarnedPot", "EndDate", "HostId", "MaxPot", "PublicUrl", "PurchaseUrl", "StartDate", "Station", "Title" },
                values: new object[] { 1, "USA", 1, 510000, new DateTime(2001, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1000000, "https://www.youtube.com/watch?v=F3tgJwpCFWo&list=PL09numCPHqBQLU0q7VY1PsOBmrF860gt3", "https://www.amazon.com/Mole-Complete-First-Season/dp/B0007GAEXK", new DateTime(2001, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "ABC", "The Mole" });

            migrationBuilder.InsertData(
                table: "Episodes",
                columns: new[] { "EpisodeId", "AirDate", "Description", "EpisodeNum", "FullEpisodePublicUrl", "PostQuizPublicUrl", "PreQuizPublicUrl", "SeasonId", "Title" },
                values: new object[] { 1, new DateTime(2001, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, "https://www.youtube.com/watch?v=F3tgJwpCFWo", "https://www.youtube.com/embed/F3tgJwpCFWo?start=2167&end=2596&version=3", "https://www.youtube.com/embed/F3tgJwpCFWo?start=0&end=2168&version=3", 1, "Episode 1" });

            migrationBuilder.InsertData(
                table: "Quizzes",
                columns: new[] { "QuizId", "EpisodeId", "Title" },
                values: new object[] { 1, 1, "Execution 1 Quiz" });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_EpisodePlayers_PlayerId",
                table: "EpisodePlayers",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_EpisodePlayers_PlayerStatusId1",
                table: "EpisodePlayers",
                column: "PlayerStatusId1");

            migrationBuilder.CreateIndex(
                name: "IX_Episodes_SeasonId",
                table: "Episodes",
                column: "SeasonId");

            migrationBuilder.CreateIndex(
                name: "IX_MissionPlayers_MissionRoleId",
                table: "MissionPlayers",
                column: "MissionRoleId");

            migrationBuilder.CreateIndex(
                name: "IX_MissionPlayers_MissionSortId",
                table: "MissionPlayers",
                column: "MissionSortId");

            migrationBuilder.CreateIndex(
                name: "IX_MissionPlayers_PlayerId",
                table: "MissionPlayers",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_Missions_EpisodeId",
                table: "Missions",
                column: "EpisodeId");

            migrationBuilder.CreateIndex(
                name: "IX_Missions_LocationId",
                table: "Missions",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Penalties_EpisodeId",
                table: "Penalties",
                column: "EpisodeId");

            migrationBuilder.CreateIndex(
                name: "IX_Penalties_MissionId",
                table: "Penalties",
                column: "MissionId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerPenalty_PenaltyId",
                table: "PlayerPenalty",
                column: "PenaltyId");

            migrationBuilder.CreateIndex(
                name: "IX_Players_LocationId",
                table: "Players",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Players_PlayerStatusEpisodeId",
                table: "Players",
                column: "PlayerStatusEpisodeId");

            migrationBuilder.CreateIndex(
                name: "IX_Players_PlayerStatusId",
                table: "Players",
                column: "PlayerStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_QuizQuestionChoices_QuizQuestionId",
                table: "QuizQuestionChoices",
                column: "QuizQuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_QuizQuestions_EpisodeId",
                table: "QuizQuestions",
                column: "EpisodeId");

            migrationBuilder.CreateIndex(
                name: "IX_QuizQuestions_QuizId",
                table: "QuizQuestions",
                column: "QuizId");

            migrationBuilder.CreateIndex(
                name: "IX_Quizzes_EpisodeId",
                table: "Quizzes",
                column: "EpisodeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_References_DocumentTypeId",
                table: "References",
                column: "DocumentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_References_EpisodeId",
                table: "References",
                column: "EpisodeId");

            migrationBuilder.CreateIndex(
                name: "IX_References_MissionId",
                table: "References",
                column: "MissionId");

            migrationBuilder.CreateIndex(
                name: "IX_References_PlayerId",
                table: "References",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_References_SeasonId",
                table: "References",
                column: "SeasonId");

            migrationBuilder.CreateIndex(
                name: "IX_Seasons_HostId",
                table: "Seasons",
                column: "HostId");

            migrationBuilder.CreateIndex(
                name: "IX_UserQuizAnswers_QuizQuestionChoiceId",
                table: "UserQuizAnswers",
                column: "QuizQuestionChoiceId");

            migrationBuilder.CreateIndex(
                name: "IX_UserQuizAnswers_QuizQuestionId",
                table: "UserQuizAnswers",
                column: "QuizQuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_UserQuizAnswers_UserQuizId1",
                table: "UserQuizAnswers",
                column: "UserQuizId1");

            migrationBuilder.CreateIndex(
                name: "IX_UserQuizzes_EpisodeId",
                table: "UserQuizzes",
                column: "EpisodeId");

            migrationBuilder.CreateIndex(
                name: "IX_UserQuizzes_UserId",
                table: "UserQuizzes",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "EpisodePlayers");

            migrationBuilder.DropTable(
                name: "MissionPlayers");

            migrationBuilder.DropTable(
                name: "PlayerPenalty");

            migrationBuilder.DropTable(
                name: "References");

            migrationBuilder.DropTable(
                name: "UserQuizAnswers");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "MissionRoles");

            migrationBuilder.DropTable(
                name: "MissionSorts");

            migrationBuilder.DropTable(
                name: "Penalties");

            migrationBuilder.DropTable(
                name: "DocumentType");

            migrationBuilder.DropTable(
                name: "Players");

            migrationBuilder.DropTable(
                name: "QuizQuestionChoices");

            migrationBuilder.DropTable(
                name: "UserQuizzes");

            migrationBuilder.DropTable(
                name: "Missions");

            migrationBuilder.DropTable(
                name: "PlayerStatuses");

            migrationBuilder.DropTable(
                name: "QuizQuestions");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "Quizzes");

            migrationBuilder.DropTable(
                name: "Episodes");

            migrationBuilder.DropTable(
                name: "Seasons");

            migrationBuilder.DropTable(
                name: "Hosts");
        }
    }
}

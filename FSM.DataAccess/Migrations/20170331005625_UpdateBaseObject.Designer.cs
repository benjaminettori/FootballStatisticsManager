using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using FSM.DataAccess;
using FSM.Model.Enums;

namespace FSM.DataAccess.Migrations
{
    [DbContext(typeof(FsmContext))]
    [Migration("20170331005625_UpdateBaseObject")]
    partial class UpdateBaseObject
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FSM.Model.ModelObjects.Club", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Created");

                    b.Property<DateTime>("LastUpdated");

                    b.Property<Guid>("LeagueId");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("NickName");

                    b.Property<string>("SixLetterName");

                    b.Property<Guid>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("LeagueId");

                    b.HasIndex("UserId");

                    b.ToTable("Club");
                });

            modelBuilder.Entity("FSM.Model.ModelObjects.Country", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Created");

                    b.Property<DateTime>("LastUpdated");

                    b.Property<string>("Name");

                    b.Property<long>("Population");

                    b.Property<Guid>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Country");
                });

            modelBuilder.Entity("FSM.Model.ModelObjects.League", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("CountryId");

                    b.Property<DateTime>("Created");

                    b.Property<DateTime>("LastUpdated");

                    b.Property<string>("Name");

                    b.Property<int>("Tier");

                    b.Property<Guid>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.HasIndex("UserId");

                    b.ToTable("League");
                });

            modelBuilder.Entity("FSM.Model.ModelObjects.Player", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Created");

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<string>("FirstName");

                    b.Property<int>("Height");

                    b.Property<string>("LastName");

                    b.Property<DateTime>("LastUpdated");

                    b.Property<int>("LeftFootRating");

                    b.Property<int>("RightFootRating");

                    b.Property<Guid>("UserId");

                    b.Property<int>("Weight");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Player");
                });

            modelBuilder.Entity("FSM.Model.ModelObjects.PlayerAttribute", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Attribute");

                    b.Property<string>("AttributeCode");

                    b.Property<string>("AttributeName");

                    b.Property<DateTime>("Created");

                    b.Property<bool>("Current");

                    b.Property<DateTime>("LastUpdated");

                    b.Property<DateTime>("OnDate");

                    b.Property<Guid>("PlayerId");

                    b.Property<int>("Rating");

                    b.Property<Guid>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("PlayerId");

                    b.HasIndex("UserId");

                    b.ToTable("PlayerAttributes");
                });

            modelBuilder.Entity("FSM.Model.ModelObjects.PlayerContract", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<decimal>("Amount");

                    b.Property<Guid>("ClubId");

                    b.Property<DateTime>("Created");

                    b.Property<int>("Currency");

                    b.Property<DateTime>("EndDate");

                    b.Property<DateTime>("LastUpdated");

                    b.Property<Guid>("PlayerId");

                    b.Property<DateTime>("StartDate");

                    b.Property<int>("Type");

                    b.Property<Guid>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("ClubId");

                    b.HasIndex("PlayerId");

                    b.HasIndex("UserId");

                    b.ToTable("PlayerContract");
                });

            modelBuilder.Entity("FSM.Model.ModelObjects.PlayerContractClause", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ClauseType");

                    b.Property<decimal>("ClauseValue");

                    b.Property<Guid>("ContractId");

                    b.Property<DateTime>("Created");

                    b.Property<DateTime>("LastUpdated");

                    b.Property<decimal?>("SecondClauseValue");

                    b.Property<Guid>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("ContractId");

                    b.HasIndex("UserId");

                    b.ToTable("PlayerContractClause");
                });

            modelBuilder.Entity("FSM.Model.ModelObjects.PlayerPosition", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Created");

                    b.Property<DateTime>("LastUpdated");

                    b.Property<DateTime>("OnDate");

                    b.Property<Guid>("PlayerId");

                    b.Property<int>("Rating");

                    b.Property<Guid>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("PlayerId");

                    b.HasIndex("UserId");

                    b.ToTable("Positions");
                });

            modelBuilder.Entity("FSM.Model.ModelObjects.PlayerStatistic", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("CategoryId");

                    b.Property<DateTime>("Created");

                    b.Property<DateTime>("LastUpdated");

                    b.Property<DateTime>("OnDate");

                    b.Property<Guid>("PlayerId");

                    b.Property<Guid>("SeasonId");

                    b.Property<Guid>("UserId");

                    b.Property<double>("Value");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("PlayerId");

                    b.HasIndex("SeasonId");

                    b.HasIndex("UserId");

                    b.ToTable("PlayerStatistics");
                });

            modelBuilder.Entity("FSM.Model.ModelObjects.Season", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Created");

                    b.Property<DateTime>("EndDate");

                    b.Property<DateTime>("LastUpdated");

                    b.Property<Guid>("LeagueId");

                    b.Property<DateTime>("StartDate");

                    b.Property<Guid>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("LeagueId");

                    b.HasIndex("UserId");

                    b.ToTable("Season");
                });

            modelBuilder.Entity("FSM.Model.ModelObjects.StatisticalCategory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CategoryCode");

                    b.Property<string>("CategoryName");

                    b.Property<DateTime>("Created");

                    b.Property<int>("Format");

                    b.Property<DateTime>("LastUpdated");

                    b.HasKey("Id");

                    b.ToTable("StatisticalCategories");
                });

            modelBuilder.Entity("FSM.Model.ModelObjects.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Created");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<DateTime>("LastUpdated");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("FSM.Model.ModelObjects.Club", b =>
                {
                    b.HasOne("FSM.Model.ModelObjects.League", "League")
                        .WithMany()
                        .HasForeignKey("LeagueId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FSM.Model.ModelObjects.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("FSM.Model.ModelObjects.Country", b =>
                {
                    b.HasOne("FSM.Model.ModelObjects.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("FSM.Model.ModelObjects.League", b =>
                {
                    b.HasOne("FSM.Model.ModelObjects.Country", "Country")
                        .WithMany("Leagues")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FSM.Model.ModelObjects.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("FSM.Model.ModelObjects.Player", b =>
                {
                    b.HasOne("FSM.Model.ModelObjects.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("FSM.Model.ModelObjects.PlayerAttribute", b =>
                {
                    b.HasOne("FSM.Model.ModelObjects.Player", "Player")
                        .WithMany()
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FSM.Model.ModelObjects.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("FSM.Model.ModelObjects.PlayerContract", b =>
                {
                    b.HasOne("FSM.Model.ModelObjects.Club", "Club")
                        .WithMany("PlayerContracts")
                        .HasForeignKey("ClubId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FSM.Model.ModelObjects.Player", "Player")
                        .WithMany("Contracts")
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FSM.Model.ModelObjects.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("FSM.Model.ModelObjects.PlayerContractClause", b =>
                {
                    b.HasOne("FSM.Model.ModelObjects.PlayerContract", "Contract")
                        .WithMany("Clauses")
                        .HasForeignKey("ContractId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FSM.Model.ModelObjects.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("FSM.Model.ModelObjects.PlayerPosition", b =>
                {
                    b.HasOne("FSM.Model.ModelObjects.Player", "Player")
                        .WithMany()
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FSM.Model.ModelObjects.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("FSM.Model.ModelObjects.PlayerStatistic", b =>
                {
                    b.HasOne("FSM.Model.ModelObjects.StatisticalCategory", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FSM.Model.ModelObjects.Player", "Player")
                        .WithMany()
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FSM.Model.ModelObjects.Season", "Season")
                        .WithMany()
                        .HasForeignKey("SeasonId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FSM.Model.ModelObjects.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("FSM.Model.ModelObjects.Season", b =>
                {
                    b.HasOne("FSM.Model.ModelObjects.League", "League")
                        .WithMany()
                        .HasForeignKey("LeagueId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FSM.Model.ModelObjects.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });
        }
    }
}

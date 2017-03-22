using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using FSM.DataAccess;

namespace FSM.DataAccess.Migrations
{
    [DbContext(typeof(FsmContext))]
    partial class FsmContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FSM.Model.Country", b =>
                {
                    b.Property<Guid>("CountryId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<long>("Population");

                    b.Property<Guid>("UserId");

                    b.HasKey("CountryId");

                    b.HasIndex("UserId");

                    b.ToTable("Country");
                });

            modelBuilder.Entity("FSM.Model.League", b =>
                {
                    b.Property<Guid>("LeagueId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<int>("Tier");

                    b.Property<Guid>("UserId");

                    b.HasKey("LeagueId");

                    b.HasIndex("UserId");

                    b.ToTable("League");
                });

            modelBuilder.Entity("FSM.Model.User", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.HasKey("UserId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("FSM.Model.Country", b =>
                {
                    b.HasOne("FSM.Model.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FSM.Model.League", b =>
                {
                    b.HasOne("FSM.Model.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}

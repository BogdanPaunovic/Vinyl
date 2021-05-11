﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Projekat.Models;

namespace Projekat.Migrations
{
    [DbContext(typeof(VinylContext))]
    [Migration("20200619160215_V5.1")]
    partial class V51
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Projekat.Models.Caffe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnName("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BackgroundImg")
                        .HasColumnName("BackgroundImg")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnName("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Info")
                        .HasColumnName("Info")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnName("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("OwnerRef")
                        .HasColumnName("OwnerRef")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("Name");

                    b.HasIndex("OwnerRef");

                    b.ToTable("Caffe");
                });

            modelBuilder.Entity("Projekat.Models.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BoundRecordRef")
                        .HasColumnName("BoundRecordRef")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .HasColumnName("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OwnerRef")
                        .HasColumnName("OwnerRef")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("BoundRecordRef");

                    b.HasIndex("OwnerRef");

                    b.ToTable("Comment");
                });

            modelBuilder.Entity("Projekat.Models.Event", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CaffeRef")
                        .HasColumnName("Caffe")
                        .HasColumnType("int");

                    b.Property<string>("Date")
                        .HasColumnName("Date")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Info")
                        .HasColumnName("Info")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Modifier")
                        .HasColumnName("Modifier")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OwnerRef")
                        .HasColumnName("Owner")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Time")
                        .HasColumnName("Time")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnName("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CaffeRef");

                    b.HasIndex("OwnerRef");

                    b.ToTable("Event");
                });

            modelBuilder.Entity("Projekat.Models.FavoriteRecord", b =>
                {
                    b.Property<string>("UserRef")
                        .HasColumnName("UserRef")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("RecordRef")
                        .HasColumnName("RecordRef")
                        .HasColumnType("int");

                    b.HasKey("UserRef", "RecordRef");

                    b.ToTable("FavoriteRecord");
                });

            modelBuilder.Entity("Projekat.Models.Friend", b =>
                {
                    b.Property<string>("User1Ref")
                        .HasColumnName("User1Ref")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("User2Ref")
                        .HasColumnName("User2Ref")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("User1Ref", "User2Ref");

                    b.ToTable("Friend");
                });

            modelBuilder.Entity("Projekat.Models.Interested", b =>
                {
                    b.Property<int>("EventRef")
                        .HasColumnName("EventRef")
                        .HasColumnType("int");

                    b.Property<string>("AttenderRef")
                        .HasColumnName("AttenderRef")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("EventRef", "AttenderRef");

                    b.HasIndex("AttenderRef");

                    b.ToTable("Interested");
                });

            modelBuilder.Entity("Projekat.Models.News", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ImageLarge")
                        .HasColumnName("ImageLarge")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageSmall")
                        .HasColumnName("ImageSmall")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TextLarge")
                        .HasColumnName("TextLarge")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TextSmall")
                        .HasColumnName("TextSmall")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TitleLarge")
                        .HasColumnName("TitleLarge")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TitleSmall")
                        .HasColumnName("TitleSmall")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("News");
                });

            modelBuilder.Entity("Projekat.Models.PendingRequest", b =>
                {
                    b.Property<string>("UserSentRef")
                        .HasColumnName("UserSentRef")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("UserReceavedRef")
                        .HasColumnName("UserReceavedRef")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserSentRef", "UserReceavedRef");

                    b.HasIndex("UserReceavedRef");

                    b.ToTable("PendingRequest");
                });

            modelBuilder.Entity("Projekat.Models.Record", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Author")
                        .HasColumnName("Author")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Category")
                        .HasColumnName("Category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Demo")
                        .HasColumnName("Demo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DisplayImg")
                        .HasColumnName("DisplayImg")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Info")
                        .HasColumnName("Info")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnName("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Record");
                });

            modelBuilder.Entity("Projekat.Models.Song", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("RecordRef")
                        .HasColumnName("RecordRef")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnName("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("RecordRef");

                    b.ToTable("Song");
                });

            modelBuilder.Entity("Projekat.Models.User", b =>
                {
                    b.Property<string>("Username")
                        .HasColumnName("Username")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Bio")
                        .HasColumnName("Bio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnName("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IsAdmin")
                        .HasColumnName("IsAdmin")
                        .HasColumnType("int");

                    b.Property<int>("IsOwner")
                        .HasColumnName("IsOwner")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnName("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnName("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfileImg")
                        .HasColumnName("ProfileImg")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .HasColumnName("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Username");

                    b.ToTable("User");
                });

            modelBuilder.Entity("Projekat.Models.Caffe", b =>
                {
                    b.HasOne("Projekat.Models.User", "Owner")
                        .WithMany("OwnedCaffes")
                        .HasForeignKey("OwnerRef")
                        .OnDelete(DeleteBehavior.ClientCascade);
                });

            modelBuilder.Entity("Projekat.Models.Comment", b =>
                {
                    b.HasOne("Projekat.Models.Record", "BoundRecord")
                        .WithMany("Comments")
                        .HasForeignKey("BoundRecordRef")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.HasOne("Projekat.Models.User", "Owner")
                        .WithMany("PostedComments")
                        .HasForeignKey("OwnerRef")
                        .OnDelete(DeleteBehavior.ClientCascade);
                });

            modelBuilder.Entity("Projekat.Models.Event", b =>
                {
                    b.HasOne("Projekat.Models.Caffe", "Caffe")
                        .WithMany("OrganizedEvents")
                        .HasForeignKey("CaffeRef")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.HasOne("Projekat.Models.User", "Owner")
                        .WithMany("EventsOwned")
                        .HasForeignKey("OwnerRef");
                });

            modelBuilder.Entity("Projekat.Models.FavoriteRecord", b =>
                {
                    b.HasOne("Projekat.Models.User", "User")
                        .WithMany("FavoriteRecords")
                        .HasForeignKey("UserRef")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Projekat.Models.Friend", b =>
                {
                    b.HasOne("Projekat.Models.User", "User1")
                        .WithMany("Friends")
                        .HasForeignKey("User1Ref")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Projekat.Models.Interested", b =>
                {
                    b.HasOne("Projekat.Models.User", "Attender")
                        .WithMany("EventsInterested")
                        .HasForeignKey("AttenderRef")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.HasOne("Projekat.Models.Event", "Event")
                        .WithMany("Interested")
                        .HasForeignKey("EventRef")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Projekat.Models.PendingRequest", b =>
                {
                    b.HasOne("Projekat.Models.User", "UserReceaved")
                        .WithMany("PendingRequests")
                        .HasForeignKey("UserReceavedRef")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.HasOne("Projekat.Models.User", "UserSent")
                        .WithMany("SentRequests")
                        .HasForeignKey("UserSentRef")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Projekat.Models.Song", b =>
                {
                    b.HasOne("Projekat.Models.Record", "Record")
                        .WithMany("Songs")
                        .HasForeignKey("RecordRef")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}

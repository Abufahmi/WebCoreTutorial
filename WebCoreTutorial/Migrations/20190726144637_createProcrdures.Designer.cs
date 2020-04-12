﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebCoreTutorial.Data;

namespace WebCoreTutorial.Migrations
{
    [DbContext(typeof(ApplicationDb))]
    [Migration("20190726144637_createProcrdures")]
    partial class createProcrdures
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebCoreTutorial.Models.AppConfirm", b =>
                {
                    b.Property<string>("id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(450);

                    b.Property<DateTime>("DateConfirm");

                    b.Property<string>("UserId");

                    b.HasKey("id");

                    b.HasIndex("UserId");

                    b.ToTable("AppConfirms");
                });

            modelBuilder.Entity("WebCoreTutorial.Models.AppRole", b =>
                {
                    b.Property<string>("id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(450);

                    b.Property<string>("RoleName")
                        .HasMaxLength(150);

                    b.HasKey("id");

                    b.ToTable("AppRoles");
                });

            modelBuilder.Entity("WebCoreTutorial.Models.AppUser", b =>
                {
                    b.Property<string>("id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(450);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.Property<bool>("EmailConfirm");

                    b.Property<int>("ErrorLogCount");

                    b.Property<DateTime?>("LockTime");

                    b.Property<bool>("Lockout");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(650);

                    b.Property<string>("PasswordConfirm")
                        .IsRequired()
                        .HasMaxLength(650);

                    b.Property<string>("Phone")
                        .HasMaxLength(250);

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.HasKey("id");

                    b.ToTable("AppUsers");
                });

            modelBuilder.Entity("WebCoreTutorial.Models.BillingAddress", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.Property<int>("Zip")
                        .HasMaxLength(50);

                    b.Property<string>("firstName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("lastName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("id");

                    b.ToTable("BillingAddresses");
                });

            modelBuilder.Entity("WebCoreTutorial.Models.Cart", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Discount");

                    b.Property<double?>("Price");

                    b.Property<string>("ProductName")
                        .HasMaxLength(70);

                    b.HasKey("id");

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("WebCoreTutorial.Models.Category", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("catName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("WebCoreTutorial.Models.Payment", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("billingId");

                    b.Property<string>("cardName")
                        .IsRequired()
                        .HasMaxLength(70);

                    b.Property<long>("cardNumber");

                    b.Property<string>("cardType")
                        .IsRequired()
                        .HasMaxLength(70);

                    b.Property<int>("cartId");

                    b.Property<int>("cvv");

                    b.Property<DateTime>("expiration");

                    b.HasKey("id");

                    b.HasIndex("billingId");

                    b.HasIndex("cartId");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("WebCoreTutorial.Models.Post", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Auther")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.Property<int?>("Discount");

                    b.Property<bool>("IsPublish");

                    b.Property<string>("LikeUserName");

                    b.Property<string>("PostContent")
                        .IsRequired()
                        .HasMaxLength(4000);

                    b.Property<DateTime>("PostDate");

                    b.Property<string>("PostImg")
                        .HasMaxLength(1000);

                    b.Property<int>("PostLike");

                    b.Property<int>("PostViews");

                    b.Property<double?>("Price");

                    b.Property<string>("ProductName")
                        .HasMaxLength(70);

                    b.Property<int>("SubId");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("id");

                    b.HasIndex("SubId");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("WebCoreTutorial.Models.SubCategory", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("SubCatName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<int>("catId");

                    b.HasKey("id");

                    b.HasIndex("catId");

                    b.ToTable("SubCategories");
                });

            modelBuilder.Entity("WebCoreTutorial.Models.UserProfile", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Country")
                        .HasMaxLength(100);

                    b.Property<DateTime?>("DateOfBurth");

                    b.Property<string>("PersonalWebUrl")
                        .HasMaxLength(200);

                    b.Property<string>("UrlImage")
                        .HasMaxLength(400);

                    b.Property<string>("UserId");

                    b.HasKey("id");

                    b.HasIndex("UserId");

                    b.ToTable("UserProfiles");
                });

            modelBuilder.Entity("WebCoreTutorial.Models.UserRole", b =>
                {
                    b.Property<string>("id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(450);

                    b.Property<string>("RoleId");

                    b.Property<string>("UserId");

                    b.HasKey("id");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("WebCoreTutorial.Models.UserSetting", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MaxPassLength");

                    b.Property<int>("MinimumPassLength");

                    b.Property<bool>("SendWelcomeMessage");

                    b.Property<bool>("isDigit");

                    b.Property<bool>("isEmailConfirm");

                    b.Property<bool>("isRegisterOpen");

                    b.Property<bool>("isUpper");

                    b.HasKey("id");

                    b.ToTable("UserSettings");
                });

            modelBuilder.Entity("WebCoreTutorial.Models.VideoFile", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FilePath");

                    b.Property<int?>("FileSize");

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.ToTable("VideoFiles");
                });

            modelBuilder.Entity("WebCoreTutorial.Models.AppConfirm", b =>
                {
                    b.HasOne("WebCoreTutorial.Models.AppUser", "appUser")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("WebCoreTutorial.Models.Payment", b =>
                {
                    b.HasOne("WebCoreTutorial.Models.BillingAddress", "billingAddress")
                        .WithMany()
                        .HasForeignKey("billingId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WebCoreTutorial.Models.Cart", "Cart")
                        .WithMany()
                        .HasForeignKey("cartId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebCoreTutorial.Models.Post", b =>
                {
                    b.HasOne("WebCoreTutorial.Models.SubCategory", "SubCategory")
                        .WithMany()
                        .HasForeignKey("SubId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebCoreTutorial.Models.SubCategory", b =>
                {
                    b.HasOne("WebCoreTutorial.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("catId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebCoreTutorial.Models.UserProfile", b =>
                {
                    b.HasOne("WebCoreTutorial.Models.AppUser", "appUser")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("WebCoreTutorial.Models.UserRole", b =>
                {
                    b.HasOne("WebCoreTutorial.Models.AppRole", "appRole")
                        .WithMany()
                        .HasForeignKey("RoleId");

                    b.HasOne("WebCoreTutorial.Models.AppUser", "appUser")
                        .WithMany()
                        .HasForeignKey("UserId");
                });
#pragma warning restore 612, 618
        }
    }
}
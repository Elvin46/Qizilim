﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Qizilim.az.Models.DataContext;

namespace Qizilim.az.Migrations
{
    [DbContext(typeof(QizilimDbContext))]
    [Migration("20230402221644_AddUserIdColumnToAdvertisementTable")]
    partial class AddUserIdColumnToAdvertisementTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Qizilim.az.Models.Entities.Advertisement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CreatedById")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DeletedById")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Link")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("QizilimUserId")
                        .HasColumnType("int");

                    b.Property<int>("ShopId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("QizilimUserId");

                    b.ToTable("Advertisement");
                });

            modelBuilder.Entity("Qizilim.az.Models.Entities.Centers", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CreatedById")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DeletedById")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Centers");
                });

            modelBuilder.Entity("Qizilim.az.Models.Entities.Color", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CreatedById")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DeletedById")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Colors");
                });

            modelBuilder.Entity("Qizilim.az.Models.Entities.Color+ProductColors", b =>
                {
                    b.Property<int>("ColorId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("ColorId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductColors");
                });

            modelBuilder.Entity("Qizilim.az.Models.Entities.Eyar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CreatedById")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DeletedById")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("EyarOlcusu")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Eyars");
                });

            modelBuilder.Entity("Qizilim.az.Models.Entities.Images", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CreatedById")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DeletedById")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Path")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("Qizilim.az.Models.Entities.Images+ProductImage", b =>
                {
                    b.Property<int>("ImageId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<bool?>("IsMain")
                        .HasColumnType("bit");

                    b.HasKey("ImageId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductImage");
                });

            modelBuilder.Entity("Qizilim.az.Models.Entities.Kateqoriya", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CreatedById")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DeletedById")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Kateqoriya");
                });

            modelBuilder.Entity("Qizilim.az.Models.Entities.Membreship.Follow", b =>
                {
                    b.Property<int>("FollowerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FollowerName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FollowerId");

                    b.ToTable("Follows");
                });

            modelBuilder.Entity("Qizilim.az.Models.Entities.Membreship.FollowUser", b =>
                {
                    b.Property<int>("FollowerId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("FollowerId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("FollowUser");
                });

            modelBuilder.Entity("Qizilim.az.Models.Entities.Membreship.FollowersShops", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CreatedById")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DeletedById")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("FollowerId")
                        .HasColumnType("int");

                    b.Property<int>("ShopId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FollowerId");

                    b.ToTable("FollowerShop");
                });

            modelBuilder.Entity("Qizilim.az.Models.Entities.Membreship.QizilimRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("Roles", "Membership");
                });

            modelBuilder.Entity("Qizilim.az.Models.Entities.Membreship.QizilimRoleClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("RoleClaims", "Membership");
                });

            modelBuilder.Entity("Qizilim.az.Models.Entities.Membreship.QizilimUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<int>("FollowerCount")
                        .HasColumnType("int");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("ProfileImg")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<double?>("Wallet")
                        .HasColumnType("float");

                    b.Property<string>("aboutShop")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("catdirilma")
                        .HasColumnType("bit");

                    b.Property<string>("instagramLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("isPremium")
                        .HasColumnType("bit");

                    b.Property<string>("shopLocation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("shopName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("shopNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tiktokLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("whatsappNumber")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("Users", "Membership");
                });

            modelBuilder.Entity("Qizilim.az.Models.Entities.Membreship.QizilimUserClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserClaims", "Membership");
                });

            modelBuilder.Entity("Qizilim.az.Models.Entities.Membreship.QizilimUserLogin", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "ProviderKey");

                    b.ToTable("UserLogins", "Membership");
                });

            modelBuilder.Entity("Qizilim.az.Models.Entities.Membreship.QizilimUserRole", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRoles", "Membership");
                });

            modelBuilder.Entity("Qizilim.az.Models.Entities.Membreship.QizilimUserToken", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("UserTokens", "Membership");
                });

            modelBuilder.Entity("Qizilim.az.Models.Entities.ProductEyar", b =>
                {
                    b.Property<int>("EyarId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("EyarId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductEyar");
                });

            modelBuilder.Entity("Qizilim.az.Models.Entities.ProductKateqoriya", b =>
                {
                    b.Property<int>("KateqoriyaId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("KateqoriyaId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductKateqoriya");
                });

            modelBuilder.Entity("Qizilim.az.Models.Entities.Products", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("CountDiamond")
                        .HasColumnType("float");

                    b.Property<int?>("CreatedById")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DeletedById")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Delivery")
                        .HasColumnType("bit");

                    b.Property<bool>("HasDiamond")
                        .HasColumnType("bit");

                    b.Property<bool>("IreliCekilmisProduct")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("IreliEndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("IreliStartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Kateqoriya")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nov")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("PremiumEndDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("PremiumProduct")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("PremiumStartDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<double>("Weight")
                        .HasColumnType("float");

                    b.Property<string>("aboutProduct")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Qizilim.az.Models.Entities.Products+LikedProduct", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("ProductId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("LikedProducts");
                });

            modelBuilder.Entity("Qizilim.az.Models.Entities.Shops", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CenterId")
                        .HasColumnType("int");

                    b.Property<int?>("CreatedById")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DeletedById")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InstagramAccount")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Logo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TiktokAccount")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WhatsappNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CenterId");

                    b.ToTable("Shops");
                });

            modelBuilder.Entity("Qizilim.az.Models.Entities.Advertisement", b =>
                {
                    b.HasOne("Qizilim.az.Models.Entities.Membreship.QizilimUser", null)
                        .WithMany("Advertisements")
                        .HasForeignKey("QizilimUserId");
                });

            modelBuilder.Entity("Qizilim.az.Models.Entities.Color+ProductColors", b =>
                {
                    b.HasOne("Qizilim.az.Models.Entities.Color", "Color")
                        .WithMany("ProductColor")
                        .HasForeignKey("ColorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Qizilim.az.Models.Entities.Products", "Product")
                        .WithMany("ProductColor")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Color");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Qizilim.az.Models.Entities.Images+ProductImage", b =>
                {
                    b.HasOne("Qizilim.az.Models.Entities.Images", "Image")
                        .WithMany("ProductImages")
                        .HasForeignKey("ImageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Qizilim.az.Models.Entities.Products", "Product")
                        .WithMany("ProductImages")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Image");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Qizilim.az.Models.Entities.Membreship.FollowUser", b =>
                {
                    b.HasOne("Qizilim.az.Models.Entities.Membreship.Follow", "Follower")
                        .WithMany("FollowUser")
                        .HasForeignKey("FollowerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Qizilim.az.Models.Entities.Membreship.QizilimUser", "User")
                        .WithMany("FollowUser")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Follower");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Qizilim.az.Models.Entities.Membreship.FollowersShops", b =>
                {
                    b.HasOne("Qizilim.az.Models.Entities.Membreship.QizilimUser", "Follower")
                        .WithMany("FollowerShops")
                        .HasForeignKey("FollowerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Follower");
                });

            modelBuilder.Entity("Qizilim.az.Models.Entities.Membreship.QizilimRoleClaim", b =>
                {
                    b.HasOne("Qizilim.az.Models.Entities.Membreship.QizilimRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Qizilim.az.Models.Entities.Membreship.QizilimUserClaim", b =>
                {
                    b.HasOne("Qizilim.az.Models.Entities.Membreship.QizilimUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Qizilim.az.Models.Entities.Membreship.QizilimUserLogin", b =>
                {
                    b.HasOne("Qizilim.az.Models.Entities.Membreship.QizilimUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Qizilim.az.Models.Entities.Membreship.QizilimUserRole", b =>
                {
                    b.HasOne("Qizilim.az.Models.Entities.Membreship.QizilimRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Qizilim.az.Models.Entities.Membreship.QizilimUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Qizilim.az.Models.Entities.Membreship.QizilimUserToken", b =>
                {
                    b.HasOne("Qizilim.az.Models.Entities.Membreship.QizilimUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Qizilim.az.Models.Entities.ProductEyar", b =>
                {
                    b.HasOne("Qizilim.az.Models.Entities.Eyar", "Eyar")
                        .WithMany("ProductEyar")
                        .HasForeignKey("EyarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Qizilim.az.Models.Entities.Products", "Product")
                        .WithMany("ProductEyar")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Eyar");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Qizilim.az.Models.Entities.ProductKateqoriya", b =>
                {
                    b.HasOne("Qizilim.az.Models.Entities.Kateqoriya", "Kateqoriya")
                        .WithMany("ProductKateqoriya")
                        .HasForeignKey("KateqoriyaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Qizilim.az.Models.Entities.Products", "Product")
                        .WithMany("ProductKateqoriya")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kateqoriya");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Qizilim.az.Models.Entities.Products+LikedProduct", b =>
                {
                    b.HasOne("Qizilim.az.Models.Entities.Products", "Product")
                        .WithMany("LikedProducts")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Qizilim.az.Models.Entities.Membreship.QizilimUser", "User")
                        .WithMany("LikedProducts")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Qizilim.az.Models.Entities.Shops", b =>
                {
                    b.HasOne("Qizilim.az.Models.Entities.Centers", "Center")
                        .WithMany("Shop")
                        .HasForeignKey("CenterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Center");
                });

            modelBuilder.Entity("Qizilim.az.Models.Entities.Centers", b =>
                {
                    b.Navigation("Shop");
                });

            modelBuilder.Entity("Qizilim.az.Models.Entities.Color", b =>
                {
                    b.Navigation("ProductColor");
                });

            modelBuilder.Entity("Qizilim.az.Models.Entities.Eyar", b =>
                {
                    b.Navigation("ProductEyar");
                });

            modelBuilder.Entity("Qizilim.az.Models.Entities.Images", b =>
                {
                    b.Navigation("ProductImages");
                });

            modelBuilder.Entity("Qizilim.az.Models.Entities.Kateqoriya", b =>
                {
                    b.Navigation("ProductKateqoriya");
                });

            modelBuilder.Entity("Qizilim.az.Models.Entities.Membreship.Follow", b =>
                {
                    b.Navigation("FollowUser");
                });

            modelBuilder.Entity("Qizilim.az.Models.Entities.Membreship.QizilimUser", b =>
                {
                    b.Navigation("Advertisements");

                    b.Navigation("FollowerShops");

                    b.Navigation("FollowUser");

                    b.Navigation("LikedProducts");
                });

            modelBuilder.Entity("Qizilim.az.Models.Entities.Products", b =>
                {
                    b.Navigation("LikedProducts");

                    b.Navigation("ProductColor");

                    b.Navigation("ProductEyar");

                    b.Navigation("ProductImages");

                    b.Navigation("ProductKateqoriya");
                });
#pragma warning restore 612, 618
        }
    }
}

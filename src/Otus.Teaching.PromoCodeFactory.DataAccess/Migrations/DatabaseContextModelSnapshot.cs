﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Otus.Teaching.PromoCodeFactory.DataAccess;

#nullable disable

namespace Otus.Teaching.PromoCodeFactory.DataAccess.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true);

            modelBuilder.Entity("Otus.Teaching.PromoCodeFactory.Core.Domain.Administration.Employee", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasColumnName("id");

                    b.Property<int>("AppliedPromocodesCount")
                        .HasColumnType("INTEGER")
                        .HasColumnName("applied_promocodes_count");

                    b.Property<string>("Email")
                        .HasMaxLength(12)
                        .HasColumnType("TEXT")
                        .HasColumnName("email");

                    b.Property<string>("FirstName")
                        .HasMaxLength(12)
                        .HasColumnType("TEXT")
                        .HasColumnName("first_name");

                    b.Property<string>("LastName")
                        .HasMaxLength(12)
                        .HasColumnType("TEXT")
                        .HasColumnName("last_name");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("TEXT")
                        .HasColumnName("role_id");

                    b.HasKey("Id")
                        .HasName("pk_employees");

                    b.HasIndex("RoleId")
                        .IsUnique()
                        .HasDatabaseName("ix_employees_role_id");

                    b.ToTable("employees", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("451533d5-d8d5-4a11-9c7b-eb9f14e1a32f"),
                            AppliedPromocodesCount = 5,
                            Email = "owner@somemail.ru",
                            FirstName = "Иван",
                            LastName = "Сергеев",
                            RoleId = new Guid("53729686-a368-4eeb-8bfa-cc69b6050d02")
                        },
                        new
                        {
                            Id = new Guid("f766e2bf-340a-46ea-bff3-f1700b435895"),
                            AppliedPromocodesCount = 10,
                            Email = "andreev@somemail.ru",
                            FirstName = "Петр",
                            LastName = "Андреев",
                            RoleId = new Guid("b0ae7aac-5493-45cd-ad16-87426a5e7665")
                        });
                });

            modelBuilder.Entity("Otus.Teaching.PromoCodeFactory.Core.Domain.Administration.Role", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasColumnName("id");

                    b.Property<string>("Description")
                        .HasMaxLength(12)
                        .HasColumnType("TEXT")
                        .HasColumnName("description");

                    b.Property<string>("Name")
                        .HasMaxLength(12)
                        .HasColumnType("TEXT")
                        .HasColumnName("name");

                    b.HasKey("Id")
                        .HasName("pk_roles");

                    b.ToTable("roles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("53729686-a368-4eeb-8bfa-cc69b6050d02"),
                            Description = "Администратор",
                            Name = "Admin"
                        },
                        new
                        {
                            Id = new Guid("b0ae7aac-5493-45cd-ad16-87426a5e7665"),
                            Description = "Партнерский менеджер",
                            Name = "PartnerManager"
                        });
                });

            modelBuilder.Entity("Otus.Teaching.PromoCodeFactory.Core.Domain.PromoCodeManagement.Customer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasColumnName("id");

                    b.Property<string>("Email")
                        .HasMaxLength(12)
                        .HasColumnType("TEXT")
                        .HasColumnName("email");

                    b.Property<string>("FirstName")
                        .HasMaxLength(12)
                        .HasColumnType("TEXT")
                        .HasColumnName("first_name");

                    b.Property<string>("LastName")
                        .HasMaxLength(12)
                        .HasColumnType("TEXT")
                        .HasColumnName("last_name");

                    b.HasKey("Id")
                        .HasName("pk_customers");

                    b.ToTable("customers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("a6c8c6b1-4349-45b0-ab31-244740aaf0f0"),
                            Email = "ivan_sergeev@mail.ru",
                            FirstName = "Иван",
                            LastName = "Петров"
                        });
                });

            modelBuilder.Entity("Otus.Teaching.PromoCodeFactory.Core.Domain.PromoCodeManagement.CustomerPreference", b =>
                {
                    b.Property<Guid>("CustomerId")
                        .HasColumnType("TEXT")
                        .HasColumnName("customer_id");

                    b.Property<Guid>("PreferenceId")
                        .HasColumnType("TEXT")
                        .HasColumnName("preference_id");

                    b.HasKey("CustomerId", "PreferenceId")
                        .HasName("pk_customer_preferences");

                    b.HasIndex("PreferenceId")
                        .HasDatabaseName("ix_customer_preferences_preference_id");

                    b.ToTable("customer_preferences", (string)null);

                    b.HasData(
                        new
                        {
                            CustomerId = new Guid("a6c8c6b1-4349-45b0-ab31-244740aaf0f0"),
                            PreferenceId = new Guid("ef7f299f-92d7-459f-896e-078ed53ef99c")
                        },
                        new
                        {
                            CustomerId = new Guid("a6c8c6b1-4349-45b0-ab31-244740aaf0f0"),
                            PreferenceId = new Guid("c4bda62e-fc74-4256-a956-4760b3858cbd")
                        },
                        new
                        {
                            CustomerId = new Guid("a6c8c6b1-4349-45b0-ab31-244740aaf0f0"),
                            PreferenceId = new Guid("76324c47-68d2-472d-abb8-33cfa8cc0c84")
                        });
                });

            modelBuilder.Entity("Otus.Teaching.PromoCodeFactory.Core.Domain.PromoCodeManagement.Preference", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasColumnName("id");

                    b.Property<string>("Name")
                        .HasMaxLength(12)
                        .HasColumnType("TEXT")
                        .HasColumnName("name");

                    b.HasKey("Id")
                        .HasName("pk_preferences");

                    b.ToTable("preferences", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("ef7f299f-92d7-459f-896e-078ed53ef99c"),
                            Name = "Театр"
                        },
                        new
                        {
                            Id = new Guid("c4bda62e-fc74-4256-a956-4760b3858cbd"),
                            Name = "Семья"
                        },
                        new
                        {
                            Id = new Guid("76324c47-68d2-472d-abb8-33cfa8cc0c84"),
                            Name = "Дети"
                        });
                });

            modelBuilder.Entity("Otus.Teaching.PromoCodeFactory.Core.Domain.PromoCodeManagement.PromoCode", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasColumnName("id");

                    b.Property<DateTime?>("BeginDate")
                        .HasColumnType("TEXT")
                        .HasColumnName("begin_date");

                    b.Property<string>("Code1")
                        .HasMaxLength(12)
                        .HasColumnType("TEXT")
                        .HasColumnName("code1");

                    b.Property<Guid?>("CustomerId")
                        .HasColumnType("TEXT")
                        .HasColumnName("customer_id");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("TEXT")
                        .HasColumnName("end_date");

                    b.Property<Guid?>("PartnerManagerId")
                        .HasColumnType("TEXT")
                        .HasColumnName("partner_manager_id");

                    b.Property<string>("PartnerName")
                        .HasMaxLength(12)
                        .HasColumnType("TEXT")
                        .HasColumnName("partner_name");

                    b.Property<Guid?>("PreferenceId")
                        .HasColumnType("TEXT")
                        .HasColumnName("preference_id");

                    b.Property<string>("ServiceInfo")
                        .HasMaxLength(12)
                        .HasColumnType("TEXT")
                        .HasColumnName("service_info");

                    b.HasKey("Id")
                        .HasName("pk_promo_code");

                    b.HasIndex("CustomerId")
                        .HasDatabaseName("ix_promo_code_customer_id");

                    b.HasIndex("PartnerManagerId")
                        .HasDatabaseName("ix_promo_code_partner_manager_id");

                    b.HasIndex("PreferenceId")
                        .IsUnique()
                        .HasDatabaseName("ix_promo_code_preference_id");

                    b.ToTable("promo_code", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("2d5c0b24-0f61-4ae3-ad2a-e0ded5153d09"),
                            BeginDate = new DateTime(2024, 4, 20, 16, 31, 32, 283, DateTimeKind.Local).AddTicks(3996),
                            Code1 = "OSEN2024",
                            CustomerId = new Guid("a6c8c6b1-4349-45b0-ab31-244740aaf0f0"),
                            EndDate = new DateTime(2024, 4, 21, 16, 31, 32, 283, DateTimeKind.Local).AddTicks(4009),
                            PartnerManagerId = new Guid("451533d5-d8d5-4a11-9c7b-eb9f14e1a32f"),
                            PartnerName = "Рога и Копыта",
                            PreferenceId = new Guid("ef7f299f-92d7-459f-896e-078ed53ef99c"),
                            ServiceInfo = "Сервисная информация1"
                        },
                        new
                        {
                            Id = new Guid("33867eef-321b-4b88-a4e6-e57f77e3e57a"),
                            BeginDate = new DateTime(2024, 4, 19, 16, 31, 32, 283, DateTimeKind.Local).AddTicks(4022),
                            Code1 = "LETO2024",
                            CustomerId = new Guid("a6c8c6b1-4349-45b0-ab31-244740aaf0f0"),
                            EndDate = new DateTime(2024, 4, 22, 16, 31, 32, 283, DateTimeKind.Local).AddTicks(4023),
                            PartnerManagerId = new Guid("451533d5-d8d5-4a11-9c7b-eb9f14e1a32f"),
                            PartnerName = "Домик в Деревне",
                            PreferenceId = new Guid("c4bda62e-fc74-4256-a956-4760b3858cbd"),
                            ServiceInfo = "Сервисная информация2"
                        },
                        new
                        {
                            Id = new Guid("fd49d9a9-609f-4376-bfb4-14b157aae3a9"),
                            BeginDate = new DateTime(2024, 4, 17, 16, 31, 32, 283, DateTimeKind.Local).AddTicks(4029),
                            Code1 = "ZIMA2024",
                            CustomerId = new Guid("a6c8c6b1-4349-45b0-ab31-244740aaf0f0"),
                            EndDate = new DateTime(2024, 4, 24, 16, 31, 32, 283, DateTimeKind.Local).AddTicks(4030),
                            PartnerManagerId = new Guid("f766e2bf-340a-46ea-bff3-f1700b435895"),
                            PartnerName = "Интел",
                            ServiceInfo = "Сервисная информация3"
                        });
                });

            modelBuilder.Entity("Otus.Teaching.PromoCodeFactory.Core.Domain.Administration.Employee", b =>
                {
                    b.HasOne("Otus.Teaching.PromoCodeFactory.Core.Domain.Administration.Role", "Role")
                        .WithOne()
                        .HasForeignKey("Otus.Teaching.PromoCodeFactory.Core.Domain.Administration.Employee", "RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_employees_roles_role_id");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("Otus.Teaching.PromoCodeFactory.Core.Domain.PromoCodeManagement.CustomerPreference", b =>
                {
                    b.HasOne("Otus.Teaching.PromoCodeFactory.Core.Domain.PromoCodeManagement.Customer", "Customer")
                        .WithMany("Preferences")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_customer_preferences_customers_customer_id");

                    b.HasOne("Otus.Teaching.PromoCodeFactory.Core.Domain.PromoCodeManagement.Preference", "Preference")
                        .WithMany()
                        .HasForeignKey("PreferenceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_customer_preferences_preferences_preference_id");

                    b.Navigation("Customer");

                    b.Navigation("Preference");
                });

            modelBuilder.Entity("Otus.Teaching.PromoCodeFactory.Core.Domain.PromoCodeManagement.PromoCode", b =>
                {
                    b.HasOne("Otus.Teaching.PromoCodeFactory.Core.Domain.PromoCodeManagement.Customer", "Customer")
                        .WithMany("PromoCodes")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .HasConstraintName("fk_promo_code_customers_customer_id");

                    b.HasOne("Otus.Teaching.PromoCodeFactory.Core.Domain.Administration.Employee", "PartnerManager")
                        .WithMany("PromoCodes")
                        .HasForeignKey("PartnerManagerId")
                        .HasConstraintName("fk_promo_code_employees_partner_manager_id");

                    b.HasOne("Otus.Teaching.PromoCodeFactory.Core.Domain.PromoCodeManagement.Preference", "Preference")
                        .WithOne()
                        .HasForeignKey("Otus.Teaching.PromoCodeFactory.Core.Domain.PromoCodeManagement.PromoCode", "PreferenceId")
                        .HasConstraintName("fk_promo_code_preferences_preference_id");

                    b.Navigation("Customer");

                    b.Navigation("PartnerManager");

                    b.Navigation("Preference");
                });

            modelBuilder.Entity("Otus.Teaching.PromoCodeFactory.Core.Domain.Administration.Employee", b =>
                {
                    b.Navigation("PromoCodes");
                });

            modelBuilder.Entity("Otus.Teaching.PromoCodeFactory.Core.Domain.PromoCodeManagement.Customer", b =>
                {
                    b.Navigation("Preferences");

                    b.Navigation("PromoCodes");
                });
#pragma warning restore 612, 618
        }
    }
}

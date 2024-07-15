﻿// <auto-generated />
using System;
using JobLeet.WebApi.JobLeet.Infrastructure.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace JobLeet.WebApi.Migrations
{
    [DbContext(typeof(BaseDBContext))]
    partial class BaseDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("JobLeet.WebApi.JobLeet.Core.Entities.Accounts.V1.LoginUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("loginuser_id");

                    b.Property<bool>("AccountCreated")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("loginuser_accountcreated");

                    b.Property<int>("AccountStatus")
                        .HasColumnType("int")
                        .HasColumnName("loginuser_accountstatus");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("loginuser_address");

                    b.Property<string>("IPAddress")
                        .HasColumnType("longtext")
                        .HasColumnName("loginuser_ipaddress");

                    b.Property<DateTime>("LoginTime")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("loginuser_logintime");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(101)
                        .HasColumnType("varchar(101)")
                        .HasColumnName("loginuser_password");

                    b.Property<int>("Role")
                        .HasColumnType("int")
                        .HasColumnName("loginuser_role");

                    b.HasKey("Id");

                    b.ToTable("jblt_loginuser", (string)null);
                });

            modelBuilder.Entity("JobLeet.WebApi.JobLeet.Core.Entities.Accounts.V1.RegisterUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("jblt_registerid");

                    b.Property<string>("ConfirmPassword")
                        .IsRequired()
                        .HasMaxLength(101)
                        .HasColumnType("varchar(101)")
                        .HasColumnName("jblt_confirmpassword");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(101)
                        .HasColumnType("varchar(101)")
                        .HasColumnName("jblt_password");

                    b.Property<int>("PersonNameId")
                        .HasColumnType("int");

                    b.Property<string>("Salt")
                        .HasColumnType("longtext");

                    b.Property<int>("UserEmailId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PersonNameId");

                    b.HasIndex("UserEmailId");

                    b.ToTable("jblt_registerUser", (string)null);
                });

            modelBuilder.Entity("JobLeet.WebApi.JobLeet.Core.Entities.Accounts.V1.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("role_roleid");

                    b.Property<int>("RoleName")
                        .HasColumnType("int")
                        .HasColumnName("role_name");

                    b.HasKey("Id");

                    b.ToTable("jblt_role", (string)null);
                });

            modelBuilder.Entity("JobLeet.WebApi.JobLeet.Core.Entities.Common.V1.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("address_id");

                    b.Property<string>("City")
                        .HasColumnType("longtext")
                        .HasColumnName("address_city");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("address_country");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("address_postalCode");

                    b.Property<string>("State")
                        .HasColumnType("longtext")
                        .HasColumnName("address_state");

                    b.Property<string>("Street")
                        .HasColumnType("longtext")
                        .HasColumnName("address_street");

                    b.HasKey("Id");

                    b.ToTable("jblt_userAddress", (string)null);
                });

            modelBuilder.Entity("JobLeet.WebApi.JobLeet.Core.Entities.Common.V1.Education", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("education_id");

                    b.Property<decimal>("Cgpa")
                        .HasColumnType("decimal(65,30)")
                        .HasColumnName("education_cgpa");

                    b.Property<string>("Degree")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("education_degree");

                    b.Property<DateOnly>("GraduationDate")
                        .HasColumnType("date")
                        .HasColumnName("education_graduationdate");

                    b.Property<string>("Institution")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("education_nstitution");

                    b.Property<string>("Major")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("education_major");

                    b.HasKey("Id");

                    b.ToTable("jblt_education", (string)null);
                });

            modelBuilder.Entity("JobLeet.WebApi.JobLeet.Core.Entities.Common.V1.Email", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("email_id");

                    b.Property<string>("EmailAddress")
                        .HasColumnType("longtext")
                        .HasColumnName("email_address");

                    b.Property<int>("EmailType")
                        .HasColumnType("int")
                        .HasColumnName("email_type");

                    b.HasKey("Id");

                    b.ToTable("jblt_email", (string)null);
                });

            modelBuilder.Entity("JobLeet.WebApi.JobLeet.Core.Entities.Common.V1.Experience", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("experience_id");

                    b.Property<int>("ExperienceLevel")
                        .HasColumnType("int")
                        .HasColumnName("experience_type");

                    b.HasKey("Id");

                    b.ToTable("jblt_experience", (string)null);
                });

            modelBuilder.Entity("JobLeet.WebApi.JobLeet.Core.Entities.Common.V1.PersonName", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("personname_id");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("personName_firstname");

                    b.Property<string>("LastName")
                        .HasColumnType("longtext")
                        .HasColumnName("personName_lastname");

                    b.Property<string>("MiddleName")
                        .HasColumnType("longtext")
                        .HasColumnName("personName_middlename");

                    b.HasKey("Id");

                    b.ToTable("jblt_personName", (string)null);
                });

            modelBuilder.Entity("JobLeet.WebApi.JobLeet.Core.Entities.Common.V1.Phone", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("jblt_phoneid");

                    b.Property<int>("CountryCode")
                        .HasColumnType("int")
                        .HasColumnName("jblt_countrycode");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("jblt_phonenumber");

                    b.HasKey("Id");

                    b.ToTable("jblt_phone", (string)null);
                });

            modelBuilder.Entity("JobLeet.WebApi.JobLeet.Core.Entities.Common.V1.Qualification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("qualification_id");

                    b.Property<string>("QualificationInformation")
                        .HasColumnType("longtext")
                        .HasColumnName("qualification_information");

                    b.Property<int>("QualificationType")
                        .HasColumnType("int")
                        .HasColumnName("qualification_type");

                    b.HasKey("Id");

                    b.ToTable("jblt_qualification", (string)null);
                });

            modelBuilder.Entity("JobLeet.WebApi.JobLeet.Core.Entities.Common.V1.Skill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("skill_id");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("skill_description");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("skill_title");

                    b.HasKey("Id");

                    b.ToTable("jblt_skill", (string)null);
                });

            modelBuilder.Entity("JobLeet.WebApi.JobLeet.Core.Entities.Accounts.V1.LoginUser", b =>
                {
                    b.OwnsOne("JobLeet.WebApi.JobLeet.Core.Entities.Common.V1.MetaData", "MetaData", b1 =>
                        {
                            b1.Property<int>("LoginUserId")
                                .HasColumnType("int");

                            b1.HasKey("LoginUserId");

                            b1.ToTable("jblt_loginuser");

                            b1.WithOwner()
                                .HasForeignKey("LoginUserId");
                        });

                    b.Navigation("MetaData")
                        .IsRequired();
                });

            modelBuilder.Entity("JobLeet.WebApi.JobLeet.Core.Entities.Accounts.V1.RegisterUser", b =>
                {
                    b.HasOne("JobLeet.WebApi.JobLeet.Core.Entities.Common.V1.PersonName", "PersonName")
                        .WithMany()
                        .HasForeignKey("PersonNameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("JobLeet.WebApi.JobLeet.Core.Entities.Common.V1.Email", "UserEmail")
                        .WithMany()
                        .HasForeignKey("UserEmailId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.OwnsOne("JobLeet.WebApi.JobLeet.Core.Entities.Common.V1.MetaData", "MetaData", b1 =>
                        {
                            b1.Property<int>("RegisterUserId")
                                .HasColumnType("int");

                            b1.HasKey("RegisterUserId");

                            b1.ToTable("jblt_registerUser");

                            b1.WithOwner()
                                .HasForeignKey("RegisterUserId");
                        });

                    b.Navigation("MetaData")
                        .IsRequired();

                    b.Navigation("PersonName");

                    b.Navigation("UserEmail");
                });

            modelBuilder.Entity("JobLeet.WebApi.JobLeet.Core.Entities.Accounts.V1.Role", b =>
                {
                    b.OwnsOne("JobLeet.WebApi.JobLeet.Core.Entities.Common.V1.MetaData", "MetaData", b1 =>
                        {
                            b1.Property<int>("RoleId")
                                .HasColumnType("int");

                            b1.HasKey("RoleId");

                            b1.ToTable("jblt_role");

                            b1.WithOwner()
                                .HasForeignKey("RoleId");
                        });

                    b.Navigation("MetaData")
                        .IsRequired();
                });

            modelBuilder.Entity("JobLeet.WebApi.JobLeet.Core.Entities.Common.V1.Education", b =>
                {
                    b.OwnsOne("JobLeet.WebApi.JobLeet.Core.Entities.Common.V1.MetaData", "MetaData", b1 =>
                        {
                            b1.Property<int>("EducationId")
                                .HasColumnType("int");

                            b1.HasKey("EducationId");

                            b1.ToTable("jblt_education");

                            b1.WithOwner()
                                .HasForeignKey("EducationId");
                        });

                    b.Navigation("MetaData")
                        .IsRequired();
                });

            modelBuilder.Entity("JobLeet.WebApi.JobLeet.Core.Entities.Common.V1.Experience", b =>
                {
                    b.OwnsOne("JobLeet.WebApi.JobLeet.Core.Entities.Common.V1.MetaData", "MetaData", b1 =>
                        {
                            b1.Property<int>("ExperienceId")
                                .HasColumnType("int");

                            b1.HasKey("ExperienceId");

                            b1.ToTable("jblt_experience");

                            b1.WithOwner()
                                .HasForeignKey("ExperienceId");
                        });

                    b.Navigation("MetaData")
                        .IsRequired();
                });

            modelBuilder.Entity("JobLeet.WebApi.JobLeet.Core.Entities.Common.V1.Phone", b =>
                {
                    b.OwnsOne("JobLeet.WebApi.JobLeet.Core.Entities.Common.V1.MetaData", "MetaData", b1 =>
                        {
                            b1.Property<int>("PhoneId")
                                .HasColumnType("int");

                            b1.HasKey("PhoneId");

                            b1.ToTable("jblt_phone");

                            b1.WithOwner()
                                .HasForeignKey("PhoneId");
                        });

                    b.Navigation("MetaData")
                        .IsRequired();
                });

            modelBuilder.Entity("JobLeet.WebApi.JobLeet.Core.Entities.Common.V1.Qualification", b =>
                {
                    b.OwnsOne("JobLeet.WebApi.JobLeet.Core.Entities.Common.V1.MetaData", "MetaData", b1 =>
                        {
                            b1.Property<int>("QualificationId")
                                .HasColumnType("int");

                            b1.HasKey("QualificationId");

                            b1.ToTable("jblt_qualification");

                            b1.WithOwner()
                                .HasForeignKey("QualificationId");
                        });

                    b.Navigation("MetaData")
                        .IsRequired();
                });

            modelBuilder.Entity("JobLeet.WebApi.JobLeet.Core.Entities.Common.V1.Skill", b =>
                {
                    b.OwnsOne("JobLeet.WebApi.JobLeet.Core.Entities.Common.V1.MetaData", "MetaData", b1 =>
                        {
                            b1.Property<int>("SkillId")
                                .HasColumnType("int");

                            b1.HasKey("SkillId");

                            b1.ToTable("jblt_skill");

                            b1.WithOwner()
                                .HasForeignKey("SkillId");
                        });

                    b.Navigation("MetaData")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}

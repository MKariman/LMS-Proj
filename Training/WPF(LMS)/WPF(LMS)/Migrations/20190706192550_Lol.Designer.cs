﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WPF_LMS_.BackEnd;

namespace WPF_LMS_.Migrations
{
    [DbContext(typeof(DB_Proj))]
    [Migration("20190706192550_Lol")]
    partial class Lol
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WPF_LMS_.BackEnd.MajorsLessons", b =>
                {
                    b.Property<int>("MajorId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Lesson");

                    b.Property<string>("Major");

                    b.Property<string>("Type");

                    b.Property<int>("Unit");

                    b.HasKey("MajorId");

                    b.ToTable("Lessons");
                });

            modelBuilder.Entity("WPF_LMS_.BackEnd.Marks.AllMarks", b =>
                {
                    b.Property<int>("AllMarksId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Adabiat");

                    b.Property<int?>("Andishe");

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("Major");

                    b.Property<int?>("Moadelat");

                    b.Property<int?>("Riazi1");

                    b.Property<int>("St_ModelsId");

                    b.HasKey("AllMarksId");

                    b.HasIndex("St_ModelsId");

                    b.ToTable("Marks");

                    b.HasDiscriminator<string>("Discriminator").HasValue("AllMarks");
                });

            modelBuilder.Entity("WPF_LMS_.BackEnd.Mg_Models", b =>
                {
                    b.Property<int>("Mg_ModelsId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age");

                    b.Property<int>("BirthDate");

                    b.Property<string>("Education");

                    b.Property<string>("Email");

                    b.Property<string>("LastName");

                    b.Property<int>("MeliCode");

                    b.Property<string>("Name");

                    b.Property<int>("OrgCode");

                    b.Property<string>("Password");

                    b.Property<int>("Phone");

                    b.Property<string>("Post");

                    b.HasKey("Mg_ModelsId");

                    b.ToTable("Mg_InfM");
                });

            modelBuilder.Entity("WPF_LMS_.BackEnd.St_Models", b =>
                {
                    b.Property<int>("St_ModelsId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age");

                    b.Property<int>("Birthdate");

                    b.Property<string>("Email");

                    b.Property<string>("LastName");

                    b.Property<string>("Major");

                    b.Property<int>("MeliCode");

                    b.Property<string>("Name");

                    b.Property<string>("Password");

                    b.Property<int>("Phone");

                    b.Property<int>("UniCode");

                    b.Property<int>("UniLog");

                    b.Property<int>("Vahedha");

                    b.HasKey("St_ModelsId");

                    b.ToTable("St_InfM");
                });

            modelBuilder.Entity("WPF_LMS_.BackEnd.Tch_Models", b =>
                {
                    b.Property<int>("Tch_ModelsId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age");

                    b.Property<int>("BirthDate");

                    b.Property<string>("Education");

                    b.Property<string>("Email");

                    b.Property<string>("LastName");

                    b.Property<int>("MeliCode");

                    b.Property<string>("Name");

                    b.Property<int>("OrgCode");

                    b.Property<string>("Password");

                    b.Property<int>("Phone");

                    b.Property<string>("TeachingLesson");

                    b.HasKey("Tch_ModelsId");

                    b.ToTable("Tch_InfM");
                });

            modelBuilder.Entity("WPF_LMS_.BackEnd.Marks.BarqM", b =>
                {
                    b.HasBaseType("WPF_LMS_.BackEnd.Marks.AllMarks");

                    b.Property<int?>("BCmos");

                    b.Property<int?>("BElectro");

                    b.Property<int?>("BMadar");

                    b.Property<int?>("BQodrat");

                    b.Property<int?>("BVLSI");

                    b.Property<int>("BarqMId");

                    b.HasDiscriminator().HasValue("BarqM");
                });

            modelBuilder.Entity("WPF_LMS_.BackEnd.Marks.CompM", b =>
                {
                    b.HasBaseType("WPF_LMS_.BackEnd.Marks.AllMarks");

                    b.Property<int?>("CDatabase");

                    b.Property<int?>("CGosaste");

                    b.Property<int?>("CInteligence");

                    b.Property<int?>("CManteqi");

                    b.Property<int?>("CProgramming");

                    b.Property<int>("CompMId");

                    b.HasDiscriminator().HasValue("CompM");
                });

            modelBuilder.Entity("WPF_LMS_.BackEnd.Marks.MechM", b =>
                {
                    b.HasBaseType("WPF_LMS_.BackEnd.Marks.AllMarks");

                    b.Property<int?>("MControl");

                    b.Property<int?>("MFizik");

                    b.Property<int?>("MMashin");

                    b.Property<int?>("MSayalat");

                    b.Property<int?>("MTermo");

                    b.Property<int>("MechMId");

                    b.HasDiscriminator().HasValue("MechM");
                });

            modelBuilder.Entity("WPF_LMS_.BackEnd.Marks.MemM", b =>
                {
                    b.HasBaseType("WPF_LMS_.BackEnd.Marks.AllMarks");

                    b.Property<int?>("MeDekor");

                    b.Property<int?>("MeFazas");

                    b.Property<int?>("MeNama");

                    b.Property<int?>("MeNaqshe");

                    b.Property<int?>("MeTarahi");

                    b.Property<int>("MemMId");

                    b.HasDiscriminator().HasValue("MemM");
                });

            modelBuilder.Entity("WPF_LMS_.BackEnd.Marks.OmranM", b =>
                {
                    b.HasBaseType("WPF_LMS_.BackEnd.Marks.AllMarks");

                    b.Property<int?>("OBotons");

                    b.Property<int?>("ODinamik");

                    b.Property<int?>("OMasaleh");

                    b.Property<int?>("ONaqshe");

                    b.Property<int?>("OStatik");

                    b.Property<int>("OmranMId");

                    b.HasDiscriminator().HasValue("OmranM");
                });

            modelBuilder.Entity("WPF_LMS_.BackEnd.Marks.ShimiM", b =>
                {
                    b.HasBaseType("WPF_LMS_.BackEnd.Marks.AllMarks");

                    b.Property<int?>("SHGaz");

                    b.Property<int?>("SHHararat");

                    b.Property<int?>("SHJerm");

                    b.Property<int?>("SHMavad");

                    b.Property<int?>("SHSinema");

                    b.Property<int>("ShimiMId");

                    b.HasDiscriminator().HasValue("ShimiM");
                });

            modelBuilder.Entity("WPF_LMS_.BackEnd.Marks.AllMarks", b =>
                {
                    b.HasOne("WPF_LMS_.BackEnd.St_Models", "St_Models")
                        .WithMany("AMarks")
                        .HasForeignKey("St_ModelsId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}

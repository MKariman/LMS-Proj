﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WPF_LMS_.BackEnd;

namespace WPF_LMS_.Migrations
{
    [DbContext(typeof(DB_Proj))]
    partial class DB_ProjModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WPF_LMS_.BackEnd.Mg_Models", b =>
                {
                    b.Property<int>("Mg_ModelsId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age");

                    b.Property<int>("BirthDate");

                    b.Property<string>("Email");

                    b.Property<string>("LastName");

                    b.Property<int>("MeliCode");

                    b.Property<string>("Name");

                    b.Property<int>("OrgCode");

                    b.Property<string>("Password");

                    b.Property<int>("Phone");

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

                    b.Property<string>("Email");

                    b.Property<string>("LastName");

                    b.Property<int>("MeliCode");

                    b.Property<string>("Name");

                    b.Property<int>("OrgCode");

                    b.Property<string>("Password");

                    b.Property<int>("Phone");

                    b.HasKey("Tch_ModelsId");

                    b.ToTable("Tch_InfM");
                });
#pragma warning restore 612, 618
        }
    }
}

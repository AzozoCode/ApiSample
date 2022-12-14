// <auto-generated />
using System;
using Library_Data.Data_Access;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Library_Data.Migrations
{
    [DbContext(typeof(LibraryDbContext))]
    [Migration("20211110134908_PasswordUserAddition")]
    partial class PasswordUserAddition
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Library_Data.Models.Admin", b =>
                {
                    b.Property<int>("AdminID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Contact")
                        .IsRequired()
                        .HasColumnType("varchar(15)");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("varchar(40)");

                    b.HasKey("AdminID");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("Library_Data.Models.Book", b =>
                {
                    b.Property<int>("BookID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<int>("CategoryID")
                        .HasColumnType("int");

                    b.Property<DateTime>("DatePublished")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.HasKey("BookID");

                    b.HasIndex("CategoryID");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("Library_Data.Models.BookCategory", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.HasKey("CategoryID");

                    b.ToTable("BookCategories");
                });

            modelBuilder.Entity("Library_Data.Models.BorrowRequests", b =>
                {
                    b.Property<int>("RequestID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Contact")
                        .IsRequired()
                        .HasColumnType("varchar(15)");

                    b.Property<DateTime>("DateRequested")
                        .HasColumnType("datetime2");

                    b.Property<int>("DepartmentID")
                        .HasColumnType("int");

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasColumnType("varchar(30)");

                    b.Property<int>("GradeID")
                        .HasColumnType("int");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Middlename")
                        .HasColumnType("varchar(30)");

                    b.Property<int?>("StaffID")
                        .HasColumnType("int");

                    b.Property<string>("StudentID")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("RequestID");

                    b.HasIndex("DepartmentID");

                    b.HasIndex("GradeID");

                    b.HasIndex("StaffID");

                    b.HasIndex("StudentID");

                    b.ToTable("BorrowRequests");
                });

            modelBuilder.Entity("Library_Data.Models.BorrowedBooks", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Contact")
                        .IsRequired()
                        .HasColumnType("varchar(15)");

                    b.Property<DateTime>("DateBorrowed")
                        .HasColumnType("datetime2");

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Middlename")
                        .HasColumnType("varchar(30)");

                    b.Property<int>("RequestID")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("RequestID");

                    b.ToTable("BorrowedBooks");
                });

            modelBuilder.Entity("Library_Data.Models.DeclinedRequests", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Contact")
                        .IsRequired()
                        .HasColumnType("varchar(15)");

                    b.Property<DateTime>("DateBorrowed")
                        .HasColumnType("datetime2");

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Middlename")
                        .HasColumnType("varchar(30)");

                    b.Property<int>("RequestID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("RequestID");

                    b.ToTable("DeclinedRequests");
                });

            modelBuilder.Entity("Library_Data.Models.Department", b =>
                {
                    b.Property<int>("DepartmentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Contact")
                        .IsRequired()
                        .HasColumnType("varchar(15)");

                    b.Property<string>("DepartmentName")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasColumnType("varchar(40)");

                    b.HasKey("DepartmentID");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("Library_Data.Models.Faculty", b =>
                {
                    b.Property<int>("FacultyID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Contact")
                        .IsRequired()
                        .HasColumnType("varchar(15)");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasColumnType("varchar(40)");

                    b.Property<string>("FacultyName")
                        .IsRequired()
                        .HasColumnType("varchar(5)");

                    b.HasKey("FacultyID");

                    b.ToTable("Faculties");
                });

            modelBuilder.Entity("Library_Data.Models.Grade", b =>
                {
                    b.Property<int>("GradeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("GradeName")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("GradeID");

                    b.ToTable("Grades");
                });

            modelBuilder.Entity("Library_Data.Models.Staff", b =>
                {
                    b.Property<int>("StaffID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Contact")
                        .IsRequired()
                        .HasColumnType("varchar(15)");

                    b.Property<int>("DepartmentID")
                        .HasColumnType("int");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasColumnType("varchar(40)");

                    b.Property<int>("FacultyID")
                        .HasColumnType("int");

                    b.Property<string>("StaffName")
                        .IsRequired()
                        .HasColumnType("varchar(40)");

                    b.HasKey("StaffID");

                    b.HasIndex("DepartmentID");

                    b.HasIndex("FacultyID");

                    b.ToTable("Staffs");
                });

            modelBuilder.Entity("Library_Data.Models.Student", b =>
                {
                    b.Property<string>("StudentID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Contact")
                        .IsRequired()
                        .HasColumnType("varchar(15)");

                    b.Property<int>("DepartmentID")
                        .HasColumnType("int");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasColumnType("varchar(40)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(40)");

                    b.HasKey("StudentID");

                    b.HasIndex("DepartmentID");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("Library_Data.Models.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Contact")
                        .IsRequired()
                        .HasColumnType("varchar(15)");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasColumnType("varchar(40)");

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasColumnType("varchar(30)");

                    b.Property<int>("GradeID")
                        .HasColumnType("int");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Middlename")
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<int>("StaffID")
                        .HasColumnType("int");

                    b.Property<string>("StudentID")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserID");

                    b.HasIndex("GradeID");

                    b.HasIndex("StaffID");

                    b.HasIndex("StudentID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Library_Data.Models.Book", b =>
                {
                    b.HasOne("Library_Data.Models.BookCategory", "Category")
                        .WithMany("Books")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Library_Data.Models.BorrowRequests", b =>
                {
                    b.HasOne("Library_Data.Models.Department", "Department")
                        .WithMany("Borrowers")
                        .HasForeignKey("DepartmentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Library_Data.Models.Grade", "Grade")
                        .WithMany("Borrowers")
                        .HasForeignKey("GradeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Library_Data.Models.Staff", null)
                        .WithMany("BorrowRequests")
                        .HasForeignKey("StaffID");

                    b.HasOne("Library_Data.Models.Student", "Student")
                        .WithMany("Borrowers")
                        .HasForeignKey("StudentID");

                    b.Navigation("Department");

                    b.Navigation("Grade");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("Library_Data.Models.BorrowedBooks", b =>
                {
                    b.HasOne("Library_Data.Models.BorrowRequests", "BorrowRequests")
                        .WithMany("BorrowedBooks")
                        .HasForeignKey("RequestID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BorrowRequests");
                });

            modelBuilder.Entity("Library_Data.Models.DeclinedRequests", b =>
                {
                    b.HasOne("Library_Data.Models.BorrowRequests", "BorrowRequests")
                        .WithMany("DeclinedRequests")
                        .HasForeignKey("RequestID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BorrowRequests");
                });

            modelBuilder.Entity("Library_Data.Models.Staff", b =>
                {
                    b.HasOne("Library_Data.Models.Department", "Department")
                        .WithMany("Staffs")
                        .HasForeignKey("DepartmentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Library_Data.Models.Faculty", "Faculty")
                        .WithMany("Staffs")
                        .HasForeignKey("FacultyID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");

                    b.Navigation("Faculty");
                });

            modelBuilder.Entity("Library_Data.Models.Student", b =>
                {
                    b.HasOne("Library_Data.Models.Department", "Department")
                        .WithMany("Students")
                        .HasForeignKey("DepartmentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("Library_Data.Models.User", b =>
                {
                    b.HasOne("Library_Data.Models.Grade", "Grade")
                        .WithMany("Users")
                        .HasForeignKey("GradeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Library_Data.Models.Staff", "Staff")
                        .WithMany("Users")
                        .HasForeignKey("StaffID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Library_Data.Models.Student", "Student")
                        .WithMany("Users")
                        .HasForeignKey("StudentID");

                    b.Navigation("Grade");

                    b.Navigation("Staff");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("Library_Data.Models.BookCategory", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("Library_Data.Models.BorrowRequests", b =>
                {
                    b.Navigation("BorrowedBooks");

                    b.Navigation("DeclinedRequests");
                });

            modelBuilder.Entity("Library_Data.Models.Department", b =>
                {
                    b.Navigation("Borrowers");

                    b.Navigation("Staffs");

                    b.Navigation("Students");
                });

            modelBuilder.Entity("Library_Data.Models.Faculty", b =>
                {
                    b.Navigation("Staffs");
                });

            modelBuilder.Entity("Library_Data.Models.Grade", b =>
                {
                    b.Navigation("Borrowers");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("Library_Data.Models.Staff", b =>
                {
                    b.Navigation("BorrowRequests");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("Library_Data.Models.Student", b =>
                {
                    b.Navigation("Borrowers");

                    b.Navigation("Users");
                });
#pragma warning restore 612, 618
        }
    }
}

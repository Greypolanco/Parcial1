// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Parcial1.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.2");

            modelBuilder.Entity("BooksG", b =>
                {
                    b.Property<int>("Idbook")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("prec")
                        .HasColumnType("INTEGER");

                    b.Property<string>("tittle")
                        .HasColumnType("TEXT");

                    b.HasKey("Idbook");

                    b.ToTable("book");
                });
#pragma warning restore 612, 618
        }
    }
}

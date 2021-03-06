// <auto-generated />
using System;
using DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccessLayer.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20210920104453_3")]
    partial class _3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EntityLayer.Concrete.Blog", b =>
                {
                    b.Property<int>("BlogID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BlogBaslik")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("BlogDurum")
                        .HasColumnType("bit");

                    b.Property<string>("BlogIcerik")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BlogKucukResim")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("BlogOlusturmaTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("BlogResim")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("KategoriID")
                        .HasColumnType("int");

                    b.HasKey("BlogID");

                    b.HasIndex("KategoriID");

                    b.ToTable("BlogVT");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Hakkinda", b =>
                {
                    b.Property<int>("HakkindaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("HakkindaDetay1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HakkindaDetay2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("HakkindaDurum")
                        .HasColumnType("bit");

                    b.Property<string>("HakkindaHaritaKonum")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HakkindaResim1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HakkindaResim2")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("HakkindaID");

                    b.ToTable("HakkindaVT");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Iletisim", b =>
                {
                    b.Property<int>("IletisimID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("IletisimBaslik")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IletisimDurum")
                        .HasColumnType("bit");

                    b.Property<string>("IletisimEposta")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IletisimKullaniciAdi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IletisimMesaj")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("IletisimTarihi")
                        .HasColumnType("datetime2");

                    b.HasKey("IletisimID");

                    b.ToTable("IletisimVT");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Kategori", b =>
                {
                    b.Property<int>("KategoriID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("KategoriAciklama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KategoriAdi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("KategoriDurum")
                        .HasColumnType("bit");

                    b.HasKey("KategoriID");

                    b.ToTable("KategoriVT");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Yazar", b =>
                {
                    b.Property<int>("YazarID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("YazarAdi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("YazarDurum")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("YazarEposta")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("YazarHakkinda")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("YazarResim")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("YazarSifre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("YazarID");

                    b.ToTable("YazarVT");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Yorum", b =>
                {
                    b.Property<int>("YorumID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BlogID")
                        .HasColumnType("int");

                    b.Property<string>("YorumBaslik")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("YorumDurum")
                        .HasColumnType("bit");

                    b.Property<string>("YorumIcerik")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("YorumKullaniciAdi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("YorumTarihi")
                        .HasColumnType("datetime2");

                    b.HasKey("YorumID");

                    b.HasIndex("BlogID");

                    b.ToTable("YorumVT");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Blog", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Kategori", "Kategori")
                        .WithMany("BlogVT")
                        .HasForeignKey("KategoriID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kategori");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Yorum", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Blog", "Blog")
                        .WithMany("YorumVT")
                        .HasForeignKey("BlogID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Blog");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Blog", b =>
                {
                    b.Navigation("YorumVT");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Kategori", b =>
                {
                    b.Navigation("BlogVT");
                });
#pragma warning restore 612, 618
        }
    }
}

using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Quiron.LojaVirtual.Dominio.Entidades;
using Quiron.LojaVirtual.Dominio.Entidades.Vitrine;

namespace Quiron.LojaVirtual.Dominio.Repositorio
{
    public class EfDbContext : DbContext
    {

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Administrador> Administradores { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<MarcaVitrine> MarcaVitrine { get; set; }
        public DbSet<ClubesNacionais> ClubesNacionais { get; set; }
        public DbSet<ClubesInternacionais> ClubesInternacionais { get; set; }
        public DbSet<FaixaEtaria> FaixasEtarias { get; set; }
        public DbSet<Genero> Generos { get; set; }
        public DbSet<Grupo> Grupos { get; set; }
        public DbSet<Marca> Marcas { get; set; }
        public DbSet<Modalidade> Modalidades { get; set; }
        public DbSet<SubGrupo> SubGrupos { get; set; }
        public DbSet<ProdutoVitrine> ProdutoVitrine { get; set; }
        public DbSet<QuironProduto> QuironProdutos { get; set; }
        public DbSet<Cor> Cores { get; set; }
        public DbSet<Tamanho> Tamanhos { get; set; }
        public DbSet<Estoque> Estoque { get; set; }
        public DbSet<ProdutoModelo> ProdutoModelo { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Entity<Produto>().ToTable("Produtos");
            modelBuilder.Entity<Administrador>().ToTable("Administradores");

        }

    }
}

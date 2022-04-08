using TP_Ecommerce.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
namespace TP_Ecommerce.DAL
{
    public class EcommerceContext : DbContext
    {
        public EcommerceContext() : base("EcommerceContext")
        {
        }
        public DbSet<Produit> produit { get; set; }
    public DbSet<Marque> marque { get; set; }
public DbSet<Categorie> categorie{ get; set; }
 }
}

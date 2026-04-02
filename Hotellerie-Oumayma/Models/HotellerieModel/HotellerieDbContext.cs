using Microsoft.EntityFrameworkCore;

namespace Hotellerie_Oumayma.Models.HotellerieModel
{
    public class HotellerieDbContext : DbContext
    {
        public HotellerieDbContext(DbContextOptions<HotellerieDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Hotel> Hotels { get; set; }

        // Ajouté V.5
        public virtual DbSet<Appreciation> Appreciations { get; set; }
    }
}
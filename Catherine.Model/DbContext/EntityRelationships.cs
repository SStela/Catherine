using Catherine.Model.Citizens;
using Catherine.Model.Citizenships;
using Catherine.Model.Countries;
using Microsoft.EntityFrameworkCore;

namespace Catherine.Model.DbContext
{
    public static class EntityRelationships
    {
        public static void SetRelationships(this ModelBuilder modelBuilder)
        {
            // many-to-many for citizenships
            // relationship is: country - citizenship - citizen
            modelBuilder.Entity<Citizenship>().HasKey(c => new { c.CitizenId, c.CountryId });

            modelBuilder.Entity<Citizenship>()
                .HasOne<Citizen>(sc => sc.Citizen)
                .WithMany(s => s.Citizenships)
                .HasForeignKey(sc => sc.CitizenId);


            modelBuilder.Entity<Citizenship>()
                .HasOne<Country>(sc => sc.Country)
                .WithMany(s => s.Citizenships)
                .HasForeignKey(sc => sc.CountryId);

            // unique key on vat number
            modelBuilder.Entity<Citizen>()
                .HasIndex(u => u.VatNumber)
                .IsUnique();

            // unique key on country name
            modelBuilder.Entity<Country>()
                .HasIndex(u => u.Name)
                .IsUnique();
        }
    }
}
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace JohanVanRobays.Models.Mapping
{
    public class JDCMap : EntityTypeConfiguration<JDC>
    {
        public JDCMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Url)
                .HasMaxLength(50);

            this.Property(t => t.Name)
                .IsFixedLength()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("JDC");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Url).HasColumnName("Url");
            this.Property(t => t.Name).HasColumnName("Name");
        }
    }
}

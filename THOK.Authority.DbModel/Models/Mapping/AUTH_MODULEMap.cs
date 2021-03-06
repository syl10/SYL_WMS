using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace THOK.Authority.DbModel.Mapping
{
    public class AUTH_MODULEMap : EntityTypeConfiguration<AUTH_MODULE>
    {
        public AUTH_MODULEMap()
        {
            // Primary Key
            this.HasKey(t => t.MODULE_ID);

            // Properties
            this.Property(t => t.MODULE_ID)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(36);

            this.Property(t => t.MODULE_NAME)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.MODULE_URL)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.INDICATE_IMAGE)
                .HasMaxLength(100);

            this.Property(t => t.DESK_TOP_IMAGE)
                .HasMaxLength(100);

            this.Property(t => t.SYSTEM_SYSTEM_ID)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(36);

            this.Property(t => t.PARENT_MODULE_MODULE_ID)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(36);

            // Table & Column Mappings
            this.ToTable("AUTH_MODULE", "THOK");
            this.Property(t => t.MODULE_ID).HasColumnName("MODULE_ID");
            this.Property(t => t.MODULE_NAME).HasColumnName("MODULE_NAME");
            this.Property(t => t.SHOW_ORDER).HasColumnName("SHOW_ORDER");
            this.Property(t => t.MODULE_URL).HasColumnName("MODULE_URL");
            this.Property(t => t.INDICATE_IMAGE).HasColumnName("INDICATE_IMAGE");
            this.Property(t => t.DESK_TOP_IMAGE).HasColumnName("DESK_TOP_IMAGE");
            this.Property(t => t.SYSTEM_SYSTEM_ID).HasColumnName("SYSTEM_SYSTEM_ID");
            this.Property(t => t.PARENT_MODULE_MODULE_ID).HasColumnName("PARENT_MODULE_MODULE_ID");
        }
    }
}

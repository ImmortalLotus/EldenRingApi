using EldenRing.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EldenRing.Infra.Mappings
{
    public class AmmoMapping : IEntityTypeConfiguration<Ammo>
    {
        public void Configure(EntityTypeBuilder<Ammo> builder)
        {
            builder.ToTable("ammo");
            builder.HasNoKey();
            builder.Property(x => x.Name).HasColumnName("name");
            builder.Property(x => x.Description).HasColumnName("description");
            builder.Property(x=>x.Image).HasColumnName("image");
            builder.Property(x => x.AttackPowerJson).HasColumnName("attackPower");
            builder.Property(x => x.Passive).HasColumnName("passive");
        }
    }
}

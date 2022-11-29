using AbpEcommerce.ProductAttributes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbpEcommerce.Configurations.ProductAttributes
{
    public class ProductAttributeConfiguration : IEntityTypeConfiguration<ProductAttribute>
    {
        public void Configure(EntityTypeBuilder<ProductAttribute> builder)
        {
            builder.ToTable(AbpEcommerceConsts.DbTablePrefix + "ProductAttributes");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Code)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsRequired();

            builder.Property(x => x.Label)
                .HasMaxLength(50)
                .IsRequired();
        }
    }
}
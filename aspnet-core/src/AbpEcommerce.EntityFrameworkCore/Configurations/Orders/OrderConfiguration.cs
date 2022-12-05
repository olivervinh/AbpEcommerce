﻿using AbpEcommerce.Orders;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbpEcommerce.Configurations.Orders
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable(AbpEcommerceConsts.DbTablePrefix + "Orders");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Code)
                 .HasMaxLength(50)
                 .IsUnicode(false)
                 .IsRequired();

            builder.Property(x => x.CustomerName)
              .HasMaxLength(50)
              .IsRequired();
            builder.Property(x => x.CustomerAddress)
              .HasMaxLength(250)
              .IsRequired();

            builder.Property(x => x.CustomerPhoneNumber)
              .HasMaxLength(50)
              .IsRequired();


        }
    }
}

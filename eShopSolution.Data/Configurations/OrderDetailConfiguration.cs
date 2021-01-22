using eShopSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Configurations
{
    public class OrderDetailConfiguration : IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            builder.ToTable("OrderDetials");
            builder.HasKey(x => new { x.OrderId, x.ProductId });
            builder.HasOne(x=>x.Order).WithMany(pc=>pc.OrderDetails).HasForeignKey(pc=>pc.OrderId);
            builder.HasOne(x => x.Product).WithMany(pc => pc.OrderDetails).HasForeignKey(pc => pc.ProductId);
        }
    }
}

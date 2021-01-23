using eShopSolution.Data.Entities;
using eShopSolution.Data.Enums;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppConfig>().HasData(
                new AppConfig() { 
                    Key = "HomeTitle", 
                    Value = "This is home page of eShopSolution" 
                },
                new AppConfig() { 
                    Key = "HomeKeyword", 
                    Value = "This is Keyword of eShopSolution" 
                },
                new AppConfig() { 
                    Key = "HomeDescription", 
                    Value = "This is Description of eShopSolution" 
                }
            );

            modelBuilder.Entity<Language>().HasData(
                new Language() {
                    Id = "vi-VN", 
                    Name="Tiếng Việt", 
                    IsDefault=true 
                },
                new Language() { 
                    Id = "en-US", 
                    Name = "English", 
                    IsDefault = false 
                }
            );

            modelBuilder.Entity<Category>().HasData(
                new Category() { 
                    Id=1,
                    IsShowOnHome = true, 
                    ParentId=null, 
                    SortOrder = 1, 
                    Status = Status.Active
                },
                new Category()
                {
                    Id=2,
                    IsShowOnHome = true,
                    ParentId = null,
                    SortOrder = 2,
                    Status = Status.Active
                }
            );

            modelBuilder.Entity<CategoryTranslation>().HasData(
                new CategoryTranslation()
                {
                    Id=1,
                    CategoryId=1,
                    Name = "Áo nam",
                    LanguageId = "vi-VN",
                    SeoAlias = "ao-nam",
                    SeoDescription = "Sản phẩm áo thời trang nam",
                    SeoTitle = "Sản phẩm áo thời trang nam"
                },
                new CategoryTranslation()
                {
                    Id = 2,
                    CategoryId =1,
                    Name = "Men shirt",
                    LanguageId = "en-US",
                    SeoAlias = "men-shirt",
                    SeoDescription = "The shirt product for men",
                    SeoTitle = "The shirt product for men"
                },
                new CategoryTranslation()
                {
                    Id = 3,
                    CategoryId =2,
                    Name = "Áo nữ",
                    LanguageId = "vi-VN",
                    SeoAlias = "ao-nu",
                    SeoDescription = "Sản phẩm áo thời trang nữ",
                    SeoTitle = "Sản phẩm áo thời trang nữ"
                },
                new CategoryTranslation()
                {
                    Id = 4,
                    CategoryId = 2,
                    Name = "Women shirt",
                    LanguageId = "en-US",
                    SeoAlias = "women-shirt",
                    SeoDescription = "The shirt product for women",
                    SeoTitle = "The shirt product for women"
                }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product() { 
                    Id=1,
                    DateCreated=DateTime.Now, 
                    OriginalPrice=100000, 
                    Price=200000, 
                    Stock=0,
                    ViewCount=0
                }
            );
            modelBuilder.Entity<ProductTranslation>().HasData(
                new ProductTranslation()
                {
                    Id=1,
                    ProductId=1,
                    Name = "Áo nam trăng Việt Tiến",
                    LanguageId = "vi-VN",
                    SeoAlias = "ao-nam-trang-viet-tien",
                    SeoDescription = "Áo nam trăng Việt Tiến",
                    SeoTitle = "Áo nam trăng Việt Tiến",
                    Details = "Áo nam trăng Việt Tiến",
                    Description = "Áo nam trăng Việt Tiến"
                },
                new ProductTranslation()
                {
                    Id = 2,
                    ProductId =1,
                    Name = "Viet Tien Men T-Shirt white",
                    LanguageId = "en-US",
                    SeoAlias = "viet-tien-men-shirt-white",
                    SeoDescription = "Viet Tien Men T-Shirt white",
                    SeoTitle = "Viet Tien Men T-Shirt white",
                    Details = "Viet Tien Men T-Shirt white",
                    Description = "Viet Tien Men T-Shirt white"
                }
            );
            modelBuilder.Entity<ProductInCategory>().HasData(
                new ProductInCategory()
                {
                    ProductId=1,
                    CategoryId = 1
                }
            );

            var roleId = new Guid("50B4F6C8-A041-42A6-A273-5C9FBBD15516");
            var adminId = new Guid("DCE43894-E786-4CB1-B67C-BB55EDA3B091");
            modelBuilder.Entity<AppRole>().HasData(
                new AppRole
                {
                    Id=roleId,
                    Name="admin",
                    NormalizedName="admin",
                    Description="Administrator role"
                }
            );

            var hasher = new PasswordHasher<AppUser>();
            modelBuilder.Entity<AppUser>().HasData(
                new AppUser
                {
                    Id=adminId,
                    UserName="admin",
                    NormalizedUserName="admin",
                    Email="locteo2016@gmail.com",
                    NormalizedEmail="locteo2016@gmail.com",
                    EmailConfirmed=true,
                    PasswordHash=hasher.HashPassword(null, "Abcd1234$"),
                    SecurityStamp=string.Empty,
                    FirstName="Nguyen",
                    LastName="Loc",
                    Dob=new DateTime(2020,01,31)
                }
            );
            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(
                new IdentityUserRole<Guid>
                {
                    RoleId=roleId,
                    UserId=adminId
                }
            );
        }

    }
}

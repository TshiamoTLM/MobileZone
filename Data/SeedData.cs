using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MobileZone.Models;
using System;
using System.Linq;

namespace MobileZone.Data
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            MobileDbContext context = app.ApplicationServices
                .CreateScope().ServiceProvider.GetRequiredService<MobileDbContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
            if (!context.Categories.Any())
            {
                context.Categories.AddRange(
                    new Category {CategoryName = "Tablet" },
                    new Category {CategoryName = "Smart phone" },
                    new Category {CategoryName = "Laptop computer" },
                    new Category {CategoryName = "Smart watch" },
                    new Category {CategoryName = "E-reader" });
            }
            context.SaveChanges();
            if (!context.Mobiles.Any())
            {
                context.Mobiles.AddRange(
                    new Mobile
                    {
                        Name = "New Microsoft Surface",
                        Price = 7786.90M,
                        Description = "Starting at just 1.2 pounds (not including Type Cover), with new 10.5” touchscreen. Battery life up to 10 hours.",
                        ManufactureDate = DateTime.Parse("2022-03-29"),
                        IsInStock = true,
                        CategoryId = 1
                    },
                    new Mobile
                    {
                        Name = "Samsung Galaxy Tab",
                        Price = 3689.95M,
                        Description = "Samsung Galaxy Tab S3 9.7-Inch, 32GB Tablet (Black, SM-T820NZKAXAR).",
                        ManufactureDate = DateTime.Parse("2021-12-29"),
                        IsInStock = false,
                        CategoryId = 1
                    },
                    new Mobile
                    {
                        Name = "Apple iPhone 13",
                        Price = 20499.95M,
                        Description = "Model is iPhone 13, 12MP Dual/Wide/Ultra Wide with an Operating System of iOS",
                        ManufactureDate = DateTime.Parse("2022-03-13"),
                        IsInStock = true,
                        CategoryId = 2

                    },
                    new Mobile
                    {
                        Name = "Samsung Galaxy S21",
                        Price = 20999.41M,
                        Description = "Samsung Galaxy S21 Ultra 5G (Dual Sim) 256GB Phantom Silver. Battery Li-Ion 5000 mAh, non-removable and storage 256GB 12GB RAM",
                        ManufactureDate = DateTime.Parse("2022-01-28"),
                        IsInStock = false,
                        CategoryId = 2
                    },
                    new Mobile
                    {
                        Name = "Dell Latitude",
                        Price = 18599.85M,
                        Description = "Dell Latitude 3520 15.6-inch Core i5-1145G7 8GB RAM 256GB SSD Win 10 Pro Laptop N024L352015EMEA",
                        ManufactureDate = DateTime.Parse("2021-12-01"),
                        IsInStock = true,
                        CategoryId = 3
                    },
                    new Mobile
                    {
                        Name = "Asus",
                        Price = 3295.15M,
                        Description = "AsusS Laptop 12 - Celeron N3350 - 4GB RAM - 64GB EMMC - INTEL GRAPHICS - 11.6 HD - W10H - BLUE - 1YR PUR",
                        ManufactureDate = DateTime.Parse("2022-01-29"),
                        IsInStock = true,
                        CategoryId = 3
                    },
                    new Mobile
                    {
                        Name = "LokMat Smart Watch",
                        Price = 3397.90M,
                        Description = "Lokmat Max Smart Watch 2.88 inch Smartwatch Fitness Running Watch 4G LTE Cellular Smartwatch Phone Bluetooth Pedometer Sleep Tracker",
                        ManufactureDate = DateTime.Parse("2022-01-01"),
                        IsInStock = true,
                        CategoryId = 4
                    },
                    new Mobile
                    {
                        Name = "Graphics Tablet",
                        Price = 1298.95M,
                        Description = "Graphics Tablet (Wired - 10 x 6 inch) Light and Compact Ideal, Sample Rate: 233 PPS USB InterfaceResolution: 5080 LPIActive Height : 15mm Built in DriverOS Support: Windows 10",
                        ManufactureDate = DateTime.Parse("2022-11-01"),
                        IsInStock = false,
                        CategoryId = 5
                    },
                    new Mobile
                    {
                        Name = "LCD Writing",
                        Price = 3045.95M,
                        Description = "Digital Electronic LCD Writing Drawing Tablet Board Pad eWriter for Kids 8.5 inch 10 inch",
                        ManufactureDate = DateTime.Parse("2018-04-01"),
                        IsInStock = false,
                        CategoryId = 1
                    },
                    new Mobile
                    {
                        Name = "iPhone 15",
                        Price = 7890.95M,
                        Description = "iPhone 15 is he most advanced dual-camera system ever on iPhone. Lightning-fast A15 Bionic chip.",
                        ManufactureDate = DateTime.Parse("2019-12-01"),
                        IsInStock = true,
                        CategoryId = 2
                    },
                    new Mobile
                    {
                        Name = "Alcatel 1T 73G",
                        Price = 1298.95M,
                        Description = "Alcatel 1T 73G 16Gb Vodacom Network Locked Tablet",
                        ManufactureDate = DateTime.Parse("2021-01-01"),
                        IsInStock = true,
                        CategoryId = 5
                    },
                    new Mobile
                    {
                        Name = "FocusFit",
                        Price = 6102.95M,
                        Description = "FocusFit Pro – H30 Smartwatch and Fitness Tracker Unleashing Your Potential.",
                        ManufactureDate = DateTime.Parse("2020-07-01"),
                        IsInStock = false,  
                        CategoryId = 4
                    });
            }
            context.SaveChanges();

        }

        
        
       

        public static async void CreateAdminUser(IApplicationBuilder app)
        {

             const string adminUser = "Admin";
             const string adminPassword = "Mobile123$";
             const string adminEmail = "admin@mobile.co.za";
             const string adminRole = "Admin";

          
            UserManager<IdentityUser> userManager = app.ApplicationServices
                .CreateScope().ServiceProvider
                .GetRequiredService<UserManager<IdentityUser>>();

            RoleManager<IdentityRole> roleManager = app.ApplicationServices
                .CreateScope().ServiceProvider
                .GetRequiredService<RoleManager<IdentityRole>>();

            if (await userManager.FindByNameAsync(adminUser) == null)
            {
                if (await roleManager.FindByNameAsync(adminRole) == null)
                {
                    await roleManager.CreateAsync(new IdentityRole(adminRole));
                }

                IdentityUser user = new IdentityUser
                {
                    UserName = adminUser,
                    Email = adminEmail
                };

                IdentityResult result = await userManager.CreateAsync(user, adminPassword);

                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(user, adminRole);
                }

            }
        }

    }
}


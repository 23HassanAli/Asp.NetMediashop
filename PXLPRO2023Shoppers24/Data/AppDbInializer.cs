using Microsoft.AspNetCore.Identity;
using PXLPRO2023Shoppers24.Data.Static;
using PXLPRO2023Shoppers24.Models;

namespace PXLPRO2023Shoppers24.Data
{
    public class AppDbInializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                //Cinema
                if (!context.Laptops.Any())
                {
                    context.Laptops.AddRange(new List<Laptop>()
                    {
                        new Laptop()
                        {
                            Name = "Probook 450 G9 i7-16GB-1TB Azerty",
                            Price = 1299,
                            Description = "You'll look very professional with the 15-inch HP ProBook 450 G9 i7-16GB-1TB business laptop. With the 12th generation Intel Core i7 processor and 16GB DDR5 RAM, you can smoothly edit large photo and video files in demanding Adobe programs. In the meantime, you can run other programs in the background as well. This way, you can work on your presentation or keep an eye on your numbers. After editing, your images render smoothly thanks to the NVIDIA GeForce MX570 video card. You can store your creations and other files on the 1TB SSD. This ProBook has Windows 10 Pro, so it's easy to remotely connect to office systems. That's useful if you often work in different locations. You can log in to this HP securely and quickly via the fingerprint sensor. This way, you can be sure that nobody else can access your files. Spilled something on your keyboard by accident? Don't worry, the laptop is spill-resistant.",
                            StockQuantity = 1,
                            ImageURL = "https://image.coolblue.be/max/500x500/products/1871696",
                            ProductCategory = Models.Enums.ProductCategory.Laptop,
                            Brand = "HP",
                            Color = "Silver",
                            Processor = "Intel Core i7",
                            ScreenSize = 15.6,
                            InternalRAM = 16,
                            TotalStorageCapacity = 1,
                            Touchscreen = false,
                            VideoCard = "Interl Iris Xe Graphics"

                        },
                        new Laptop()
                        {
                            Name = "HP 470 G9 i7-16GB-512GB Azerty",
                            Price = 1269,
                            Description = "The HP 470 G9 i7-16GB-512GB is a 17-inch laptop suitable for business use as well as photo and video editing. With the 12th generation Intel Core i7 processor and 16GB DDR4 RAM, you can edit large photo and video files while running other programs in the background. You don't have to worry about your privacy with this laptop. You can log in quickly and securely via the built-in fingerprint sensor. That means only you have access to the laptop. You can also easily connect to your office systems remotely, thanks to Windows 11 Pro.",
                            StockQuantity = 2,
                            ImageURL = "https://image.coolblue.be/max/500x500/products/1870420",
                            ProductCategory = Models.Enums.ProductCategory.Laptop,
                            Brand = "HP",
                            Color = "Silver",
                            Processor = "Intel Core i7",
                            ScreenSize = 17.3,
                            InternalRAM = 16,
                            TotalStorageCapacity = 512,
                            Touchscreen = false,
                            VideoCard = "Intel Iris Xe Graphics"
                        },
                           new Laptop()
                        {
                            Name = "Lenovo IdeaPad 3 15IAU7 82RK00JMMB Azerty",
                            Price = 899,
                            Description = "The Lenovo IdeaPad 3 15IAU7 82RK00JMMB is a 15-inch laptop powerful enough for video editing. With the 12th generation Intel Core i7 processor and 16GB DDR4 RAM, you can edit photos and videos and multitask with demanding programs. All your creations also render smoothly thanks to the Intel Iris Xe Graphics shared video card. Need more storage space for all your files? You can easily add an extra SSD or HDD to expand the storage of your laptop. With this Lenovo, you also enjoy clear sound thanks to the Dolby Audio speakers. After a video call, you can easily slide the webcam switch over your camera. This way, you don't have to worry about your privacy.\r\n\r\n",
                            StockQuantity = 3,
                            ImageURL = "https://image.coolblue.be/max/500x500/products/1864807",
                            ProductCategory = Models.Enums.ProductCategory.Laptop,
                            Brand = "Lenovo",
                            Color = "Silver",
                            Processor = "Intel Core i7",
                            ScreenSize = 15.6,
                            InternalRAM = 16,
                            TotalStorageCapacity = 512,
                            Touchscreen = false,
                            VideoCard = "Intel Iris Xe Graphics"
                        },
                              new Laptop()
                        {
                            Name = "HP ENVY x360 15-ew0009nb Azerty",
                            Price = 1299,
                            Description = "On the 15-inch HP ENVY x360 15-ew0009nb 2-in-1 laptop, you can edit photos and videos with Adobe Premiere Pro, and multitask with all your projects. The 12th generation Intel Core i7 processor and 16GB RAM are powerful enough to do this. Flip the touchscreen 360 degrees and use your fingers to easily swipe through web pages and photos. Is it time to render your material? Thanks to the Intel Iris Xe Graphics shared video card, this process is much smoother than with other shared video cards. In addition, you can store all your files on the internal 512GB SSD. During a long office day, you won't have to worry about the battery of your laptop. With HP Fast Charge, you can charge your laptop back up to 50% in about 45 minutes. So you can soon continue to work wirelessly.",
                            StockQuantity = 4,
                            ImageURL = "https://image.coolblue.be/max/500x500/products/1786078",
                            ProductCategory = Models.Enums.ProductCategory.Laptop,
                            Brand = "HP",
                            Color = "Silver",
                            Processor = "Intel Core i7",
                            ScreenSize = 15.6,
                            InternalRAM = 16,
                            TotalStorageCapacity = 512,
                            Touchscreen = false,
                            VideoCard = "Intel Iris Xe Graphics"
                        },
                                 new Laptop()
                        {
                            Name = "HP ProBook 450 G9 i5-8GB-512GB AZERTY",
                            Price = 1069,
                            Description = "You'll look very professional with the 15-inch HP ProBook 450 G9 i5-8GB-512GB business laptop. With the 12th generation Intel Core i5 processor and 8GB DDR4 RAM, you can edit photos in Adobe Photoshop. You don't have to worry about your privacy with this laptop. This ProBook has Windows 10 Pro, so it's easy to remotely connect to the office systems. That' useful if you often work in different locations. You can log in to this HP quickly and securely via the fingerprint sensor. This way, you can be sure that nobody else can access your files. Spilled something on your keyboard by accident? Don't worry, the laptop is spill-resistant.",
                            StockQuantity = 5,
                            ImageURL = "https://image.coolblue.be/max/500x500/products/1871695",
                            ProductCategory = Models.Enums.ProductCategory.Laptop,
                            Brand = "HP",
                            Color = "Silver",
                            Processor = "Intel Core i5",
                            ScreenSize = 15.6,
                            InternalRAM = 8,
                            TotalStorageCapacity = 512,
                            Touchscreen = false,
                            VideoCard = "Intel Iris Xe Graphics"
                        },
                                    new Laptop()
                        {
                            Name = "Asus Vivobook Pro 16X N7601ZM-K8234W-BE AZERTY",
                            Price = 1899,
                            Description = "The Asus Vivobook Pro 16X N7601ZM-K8234W-BE is a 16-inch laptop that's powerful enough for photo editing and video editing. You can also multitask between demanding programs without slowing down, thanks to the future-proof 12th generation Intel Core i7 processor and the 16GB DDR5 RAM. Your creations also render faster and you can play a medium demanding game every now and then thanks to the NVIDIA GeForce RTX 3060 video card. In addition, you can enjoy an extra sharp image thanks to the 165Hz refresh rate. Do you need more storage space after a while? You can easily add an extra SSD to expand your storage. In addition, you don't have to worry about your privacy with this laptop. You can log in securely and quickly with the fingerprint sensor and you can shield the camera with the webcam switch after a video call. Do you also use your laptop in the evening? No problem, you can find the right keys even in the dark, with the backlit keyboard.",
                            StockQuantity = 5,
                            ImageURL = "https://image.coolblue.be/max/500x500/products/1858978",
                            ProductCategory = Models.Enums.ProductCategory.Laptop,
                            Brand = "Asus",
                            Color = "Black",
                            Processor = "Inter core i7",
                            ScreenSize = 16,
                            InternalRAM = 16,
                            TotalStorageCapacity = 512,
                            Touchscreen = false,
                            VideoCard = "NVIDIA GeForce RTX 3060"
                        },
                    });
                    context.SaveChanges();
                }
            }
        }
        
        public static async Task SeedUsersAndRolesAsync(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {

                //Roles
                var roleManager = serviceScope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

                if (!await roleManager.RoleExistsAsync(UserRoles.Admin))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.Admin));
                if (!await roleManager.RoleExistsAsync(UserRoles.Client))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.Client));

                //Users
                var userManager = serviceScope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
                string adminUserEmail = "admin@pxl.be";

                var adminUser = await userManager.FindByEmailAsync(adminUserEmail);
                if (adminUser == null)
                {
                    var newAdminUser = new ApplicationUser()
                    {
                        FullName = "Admin User",
                        UserName = "admin-user",
                        Email = adminUserEmail,
                        EmailConfirmed = true
                    };
                    await userManager.CreateAsync(newAdminUser, "Adm!n007");
                    await userManager.AddToRoleAsync(newAdminUser, UserRoles.Admin);
                }


                string appUserEmail = "Client@pxl.be";

                var appUser = await userManager.FindByEmailAsync(appUserEmail);
                if (appUser == null)
                {
                    var newAppUser = new ApplicationUser()
                    {
                        FullName = "Application User",
                        UserName = "app-user",
                        Email = appUserEmail,
                        EmailConfirmed = true
                    };
                    await userManager.CreateAsync(newAppUser, "Cli3nt001!");
                    await userManager.AddToRoleAsync(newAppUser, UserRoles.Client);
                }
            }
        }
    }
}

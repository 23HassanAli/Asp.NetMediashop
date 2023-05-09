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

                if (!context.Smartphones.Any())
                {
                    context.Smartphones.AddRange(new List<Smartphone>()
                    {
                        new Smartphone() {
                            Name = "Samsung Galaxy A34 256GB Black 5G",
                            ProductId = 1,
                            Price = 439,
                            Description = "The Samsung Galaxy A34 256GB Black 5G is a mid-range smartphone with good cameras and lots of storage. Take sharp photos with the 3 cameras on the back of the Samsung A34. Thanks to the wide-angle lens and macro lens, you have a suitable camera for many situations. You have enough space for all your apps, photos, and stored movies and series on the spacious 256GB storage. Comfortably watch your favorite movies and series on the large 6.6-inch Full HD screen. Due to its size, it's hard to control with 1 hand. The large 5000mAh battery easily lasts an entire day at average use. You can charge the battery with a separately available 25W fast charger. The Samsung Galaxy A34 is suitable for light tasks like calls, checking your social media, or playing a light game such as Candy Crush.",
                            StockQuantity= 2,
                            ImageURL = "https://image.coolblue.be/max/500x500/products/1893603",
                            ProductCategory = Models.Enums.ProductCategory.Smartphone,
                            Type = "A32",
                            Brand = "Samnsung",
                            IntroducedYear  = 2023,
                            IntroductionMonth = "March",
                            OperatingSystem = "Android",
                            Height = "16,13", //cm
                            Width = "7,81", //cm
                            Weight = "199",//g
                            Color = "Black",
                            WaterResistant = true,
                            TotalStorageCapacity = 256, //GB
                            InternalRAM = 8, //GB
                            TotalRearCameras = 3,
                            TotalNumberOfMegapixels = 48, //MP
                            ScreenSize = "6,6" //inches
                        },
                        new Smartphone() {
                            ProductId = 2,
                            Name = "Apple iPhone 14 Pro Max 256GB Space Black",
                            Price = 1499,
                            Description = "The large Apple iPhone 14 Pro Max 256GB Space Black doesn't have a notch anymore. All sensors are now incorporated into a pill-shaped notch called Dynamic Island. This shows you notifications from apps. You can always see your widgets on the useful Always On screen. Thanks to the 48-megapixel standard lens, you can now take even more detailed photos, even in the dark. In addition, you have a wide-angle lens and a telephoto lens, which support night mode. This allows you to take even sharper photos in low light compared to the iPhone 13 Pro Max. On the bright 6.7-inch OLED screen, you can watch all your favorite series and movies in high quality. Thanks to ProMotion, images are smooth and easier on your eyes. Thanks to the powerful A16 Bionic chip and 6GB RAM, the iPhone 14 Pro Max is super fast. This chip is also energy-efficient. This means the device easily lasts a day and a half. You can store your photos, music, and apps on the 256GB storage.",
                            StockQuantity= 5,
                            ImageURL = "https://image.coolblue.be/max/500x500/products/1812860",
                            ProductCategory = Models.Enums.ProductCategory.Smartphone,
                            Type = "14 PRO Max",
                            Brand = "Apple",
                            IntroducedYear  = 2022,
                            IntroductionMonth = "September",
                            OperatingSystem = "iOS",
                            Height = "16,07", //cm
                            Width = "7,76",
                            Weight = "240", //g
                            Color = "Black",
                            WaterResistant = true,
                            TotalStorageCapacity = 256,
                            InternalRAM = 6,
                            TotalRearCameras = 3,
                            TotalNumberOfMegapixels = 48,
                            ScreenSize = "6,7" //inches
                        },
                        new Smartphone() {
                            ProductId = 3,
                            Name = "Apple iPhone 14 128GB Midnight",
                            Price = 952,
                            Description = "The Apple iPhone 14 128GB Midnight is a real all-rounder. With the improved standard and wide-angle lens, you can take even sharper photos than its predecessor, the Apple iPhone 13. In addition, the TrueDepth selfie camera has autofocus. This means it focuses on your face faster. And the image remains sharp if you move during video calls, for example. Even when there¿s not a lot of light. Thanks to the powerful A15 Bionic chip and 4GB RAM, you can quickly edit all your photos and multitask any way you want. You can store your photos and apps on the 128GB storage. With the special Action Mode, all your videos remain stable when you record something while you move around a lot. On the 6.1-inch OLED screen, you can watch all your favorite movies and series in high quality. Want more screen space? Choose the iPhone 14 Plus.",
                            StockQuantity= 3,
                            ImageURL = "https://image.coolblue.be/max/500x500/products/1812765",
                            ProductCategory = Models.Enums.ProductCategory.Smartphone,
                            Type = "14",
                            Brand = "Apple",
                            IntroducedYear  = 2022,
                            IntroductionMonth = "September",
                            OperatingSystem = "iOS",
                            Height = "14,67", //cm
                            Width = "7,15",
                            Weight = "172",
                            Color = "Midnight",
                            WaterResistant = true,
                            TotalStorageCapacity = 128,
                            InternalRAM = 6,
                            TotalRearCameras = 2,
                            TotalNumberOfMegapixels = 12,
                            ScreenSize = "6,1"
                        },
                        new Smartphone() {
                            ProductId = 4,
                            Name = "Apple iPhone 14 Pro Max 256GB Purple",
                            Price = 1459,
                            Description = "The large Apple iPhone 14 Pro Max 256GB Purple doesn't have a notch anymore. All sensors are now incorporated into a pill-shaped notch called Dynamic Island. This shows you notifications from apps. You can always see your widgets on the useful Always On screen. Thanks to the 48-megapixel standard lens, you can now take even more detailed photos, even in the dark. In addition, you have a wide-angle lens and a telephoto lens, which support night mode. This allows you to take even sharper photos in low light compared to the iPhone 13 Pro Max. On the bright 6.7-inch OLED screen, you can watch all your favorite series and movies in high quality. Thanks to ProMotion, images are smooth and easier on your eyes. Thanks to the powerful A16 Bionic chip and 6GB RAM, the iPhone 14 Pro Max is super fast. This chip is also energy-efficient. This means the device easily lasts a day and a half. You can store your photos, music, and apps on the 256GB storage.",
                            StockQuantity= 10,
                            ImageURL = "https://image.coolblue.be/max/500x500/products/1812959",
                            ProductCategory = Models.Enums.ProductCategory.Smartphone,
                            Type = "14 Pro Max",
                            Brand = "Apple",
                            IntroducedYear  = 2022,
                            IntroductionMonth = "September",
                            OperatingSystem = "iOS",
                            Height = "16,07",
                            Width = "7,76",
                            Weight = "240",
                            Color = "Purple",
                            WaterResistant = true,
                            TotalStorageCapacity = 256,
                            InternalRAM = 6,
                            TotalRearCameras = 3,
                            TotalNumberOfMegapixels = 48,
                            ScreenSize = "6,7"},
                        new Smartphone() {
                            ProductId = 5,
                            Name = "OnePlus 11 256GB Black 5G",
                            Price = 899,
                            Description = "The OnePlus 11 256GB Black 5G is a high-end smartphone that allows you to take razor-sharp photos. In addition to the main camera, you'll find a wide-angle lens and a telephoto lens on the back. With the wide-angle lens, you can capture images of a large building, for example. The telephoto lens allows you to zoom in without your photos becoming less sharp. You can store your photos, videos, apps, and downloaded series on the large 256GB storage. Thanks to the Snapdragon processor and 16GB RAM, this OnePlus smartphone is suitable for the most demanding tasks like image editing and 3D games. You can charge the 5000mAh battery within 30 minutes with the included 100W fast charger. On the large 6.7-inch Quad HD screen, you can watch your favorite movies and series in the highest quality. The screen refreshes 120 times per second, which makes motions like animations and scrolling look smooth. The size makes the screen difficult to control with 1 hand.",
                            StockQuantity= 3,
                            ImageURL = "https://image.coolblue.be/max/500x500/products/1878980",
                            ProductCategory = Models.Enums.ProductCategory.Smartphone,
                            Type = "11 5G",
                            Brand = "OnePlus",
                            IntroducedYear  = 2023,
                            IntroductionMonth = "February",
                            OperatingSystem = "Android",
                            Height = "16,3",
                            Width = "7,41",
                            Weight = "208",
                            Color = "Black",
                            WaterResistant = true,
                            TotalStorageCapacity = 256,
                            InternalRAM = 16,
                            TotalRearCameras = 3,
                            TotalNumberOfMegapixels = 5,
                            ScreenSize = "6,7"},
                        new Smartphone() {
                            ProductId = 6,
                            Name = "Samsung Galaxy S23 Ultra 512GB Green 5G",
                            Price = 1579,
                            Description = "The Samsung Galaxy S23 Ultra 512GB Green 5G is a smartphone with excellent cameras. With the 4 cameras on the back, you can capture razor-sharp photos and 8K videos. The telephoto lens zooms in up to 10 times without quality loss in your photos. The 200-megapixel standard lens and all other camera lenses have a night mode, so you can also take realistic photos in low light. Store your photos, apps, series, and movies on the large 512GB storage capacity. The large 6.8-inch screen of the Galaxy S23 Ultra is difficult to operate with one hand. Thanks to the size and the sharp Quad HD resolution, you can comfortably watch your favorite movies and series. With the Snapdragon processor and 8GB RAM, you can perform the most demanding tasks and switch between various apps quickly. You can take precise notes and edit photos with the included S Pen stylus. The large 5000mAh battery lasts a full day with average use. You can fast charge the battery with the separately available 45W fast charger. Your battery is fully charged within an hour.",
                            StockQuantity= 3,
                            ImageURL = "https://image.coolblue.be/max/500x500/products/1876801",
                            ProductCategory = Models.Enums.ProductCategory.Smartphone,
                            Type = "S23 5G",
                            Brand = "Samsung",
                            IntroducedYear  = 2023,
                            IntroductionMonth = "February",
                            OperatingSystem = "Andorid",
                            Height = "16,34",
                            Width = "7,81",
                            Weight = "233",
                            Color = "Green",
                            WaterResistant = true,
                            TotalStorageCapacity = 512,
                            InternalRAM = 12,
                            TotalRearCameras = 3,
                            TotalNumberOfMegapixels = 200,
                            ScreenSize = "6,8"},
                    });
                    context.SaveChanges();

                }
                //Laptops
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
                            ScreenSize = "15,6",
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
                            ScreenSize = "17,3",
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
                            ScreenSize = "15,6",
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
                            ScreenSize = "15,6",
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
                            ScreenSize = "15,6",
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
                            ScreenSize = "16",
                            InternalRAM = 16,
                            TotalStorageCapacity = 512,
                            Touchscreen = false,
                            VideoCard = "NVIDIA GeForce RTX 3060"
                        },
                        new Laptop()
                        {
                            Name = "Dell XPS 13 9310 i5-8GB-256GB Qwerty",
                            Price = 1199,
                            Description = "The Dell XPS 13 9310 i5-8GB-256GB Qwerty is a slim and lightweight laptop that's perfect for working on the go. With the 11th generation Intel Core i5 processor and 8GB DDR4 RAM, you can easily handle everyday tasks such as browsing the internet and editing documents. The 256GB SSD provides fast storage and quick boot times. The XPS 13 has a 13.4-inch Full HD IPS display that's perfect for streaming movies or working on documents. The laptop's battery lasts up to 12 hours on a single charge, so you can work all day without needing to recharge. The laptop also comes with Windows 10 Home pre-installed.",
                            StockQuantity = 5,
                            ImageURL = "https://image.coolblue.be/max/500x500/products/1875110",
                            ProductCategory = Models.Enums.ProductCategory.Laptop,
                            Brand = "Dell",
                            Color = "Silver",
                            Processor = "Intel Core i5",
                            ScreenSize = "13,4",
                            InternalRAM = 8,
                            TotalStorageCapacity = 256,
                            Touchscreen = false,
                            VideoCard = "Intel Iris Xe Graphics"
                        },
                        new Laptop()
                        {
                            Name = "Apple MacBook Air M1 8GB 256GB",
                            Price = 1049,
                            Description = "The Apple MacBook Air M1 8GB 256GB is a lightweight and powerful laptop that's perfect for students and professionals. With the Apple M1 chip and 8GB DDR4 RAM, you can easily handle demanding tasks such as video editing and graphic design. The 256GB SSD provides fast storage and quick boot times. The MacBook Air has a 13.3-inch Retina display with True Tone technology that adjusts the screen's color temperature to match the ambient lighting. The laptop's battery lasts up to 18 hours on a single charge, so you can work all day without needing to recharge. The laptop also comes with macOS Big Sur pre-installed.",
                            StockQuantity = 3,
                            ImageURL = "https://image.coolblue.be/max/500x500/products/1768945",
                            ProductCategory = Models.Enums.ProductCategory.Laptop,
                            Brand = "Apple",
                            Color = "Silver",
                            Processor = "Apple M1",
                            ScreenSize = "13,3",
                            InternalRAM = 8,
                            TotalStorageCapacity = 256,
                            Touchscreen = false,
                            VideoCard = "Apple M1 Graphics"
                        },
                                            new Laptop()
                    {
                        Name = "Lenovo IdeaPad 5 14ALC05 Ryzen 5 8GB 512GB",
                        Price = 799,
                        Description = "The Lenovo IdeaPad 5 14ALC05 Ryzen 5 8GB 512GB is a versatile laptop that's perfect for both work and play. With the AMD Ryzen 5 processor and 8GB DDR4 RAM, you can easily handle everyday tasks such as browsing the internet and editing documents. The 512GB SSD provides fast storage and quick boot times. The IdeaPad 5 has a 14-inch Full HD IPS display that's perfect for streaming movies or working on documents. The laptop's battery lasts up to 12 hours on a single charge, so you can work all day without needing to recharge. The laptop also comes with Windows 10 Home pre-installed.",
                        StockQuantity = 7,
                        ImageURL = "https://image.coolblue.be/max/500x500/products/1878909",
                        ProductCategory = Models.Enums.ProductCategory.Laptop,
                        Brand = "Lenovo",
                        Color = "Silver",
                        Processor = "AMD Ryzen 5",
                        ScreenSize = "14",
                        InternalRAM = 8,
                        TotalStorageCapacity = 512,
                        Touchscreen = false,
                        VideoCard = "AMD Radeon Graphics"
                    },
                    new Laptop()
                    {
                        Name = "Acer Aspire 5 A515-56-79AP i7-16GB-1TB",
                        Price = 899,
                        Description = "The Acer Aspire 5 A515-56-79AP i7-16GB-1TB is a powerful laptop that's perfect for multitasking. With the 11th generation Intel Core i7 processor and 16GB DDR4 RAM, you can easily handle demanding tasks such as video editing and graphic design. The 1TB SSD provides fast storage and quick boot times. The Aspire 5 has a 15.6-inch Full HD IPS display that's perfect for streaming movies or working on documents. The laptop's battery lasts up to 8 hours on a single charge, so you can work all day without needing to recharge. The laptop also comes with Windows 10 Home pre-installed.",
                        StockQuantity = 2,
                        ImageURL = "https://image.coolblue.be/max/500x500/products/1871796",
                        ProductCategory = Models.Enums.ProductCategory.Laptop,
                        Brand = "Acer",
                        Color = "Silver",
                        Processor = "Intel Core i7",
                        ScreenSize = "15,6",
                        InternalRAM = 16,
                        TotalStorageCapacity = 1,
                        Touchscreen = false,
                        VideoCard = "Intel Iris Xe Graphics"
                    },
                    new Laptop()
                    {
                        Name = "MSI Modern 14 B4MW-029BE i5-8GB-512GB Qwerty",
                        Price = 899,
                        Description = "The MSI Modern 14 B4MW-029BE i5-8GB-512GB Qwerty is a slim and lightweight laptop that's perfect for creative professionals. With the 11th generation Intel Core i5 processor and 8GB DDR4 RAM, you can easily handle demanding tasks such as video editing and graphic design. The 512GB SSD provides fast storage and quick boot times. The Modern 14 has a 14-inch Full HD IPS display that's perfect for streaming movies or working on documents. The laptop's battery lasts up to 10 hours on a single charge, so you can work all day without needing to recharge. The laptop also comes with Windows 10 Home pre-installed.",
                        StockQuantity = 4,
                        ImageURL = "https://tweakers.net/i/2zieGXr737N_OK1B_VXcN2PeIqI=/fit-in/656x/filters:strip_icc():strip_exif()/i/2003817146.jpeg?f=imagenormal",
                        ProductCategory = Models.Enums.ProductCategory.Laptop,
                        Brand = "MSI",
                        Color = "Grey",
                        Processor = "Intel Core i5",
                        ScreenSize = "14",
                        InternalRAM = 8,
                        TotalStorageCapacity = 512,
                        Touchscreen = false,
                        VideoCard = "Intel Iris Xe Graphics"
                    },
                    new Laptop()
                    {
                        Name = "HP Pavilion 15-eg0770nd i5-16GB-512GB Azerty",
                        Price = 849,
                        Description = "The HP Pavilion 15-eg0770nd i5-16GB-512GB Azerty is a versatile laptop that's perfect for both work and play. With the 11th generation Intel Core i5 processor and 16GB DDR4 RAM, you can easily handle everyday tasks such as browsing the internet and editing documents. The 512GB SSD provides fast storage and quick boot times. The Pavilion 15 has a 15.6-inch Full HD IPS display that's perfect for streaming movies or working on documents. The laptop's battery lasts up to 8 hours on a single charge, so you can work all day without needing to recharge. The laptop also comes with Windows 10 Home pre-installed.",
                        StockQuantity = 3,
                        ImageURL = "https://media.s-bol.com/4V0KyqYr4qWk/OgyBOmL/550x445.jpg",
                        ProductCategory = Models.Enums.ProductCategory.Laptop,
                        Brand = "HP",
                        Color = "Silver",
                        Processor = "Intel Core i5",
                        ScreenSize = "15,6",
                        InternalRAM = 16,
                        TotalStorageCapacity = 512,
                        Touchscreen = false,
                        VideoCard = "Intel Iris Xe Graphics"
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

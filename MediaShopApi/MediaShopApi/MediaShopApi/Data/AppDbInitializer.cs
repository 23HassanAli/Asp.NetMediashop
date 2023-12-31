﻿using MediaShopApi.Models;

namespace MediaShopApi.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();
                if (!context.Laptops.Any())
                {
                    context.Laptops.AddRange(new List<Laptop>()
                    {
                        new Laptop()
                        {
                            LaptopId = "1",
                            Name = "Probook 450 G9 i7-16GB-1TB Azerty",
                            Price = 1299,
                            Description = "You'll look very professional with the 15-inch HP ProBook 450 G9 i7-16GB-1TB business laptop. With the 12th generation Intel Core i7 processor and 16GB DDR5 RAM, you can smoothly edit large photo and video files in demanding Adobe programs. In the meantime, you can run other programs in the background as well. This way, you can work on your presentation or keep an eye on your numbers. After editing, your images render smoothly thanks to the NVIDIA GeForce MX570 video card. You can store your creations and other files on the 1TB SSD. This ProBook has Windows 10 Pro, so it's easy to remotely connect to office systems. That's useful if you often work in different locations. You can log in to this HP securely and quickly via the fingerprint sensor. This way, you can be sure that nobody else can access your files. Spilled something on your keyboard by accident? Don't worry, the laptop is spill-resistant.",
                            StockQuantity = 1,
                            ImageURL = "https://image.coolblue.be/max/500x500/products/1871696",
                            ProductCategory = "Laptop",
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
                            LaptopId = "2",
                            Name = "HP 470 G9 i7-16GB-512GB Azerty",
                            Price = 1269,
                            Description = "The HP 470 G9 i7-16GB-512GB is a 17-inch laptop suitable for business use as well as photo and video editing. With the 12th generation Intel Core i7 processor and 16GB DDR4 RAM, you can edit large photo and video files while running other programs in the background. You don't have to worry about your privacy with this laptop. You can log in quickly and securely via the built-in fingerprint sensor. That means only you have access to the laptop. You can also easily connect to your office systems remotely, thanks to Windows 11 Pro.",
                            StockQuantity = 2,
                            ImageURL = "https://image.coolblue.be/max/500x500/products/1870420",
                            ProductCategory = "Laptop",
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
                               LaptopId = "3",
                            Name = "Lenovo IdeaPad 3 15IAU7 82RK00JMMB Azerty",
                            Price = 899,
                            Description = "The Lenovo IdeaPad 3 15IAU7 82RK00JMMB is a 15-inch laptop powerful enough for video editing. With the 12th generation Intel Core i7 processor and 16GB DDR4 RAM, you can edit photos and videos and multitask with demanding programs. All your creations also render smoothly thanks to the Intel Iris Xe Graphics shared video card. Need more storage space for all your files? You can easily add an extra SSD or HDD to expand the storage of your laptop. With this Lenovo, you also enjoy clear sound thanks to the Dolby Audio speakers. After a video call, you can easily slide the webcam switch over your camera. This way, you don't have to worry about your privacy.\r\n\r\n",
                            StockQuantity = 3,
                            ImageURL = "https://image.coolblue.be/max/500x500/products/1864807",
                            ProductCategory = "Laptop",
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
                            LaptopId = "4",
                            Name = "HP ENVY x360 15-ew0009nb Azerty",
                            Price = 1299,
                            Description = "On the 15-inch HP ENVY x360 15-ew0009nb 2-in-1 laptop, you can edit photos and videos with Adobe Premiere Pro, and multitask with all your projects. The 12th generation Intel Core i7 processor and 16GB RAM are powerful enough to do this. Flip the touchscreen 360 degrees and use your fingers to easily swipe through web pages and photos. Is it time to render your material? Thanks to the Intel Iris Xe Graphics shared video card, this process is much smoother than with other shared video cards. In addition, you can store all your files on the internal 512GB SSD. During a long office day, you won't have to worry about the battery of your laptop. With HP Fast Charge, you can charge your laptop back up to 50% in about 45 minutes. So you can soon continue to work wirelessly.",
                            StockQuantity = 4,
                            ImageURL = "https://image.coolblue.be/max/500x500/products/1786078",
                            ProductCategory = "Laptop",
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
                            LaptopId = "5",
                            Name = "HP ProBook 450 G9 i5-8GB-512GB AZERTY",
                            Price = 1069,
                            Description = "You'll look very professional with the 15-inch HP ProBook 450 G9 i5-8GB-512GB business laptop. With the 12th generation Intel Core i5 processor and 8GB DDR4 RAM, you can edit photos in Adobe Photoshop. You don't have to worry about your privacy with this laptop. This ProBook has Windows 10 Pro, so it's easy to remotely connect to the office systems. That' useful if you often work in different locations. You can log in to this HP quickly and securely via the fingerprint sensor. This way, you can be sure that nobody else can access your files. Spilled something on your keyboard by accident? Don't worry, the laptop is spill-resistant.",
                            StockQuantity = 5,
                            ImageURL = "https://image.coolblue.be/max/500x500/products/1871695",
                            ProductCategory = "Laptop",
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
                            LaptopId = "6",
                            Name = "Asus Vivobook Pro 16X N7601ZM-K8234W-BE AZERTY",
                            Price = 1899,
                            Description = "The Asus Vivobook Pro 16X N7601ZM-K8234W-BE is a 16-inch laptop that's powerful enough for photo editing and video editing. You can also multitask between demanding programs without slowing down, thanks to the future-proof 12th generation Intel Core i7 processor and the 16GB DDR5 RAM. Your creations also render faster and you can play a medium demanding game every now and then thanks to the NVIDIA GeForce RTX 3060 video card. In addition, you can enjoy an extra sharp image thanks to the 165Hz refresh rate. Do you need more storage space after a while? You can easily add an extra SSD to expand your storage. In addition, you don't have to worry about your privacy with this laptop. You can log in securely and quickly with the fingerprint sensor and you can shield the camera with the webcam switch after a video call. Do you also use your laptop in the evening? No problem, you can find the right keys even in the dark, with the backlit keyboard.",
                            StockQuantity = 5,
                            ImageURL = "https://image.coolblue.be/max/500x500/products/1858978",
                            ProductCategory ="Laptop",
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
                        {LaptopId = "7",
                            Name = "Dell XPS 13 9310 i5-8GB-256GB Qwerty",
                            Price = 1199,
                            Description = "The Dell XPS 13 9310 i5-8GB-256GB Qwerty is a slim and lightweight laptop that's perfect for working on the go. With the 11th generation Intel Core i5 processor and 8GB DDR4 RAM, you can easily handle everyday tasks such as browsing the internet and editing documents. The 256GB SSD provides fast storage and quick boot times. The XPS 13 has a 13.4-inch Full HD IPS display that's perfect for streaming movies or working on documents. The laptop's battery lasts up to 12 hours on a single charge, so you can work all day without needing to recharge. The laptop also comes with Windows 10 Home pre-installed.",
                            StockQuantity = 5,
                            ImageURL = "https://image.coolblue.be/max/500x500/products/1875110",
                            ProductCategory = "Laptop",
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

                            LaptopId = "8",
                            Name = "Apple MacBook Air M1 8GB 256GB",
                            Price = 1049,
                            Description = "The Apple MacBook Air M1 8GB 256GB is a lightweight and powerful laptop that's perfect for students and professionals. With the Apple M1 chip and 8GB DDR4 RAM, you can easily handle demanding tasks such as video editing and graphic design. The 256GB SSD provides fast storage and quick boot times. The MacBook Air has a 13.3-inch Retina display with True Tone technology that adjusts the screen's color temperature to match the ambient lighting. The laptop's battery lasts up to 18 hours on a single charge, so you can work all day without needing to recharge. The laptop also comes with macOS Big Sur pre-installed.",
                            StockQuantity = 3,
                            ImageURL = "https://image.coolblue.be/max/500x500/products/1766759",
                            ProductCategory = "Laptop",
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
                                                LaptopId = "9",
                        Name = "Lenovo IdeaPad 5 14ALC05 Ryzen 5 8GB 512GB",
                        Price = 799,
                        Description = "The Lenovo IdeaPad 5 14ALC05 Ryzen 5 8GB 512GB is a versatile laptop that's perfect for both work and play. With the AMD Ryzen 5 processor and 8GB DDR4 RAM, you can easily handle everyday tasks such as browsing the internet and editing documents. The 512GB SSD provides fast storage and quick boot times. The IdeaPad 5 has a 14-inch Full HD IPS display that's perfect for streaming movies or working on documents. The laptop's battery lasts up to 12 hours on a single charge, so you can work all day without needing to recharge. The laptop also comes with Windows 10 Home pre-installed.",
                        StockQuantity = 7,
                        ImageURL = "https://image.coolblue.be/max/500x500/products/1863462",
                        ProductCategory = "Laptop",
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
                        LaptopId = "10",
                        Name = "Acer Aspire 5 A515-56-79AP i7-16GB-1TB",
                        Price = 899,
                        Description = "The Acer Aspire 5 A515-56-79AP i7-16GB-1TB is a powerful laptop that's perfect for multitasking. With the 11th generation Intel Core i7 processor and 16GB DDR4 RAM, you can easily handle demanding tasks such as video editing and graphic design. The 1TB SSD provides fast storage and quick boot times. The Aspire 5 has a 15.6-inch Full HD IPS display that's perfect for streaming movies or working on documents. The laptop's battery lasts up to 8 hours on a single charge, so you can work all day without needing to recharge. The laptop also comes with Windows 10 Home pre-installed.",
                        StockQuantity = 2,
                        ImageURL = "https://image.coolblue.be/max/500x500/products/1849719",
                        ProductCategory = "Laptop",
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
                        LaptopId = "11",
                        Name = "MSI Modern 14 B4MW-029BE i5-8GB-512GB Qwerty",
                        Price = 899,
                        Description = "The MSI Modern 14 B4MW-029BE i5-8GB-512GB Qwerty is a slim and lightweight laptop that's perfect for creative professionals. With the 11th generation Intel Core i5 processor and 8GB DDR4 RAM, you can easily handle demanding tasks such as video editing and graphic design. The 512GB SSD provides fast storage and quick boot times. The Modern 14 has a 14-inch Full HD IPS display that's perfect for streaming movies or working on documents. The laptop's battery lasts up to 10 hours on a single charge, so you can work all day without needing to recharge. The laptop also comes with Windows 10 Home pre-installed.",
                        StockQuantity = 4,
                        ImageURL = "https://tweakers.net/i/2zieGXr737N_OK1B_VXcN2PeIqI=/fit-in/656x/filters:strip_icc():strip_exif()/i/2003817146.jpeg?f=imagenormal",
                        ProductCategory = "Laptop",
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
                        LaptopId = "12",
                        Name = "HP Pavilion 15-eg0770nd i5-16GB-512GB Azerty",
                        Price = 849,
                        Description = "The HP Pavilion 15-eg0770nd i5-16GB-512GB Azerty is a versatile laptop that's perfect for both work and play. With the 11th generation Intel Core i5 processor and 16GB DDR4 RAM, you can easily handle everyday tasks such as browsing the internet and editing documents. The 512GB SSD provides fast storage and quick boot times. The Pavilion 15 has a 15.6-inch Full HD IPS display that's perfect for streaming movies or working on documents. The laptop's battery lasts up to 8 hours on a single charge, so you can work all day without needing to recharge. The laptop also comes with Windows 10 Home pre-installed.",
                        StockQuantity = 3,
                        ImageURL = "https://media.s-bol.com/4V0KyqYr4qWk/OgyBOmL/550x445.jpg",
                        ProductCategory = "Laptop",
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
    }
}

﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Webapp.Contexts;

#nullable disable

namespace Webapp.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230602122231_Tags on all products")]
    partial class Tagsonallproducts
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "409ce090-0dcb-425e-ab5d-dd7a37c74959",
                            ConcurrencyStamp = "85fd5a0b-eec1-4426-b10c-5b8f9b2becc9",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "466a8cb7-a123-4dcf-b636-98c60a18ae80",
                            ConcurrencyStamp = "bf900362-4e20-486c-84f1-cad6a1bb04cd",
                            Name = "User",
                            NormalizedName = "USER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "6a45fa8b-9656-4336-99e3-5e41a07d0a88",
                            RoleId = "409ce090-0dcb-425e-ab5d-dd7a37c74959"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Webapp.Models.Entites.AddressEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StreetName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("Webapp.Models.Entites.ContactFormEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ContactForms");
                });

            modelBuilder.Entity("Webapp.Models.Entites.ProductEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("money");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Meet the most rugged and capable Apple Watch ever. With a robust titanium case, precision dual-frequency GPS, up to 36 hours of battery life,1 the freedom of cellular,2 and three specialized bands made for athletes and adventurers of all kinds.",
                            ImageUrl = "https://cdn.shopify.com/s/files/1/0295/3245/4956/products/Board_700x.png?v=1653736635",
                            Price = 1800m,
                            Title = "Apple watch series"
                        },
                        new
                        {
                            Id = 2,
                            Description = "The Flowerpot portable table lamp VP9 from &Tradition is an innovative version of Verner Panton's popular table lamp VP3. This portable table lamp is slightly smaller than the classic table lamp and is perfect indoors and outdoors to create an atmospheric atmosphere wherever you are. The lamp can be dimmed in three stages using the small steel knob on top of the lampshade.",
                            ImageUrl = "https://cdn.shopify.com/s/files/1/0295/3245/4956/products/Board_700x.png?v=1653736635",
                            Price = 90m,
                            Title = "Table Lamp"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Co-engineered with Intel®, the Lenovo ThinkPad X1 Carbon Gen 11 meets Intel® Evo™ laptop design requirements, hardware specifications, and key user experience targets for consistent responsiveness, instant wake, all-day battery life, fast charging, and intelligent video conferencing. This Evo-certified device also includes Intel® Unison™ for seamless connectivity with your Android or iOS smart phone for calling, messaging, and file and photo sharing—all done from your laptop.\r\n\r\n",
                            ImageUrl = "https://cdn.shopify.com/s/files/1/0295/3245/4956/products/Board_700x.png?v=1653736635",
                            Price = 1000m,
                            Title = "laptop thinkpad lenovo"
                        },
                        new
                        {
                            Id = 4,
                            Description = "The Buddy wall lamp is stripped down and feels industrial and at the same time Scandinavian. The black colour enhances the minimalist feeling of the lamp.",
                            ImageUrl = "https://cdn.shopify.com/s/files/1/0295/3245/4956/products/Board_700x.png?v=1653736635",
                            Price = 20m,
                            Title = "Wall Lamp"
                        },
                        new
                        {
                            Id = 5,
                            Description = "Comfortably zen, just like every run should be. With the Nike Flex Experience Run 11, we created a lightweight, clean design that feels as good as it looks. The shoes are supportive in all the right ways with movement so natural, you'll swear you've been wearing them for years.",
                            ImageUrl = "https://cdn.shopify.com/s/files/1/0295/3245/4956/products/Board_700x.png?v=1653736635",
                            Price = 35m,
                            Title = "Gumshoes black fashion"
                        },
                        new
                        {
                            Id = 6,
                            Description = "Give your wardrobe that extra something-something with the latest drop from Wednesday's Girl. Big on floral and ditsy prints, the brand helps bring your daytime thing together with its range of designs. Choose from cute co-ords for a look that’s twice as nice, or have some all-in-one fun with its jumpsuits and playsuits.",
                            ImageUrl = "https://cdn.shopify.com/s/files/1/0295/3245/4956/products/Board_700x.png?v=1653736635",
                            Price = 28m,
                            Title = "Woman white dress"
                        },
                        new
                        {
                            Id = 7,
                            Description = "The Hamilton Beach® Electric Kettle has 1500 watts to heat up to 1 liter of water faster than a microwave and safer than a stovetop. You'll love the convenience of making a quick, hot cup of tea, instant coffee, or hot cocoa without the long wait. This kettle is perfect for hectic mornings or anytime you're in a hurry and need boiling water fast.",
                            ImageUrl = "https://cdn.shopify.com/s/files/1/0295/3245/4956/products/Board_700x.png?v=1653736635",
                            Price = 47m,
                            Title = "Kettle water boiler"
                        },
                        new
                        {
                            Id = 8,
                            Description = "The possibilities for easy home cooking are nearly endless with the Aroma 6-Cup Rice Cooker. Enjoy a variety of food with this appliance, including soups and stews. Featuring a non-stick inner pot and a tempered glass lid, the Aroma Rice Cooker is incredibly versatile. ",
                            ImageUrl = "https://cdn.shopify.com/s/files/1/0295/3245/4956/products/Board_700x.png?v=1653736635",
                            Price = 60m,
                            Title = "Congee cooking rice cooker"
                        },
                        new
                        {
                            Id = 9,
                            Description = "Add trendy table space to your living room with the CosmoLiving Westerleigh End Table",
                            ImageUrl = "https://cdn.shopify.com/s/files/1/0295/3245/4956/products/Board_700x.png?v=1653736635",
                            Price = 66m,
                            Title = "CosmoLiving Westerleigh End Table"
                        },
                        new
                        {
                            Id = 10,
                            Description = "A quiet, lightweight and portable mini fridge that can be used anywhere to cool or warm food, drinks, beer, snacks, breast milk, insulin, skincare and medications.",
                            ImageUrl = "https://cdn.shopify.com/s/files/1/0295/3245/4956/products/Board_700x.png?v=1653736635",
                            Price = 39m,
                            Title = "Mini Portable Fridge"
                        },
                        new
                        {
                            Id = 11,
                            Description = "Surround yourself with spatial sound technologies including Windows Sonic, Dolby Atmos, and DTS Headphone:X.",
                            ImageUrl = "https://cdn.shopify.com/s/files/1/0295/3245/4956/products/Board_700x.png?v=1653736635",
                            Price = 110m,
                            Title = "Wireless Headset"
                        },
                        new
                        {
                            Id = 12,
                            Description = "XBOX SERIES X: The fastest, most powerful Xbox ever. Explore rich new worlds with 12 teraflops of raw graphic processing power, DirectX ray tracing, a custom SSD, and 4K gaming.",
                            ImageUrl = "https://cdn.shopify.com/s/files/1/0295/3245/4956/products/Board_700x.png?v=1653736635",
                            Price = 200m,
                            Title = "Xbox Series X"
                        },
                        new
                        {
                            Id = 13,
                            Description = "1TB of storage increases the overall capacity of the Xbox Series X|S—collect thousands of games across four generations of Xbox without sacrificing performance",
                            ImageUrl = "https://cdn.shopify.com/s/files/1/0295/3245/4956/products/Board_700x.png?v=1653736635",
                            Price = 999m,
                            Title = "Seagate Storage"
                        },
                        new
                        {
                            Id = 14,
                            Description = "Rediscover everything you watch with billions of accurate colors and see impressive picture quality that is natural and beautiful, enhanced by XR Triluminos Pro.",
                            ImageUrl = "https://cdn.shopify.com/s/files/1/0295/3245/4956/products/Board_700x.png?v=1653736635",
                            Price = 550m,
                            Title = "Sony 85 Inch 4K Ultra HD TV X90K Series"
                        },
                        new
                        {
                            Id = 15,
                            Description = "Operated with frequency response of 50Hz-16KHz, the podcast microphone XLR delivers balanced audio range for smooth mid, bright high and stable bass, likely to resonate with your audience. Directional cardioid dynamic microphone corded will not exaggerate your voice, while rejects unwanted off-axis noise for vocal originality and intelligibility during your gaming streaming video recording. (Tips: Keep the top of end-addressing dynamic microphone AM8 facing audio source, and suggested recording range is 2 to 6 in.)",
                            ImageUrl = "https://cdn.shopify.com/s/files/1/0295/3245/4956/products/Board_700x.png?v=1653736635",
                            Price = 315m,
                            Title = "FIFINE XLR/USB Dynamic Microphone"
                        },
                        new
                        {
                            Id = 16,
                            Description = "These strings have a highly flexible, multi-strand nylon core and cater for artists who feel uncomfortable with steel strings. The resounding success of our Dominant string owes a lot to its similarity in tone and response to gut strings, without gut's attendant drawbacks. The sound of the Dominant string is full and mellow, yet rich in overtones. Its radiance, its ability to project sound without being metallic, comes to the fore both in arco and pizzicato. Comparable in sound to gut, without gut's disadvantages. Other advantages are Dominant's effortless response to intricate fingering and its tuning stability even under extreme atmospheric conditions. But Dominant's beauty of tone is not as long lasting as that of a steel string, a price the discerning musician will be prepared to pay for this quality of sound. Dominant strings should be changed at appropriate intervals to ensure continuity of tone color. N.B. The playing and tuning peg length of the string are critical, so the string used should be exactly matched to the instrument's measurements",
                            ImageUrl = "https://cdn.shopify.com/s/files/1/0295/3245/4956/products/Board_700x.png?v=1653736635",
                            Price = 59m,
                            Title = "Dr Thomastik Cello Strings"
                        });
                });

            modelBuilder.Entity("Webapp.Models.Entites.ProductTagEntity", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("TagId")
                        .HasColumnType("int");

                    b.HasKey("ProductId", "TagId");

                    b.HasIndex("TagId");

                    b.ToTable("ProductTags");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            TagId = 1
                        },
                        new
                        {
                            ProductId = 2,
                            TagId = 2
                        },
                        new
                        {
                            ProductId = 3,
                            TagId = 3
                        },
                        new
                        {
                            ProductId = 4,
                            TagId = 1
                        },
                        new
                        {
                            ProductId = 5,
                            TagId = 2
                        },
                        new
                        {
                            ProductId = 6,
                            TagId = 3
                        },
                        new
                        {
                            ProductId = 7,
                            TagId = 2
                        },
                        new
                        {
                            ProductId = 8,
                            TagId = 1
                        },
                        new
                        {
                            ProductId = 9,
                            TagId = 3
                        },
                        new
                        {
                            ProductId = 10,
                            TagId = 1
                        },
                        new
                        {
                            ProductId = 11,
                            TagId = 2
                        },
                        new
                        {
                            ProductId = 12,
                            TagId = 2
                        },
                        new
                        {
                            ProductId = 13,
                            TagId = 1
                        },
                        new
                        {
                            ProductId = 14,
                            TagId = 3
                        },
                        new
                        {
                            ProductId = 15,
                            TagId = 3
                        },
                        new
                        {
                            ProductId = 16,
                            TagId = 2
                        });
                });

            modelBuilder.Entity("Webapp.Models.Entites.TagEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("TagName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tags");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            TagName = "new"
                        },
                        new
                        {
                            Id = 2,
                            TagName = "featured"
                        },
                        new
                        {
                            Id = 3,
                            TagName = "popular"
                        });
                });

            modelBuilder.Entity("Webapp.Models.Entites.UserAddressEntity", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AddressId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "AddressId");

                    b.HasIndex("AddressId");

                    b.ToTable("UserAddresses");
                });

            modelBuilder.Entity("Webapp.Models.Entites.UserEntity", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "6a45fa8b-9656-4336-99e3-5e41a07d0a88",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "a9d75486-1ed8-44e8-ab2b-4f5aea5bba4b",
                            Email = "admin@domain.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@DOMAIN.COM",
                            NormalizedUserName = "ADMIN@DOMAIN.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEHIVm9wODnOZYN4JfnhJjnFrnOiF79Oy+8x1hP6m8+7WGFlVeRZlakuuiEjlEQIhoA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "b86e26bf-e98c-4394-aead-607ecc109fd9",
                            TwoFactorEnabled = false,
                            UserName = "admin@domain.com"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Webapp.Models.Entites.UserEntity", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Webapp.Models.Entites.UserEntity", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Webapp.Models.Entites.UserEntity", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Webapp.Models.Entites.UserEntity", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Webapp.Models.Entites.ProductTagEntity", b =>
                {
                    b.HasOne("Webapp.Models.Entites.ProductEntity", "Product")
                        .WithMany("ProductTags")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Webapp.Models.Entites.TagEntity", "Tag")
                        .WithMany("ProductTags")
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("Tag");
                });

            modelBuilder.Entity("Webapp.Models.Entites.UserAddressEntity", b =>
                {
                    b.HasOne("Webapp.Models.Entites.AddressEntity", "Address")
                        .WithMany("Users")
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Webapp.Models.Entites.UserEntity", "User")
                        .WithMany("UserÁddresses")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Webapp.Models.Entites.AddressEntity", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("Webapp.Models.Entites.ProductEntity", b =>
                {
                    b.Navigation("ProductTags");
                });

            modelBuilder.Entity("Webapp.Models.Entites.TagEntity", b =>
                {
                    b.Navigation("ProductTags");
                });

            modelBuilder.Entity("Webapp.Models.Entites.UserEntity", b =>
                {
                    b.Navigation("UserÁddresses");
                });
#pragma warning restore 612, 618
        }
    }
}

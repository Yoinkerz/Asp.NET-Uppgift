using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Webapp.Models.Entites;

namespace Webapp.Contexts;

public class DataContext : IdentityDbContext<UserEntity>
{
    public DataContext(DbContextOptions<DataContext>options) : base(options)
    {
    }

    public DbSet<AddressEntity> Addresses { get; set; }
    public DbSet<UserAddressEntity> UserAddresses { get; set; }

    public DbSet<ProductEntity> Products { get; set; }
    public DbSet<TagEntity> Tags { get; set; }
    public DbSet<ProductTagEntity> ProductTags { get; set; }
    public DbSet<ContactFormEntity> ContactForms { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<IdentityRole>().HasData(
            new IdentityRole {
                Id = "409ce090-0dcb-425e-ab5d-dd7a37c74959",
                Name = "Admin",
                NormalizedName = "ADMIN",
                ConcurrencyStamp = Guid.NewGuid().ToString(),
            },
            new IdentityRole
            {
                Id = "466a8cb7-a123-4dcf-b636-98c60a18ae80",
                Name = "User",
                NormalizedName = "USER",
                ConcurrencyStamp = Guid.NewGuid().ToString(),
            });

        var passwordHasher = new PasswordHasher<UserEntity>();
        var userEntity = new UserEntity
        {
            Id = "6a45fa8b-9656-4336-99e3-5e41a07d0a88",
            UserName = "admin@domain.com",
            NormalizedUserName = "ADMIN@DOMAIN.COM",
            Email = "admin@domain.com",
            NormalizedEmail = "ADMIN@DOMAIN.COM",
            ConcurrencyStamp = Guid.NewGuid().ToString(),
        };
        userEntity.PasswordHash = passwordHasher.HashPassword(userEntity, "BytMig123!");
        builder.Entity<UserEntity>().HasData(userEntity);


        builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string> 
        { 
            UserId = userEntity.Id,
            RoleId = "409ce090-0dcb-425e-ab5d-dd7a37c74959"
        });


        builder.Entity<TagEntity>().HasData(
            new TagEntity { Id = 1, TagName = "new" },
            new TagEntity { Id = 2, TagName = "featured"},
            new TagEntity { Id = 3, TagName = "popular" }
        );

        builder.Entity<ProductEntity>().HasData(
            new ProductEntity { Id = 1, Title = "Apple watch series", Price = 1800, ImageUrl = "https://cdn.shopify.com/s/files/1/0295/3245/4956/products/Board_700x.png?v=1653736635", Description = "Meet the most rugged and capable Apple Watch ever. With a robust titanium case, precision dual-frequency GPS, up to 36 hours of battery life,1 the freedom of cellular,2 and three specialized bands made for athletes and adventurers of all kinds." },
            new ProductEntity { Id = 2, Title = "Table Lamp", Price = 90, ImageUrl = "https://cdn.shopify.com/s/files/1/0295/3245/4956/products/Board_700x.png?v=1653736635", Description = "The Flowerpot portable table lamp VP9 from &Tradition is an innovative version of Verner Panton's popular table lamp VP3. This portable table lamp is slightly smaller than the classic table lamp and is perfect indoors and outdoors to create an atmospheric atmosphere wherever you are. The lamp can be dimmed in three stages using the small steel knob on top of the lampshade." },
            new ProductEntity { Id = 3, Title = "laptop thinkpad lenovo", Price = 1000, ImageUrl = "https://cdn.shopify.com/s/files/1/0295/3245/4956/products/Board_700x.png?v=1653736635", Description = "Co-engineered with Intel®, the Lenovo ThinkPad X1 Carbon Gen 11 meets Intel® Evo™ laptop design requirements, hardware specifications, and key user experience targets for consistent responsiveness, instant wake, all-day battery life, fast charging, and intelligent video conferencing. This Evo-certified device also includes Intel® Unison™ for seamless connectivity with your Android or iOS smart phone for calling, messaging, and file and photo sharing—all done from your laptop.\r\n\r\n" },
            new ProductEntity { Id = 4, Title = "Wall Lamp", Price = 20, ImageUrl = "https://cdn.shopify.com/s/files/1/0295/3245/4956/products/Board_700x.png?v=1653736635", Description = "The Buddy wall lamp is stripped down and feels industrial and at the same time Scandinavian. The black colour enhances the minimalist feeling of the lamp." },
            new ProductEntity { Id = 5, Title = "Gumshoes black fashion", Price = 35, ImageUrl = "https://cdn.shopify.com/s/files/1/0295/3245/4956/products/Board_700x.png?v=1653736635", Description = "Comfortably zen, just like every run should be. With the Nike Flex Experience Run 11, we created a lightweight, clean design that feels as good as it looks. The shoes are supportive in all the right ways with movement so natural, you'll swear you've been wearing them for years." },
            new ProductEntity { Id = 6, Title = "Woman white dress", Price = 28, ImageUrl = "https://cdn.shopify.com/s/files/1/0295/3245/4956/products/Board_700x.png?v=1653736635", Description = "Give your wardrobe that extra something-something with the latest drop from Wednesday's Girl. Big on floral and ditsy prints, the brand helps bring your daytime thing together with its range of designs. Choose from cute co-ords for a look that’s twice as nice, or have some all-in-one fun with its jumpsuits and playsuits." },
            new ProductEntity { Id = 7, Title = "Kettle water boiler", Price = 47, ImageUrl = "https://cdn.shopify.com/s/files/1/0295/3245/4956/products/Board_700x.png?v=1653736635", Description = "The Hamilton Beach® Electric Kettle has 1500 watts to heat up to 1 liter of water faster than a microwave and safer than a stovetop. You'll love the convenience of making a quick, hot cup of tea, instant coffee, or hot cocoa without the long wait. This kettle is perfect for hectic mornings or anytime you're in a hurry and need boiling water fast." },
            new ProductEntity { Id = 8, Title = "Congee cooking rice cooker", Price = 60, ImageUrl = "https://cdn.shopify.com/s/files/1/0295/3245/4956/products/Board_700x.png?v=1653736635", Description = "The possibilities for easy home cooking are nearly endless with the Aroma 6-Cup Rice Cooker. Enjoy a variety of food with this appliance, including soups and stews. Featuring a non-stick inner pot and a tempered glass lid, the Aroma Rice Cooker is incredibly versatile. " },
            new ProductEntity { Id = 9, Title = "CosmoLiving Westerleigh End Table", Price = 66, ImageUrl = "https://cdn.shopify.com/s/files/1/0295/3245/4956/products/Board_700x.png?v=1653736635", Description = "Add trendy table space to your living room with the CosmoLiving Westerleigh End Table" },
            new ProductEntity { Id = 10, Title = "Mini Portable Fridge", Price = 39, ImageUrl = "https://cdn.shopify.com/s/files/1/0295/3245/4956/products/Board_700x.png?v=1653736635", Description = "A quiet, lightweight and portable mini fridge that can be used anywhere to cool or warm food, drinks, beer, snacks, breast milk, insulin, skincare and medications." },
            new ProductEntity { Id = 11, Title = "Wireless Headset", Price = 110, ImageUrl = "https://cdn.shopify.com/s/files/1/0295/3245/4956/products/Board_700x.png?v=1653736635", Description = "Surround yourself with spatial sound technologies including Windows Sonic, Dolby Atmos, and DTS Headphone:X." },
            new ProductEntity { Id = 12, Title = "Xbox Series X", Price = 200, ImageUrl = "https://cdn.shopify.com/s/files/1/0295/3245/4956/products/Board_700x.png?v=1653736635", Description = "XBOX SERIES X: The fastest, most powerful Xbox ever. Explore rich new worlds with 12 teraflops of raw graphic processing power, DirectX ray tracing, a custom SSD, and 4K gaming." },
            new ProductEntity { Id = 13, Title = "Seagate Storage", Price = 999, ImageUrl = "https://cdn.shopify.com/s/files/1/0295/3245/4956/products/Board_700x.png?v=1653736635", Description = "1TB of storage increases the overall capacity of the Xbox Series X|S—collect thousands of games across four generations of Xbox without sacrificing performance" },
            new ProductEntity { Id = 14, Title = "Sony 85 Inch 4K Ultra HD TV X90K Series", Price = 550, ImageUrl = "https://cdn.shopify.com/s/files/1/0295/3245/4956/products/Board_700x.png?v=1653736635", Description = "Rediscover everything you watch with billions of accurate colors and see impressive picture quality that is natural and beautiful, enhanced by XR Triluminos Pro." },
            new ProductEntity { Id = 15, Title = "FIFINE XLR/USB Dynamic Microphone", Price = 315, ImageUrl = "https://cdn.shopify.com/s/files/1/0295/3245/4956/products/Board_700x.png?v=1653736635", Description = "Operated with frequency response of 50Hz-16KHz, the podcast microphone XLR delivers balanced audio range for smooth mid, bright high and stable bass, likely to resonate with your audience. Directional cardioid dynamic microphone corded will not exaggerate your voice, while rejects unwanted off-axis noise for vocal originality and intelligibility during your gaming streaming video recording. (Tips: Keep the top of end-addressing dynamic microphone AM8 facing audio source, and suggested recording range is 2 to 6 in.)" },
            new ProductEntity { Id = 16, Title = "Dr Thomastik Cello Strings", Price = 59, ImageUrl = "https://cdn.shopify.com/s/files/1/0295/3245/4956/products/Board_700x.png?v=1653736635", Description = "These strings have a highly flexible, multi-strand nylon core and cater for artists who feel uncomfortable with steel strings. The resounding success of our Dominant string owes a lot to its similarity in tone and response to gut strings, without gut's attendant drawbacks. The sound of the Dominant string is full and mellow, yet rich in overtones. Its radiance, its ability to project sound without being metallic, comes to the fore both in arco and pizzicato. Comparable in sound to gut, without gut's disadvantages. Other advantages are Dominant's effortless response to intricate fingering and its tuning stability even under extreme atmospheric conditions. But Dominant's beauty of tone is not as long lasting as that of a steel string, a price the discerning musician will be prepared to pay for this quality of sound. Dominant strings should be changed at appropriate intervals to ensure continuity of tone color. N.B. The playing and tuning peg length of the string are critical, so the string used should be exactly matched to the instrument's measurements" }


        );

        builder.Entity<ProductTagEntity>().HasData(
            new ProductTagEntity { ProductId = 1, TagId = 1 },
            new ProductTagEntity { ProductId = 2, TagId = 2 },
            new ProductTagEntity { ProductId = 3, TagId = 3 },
            new ProductTagEntity { ProductId = 4, TagId = 1 },
            new ProductTagEntity { ProductId = 5, TagId = 2 },
            new ProductTagEntity { ProductId = 6, TagId = 3 },
            new ProductTagEntity { ProductId = 7, TagId = 2 },
            new ProductTagEntity { ProductId = 8, TagId = 1 },
            new ProductTagEntity { ProductId = 9, TagId = 3 },
            new ProductTagEntity { ProductId = 10, TagId = 1 },
            new ProductTagEntity { ProductId = 11, TagId = 2 },
            new ProductTagEntity { ProductId = 12, TagId = 2 },
            new ProductTagEntity { ProductId = 13, TagId = 1 },
            new ProductTagEntity { ProductId = 14, TagId = 3 },
            new ProductTagEntity { ProductId = 15, TagId = 3 },
            new ProductTagEntity { ProductId = 16, TagId = 2 }
        );
    }
}

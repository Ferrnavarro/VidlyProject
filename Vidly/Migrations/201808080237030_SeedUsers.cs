namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'1d088d75-6473-4791-b372-692a6fd05875', N'fer_nandopayu@hotmail.com', 0, N'AFWJB2hU2JBuZez8mAcFW56+/6EPugIgdtPgrrxysI/lfHZBz4mFoSia/4jT5Xlc5g==', N'acf0d586-ee89-4963-bc17-037246e3de30', NULL, 0, 0, NULL, 1, 0, N'fer_nandopayu@hotmail.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'65bc0ae6-409c-4c17-871a-6cf77897aa45', N'admin@vidly.com', 0, N'AOLDIj0pMrCH+t9HoHSWsJ1YcdMxLr84pApLCDUNd71zuo6GNZEPNIXWaDeByKbufw==', N'28a35e5d-23db-4650-80e5-76a0f485764d', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'c5701dd5-a38e-4075-9079-ae751606fa2f', N'fernando@vidly.com', 0, N'AE3b6E0KwjzfGu6PEFLHlQuL6ch7ByrTk1FJXS8Bp1A5rQy0WxrJa+ZocvvHl4woQw==', N'db450147-8fc8-495e-8e68-a02c29f89561', NULL, 0, 0, NULL, 1, 0, N'fernando@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'c7d135bf-3b48-45c9-9920-489943e75a12', N'fer.maganavarro@outlook.com', 0, N'AMDG9GB3MOSxexoAnrZpBYmJL+yFoqkLStEi/bjyUk0SmSzCRqdVYj1JxugXgeUzlA==', N'3f4b9a78-6b66-4168-885f-23cd450b3d7d', NULL, 0, 0, NULL, 1, 0, N'fer.maganavarro@outlook.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'5d93bf6a-959b-47cd-b520-734fd3fad5a3', N'CanManageMovie')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'7c77ba46-d8c4-465c-87ad-570ff22fe338', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'c5701dd5-a38e-4075-9079-ae751606fa2f', N'7c77ba46-d8c4-465c-87ad-570ff22fe338')


");

          

        }

       
        
        public override void Down()
        {
        }
    }
}

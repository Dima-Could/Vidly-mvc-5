namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUser : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'a1766af0-3038-43fb-b163-dc13a7d7aae1', N'guers@vidly.com', 0, N'AI/ieDQIgE0ULMwzm5C4QFt2rO81ahtzGFZbDE07aXHLq1svdt/ROeV0Dx4R+utT5w==', N'148bd877-ac1e-489a-a510-b0671fafef70', NULL, 0, 0, NULL, 1, 0, N'guers@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'b1ebdfa4-d5cf-4f08-9b5b-f6eb04176e82', N'admin@vidly.com', 0, N'AEAmyig/UNwlFRM9Tz67mThBXDUhRv9ZH8gzMgxh34P8o6qqo58+UwbhkAVMk/ERqQ==', N'adbdb508-d575-4675-ae14-62c3891d49d3', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'545d3772-f308-491e-a9b9-db40fa03c20d', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'b1ebdfa4-d5cf-4f08-9b5b-f6eb04176e82', N'545d3772-f308-491e-a9b9-db40fa03c20d')

");
        }
        
        public override void Down()
        {
        }
    }
}

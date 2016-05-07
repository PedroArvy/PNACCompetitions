namespace PNACCompetitions.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Catches",
                c => new
                    {
                        CatchId = c.Int(nullable: false, identity: true),
                        EntryId = c.Int(nullable: false),
                        FishRuleId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CatchId)
                .ForeignKey("dbo.Entries", t => t.EntryId, cascadeDelete: true)
                .ForeignKey("dbo.FishRules", t => t.FishRuleId, cascadeDelete: true)
                .Index(t => t.EntryId)
                .Index(t => t.FishRuleId);
            
            CreateTable(
                "dbo.Entries",
                c => new
                    {
                        EntryId = c.Int(nullable: false, identity: true),
                        CompetitorId = c.Int(nullable: false),
                        CompetitionId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EntryId)
                .ForeignKey("dbo.Competitions", t => t.CompetitionId, cascadeDelete: true)
                .ForeignKey("dbo.Competitors", t => t.CompetitorId, cascadeDelete: true)
                .Index(t => t.CompetitorId)
                .Index(t => t.CompetitionId);
            
            CreateTable(
                "dbo.Competitions",
                c => new
                    {
                        CompetitionId = c.Int(nullable: false, identity: true),
                        Environment = c.Int(nullable: false),
                        End = c.DateTime(),
                        Name = c.String(maxLength: 100, unicode: false),
                        Start = c.DateTime(nullable: false),
                        SeasonId = c.Int(nullable: false),
                        Venue = c.String(nullable: false, maxLength: 100, unicode: false),
                        WeighInTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.CompetitionId)
                .ForeignKey("dbo.Seasons", t => t.SeasonId, cascadeDelete: true)
                .Index(t => t.SeasonId);
            
            CreateTable(
                "dbo.Seasons",
                c => new
                    {
                        SeasonId = c.Int(nullable: false, identity: true),
                        ClubId = c.Int(nullable: false),
                        End = c.DateTime(nullable: false),
                        Start = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.SeasonId)
                .ForeignKey("dbo.Clubs", t => t.ClubId, cascadeDelete: true)
                .Index(t => t.ClubId);
            
            CreateTable(
                "dbo.Clubs",
                c => new
                    {
                        ClubId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.ClubId);
            
            CreateTable(
                "dbo.Competitors",
                c => new
                    {
                        CompetitorId = c.Int(nullable: false, identity: true),
                        CompetitorType = c.Int(nullable: false),
                        Gender = c.Int(nullable: false),
                        ClubId = c.Int(nullable: false),
                        FirstName = c.String(nullable: false, maxLength: 100, unicode: false),
                        LastName = c.String(nullable: false, maxLength: 100, unicode: false),
                        NickName = c.String(maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.CompetitorId)
                .ForeignKey("dbo.Clubs", t => t.ClubId)
                .Index(t => t.ClubId);
            
            CreateTable(
                "dbo.FishRules",
                c => new
                    {
                        FishRuleId = c.Int(nullable: false, identity: true),
                        ClubId = c.Int(nullable: false),
                        FishId = c.Int(nullable: false),
                        Difficulty = c.Double(nullable: false),
                        Maximum = c.Int(nullable: false),
                        Minimum = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.FishRuleId)
                .ForeignKey("dbo.Clubs", t => t.ClubId)
                .ForeignKey("dbo.Fish", t => t.FishId, cascadeDelete: true)
                .Index(t => t.ClubId)
                .Index(t => t.FishId);
            
            CreateTable(
                "dbo.Fish",
                c => new
                    {
                        FishId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100, unicode: false),
                        Environment = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.FishId);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.Catches", "FishRuleId", "dbo.FishRules");
            DropForeignKey("dbo.Catches", "EntryId", "dbo.Entries");
            DropForeignKey("dbo.Entries", "CompetitorId", "dbo.Competitors");
            DropForeignKey("dbo.Entries", "CompetitionId", "dbo.Competitions");
            DropForeignKey("dbo.Competitions", "SeasonId", "dbo.Seasons");
            DropForeignKey("dbo.Seasons", "ClubId", "dbo.Clubs");
            DropForeignKey("dbo.FishRules", "FishId", "dbo.Fish");
            DropForeignKey("dbo.FishRules", "ClubId", "dbo.Clubs");
            DropForeignKey("dbo.Competitors", "ClubId", "dbo.Clubs");
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.FishRules", new[] { "FishId" });
            DropIndex("dbo.FishRules", new[] { "ClubId" });
            DropIndex("dbo.Competitors", new[] { "ClubId" });
            DropIndex("dbo.Seasons", new[] { "ClubId" });
            DropIndex("dbo.Competitions", new[] { "SeasonId" });
            DropIndex("dbo.Entries", new[] { "CompetitionId" });
            DropIndex("dbo.Entries", new[] { "CompetitorId" });
            DropIndex("dbo.Catches", new[] { "FishRuleId" });
            DropIndex("dbo.Catches", new[] { "EntryId" });
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.Fish");
            DropTable("dbo.FishRules");
            DropTable("dbo.Competitors");
            DropTable("dbo.Clubs");
            DropTable("dbo.Seasons");
            DropTable("dbo.Competitions");
            DropTable("dbo.Entries");
            DropTable("dbo.Catches");
        }
    }
}

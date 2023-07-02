namespace ErrorHub.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class initDb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MainTables",
                c => new
                {
                    RowGuid = c.Guid(nullable: false),
                    Row = c.Long(nullable: false, identity: true),
                    PersianMessage = c.String(),
                    StoredFileName = c.String(),
                    EnglishMessage = c.String(),
                    FileName = c.String(),
                    FileExtension = c.String(),
                    FileSize = c.String(),
                    PersianCategory = c.String(),
                    EnglishCategory = c.String(),
                    Description = c.String(),
                    Attachment = c.String(),
                    SequentialDirectory = c.String(),
                    CreateRecordDate = c.DateTime(precision: 7, storeType: "datetime2"),
                    LastUpdateRecordDate = c.DateTime(precision: 7, storeType: "datetime2"),
                })
                .PrimaryKey(t => t.RowGuid);

        }

        public override void Down()
        {
            DropTable("dbo.MainTables");
        }
    }
}

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Indexer.Data.Entities
{
    public class MainTable
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Row { get; set; }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid RowGuid { get; set; }
        public string PersianMessage { get; set; }
        public string StoredFileName { get; set; }
        public string EnglishMessage { get; set; }
        public string FileName { get; set; }
        public string FileExtension { get; set; }
        public string FileSize { get; set; }
        public string PersianCategory { get; set; }
        public string EnglishCategory { get; set; }
        public string Description { get; set; }
        public string Attachment { get; set; }
        public string SequentialDirectory { get; set; }
        [Column(TypeName = "DateTime2")]
        public Nullable<DateTime> CreateRecordDate { get; set; }
        [Column(TypeName = "DateTime2")]
        public Nullable<DateTime> LastUpdateRecordDate { get; set; }






    }
}

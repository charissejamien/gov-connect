using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace gov_connect.Data.Models
{
    [Table("documents")]
    public class DocumentItem : BaseModel
    {
        [PrimaryKey("id", false)]
        public int Id { get; set; }

        [Column("title")]
        public string Title { get; set; } = string.Empty;

        [Column("slug")]
        public string Slug { get; set; } = string.Empty;

        [Column("agency")]
        public string Agency { get; set; } = string.Empty;

        [Column("category")]
        public string Category { get; set; } = string.Empty;

        [Column("price")]
        public string Price { get; set; } = string.Empty;

        [Column("processing_time")]
        public string ProcessingTime { get; set; } = string.Empty;

        [Column("icon_type")]
        public string IconType { get; set; } = "scroll";

        [Column("description")]
        public string Description { get; set; } = string.Empty;
    }
}
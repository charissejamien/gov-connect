using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;
using System;

namespace gov_connect.Data.Models
{
    [Table("requests")]
    public class RequestItem : BaseModel
    {
        [PrimaryKey("id", false)]
        public long Id { get; set; }

        [Column("user_id")]
        public string UserId { get; set; } = string.Empty;

        [Column("document_title")]
        public string DocumentTitle { get; set; } = string.Empty;

        [Column("document_agency")]
        public string DocumentAgency { get; set; } = string.Empty;

        [Column("purpose")]
        public string Purpose { get; set; } = string.Empty;

        [Column("first_name")]
        public string FirstName { get; set; } = string.Empty;

        [Column("middle_name")]
        public string? MiddleName { get; set; }

        [Column("last_name")]
        public string LastName { get; set; } = string.Empty;

        [Column("delivery_method")]
        public string DeliveryMethod { get; set; } = string.Empty;

        [Column("address")]
        public string? Address { get; set; }

        [Column("status")]
        public string Status { get; set; } = "Pending";

        [Column("created_at")]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
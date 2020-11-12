using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace CRUDApplication.Models
{
    public class User
    {
        [JsonIgnore]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string Email { get; set; }

        public string Phone { get; set; }

        public string Website { get; set; }
    }
}

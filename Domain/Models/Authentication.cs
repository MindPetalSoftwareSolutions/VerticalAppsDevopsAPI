using System.ComponentModel.DataAnnotations;

namespace VerticalAppsDevopsAPI.Domain.Models{
    public class Authentication{
        
        [Required]
        public string grant_type { get; set; }
        [Required]
        public string client_id { get; set; }
        [Required]
        public string refresh_token { get; set; }

    }
}
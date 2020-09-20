using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Model.APIModels
{
    public class ApiLoginModel
    {
        [Required]
        [JsonProperty("username")]
        public string Username { get; set; }

        [Required]
        [JsonProperty("password")]
        public string Password { get; set; }
    }
}

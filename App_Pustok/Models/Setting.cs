

using System.ComponentModel.DataAnnotations;

namespace App_Pustok.Models
{
    public class Setting
    {
        [Key]
        public string Key { get; set; }
        public string Value { get; set; } 
    }
}

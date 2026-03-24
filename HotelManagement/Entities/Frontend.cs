using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HotelManagement.Entities
{
    internal class Frontend
    {
        [Key]
        [Required]
        [MaxLength(50)]
        public string user_name { get; set; }

        [Required]
        [MaxLength(50)]
        public string pass_word { get; set; }

        public override bool Equals(object? obj)
        {
            Frontend other = obj as Frontend;
            return this.user_name.Equals(other.user_name) && this.pass_word.Equals(other.pass_word);
        }
    }
}

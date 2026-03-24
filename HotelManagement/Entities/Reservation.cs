using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HotelManagement.Entities
{
    public class Reservation
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string first_name { get; set; }

        [Required]
        [MaxLength(50)]
        public string last_name { get; set; }

        [Required]
        [MaxLength(50)]
        public string birth_day { get; set; }

        [Required]
        [MaxLength(50)]
        public string gender { get; set; }

        [Required]
        [MaxLength(50)]
        public string phone_number { get; set; }

        [Required]
        public string email_address { get; set; } // nvarchar(MAX) doesn't need MaxLength

        [Required]
        public int number_guest { get; set; }

        [Required]
        public string street_address { get; set; } // nvarchar(MAX)

        [Required]
        [MaxLength(50)]
        public string apt_suite { get; set; }

        [Required]
        public string city { get; set; } // nvarchar(MAX)

        [Required]
        [MaxLength(50)]
        public string state { get; set; }

        [Required]
        [MaxLength(10)]
        [Column(TypeName = "nchar(10)")]
        public string zip_code { get; set; }

        [Required]
        [MaxLength(10)]
        [Column(TypeName = "nchar(10)")]
        public string room_type { get; set; }

        [Required]
        [MaxLength(10)]
        [Column(TypeName = "nchar(10)")]
        public string room_floor { get; set; }

        [Required]
        [MaxLength(10)]
        [Column(TypeName = "nchar(10)")]
        public string room_number { get; set; }

        [Required]
        public double total_bill { get; set; } // float in SQL maps to double in C#

        [Required]
        [MaxLength(10)]
        [Column(TypeName = "nchar(10)")]
        public string payment_type { get; set; }

        [Required]
        [MaxLength(10)]
        [Column(TypeName = "nchar(10)")]
        public string card_type { get; set; }

        [Required]
        [MaxLength(50)]
        public string card_number { get; set; }

        [Required]
        [MaxLength(50)]
        public string card_exp { get; set; }

        [Required]
        [MaxLength(10)]
        [Column(TypeName = "nchar(10)")]
        public string card_cvc { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime arrival_time { get; set; } // SQL date maps to DateTime

        [Required]
        [DataType(DataType.Date)]
        public DateTime leaving_time { get; set; } // SQL date maps to DateTime

        [Required]
        public bool check_in { get; set; } // SQL bit maps to bool

        [Required]
        public int break_fast { get; set; }

        [Required]
        public int lunch { get; set; }

        [Required]
        public int dinner { get; set; }

        [Required]
        public bool cleaning { get; set; } // SQL bit maps to bool

        [Required]
        public bool towel { get; set; } // SQL bit maps to bool

        [Required]
        public bool s_surprise { get; set; } // SQL bit maps to bool

        [Required]
        public bool supply_status { get; set; } // SQL bit maps to bool

        [Required]
        public int food_bill { get; set; }



        public string FullName => $"{first_name} {last_name}";
    }
}

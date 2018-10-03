using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RESTExercise.Models
{
    public class Users
    {
        [Key] 
        public int id { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string name { get; set; } 
        public DateTime birthdate { get; set; }


        public Users() { }


    }
}
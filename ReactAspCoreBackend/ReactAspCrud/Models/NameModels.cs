﻿using System.ComponentModel.DataAnnotations;

namespace ReactAspCrud.Models
{
    public class NameModels
    {
        [Key]
        public int Id { get; set; }


        public string FirstName { get; set; }

        public string LastName { get; set; }
       
    }
}

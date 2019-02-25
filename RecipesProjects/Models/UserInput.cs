using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace RecipesProjects.Models
{

   
    public class UserInput
    {
        [Required]
        [DataType(DataType.Text)]
        public string MovieName { get; set; }

        
        public UserInput()
        {
           
        }


    }
}

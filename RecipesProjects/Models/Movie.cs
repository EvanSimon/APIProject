<<<<<<< HEAD:RecipesProjects/Models/Movie.cs
﻿using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RecipesProjects.Models
{
    public class Movie
    {

        public int ID { get; set; }
        [Key]
=======
﻿using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;
namespace RecipesProjects.Models
{
    public class MovieAPI
    {
        public int ID { get; set; }
        
>>>>>>> 6c3931d68d44b1d7b1839bf115d5099b32a40b3f:RecipesProjects/Models/MovieAPI.cs
        public string Title { get; set; }
        public string Year { get; set; }
        public string Rated { get; set; }
        public string Released { get; set; }
        public string Director { get; set; }
        public string Genre { get; set; }

        public Movie()
        { }

        public Movie(int id, string title, string year, string rated, string released, string director, string genre)
        {
            ID = id;
            Title = title;
            Year = year;
            Rated = rated;
            Released = released;
            Director = director;
            Genre = genre;
        }
        public Movie(string APIText)
        {
            //JObject movieJson = JObject.Parse(APIText);
            JToken movieInfo = JToken.Parse(APIText);
         
            Title = movieInfo["Title"].ToString();
            Year = movieInfo["Year"].ToString();
            Rated = movieInfo["Rated"].ToString();
            Released = movieInfo["Released"].ToString();
            Director = movieInfo["Director"].ToString();
            Genre = movieInfo["Genre"].ToString();

        }


    }

    public class DBMovieContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
    }

}

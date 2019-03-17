using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;

namespace kloud.Models
{
    public class DealsViewModel
    {
        public List<Categories> categories { get; set; }
        public Categories category { get; set; }
    }
}
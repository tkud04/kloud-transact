using System;
using System.ComponentModel.DataAnnotations;

namespace kloud.Models
{
    public class DealsViewModel
    {
        public List<Categories> categories { get; set; }
        public Categories category { get; set; }
    }
}
using System;
using System.Linq;
using System.Text;
using System.IO;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authorization;
using kloud.Models;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using System.Collections.Generic;


namespace kloud.Helpers
{
    public class DemoHelper : IDemoHelper
    {	
       private readonly string[] _categories = {
			                       "Phones & Tablets",
			                       "TV & Electronics",
								   "Fashion",
								   "Computers",
								   "Groceries",
								   "Unique Bundles",
								   "Health & Beauty",
								   "Home & Office",
								   "Babies, Kids & Toys",
								   "Games & Consoles",
								   "Watches & Sunglasses",
								   "Other Categories"
			};
			
			private readonly string[] _qs = {
			                       "phones-ablets",
			                       "tv-electronics",
								   "fashion",
								   "computers",
								   "groceries",
								   "unique-bundles",
								   "health-beauty",
								   "home-office",
								   "babies-kids-toys",
								   "games-consoles",
								   "watches-sunglasses",
								   "others"
			};
			
			private List<Categories> _cats; 
			
			public DemoHelper()
           {
             _cats = new List<Categories>();
             
             for(int i = 0; i < _categories.Length; i++)
			  {
				_cats.Add(new Categories{Name = _categories[i], q = _qs[i]});
			  }
           }
			
		
		public string getRole(string email)
		{
			string ret = "NoRole";
		
			return ret;
		}
		
		public List<Categories> getCategories()
		{
			List<Categories> ret = _cats;
			return ret;
			
		}
		
		public Categories getCategory(string q)
		{
			Categories ret = _cats.FirstOrDefault(m => m.q == q);
			return ret;
			
		}
	}
}
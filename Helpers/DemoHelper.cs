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
		
		public string getRole(string email)
		{
			string ret = "NoRole";
		
			return ret;
		}
		
		public List<string> getCategories()
		{
			List<string> ret = new List<string>();
			string[] categories = {
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
			for(int i = 0; i < categories.Length; i++)
			{
				ret.Add(categories[i]);
			}
			
			return ret;
			
		}
	}
}
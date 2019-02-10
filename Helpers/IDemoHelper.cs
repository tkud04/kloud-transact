using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using kloud.Models;
using System.Collections.Generic;
using System.Linq;

namespace kloud.Helpers
{
    public interface IDemoHelper
    {
		string getRole(string email);
    }
}
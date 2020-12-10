using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using Interdisciplinary.Infrastructure;


namespace Interdisciplinary.Models.ViewModels
{
    public class DrinksListSession : DrinksListViewModel
    {

        public static DrinksListViewModel GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            DrinksListSession DrinksList = session?.GetJson<DrinksListSession>("DrinksList") ?? new DrinksListSession();
            DrinksList.Session = session;
            return DrinksList;
        }


        [JsonIgnore]
        public ISession Session { get; set; }
      
    }
}

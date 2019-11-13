using AutoMapper;
using Contoso.Apps.SportsLeague.Data.Models;
using Contoso.Apps.SportsLeague.Web.Models;
using System.Collections.Generic;

namespace Contoso.Apps.SportsLeaque.Web
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<CartItem, CartItemModel>();
            CreateMap<List<CartItem>, List<CartItemModel>>();
        }
    }

}

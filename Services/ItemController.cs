using System;
using DotNetNuke.Web.Api;
using DotNetNuke.Security;
using System.Web.Http;
using TestData;
using System.Collections.Generic;
using System.Linq;
using System.Configuration;
using TestData.Models;
using TestData.Utils;

namespace AAModules.EnhancedContactFormEnhancedContactForm.Services
{
    [DnnAuthorize]
    public class ItemController : DnnApiController
    {
        [HttpGet]
        public IEnumerable<Item> GetItems()
        {
            using(var db = DbUtil.GetConnection())
            {
                return Item.GetAll(db);
            }
        }

        [HttpGet]
        public Item GetItem(int itemId)
        {
            using (var db = DbUtil.GetConnection())
            {
                return Item.GetById(db, itemId);
            }
        }
    }
}

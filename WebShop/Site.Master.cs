using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebShop.Models;
using WebShop.Logic;

namespace WebShop
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (HttpContext.Current.User.IsInRole("canEdit"))
            {
                adminLink.Visible = true;
            }
        }
        protected void Page_PreRender(object sender, EventArgs e)
        {
            using (ShoppingCartActions usersShoppingCart = new ShoppingCartActions())
            {
                string cartStr = string.Format("Cart ({0})", usersShoppingCart.GetCount());
                cartCount.InnerText = cartStr;
            }
        }
        public IQueryable<Category> GetCategories()
        {
            var _db = new WebShop.Models.ProductContext();
            IQueryable<Category> query = _db.Categories;
            return query;
        }

    }
}
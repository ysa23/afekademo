using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SywApplicationWireframe.Domain.Products;

namespace SywApplicationWireframe.Web.UI.Controllers
{
    public class ProductsController : Controller
    {
	    private ProductsRepository _repository;

	    public ProductsController()
	    {
		    _repository = new ProductsRepository();
	    }

	    public ActionResult Get(string id)
        {
	        return Content(_repository.GetById(id).Description);
        }

		public ActionResult Add(string description)
		{
			return Content(_repository.Add(description));
		}
    }
}

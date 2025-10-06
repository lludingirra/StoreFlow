using Microsoft.AspNetCore.Mvc;
using StoreFlow.Context;

namespace StoreFlow.ViewComponents
{
    public class _CardStatisticsDashboardComponentPartial : ViewComponent
    {
        public readonly StoreContext _context;

        public _CardStatisticsDashboardComponentPartial(StoreContext context)
        {
            this._context = context;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.totalCustomerCount = _context.Customers.Count();
            ViewBag.totalCategoryCount = _context.Categories.Count();
            ViewBag.totalProductCount = _context.Products.Count();
            ViewBag.avgCustomorBalance = _context.Customers.Average(x => x.CustomerBalance);
            ViewBag.totalOrderCount = _context.Orders.Count();
            ViewBag.sumOrderProductCount = _context.Orders.Sum(x => x.OrderCount);
            return View();
        }
    }
}

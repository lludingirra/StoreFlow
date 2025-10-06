﻿using Microsoft.AspNetCore.Mvc;
using StoreFlow.Context;

namespace StoreFlow.ViewComponents.RightSidebarComponents
{
    public class RightSidebarToDoListComponentPartial :ViewComponent
    {
        private readonly StoreContext _context;

        public RightSidebarToDoListComponentPartial(StoreContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var values = _context.Todos.OrderBy(x => x.TodoId).ToList().TakeLast(10).ToList();
            return View(values);
        }
    }
}

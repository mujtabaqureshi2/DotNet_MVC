using Microsoft.AspNetCore.Mvc;
using MyMvcApp.Models;

namespace MyMvcApp.Controllers
{
  public class ItemsController: Controller
  {
    public IActionResult Overview()
    {
      var item  = new Item() {Name= "Keyboard"}; 
      return View(item);
    }

    public IActionResult Edit(int itemId)
    {
      return Content("Id= " + itemId);
    }
  }
}  
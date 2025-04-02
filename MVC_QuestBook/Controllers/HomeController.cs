using System.Reflection;
using Microsoft.AspNetCore.Mvc;
using MVC_QuestBook.Models;

namespace MVC_QuestBook.Controllers
{
    public class HomeController : Controller
    {
        static List<MessageModel> messages = new List<MessageModel>();

        [HttpGet] //Burada posttaki değer okunacak
        public IActionResult Contact()
        {
            return View(messages);
        }

        [HttpPost]
        public IActionResult Contact(MessageModel messageModel)
        {
           
            messages.Add(messageModel);
            return RedirectToAction("Contact");
        }
    }
}

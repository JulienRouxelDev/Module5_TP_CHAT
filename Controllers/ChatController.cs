using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TP.Models;

namespace testAppliWeb.Controllers
{
    public class ChatController : Controller
    {
        // GET: Chat
        public ActionResult Index()
        {
            List<Chat> chats = Chat.GetMeuteDeChats();
            return View(chats);
        }

        // GET: Chat/Details/5
        public ActionResult Details(int id)
        {

            List<Chat> chats = Chat.GetMeuteDeChats();
            Chat chatAAfficher = chats.Where(c => c.Id == id).First();
            return View(chatAAfficher);
        }


        // GET: Chat/Delete/5
        public ActionResult Delete(int id)
        {
            List<Chat> chats = Chat.GetMeuteDeChats();
            Chat chatASuppr = chats.Where(c => c.Id == id).First();

            return View(chatASuppr);
        }

        // POST: Chat/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}

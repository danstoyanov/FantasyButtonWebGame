using FantasyButtonWebGame.Models;

using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System;

namespace FantasyButtonWebGame.Controllers
{
    public class ButtonController : Controller
    {
        static List<ButtonModel> buttons = new List<ButtonModel>();
        Random random = new Random();
        const int GRID_SIZE = 25;

        public IActionResult Index()
        {
            if (buttons.Count < GRID_SIZE)
            {
                for (int i = 0; i < GRID_SIZE; i++)
                {
                    buttons.Add(new ButtonModel { Id = i, ButtonState = random.Next(4) });
                }
            }

            return View("Index", buttons);
        }
    }
}

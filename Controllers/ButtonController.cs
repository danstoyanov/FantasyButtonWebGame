﻿using FantasyButtonWebGame.Models;

using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace FantasyButtonWebGame.Controllers
{
    public class ButtonController : Controller
    {
        /* Todo List:
         * 👉 Add some kind of sound when the button is clicked.
         * 👉 Research how to make the the button as SVG or to in the same style.
         * 👉 Add message when you make specific combination or show some kind of item like picture.
         */

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

        public IActionResult HandleButtonClick(string buttonNumber)
        {
            // Parse the button value
            int currBtnNumber = int.Parse(buttonNumber);

            // here take the button state value and increase it with 1, in range of (0 - 4) - syntax.
            buttons.ElementAt(currBtnNumber).ButtonState = (buttons.ElementAt(currBtnNumber).ButtonState + 1) % 4; 

            return View("Index", buttons);
        }

        public IActionResult ShowItem(string combination)
        {
            return View("....");
        }
    }
}

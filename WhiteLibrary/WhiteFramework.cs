﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.White;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.WindowItems;
using TestStack.White.UIItems.ListBoxItems;
using TestStack.White.UIItems.MenuItems;
using TestStack.White.Configuration;
using Castle.Core.Logging;

namespace WhiteLibrary
{
    public class WhiteFW
    {
        protected Window window;

        protected void set_logging(string level)
        {
            switch (level.ToLower())
            {
                case "info":
                    CoreAppXmlConfiguration.Instance.LoggerFactory = new WhiteDefaultLoggerFactory(LoggerLevel.Info);
                    break;
                case "warn":
                    CoreAppXmlConfiguration.Instance.LoggerFactory = new WhiteDefaultLoggerFactory(LoggerLevel.Warn);
                    break;
                case "debug":
                    CoreAppXmlConfiguration.Instance.LoggerFactory = new WhiteDefaultLoggerFactory(LoggerLevel.Debug);
                    break;
            }
        }

        protected TextBox getTextBox(string locator)
        {
            SearchCriteria searchCriteria = SearchCriteria.ByAutomationId(locator);
            return (TextBox)window.Get(searchCriteria);
        }

        protected Label getLabel(string locator)
        {
            SearchCriteria searchCriteria = SearchCriteria.ByAutomationId(locator);
            return window.Get<Label>(searchCriteria);
        }

        protected ComboBox getComboBox(string locator)
        {
            SearchCriteria searchCriteria = SearchCriteria.ByAutomationId(locator);
            return window.Get<ComboBox>(searchCriteria);
        }

        protected Button getButton(string locator)
        {
            SearchCriteria searchCriteria = SearchCriteria.ByAutomationId(locator);
            return window.Get<Button>(searchCriteria);
        }

        protected Menu getMenu(string locator)
        {
            SearchCriteria searchCriteria = SearchCriteria.ByText(locator);
            return window.Get<Menu>(searchCriteria);
        }
    }
}
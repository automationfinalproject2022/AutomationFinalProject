﻿using OpenQA.Selenium;
using SkiNet.Library.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkiNet.Library.PageComponents.PageObjects
{
    public class SignUpForm : SecurityForm
    {
        public SignUpForm(IWebElement webElement) : base(webElement)
        {
        }

        protected IWebElement ActionElement => throw new NotImplementedException();
    }
}
using NUnit.Framework;
using SkiNet.Library.Abstract;
using SkiNet.Tests.Hooks;
using System;
using System.Diagnostics.Metrics;
using TechTalk.SpecFlow;

namespace SkiNet.Tests.StepDefinitions
{
    [Binding]
    public class NavigationStepDefinitions : Base_Tests
    {
        [Given(@"Home page is displayed")]
        public void GivenHomePageIsDisplayed()
        {
            App.Navigation.OpenHomePage();
        }

        [When(@"The (.*) page is opened")]
        public void WhenThePageIsOpened(string pageName)
        {
            string page = pageName.ToLower();

            switch (page)
            {
                case "login": App.Navigation.OpenLoginPage(); break;
                case "signup": App.Navigation.OpenSignUpPage(); break;
                case "shop": App.Navigation.OpenShopPage(); break;
                case "home": App.Navigation.OpenHomePage(); break;
                case "errors": App.Navigation.OpenErrorsPage(); break;
                default: throw new NotSupportedException("No such page: " + pageName);                    
            }
        }


        [Then(@"The page title should be (.*)")]
        public void ThenThePageTitleShouldBe(string expectedTitle)
        {
            string pageTitle = "";

            switch (expectedTitle.ToLower())
            {
                case "login": pageTitle = App.LoginPage.Title; break;
                case "signup": pageTitle = App.SignUpPage.Title; break;
                case "shop": pageTitle = App.ShopPage.Title; break;
                case "home": pageTitle = App.HomePage.Title; break;
                case "errors": pageTitle = App.ErrorsPage.Title; break;
                default: throw new NotSupportedException("No such page title: " + expectedTitle);
            }
            
            Assert.AreEqual(expectedTitle, pageTitle);
        }
    }
}

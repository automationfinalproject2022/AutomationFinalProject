using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using SkiNet.Library.PageComponents;
using SkiNet.Library.PageComponents.Controls;
using SkiNet.Library.PageComponents.PageObjects;
using SkiNet.Library.PageComponents.PageObjects.ShopItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTests
{
    public class PureSeleniumTests : BaseTests
    {
        protected override string Url => @"https://skinet.herokuapp.com/";

        [Test]
        public void SignUpUser()
        {
            
            IWebElement signUpButton = Driver.FindElement(By.CssSelector("a[href*='/account/register']"));
            signUpButton.Click();

            WebDriverWait webDriverWait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            IWebElement registerLabel = webDriverWait.Until(ExpectedConditions.ElementIsVisible(By.ClassName("col-9")));
            Assert.IsTrue(registerLabel.Displayed);

            IWebElement displayName = Driver.FindElement(By.Id("Display Name"));
            displayName.SendKeys("Niki");

            IWebElement email = Driver.FindElement(By.Id("Email Address"));
            email.SendKeys("niki@ggg.com");

            IWebElement password = Driver.FindElement(By.Id("Password"));
            password.SendKeys("!Q2w3e4r");

            IWebElement registerButton = Driver.FindElement(By.CssSelector("button[type='submit']"));
            registerButton.Click();
        }

        [Test]
        public void Navigate()
        {
            App app = new App(Driver);

            app.Navigation.OpenLoginPage();

            //Thread.Sleep(1000);

            app.Navigation.OpenShopPage(); 

            //Thread.Sleep(1000);

            app.Navigation.OpenErrorsPage();

            //Thread.Sleep(1000);

            app.Navigation.OpenHomePage();

            Thread.Sleep(1000);

            app.Navigation.OpenSignUpPage();

            Thread.Sleep(4000);

        }

        [Test]
        public void Login()
        {
            App app = new App(Driver);

            app.Navigation.OpenLoginPage();
            Thread.Sleep(1000);

            //IWebElement email = Driver.FindElement(By.Id("Email Address"));
            app.LoginPage.LoginForm.EmailAddress.SetData("test");
            


            IWebElement password = Driver.FindElement(By.Id("Password"));
            password.SendKeys("!Q2w3e4r");

            app.LoginPage.LoginForm.SignIn();





            //app.LoginPage.LoginForm.ClickForgotPassword();

            Thread.Sleep(2000);

            /*
            string plc = app.LoginPage.LoginForm.EmailAddress.Placeholder;
            app.LoginPage.LoginForm.EmailAddress.SetData("a@a.com");
            app.LoginPage.LoginForm.Password.SetData("!Q2w3e4r");
            app.LoginPage.LoginForm.Action();

            Thread.Sleep(5000);
            */
        }


        [Test]
        public void Login2()
        {
            App app = new App(Driver);

            app.Navigation.OpenLoginPage();

            app.LoginPage.LoginForm.EmailAddress.SetData("a@a.com");
            app.LoginPage.LoginForm.Password.SetData("!Q2w3e4r");

            app.LoginPage.LoginForm.SignIn();
        }

        [Test]
        public void LoginAndCheckout()
        {
            App app = new App(Driver);

            app.Navigation.OpenLoginPage();

            app.LoginPage.LoginForm.EmailAddress.SetData("a@a.com");
            app.LoginPage.LoginForm.Password.SetData("!Q2w3e4r");

            app.LoginPage.LoginForm.SignIn();

            app.Navigation.OpenBasketPage();

            Assert.That(app.BasketPage.BasketOrderSummaryForm.GetOrderSubTotalValue(), Is.EqualTo("180.00"));
            Assert.That(app.BasketPage.BasketOrderSummaryForm.GetShippingAndHandlingValue(), Is.EqualTo("0.00"));
            Assert.That(app.BasketPage.BasketOrderSummaryForm.GetTotalValue(), Is.EqualTo("180.00"));
            Assert.That(app.BasketPage.BasketOrderSummaryForm.GetTotalPriceCurrency().ToString(), Is.EqualTo("$"));

            app.BasketPage.ProceedToCheckout();

            app.CheckoutPage.ShippingAddressForm.FirstName.SetData("Niki");
            app.CheckoutPage.ShippingAddressForm.LastName.SetData("G");
            app.CheckoutPage.ShippingAddressForm.Street.SetData("Yerusalim");
            app.CheckoutPage.ShippingAddressForm.City.SetData("Sf");
            app.CheckoutPage.ShippingAddressForm.State.SetData("Sofia-town");
            app.CheckoutPage.ShippingAddressForm.ZipCode.SetData("1750");

            Assert.That(app.CheckoutPage.CheckoutOrderSummaryForm.GetOrderSubTotalValue(), Is.EqualTo("180.00"));
            Assert.That(app.CheckoutPage.CheckoutOrderSummaryForm.GetShippingAndHandlingValue(), Is.EqualTo("0.00"));
            Assert.That(app.CheckoutPage.CheckoutOrderSummaryForm.GetTotalValue(), Is.EqualTo("180.00"));
            Assert.That(app.CheckoutPage.CheckoutOrderSummaryForm.GetTotalPriceCurrency().ToString(), Is.EqualTo("$"));

            app.CheckoutPage.ShippingAddressForm.GoToDelivery();
                        
            app.CheckoutPage.DeliveryForm.UPS2Delivery.Tick();

            Assert.That(app.CheckoutPage.CheckoutOrderSummaryForm.GetOrderSubTotalValue(), Is.EqualTo("180.00"));
            Assert.That(app.CheckoutPage.CheckoutOrderSummaryForm.GetShippingAndHandlingValue(), Is.EqualTo("5.00"));
            Assert.That(app.CheckoutPage.CheckoutOrderSummaryForm.GetTotalValue(), Is.EqualTo("185.00"));
            Assert.That(app.CheckoutPage.CheckoutOrderSummaryForm.GetTotalPriceCurrency().ToString(), Is.EqualTo("$"));

            app.CheckoutPage.DeliveryForm.GoToReview();

            Assert.That(app.CheckoutPage.CheckoutOrderSummaryForm.GetOrderSubTotalValue(), Is.EqualTo("180.00"));
            Assert.That(app.CheckoutPage.CheckoutOrderSummaryForm.GetShippingAndHandlingValue(), Is.EqualTo("5.00"));
            Assert.That(app.CheckoutPage.CheckoutOrderSummaryForm.GetTotalValue(), Is.EqualTo("185.00"));
            Assert.That(app.CheckoutPage.CheckoutOrderSummaryForm.GetTotalPriceCurrency().ToString(), Is.EqualTo("$"));

            app.CheckoutPage.ReviewForm.GoToPayment();

            Assert.That(app.CheckoutPage.CheckoutOrderSummaryForm.GetOrderSubTotalValue(), Is.EqualTo("180.00"));
            Assert.That(app.CheckoutPage.CheckoutOrderSummaryForm.GetShippingAndHandlingValue(), Is.EqualTo("5.00"));
            Assert.That(app.CheckoutPage.CheckoutOrderSummaryForm.GetTotalValue(), Is.EqualTo("185.00"));
            Assert.That(app.CheckoutPage.CheckoutOrderSummaryForm.GetTotalPriceCurrency().ToString(), Is.EqualTo("$"));

            //app.CheckoutPage.PaymentForm.BackToReview();

            app.CheckoutPage.PaymentForm.CardName.SetData("Nicolay G");
            app.CheckoutPage.PaymentForm.CardNumber.SetData("5555555555554444"); // 5105105105105100    4111111111111111   4012888888881881
            app.CheckoutPage.PaymentForm.CardCVC.SetData("123");
            app.CheckoutPage.PaymentForm.CardExpiration.SetData("1224");            
            

            app.CheckoutPage.PaymentForm.SubmitOrder();
        }

        [Test]
        public void LoginAndOpenBasket()
        {
            App app = new App(Driver);

            app.Navigation.OpenLoginPage();

            app.LoginPage.LoginForm.EmailAddress.SetData("a@a.com");
            app.LoginPage.LoginForm.Password.SetData("!Q2w3e4r");

            app.LoginPage.LoginForm.SignIn();

            app.Navigation.OpenBasketPage();

           

            //app.Navigation.OpenWishListPage();
        }

        [Test]
        public void RemoveProductFromWishList()
        {
            App app = new App(Driver);

            app.Navigation.OpenLoginPage();

            app.LoginPage.LoginForm.EmailAddress.SetData("a@a.com");
            app.LoginPage.LoginForm.Password.SetData("!Q2w3e4r");

            app.LoginPage.LoginForm.SignIn();

            
            
            app.Navigation.OpenWishListPage();

            List<WishListProduct> products = app.WishListPage.WishListProducts;



            Assert.That(app.WishListPage.GetWishListProduct("Blue Code Gloves").Type, Is.EqualTo("Gloves"));


        }
    }
}

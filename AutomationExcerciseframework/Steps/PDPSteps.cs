using AutomationExcerciseframework.Helpers;
using AutomationExcerciseframework.Pages;
using System;
using TechTalk.SpecFlow;

namespace AutomationExcerciseframework.Steps
{
    [Binding]
    public class PDPSteps : Base
    {
        Utilities ut = new Utilities(Driver);
        HeaderPage hp = new HeaderPage(Driver);

        private readonly ProductData productData;

        public PDPSteps(ProductData productData)
        {
            this.productData = productData;
        }

        [Given(@"user opens products page")]
        public void GivenUserOpensProductsPage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"searches for '(.*)' term")]
        public void GivenSearchesForTerm(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"opens first search result")]
        public void GivenOpensFirstSearchResult()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"user click on Add to Cart button")]
        public void WhenUserClickOnAddToCartButton()
        {
            ProductDetailsPage pdp = new ProductDetailsPage(Driver);
            productData.ProductName = ut.ReturnTextFromElement(pdp.prodName);
            ut.ClickOnElement(pdp.addBtn);
        }
        
        [When(@"proceeds to cart")]
        public void WhenProceedsToCart()
        {
            ProductDetailsPage pdp = new ProductDetailsPage(Driver);
            ut.ClickOnElement(pdp.viewCart);
        }
        
        [Then(@"shopping cart will be displayed with expected product inside")]
        public void ThenShoppingCartWillBeDisplayedWithProductInside()
        {
            Assert.True(ut.TextPresentinElement(productData.ProductName)
        }
    }
}

using ClassLibrary;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject.StepDefinitions
{
    [Binding]
    public class JoePizzaStepDefinitions
    {
        private string pizza;
        private string result;
        private int price;
        private int quantity;
        private readonly ScenarioContext scenarioContext;
        private readonly Class1 class1;

        public JoePizzaStepDefinitions(ScenarioContext sc)
        {
            this.scenarioContext = sc;
            class1 = new Class1();
        }
        [Given(@"a pizza where name is ""([^""]*)""")]
        public void GivenAPizzaWhereNameIs(string vegLoaded)
        {
            pizza = vegLoaded;
        }

        [When(@"GetName method is called")]
        public void WhenGetNameMethodIsCalled()
        {
            result = class1.GetName();
        }

        [Then(@"the result should VegLoaded")]
        public void ThenTheResultShouldVegLoaded()
        {
            result.Should().Be(result);
        }

        [Given(@"a pizza where price is (.*)")]
        public void GivenAPizzaWherePriceIs(int p0)
        {
            price = p0;
        }

        [When(@"GetPrice method is called")]
        public void WhenGetPriceMethodIsCalled()
        {
            result = class1.GetPrice();
        }

        [Then(@"the result should (.*)")]
        public void ThenTheResultShould(int p0)
        {
            result.Should().Be(result);
        }

        [Given(@"a pizza where quantity is (.*)")]
        public void GivenAPizzaWhereQuantityIs(int p0)
        {
            quantity = p0;
        }

        [When(@"GetQuantity method is called")]
        public void WhenGetQuantityMethodIsCalled()
        {
           result= class1.GetQuantity();
        }

        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int p0)
        {
            result.Should().Be(result);
        }
    }
}

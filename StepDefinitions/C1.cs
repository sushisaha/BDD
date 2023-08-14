using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDD.StepDefinitions
{
    [Binding]
    internal class C1
    {
        [Given(@"B")]
        public void GivenB()
        {
            Console.WriteLine("Given B ***********");
        }

        [When(@"C")]
        public void WhenC()
        {
            Console.WriteLine("When C ***********");
        }

        [Then(@"D")]
        public void ThenD()
        {
            Console.WriteLine("Then D ***********");
        }

        [Given(@"Open Chrome")]
        public void GivenOpenChrome()
        {
            Console.WriteLine("Open Chrome for F1 ***********");        
        }
    }
}

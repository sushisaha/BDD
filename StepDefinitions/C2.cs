using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDD.StepDefinitions
{
    [Binding]
    internal class C2
    {
        [Given(@"E")]
        public void GivenE()
        {
            Console.WriteLine("Given E ***********");
        }

        [When(@"F")]
        public void WhenF()
        {
            Console.WriteLine("When F ***********");
        }

        [Then(@"G")]
        public void ThenG()
        {
            Console.WriteLine("Then G ***********");
        }

        [Given(@"Open Firefox")]
        public void GivenOpenFirefox()
        {
            Console.WriteLine("Open Firefox for F2 ***********");
        }
    }
}

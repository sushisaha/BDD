using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDD.Hooks
{
    [Binding]
    internal class Hooks
    {
        // before and after are hooks - applicable for all features
        // background - applicable for that particular feature
        [BeforeScenario] // pre
        public void BeforeScenario()
        {
            Console.WriteLine("Hooks: Before every scenario");
        }

        [AfterScenario] // post
        public void AfterScenario()
        {
            Console.WriteLine("Hooks: After every scenario");
        }

        [BeforeFeature]
        public static void BeforeFeature()
        {
            Console.WriteLine("Hooks: Before every feature");
        }

        [AfterFeature] // post
        public static void AfterFeature()
        {
            Console.WriteLine("Hooks: After every feature");
        }

        [BeforeScenario("CategoryA")]
        public void BeforeCategoryA()
        {
            Console.WriteLine("Hooks: Before every scenario with CategoryA");
        }

        [BeforeScenario("CategoryB")]
        public void BeforeCategoryB()
        {
            Console.WriteLine("Hooks: Before every scenario with CategoryB");
        }

        [BeforeScenario("CategoryC")]
        public void BeforeCategoryC()
        {
            Console.WriteLine("Hooks: Before every scenario with CategoryC");
        }
    }
}

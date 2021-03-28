using System;
using System.Collections.Generic;
using DesignPatterns_FactoryMethod.Dialog;

namespace DesignPatterns_FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            List<DialogFactory> factories = new List<DialogFactory>{new WebDialog(),new WindownsDialog()};

            factories.ForEach( fac => {
                fac.Render();
            });
        }
    }
}

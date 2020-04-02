using AutofacExample.Interfaces;
using Core.Interfaces;
using System;

namespace AutofacExample
{
    public class App : IApp
    {
        private readonly IDataModifier dataModifier;

        public App(IDataModifier dataModifier)
        {
            this.dataModifier = dataModifier;
        }

        public void Run()
        {
            Console.WriteLine("data:");
            Console.WriteLine(dataModifier.GetData());
            Console.WriteLine("improved data:");
            dataModifier.ImproveData(" Data has been improved!");
        }
    }
}

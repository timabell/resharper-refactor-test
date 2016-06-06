using System;

namespace resharper_refactor_test
{
    class UpperClass : MiddleClass
    {
        public override void CallMeSometime()
        {
            Console.Out.WriteLine("upper"); // some code to make this function not completely redundant

            // resharper (with warning) removes this line, causing the method in BaseThing to no longer be called
            base.CallMeSometime();
        }
    }
}

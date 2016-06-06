using System;

namespace resharper_refactor_test
{
    class MiddleClass : BaseThing
    {
        // resharper thinks this is redundant and offers to remove it, which it is,
        // *but* it also removes the line from upper, *breaking* the call to the base from upper
    }
}

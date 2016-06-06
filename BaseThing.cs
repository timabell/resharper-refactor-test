namespace resharper_refactor_test
{
    public class BaseThing
    {
        public int CallCount { get; set; }

        public BaseThing()
        {
            CallCount = 0;
        }

        public virtual void CallMeSometime()
        {
            CallCount++;
        }
    }
}

namespace example05
{
    // we must import standard libraries
    using System;
    using System.Threading.Tasks;

    // edge class must be named Startup
    public class Startup
    {
        // edge function must be async, named Invoke, single parameter of type dynamic
        public async Task<object> Invoke(dynamic input)
        {
            var hello = new Hello(input.firstName, input.lastName);
            return hello.ToString();
        }
    }

    // other classes can be defined as usual
    public class Hello
    {
        private string _firstName { get; set; }
        private string _lastName { get; set; }

        public Hello(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
        }

        public override string ToString()
        {
            return String.Format("Hello {0} {1}", _firstName, _lastName);
        }
    }
}

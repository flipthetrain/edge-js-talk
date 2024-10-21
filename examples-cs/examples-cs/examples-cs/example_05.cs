using EdgeJs;
using System;
using System.Threading.Tasks;

internal class example_05
    {
    internal class Name
    {
        // fields or properties must be public
        public string firstName { get; set; }
        public string lastName { get; set; }
    }
    internal static Task<Object> example_05_task(Name name)
    {
        string javascript = @"
            return function (input, callback) {
                // create functions and classes here                
                const makeMessage=(firstName, lastName)=>{
                    return `Hello ${firstName} ${lastName}`;
                };

                // execute buisness logic
                try {
                    const message=makeMessage(input.firstName, input.lastName)
                    console.log(message);
                    callback(null, `result: ${message}`);
                } catch (error) {
                    callback(error, `result: ${message}`);
                }                
            }
        ";
        Func<Object, Task<Object>> func = Edge.Func(javascript);
        return func(name);
    }

    internal static void exec()
    {
        Name name = new Name() { firstName = "Ken", lastName = "Hill" };
        string result = example_05_task(name).Result as String;
        Console.WriteLine(result);

        //wait for keyboard
        Console.ReadLine();
    }
}

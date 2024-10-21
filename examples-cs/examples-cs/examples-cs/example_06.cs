using EdgeJs;
using System;
using System.Threading.Tasks;

internal class example_06
    {
    internal static Task<Object> example_06_task()
    {
        string javascript = @"
            return function (input, callback) {
                // create functions and classes here                
                const makeMessage=(firstName, lastName)=>{
                    return `Hello ${firstName} ${lastName}`;
                };

                // execute buisness logic
                try {
                    callback(null, makeMessage);
                } catch (error) {
                    callback(error, null);
                }                
            }
        ";
        Func<Object, Task<Object>> func = Edge.Func(javascript);
        return func(null);
    }

    internal static void exec()
    {
        var makeMessage = example_06_task().Result;
        //var message = makeMessage("Ken", "Hill");
        //Console.WriteLine(message);

        //wait for keyboard
        Console.ReadLine();
    }
}

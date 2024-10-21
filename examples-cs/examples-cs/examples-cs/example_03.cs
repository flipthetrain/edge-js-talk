using EdgeJs;
using System;
using System.Threading.Tasks;

internal class example_03
    {
    internal static Task<Object> example_03_task(string firstName, string lastName)
    {
        string javascript = @"
            return function (input, callback) {
                try {
                    const message=`Hello ${input.firstName} ${input.lastName}`;
                    console.log(message);
                    callback(null, `result: ${message}`);
                } catch (error) {
                    callback(error, `result: ${message}`);
                }                
            }
        ";
        Func<Object, Task<Object>> func = Edge.Func(javascript);
        var input = new { firstName = firstName, lastName = lastName };
        return func(input);
    }

    internal static void exec()
    {
        string result = example_03_task("Ken", "Hill").Result as String;
        Console.WriteLine(result);

        //wait for keyboard
        Console.ReadLine();
    }
}

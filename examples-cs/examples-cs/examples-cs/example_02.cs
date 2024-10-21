using EdgeJs;
using System;
using System.Threading.Tasks;

internal class example_02
{
    internal static void exec()
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

        var input = new { firstName = "Ken", lastName = "Hill" };
        string result = func(input).Result as String;
        Console.WriteLine(result);

        //wait for keyboard
        Console.ReadLine();
    }
}

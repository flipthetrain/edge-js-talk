using EdgeJs;
using System;
using System.Threading.Tasks;

internal class example_01
    {
        internal static void exec()
        {
            string javascript = @"
            return function (firstName, callback) {
                try {
                    const message=`Hello ${firstName}`;
                    console.log(message);
                    callback(null, `result: ${message}`);
                } catch (error) {
                    callback(error, `result: ${message}`);
                }
                
            }
        ";
            Func<Object, Task<Object>> func = Edge.Func(javascript);

            string result = func("Ken").Result as String;
            Console.WriteLine(result);

            //wait for keyboard
            Console.ReadLine();
        }
    }

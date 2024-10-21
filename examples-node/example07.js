var edge = require('@agracio/edge-js/lib/edge');

var createSayHello = edge.func(function () {/*
    async (dynamic input) =>
    {
        return (Func<object,Task<object>>)(async (dynamic name) => { 
            Console.WriteLine(String.Format("Hello {0}",name.ToString())); 
			// we have to return something
            return "done"; 
        });
    }
*/});

// var sayHello = createSayHello(null, true); 
var sayHello=null;
createSayHello(null,
		function (error, result) {
		if (error) throw error;
		sayHello=result;
	}
); 

let name=process.argv[2];

if (sayHello) {
	sayHello(
		name, 
		function (error, result) {
			if (error) throw error;
			console.log(result);
		}
	);
}

var edge = require('@agracio/edge-js/lib/edge');

var createSayHello = edge.func(function () {/*
    async (dynamic input) =>
    {
		var count=(int)input;
        return (Func<object,Task<object>>)(async (dynamic name) => { 
			count++;			
            Console.WriteLine(String.Format("Hello {0} - {1}",name.ToString(),count.ToString())); 
			// we have to return something
            return "done"; 
        });
    }
*/});

// var sayHello = createSayHello(null, true); 
let startHelloCount=0;
var sayHello=null;
createSayHello(startHelloCount,
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

	sayHello(
		name, 
		function (error, result) {
			if (error) throw error;
			console.log(result);
		}
	);

	sayHello(
		name, 
		function (error, result) {
			if (error) throw error;
			console.log(result);
		}
	);
}

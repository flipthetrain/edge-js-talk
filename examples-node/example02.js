var edge = require('@agracio/edge-js/lib/edge');

var sayHello = edge.func('cs',function () {
/*
	async (dynamic input) => 
	{ 
		return String.Format("Hello {0} {1}", input.firstName, input.lastName); 
	}
*/
});

let firstName=process.argv[2];
let lastName=process.argv[3];

sayHello(
	{
		firstName: firstName,
		lastName: lastName
	}, 
	function (error, result) {
		if (error) throw error;
		console.log(result);
	}
);

var edge = require('@agracio/edge-js/lib/edge');

var sayHello = edge.func('cs',`
	async (dynamic input) => 
	{ 
		return String.Format("Hello {0}", input.ToString()); 
	}
`	
);

let name=process.argv[2];
sayHello(
	name, 
	function (error, result) {
		if (error) throw error;
		console.log(result);
	}
);

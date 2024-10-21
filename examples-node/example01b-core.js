process.env.EDGE_USE_CORECLR="1";
var edge = require('@agracio/edge-js/lib/edge');

var sayHello = edge.func('cs',function () 
	{
		/*
		async (dynamic input) => 
		{ 
			return $"Hello {input.ToString()}"; 
		}
		*/
	}
);

let name=process.argv[2];
sayHello(
	name, 
	function (error, result) {
		if (error) throw error;
		console.log(result);
	}
);

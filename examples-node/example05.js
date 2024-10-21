process.env.EDGE_USE_CORECLR="1";
var edge = require('@agracio/edge-js/lib/edge');
var path=require("node:path");


let firstName=process.argv[2];
let lastName=process.argv[3];

var dllPath=path.resolve("./example05/example05/bin/Debug/net8.0/example05.dll")
var sayHello = edge.func('cs',dllPath);

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

var edge = require('@agracio/edge-js/lib/edge');
var fs=require("node:fs");
var path=require("node:path");


let firstName=process.argv[2];
let lastName=process.argv[3];

var csSource= fs.readFileSync(path.resolve("./example04.cs")).toString();
var sayHello = edge.func('cs',csSource);

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

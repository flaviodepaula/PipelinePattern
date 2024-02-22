// See https://aka.ms/new-console-template for more information

using System.Text;
using Pipeline;
using Pipeline.Forward.Steps;


/*
this code intends to simulate some operations in a specific order according to pipeline pattern.
*/
Console.WriteLine("pipe to build a vehicle!");
var montagem = new Pipeline<StringBuilder>();
montagem.Add(new ChassisStep());
montagem.Add(new SeatStep());
montagem.Add(new DoorStep());
montagem.Add(new PaintStep());

var resultado = montagem.Execute(new StringBuilder());
Console.WriteLine(resultado.ToString());




/*
this code instents of validate a range of input values from different classes, using a pipeline pattern to execute the step validations in a sequence.

*/
Console.WriteLine("pipe to validate customer data !");
var isValidPipeline = new ValidatePipeline<bool>();
isValidPipeline.Add(new Card());
isValidPipeline.Add(new SecuritySocialID());
isValidPipeline.Add(new Customer());
isValidPipeline.Add(new Address());

var result = isValidPipeline.Execute();
Console.WriteLine(result.ToString());

using lenovoWarranty.function;


postrequest postreq = new postrequest();
getmachinetype gmt = new getmachinetype();

string? input;

getinput:
Console.Write("Please enter your Lenovo device's service tag : ");
input = Console.ReadLine();

if (input == String.Empty)
{ goto getinput; }

//gets machine type by service tag on htmldocument
string machinetype = gmt.getMT(input).Result.ToString();

//post request for warranty and device info by service tag and machine type
postreq.HTTPOST(input, machinetype);

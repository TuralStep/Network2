using System.Net;
using System.Net.Sockets;


using var client = new TcpClient("10.2.29.93", 27001);


var stream = client.GetStream();

var fileStream = new FileStream("Emin-Matata", FileMode.Create, FileAccess.Write);
stream.CopyTo(fileStream);
fileStream.Flush();




//var bw = new BinaryWriter(stream);
//var br = new BinaryReader(stream);


//while (true)
//{
//    bw.Write(Console.ReadLine() ?? string.Empty);
//    Console.WriteLine($"Answer: {br.ReadString()}");
//}
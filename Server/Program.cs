using System.Net;
using System.Net.Sockets;


var ip = IPAddress.Parse("127.0.0.1");
var port = 27001;

var listener = new TcpListener(ip, port);

listener.Start(10);

Console.WriteLine($"{listener.Server.LocalEndPoint} listening...");
var client = listener.AcceptTcpClient();
Console.WriteLine($"{client.Client.RemoteEndPoint} connected...");

var stream = client.GetStream();

var filePath = @$"C:\Users\{Environment.UserName}\Desktop\picture1.jpg";
FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);

fs.CopyTo(stream);
fs.Flush();
Console.WriteLine("Sent");


//var br = new BinaryReader(stream);
//var bw = new BinaryWriter(stream);


//while (true)
//{
//    Console.WriteLine(br.ReadString());
//    bw.Write("Roger that!");
//}
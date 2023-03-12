using System.Net.Sockets;

using var client = new TcpClient("10.2.29.93", 27001);

var stream = client.GetStream();
var bw = new BinaryWriter(stream);
var br = new BinaryReader(stream);

Task.Run(() =>
{
    while (true)
    {
        Console.WriteLine(br.ReadString());
    }
});

while (true)
{
    bw.Write(Console.ReadLine() ?? string.Empty);
    // 10.2.29.93:27001
}

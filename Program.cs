﻿//Demonstrate Sockets
using System;
using System.Net.Sockets;
using System.IO;
public class Whois
{
    static void Main(string[] args)
    {
        int port = 43;
        TcpClient client = new TcpClient();
        client.Connect("networksolutions.com", port);
        StreamWriter sw = new StreamWriter(client.GetStream());
        StreamReader sr = new StreamReader(client.GetStream());
        try 
        {
            sw.WriteLine(args[0]);
            sw.Flush();
            Console.WriteLine(sr.ReadToEnd());
        }
        catch (Exception e)
        {
            Console.WriteLine("No Arguments supplied" + e);
        }
        
    }
}

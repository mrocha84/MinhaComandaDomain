using AutoFixture;
using MinhaComandaDomain.Entities;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace MinhaComandaDomain
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Fixture fixture = new Fixture();

            var comanda = fixture.Create<Comanda>();

            comanda.Consumo.Lancamentos.FirstOrDefault().DataEstorno = null;

            string s = JsonConvert.SerializeObject(comanda);

            XNode node = JsonConvert.DeserializeXNode(s, "Comanda");

            string path = @"c:\tmp\comanda.xml";
            // Create a file to write to.
            using (StreamWriter sw = File.CreateText(path))
            {
                sw.WriteLine(node.ToString());
            }

            Console.WriteLine(node.ToString());
        }
    }
}
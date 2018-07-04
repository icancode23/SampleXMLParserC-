using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Xml;


namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            parseXML();
        }
        public static void parseXML(){
            XmlDocument xd = new XmlDocument();
            xd.Load("data.xml");
       
      XmlNodeList nodelist = xd.SelectNodes("/suite/testcase"); // get all <testcase> nodes
 
      foreach (XmlNode node in nodelist) // for each <testcase> node
      {
        
         
        Console.WriteLine(node.Attributes.GetNamedItem("id").Value);
        XmlNode n = node.SelectSingleNode("inputs");
        Console.WriteLine(n.ChildNodes.Item(0).InnerText);
      } 
       
      
 
    } 
    }
}

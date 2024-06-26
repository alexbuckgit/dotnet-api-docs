﻿// <Snippet1>
using System;
using System.IO;
using System.Xml;

public class Sample
{
  public static void Main()
  {

    XmlDocument doc = new XmlDocument();
    doc.LoadXml("<book genre='novel' ISBN='1-861001-57-5'>" +
                "<title>Pride And Prejudice</title>" +
                "</book>");

    XmlElement root = doc.DocumentElement;

    // Create a new element.
    XmlElement elem = doc.CreateElement("price");
    elem.InnerText="19.95";

    // Display the new element's owner document. Note
    // that although the element has not been inserted
    // into the document, it still has an owner document.
    Console.WriteLine(elem.OwnerDocument.OuterXml);

    // Add the new element into the document.
    root.AppendChild(elem);

    Console.WriteLine("Display the modified XML...");
    Console.WriteLine(doc.InnerXml);
  }
}
   // </Snippet1>

﻿// <Snippet1>
using System;
using System.IO;
using System.Xml;

public class Sample
{
  public static void Main()
  {
     //Create a writer to write XML to the console.
     XmlTextWriter writer = null;
     writer = new XmlTextWriter (Console.Out);

     //Use indentation for readability.
     writer.Formatting = Formatting.Indented;

     //Write an element (this one is the root).
     writer.WriteStartElement("order");

     //Write some attributes.
     writer.WriteAttributeString("date", "2/19/01");
     writer.WriteAttributeString("orderID", "136A5");

     //Write a full end element. Because this element has no
     //content, calling WriteEndElement would have written a
     //short end tag '/>'.
     writer.WriteFullEndElement();

     //Write the XML to file and close the writer
     writer.Close();
  }
}
   // </Snippet1>

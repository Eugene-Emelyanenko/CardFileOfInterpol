using Newtonsoft.Json;
using System;
using System.IO;
using System.Threading.Tasks;
using System.Text.Json;
using System.Collections.Generic;
using System.Xml.Serialization;

public static class Seralization
{
    const string DATA_PATH = "C:\\Users\\emely\\source\\repos\\CardFileOfInterpol\\DateOfCriminals.xml";
    public static void SerializeObjects(List<Criminal> criminals)
    {
        XmlSerializer serializer = new XmlSerializer(typeof(List<Criminal>));

        using (FileStream fileStream = new FileStream(DATA_PATH, FileMode.Create))
        {
            serializer.Serialize(fileStream, criminals);
        }
    }
    public static List<Criminal> DeserializeObjects()
    {
        XmlSerializer serializer = new XmlSerializer(typeof(List<Criminal>));

        using (FileStream fileStream = new FileStream(DATA_PATH, FileMode.Open))
        {
            return (List<Criminal>)serializer.Deserialize(fileStream);
        }
    }
}

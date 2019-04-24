/*
 * 
 * Created by Peter Gorman
 * XMLHandler.cs
 * 
 */

using System.Diagnostics;
using System.IO;
using System.Xml;

namespace PeterRG.Data
{
    class XMLHandler
    {
        public static XmlDocument LoadXMLFile(string filePath)
        {
            if (!File.Exists(filePath))
                return null;
            else
            {
                XmlDocument document = new XmlDocument();
                try
                {
                    document.Load(filePath);
                }
                catch (XmlException e)
                {
                    Debug.WriteLine("Failed to load XML file. Got error message: " + e.ToString());
                }
                return document;
            }
        }

        public static bool SaveXMLFile(string filePath, XmlDocument document)
        {
            try
            {
                document.Save(filePath);
                return true;
            }
            catch (XmlException e)
            {
                return false;
            }
        }
    }
}

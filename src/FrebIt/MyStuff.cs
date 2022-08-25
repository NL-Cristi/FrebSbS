using FrebIt.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Xsl;
namespace FrebIt
{
    public class MyStuff
    {
        public DataTable ToDataTable<FilesEntry>(List<FilesEntry> items)
        {
            DataTable dataTable = new DataTable(typeof(FilesEntry).Name);
            //Get all the properties
            PropertyInfo[] Props = typeof(FilesEntry).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in Props)
            {
                //Setting column names as Property names
                dataTable.Columns.Add(prop.Name);
            }
            foreach (FilesEntry item in items)
            {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++)
                {
                    //inserting property values to datatable rows
                    values[i] = Props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }
            //put a breakpoint here and check datatable
            DataTable dtCloned = dataTable.Clone();
            dtCloned.Columns[6].DataType = typeof(Int32);
            foreach (DataRow row in dataTable.Rows)
            {
                dtCloned.ImportRow(row);
            }
            return dtCloned;
        }
        public Boolean PopulateXSL(string folder)
        {
            FileInfo xslfile = new DirectoryInfo(folder).GetFiles("freb.xsl", SearchOption.TopDirectoryOnly).FirstOrDefault();
            if (xslfile != null)
            {
                return true;
            }
            else
            {
                var xmlFileFullName = new DirectoryInfo(folder).GetFiles("*.xml", SearchOption.TopDirectoryOnly).FirstOrDefault().FullName;
                var xmlFileToCheck = File.ReadAllText(xmlFileFullName);
                var embededXSL = Assembly.GetExecutingAssembly().GetManifestResourceNames();
                if (xmlFileToCheck.Contains("Server: Microsoft-IIS/7.5"))
                {
                    var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("FrebIt.Assests.2008R2.xsl");
                    var destination = folder + "\\freb.xsl";
                    using (FileStream fileStream = new FileStream(destination, FileMode.Create))
                    {
                        stream.Seek(0, SeekOrigin.Begin);
                        stream.CopyTo(fileStream);
                    }
                    return true;
                }
                if (xmlFileToCheck.Contains("Server: Microsoft-IIS/8.0"))
                {
                    var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("FrebIt.Assests.2012.xsl");
                    var destination = folder + "\\freb.xsl";
                    using (FileStream fileStream = new FileStream(destination, FileMode.Create))
                    {
                        stream.Seek(0, SeekOrigin.Begin);
                        stream.CopyTo(fileStream);
                    }
                    return true;
                }
                if (xmlFileToCheck.Contains("Server: Microsoft-IIS/8.5"))
                {
                    var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("FrebIt.Assests.2012R2.xsl");
                    var destination = folder + "\\freb.xsl";
                    using (FileStream fileStream = new FileStream(destination, FileMode.Create))
                    {
                        stream.Seek(0, SeekOrigin.Begin);
                        stream.CopyTo(fileStream);
                    }
                    return true;
                }
                if (xmlFileToCheck.Contains("Server: Microsoft-IIS/10.0"))
                {
                    var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("FrebIt.Assests.2022.xsl");
                    var destination = folder + "\\freb.xsl";
                    using (FileStream fileStream = new FileStream(destination, FileMode.Create))
                    {
                        stream.Seek(0, SeekOrigin.Begin);
                        stream.CopyTo(fileStream);
                    }
                    return true;
                }
                else
                {
                    var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("FrebIt.Assests.2022.xsl");
                    var destination = folder + "\\freb.xsl";
                    using (FileStream fileStream = new FileStream(destination, FileMode.Create))
                    {
                        stream.Seek(0, SeekOrigin.Begin);
                        stream.CopyTo(fileStream);
                    }
                    return true;
                }
            }
        }
        public List<FilesEntry> GetDataForGrid(string folder)
        {
            List<FilesEntry> firstData = new List<FilesEntry>();
            FileInfo[] firstFiles = new DirectoryInfo(folder).GetFiles("*.xml", SearchOption.TopDirectoryOnly);
            if (firstFiles.Length == 0)
            {
                return firstData;
            }
            FileInfo[] firstArray = firstFiles;
            foreach (FileInfo secondFileInfo in firstArray)
            {
                FilesEntry fileEntry = new FilesEntry();
                XmlDocument xmlDocument = new XmlDocument();
                xmlDocument.Load(secondFileInfo.FullName);
                XmlNode xmlNode = xmlDocument.SelectSingleNode("failedRequest");
                var tata = xmlDocument.LastChild;
                var mama = tata.ChildNodes;
                fileEntry.SiteId = xmlNode.Attributes["siteId"]?.InnerText;
                fileEntry.FileName = secondFileInfo.Name;
                fileEntry.Url = xmlNode.Attributes["url"].Value;
                fileEntry.Verb = xmlNode.Attributes["verb"].Value;
                fileEntry.AppPoolID = xmlNode.Attributes["appPoolId"].Value;
                fileEntry.StatusCode = xmlNode.Attributes["statusCode"].Value.Split('.')[0];
                fileEntry.TimeTaken = int.Parse(xmlNode.Attributes["timeTaken"].Value);
                fileEntry.FileFullPath = secondFileInfo.FullName;
                fileEntry.FolderPath = secondFileInfo.Directory.FullName;
                firstData.Add(fileEntry);
            }
            return firstData;
        }
        public void ReplaceFREB(string folder, string iisVersion)
        {
            FileInfo xslfile = new DirectoryInfo(folder).GetFiles("freb.xsl", SearchOption.TopDirectoryOnly).FirstOrDefault();
            if (xslfile != null)
            {
                xslfile.Delete();
                var embededXSL = Assembly.GetExecutingAssembly().GetManifestResourceNames();
                if (iisVersion.Contains("2008R2"))
                {
                    var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("FrebIt.Assests.2008R2.xsl");
                    var destination = folder + "\\freb.xsl";
                    using (FileStream fileStream = new FileStream(destination, FileMode.Create))
                    {
                        stream.Seek(0, SeekOrigin.Begin);
                        stream.CopyTo(fileStream);
                    }
                }
                if (iisVersion.Contains("2012"))
                {
                    var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("FrebIt.Assests.2012.xsl");
                    var destination = folder + "\\freb.xsl";
                    using (FileStream fileStream = new FileStream(destination, FileMode.Create))
                    {
                        stream.Seek(0, SeekOrigin.Begin);
                        stream.CopyTo(fileStream);
                    }
                }
                if (iisVersion.Contains("2012R2"))
                {
                    var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("FrebIt.Assests.2012R2.xsl");
                    var destination = folder + "\\freb.xsl";
                    using (FileStream fileStream = new FileStream(destination, FileMode.Create))
                    {
                        stream.Seek(0, SeekOrigin.Begin);
                        stream.CopyTo(fileStream);
                    }
                }
                if (iisVersion.Contains("2016"))
                {
                    var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("FrebIt.Assests.2016.xsl");
                    var destination = folder + "\\freb.xsl";
                    using (FileStream fileStream = new FileStream(destination, FileMode.Create))
                    {
                        stream.Seek(0, SeekOrigin.Begin);
                        stream.CopyTo(fileStream);
                    }
                }
                if (iisVersion.Contains("2019"))
                {
                    var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("FrebIt.Assests.2019.xsl");
                    var destination = folder + "\\freb.xsl";
                    using (FileStream fileStream = new FileStream(destination, FileMode.Create))
                    {
                        stream.Seek(0, SeekOrigin.Begin);
                        stream.CopyTo(fileStream);
                    }
                }
                if (iisVersion.Contains("2022"))
                {
                    var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("FrebIt.Assests.2022.xsl");
                    var destination = folder + "\\freb.xsl";
                    using (FileStream fileStream = new FileStream(destination, FileMode.Create))
                    {
                        stream.Seek(0, SeekOrigin.Begin);
                        stream.CopyTo(fileStream);
                    }
                }
                else
                {
                    var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("FrebIt.Assests.2022.xsl");
                    var destination = folder + "\\freb.xsl";
                    using (FileStream fileStream = new FileStream(destination, FileMode.Create))
                    {
                        stream.Seek(0, SeekOrigin.Begin);
                        stream.CopyTo(fileStream);
                    }
                }
            }
            else
            {
                throw new SystemException("ReplaceFREB failed");
            }
        }
        public void ConvertFileToHTML(ConvertInfo convertInfo, bool fullDetails)
        {
            var htmlFolderPath = $@"{convertInfo.FileFolderPath}\\HTML-Converted";
            var myXslTrans = new XslCompiledTransform();
            XsltSettings settings = new XsltSettings(false, fullDetails);
            if (!Directory.Exists(htmlFolderPath))
            {
                Directory.CreateDirectory(htmlFolderPath);
            }
            FileInfo xslfile = new DirectoryInfo(convertInfo.FileFolderPath).GetFiles("freb.xsl", SearchOption.TopDirectoryOnly).FirstOrDefault();
            var xsltfile = xslfile.FullName;
            var myXML = convertInfo.FileFullPath;
            if (fullDetails == true)
            {
                var myHtmlFileName = "Full-" + convertInfo.FileName.Replace(".xml", ".html");
                string myhtmlFullPath = $@"{htmlFolderPath}\{myHtmlFileName}";
                myXslTrans.Load(xsltfile, settings, new XmlUrlResolver());
                myXslTrans.Transform(myXML, myhtmlFullPath);
            }
            else
            {
                var myHtmlFileName = "DetailsOnly-" + convertInfo.FileName.Replace(".xml", ".html");
                string myhtmlFullPath = $@"{htmlFolderPath}\{myHtmlFileName}";
                myXslTrans.Load(xsltfile, settings, new XmlUrlResolver());
                myXslTrans.Transform(myXML, myhtmlFullPath);
            }
        }
        public void ConvertAllToHtml(List<ConvertInfo> convertInfoList, bool fullDetails)
        {
            var myXslTrans = new XslCompiledTransform();
            XsltSettings settings = new XsltSettings(false, fullDetails);
            foreach (var convertInfo in convertInfoList)
            {
                string htmlFolderPath = $@"{convertInfo.FileFolderPath}\HTML-Converted";
                if (!Directory.Exists(htmlFolderPath))
                {
                    Directory.CreateDirectory(htmlFolderPath);
                }
                FileInfo xslfile = new DirectoryInfo(convertInfo.FileFolderPath).GetFiles("freb.xsl", SearchOption.TopDirectoryOnly).FirstOrDefault();
                var xsltfile = xslfile.FullName;
                var myXML = convertInfo.FileFullPath;
                if (fullDetails == true)
                {
                    var myHtmlFileName = "Full-" + convertInfo.FileName.Replace(".xml", ".html");
                    string myhtmlFullPath = $@"{htmlFolderPath}\{myHtmlFileName}";
                    myXslTrans.Load(xsltfile, settings, new XmlUrlResolver());
                    myXslTrans.Transform(myXML, myhtmlFullPath);
                }
                else
                {
                    var myHtmlFileName = "DetailsOnly-" + convertInfo.FileName.Replace(".xml", ".html");
                    string myhtmlFullPath = $@"{htmlFolderPath}\{myHtmlFileName}";
                    myXslTrans.Load(xsltfile, settings, new XmlUrlResolver());
                    myXslTrans.Transform(myXML, myhtmlFullPath);
                }
            }
        }
    }
}

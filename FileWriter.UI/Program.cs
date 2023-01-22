using WritingTextToTxtFile;
using TextContent.Implementation;
using System.Text;
using WriteTextToPDFFile;
using TextContent.Utility;
using WriteTextToXMLFile;

///<summary>Method that runs the inhouse code documentation of the project.</summary>
//This codes below Creates a new text file
//Code Beggining.

MetaData.GetDocs();
StringBuilder TextData = MetaData.Data;
string Text = Convert.ToString(TextData) ?? "Text Input was empty.";
string FileName = "MetaDataInfo.txt";
CreateAndWriteToFile.CreateAndWrite(Text, FileName);
ConsoleMessage.Message(ConsoleColor.Magenta, $"=> Saved Text in Txt format!. File name: {FileName}");
//Text File Created Successfully.

//Creating a Json File.
string JsonFileName = "MetaDataInfo.json";
CreateJsonFile.SaveAsJsonFormat(MetaData.@ObjectData, JsonFileName);
ConsoleMessage.Message(ConsoleColor.Magenta, $"=> Saved Text in JSON format!. File name: {JsonFileName}");

//Creating an XML File. 
string XMLFileName = "MetaDataInfo.xml";
CreateXMLFile.SaveAsXmlFormat(MetaData.@ObjectData, XMLFileName);
ConsoleMessage.Message(ConsoleColor.DarkRed, $"=> Saved Text in XML format!. File name: {XMLFileName}");

//Creating a PDF File.
string PDFfileName = "MetaDataInfo.pdf";
CreatePDFfile.CreateFile(Text, PDFfileName);
ConsoleMessage.Message(ConsoleColor.DarkGreen, $"=> Saved Text in PDF format!. File name: {PDFfileName}");



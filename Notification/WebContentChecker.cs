using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Net;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace Notification
{   
    

    public class WebContentChecker
    {
        //public static WebContentChecker init = new WebContentChecker();        

        public static WebContentChecker value = new WebContentChecker();
        private List<Data> datas = new List<Data>();
        public List<Data> Datas
        {
            get
            {
                return datas;
            }
        }
        public void AddData(Data data)
        {
            if (!datas.Any(x => x.URL == data.URL && x.Class == data.Class && x.ID == data.ID))
            {
                datas.Add(data);
                Save();
            }
        }
        
        public void RemoveData(string url,string id, string @class = "")
        {            
            datas.RemoveAll(x => x.URL == url && x.Class == @class && x.ID == id);
            Save();
        }
        

        string dataFileName = System.Reflection.Assembly.GetEntryAssembly().Location + "data.bin";
        IFormatter formatter = new BinaryFormatter();
        private WebContentChecker()
        {
            
            //Stream stream = new FileStream(dataFileName, FileMode.Create, FileAccess.Write);
            // Check if we had previously Save information of our friends
            // previously
            if (File.Exists(dataFileName))
            {

                try
                {
                    // Create a FileStream will gain read access to the 
                    // data file.
                    FileStream readerFileStream = new FileStream(dataFileName,
                        FileMode.Open, FileAccess.Read);
                    // Reconstruct information of our friends from file.
                    //this.datas = (Datas)formatter.Deserialize(readerFileStream);
                    this.datas = (List<Data>)formatter.Deserialize(readerFileStream);
                    // Close the readerFileStream when we are done
                    readerFileStream.Close();
                }
                catch (Exception)
                {
                    Debug.WriteLine("There seems to be a file that contains " +
                        "friends information but somehow there is a problem " +
                        "with reading it.");
                } // end try-catch

            } // end if
            else
            {
                //datas = new Datas();
                datas = new List<Data>();
            }
        }

        public List<Data> NotCheckedDatas()
        {            
            return datas.Where(x => !x.IsTextReviewed()).ToList();
        }

        public void DataIsChecked(Data data)
        {
            datas.Where(x=> x.URL == data.URL && x.Class == data.Class && x.ID == data.ID).ToList().ForEach(y=> y.ReviewLastContent());
            Save();
        }

        private void Save()
        {
            // Gain code access to the file that we are going
            // to write to
            try
            {
                // Create a FileStream that will write data to file.
                FileStream writerFileStream =
                    new FileStream(dataFileName, FileMode.Create, FileAccess.Write);
                // Save our dictionary of friends to file
                this.formatter.Serialize(writerFileStream, datas);

                // Close the writerFileStream when we are done.
                writerFileStream.Close();
            }
            catch (Exception)
            {
                Debug.WriteLine("Unable to save our friends' information");
            } // end try-catch
        }

        bool isSomethingChanged = false;
        public void Update()
        {
            isSomethingChanged = false;
            foreach(Data data in datas.Where(x=> x.IsTextReviewed()))
            {
                Debug.WriteLine("===============================================================");
                Debug.WriteLine("Checking " + data.URL);
                if(IsWebContentChanged(data.URL,data.ID, data.Class,data.Content,out string changedValue)){
                    data.SetChangedContent(changedValue);
                    isSomethingChanged = true;
                }
                Debug.WriteLine("Data before");
               // Debug.WriteLine(data.Content);
                Debug.WriteLine("Data after");
                Debug.WriteLine("===============================================================");
                // Debug.WriteLine(data.ChangedContent);
            }
            if (isSomethingChanged)
            {
                Save();
            }
        }

        Match match;
        List<string> contents = new List<string>();
        int divCount = 0;
        public bool IsWebContentChanged(string url, string ID, string @class, string lastContent,out string changedContent)
        {
            try
            {
                using (WebClient wc = new WebClient())
                {

                    //string stringThatKeepsYourHtml = "<div id=....";
                    HtmlDocument doc = new HtmlDocument();
                    HtmlElementFlag hl = new HtmlElementFlag();

                    doc.LoadHtml(wc.DownloadString(url));

                    //doc.LoadHtml(stringThatKeepsYourHtml);
                    string content = doc.Text;

                    //content = content.Replace("</div>", "");
                    if (ID.Length > 0)
                        content = doc.GetElementbyId(ID).InnerHtml;
                    else
                    {
                        
                        content = doc.DocumentNode.SelectSingleNode("//div[@class='"+@class+"']").OuterHtml;
                        Debug.WriteLine("Checking content "+url);
                        Debug.WriteLine("Content first = " + content);
                        
                        Debug.WriteLine(content);
                    }
                    List<string> removers = new List<string>();
                    try
                    {
                        removers.AddRange(doc.DocumentNode.SelectNodes("//img[@class='wp-post-image']").Select(x => x.OuterHtml).ToList());
                    }
                    catch
                    {

                    }
                    try
                    {
                        removers.AddRange(doc.DocumentNode.SelectNodes("//a[@class='__cf_email__']").Select(x => x.OuterHtml).ToList());
                    }
                    catch
                    {

                    }

                    try
                    {
                        removers.AddRange(doc.DocumentNode.SelectNodes("//div[@class='grid-container grid-container__classic tc-grid-shadow tc-grid-border tc-grid-hover-move']").Select(x => x.OuterHtml).ToList());
                    }
                    catch
                    {

                    }
                    foreach (string remover in removers)
                    {
                        Debug.WriteLine("remover = " + remover);
                        content = content.Replace(remover, "");

                    }

                    content = content.Replace(" ", "");
                    content = content.Replace(System.Environment.NewLine, "");
                    content = Regex.Replace(content, @"\t|\n|\r", "");
                    if (lastContent != content)
                    {
                        changedContent = content;
                        return true;
                    }
                    
                    wc.Dispose();
                }
            }
            catch
            {

            }
            changedContent = string.Empty;
            return false ;
        }               
    }
}
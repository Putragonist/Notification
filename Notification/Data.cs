using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notification
{
    [System.Serializable] //it need serializable since this class will be saved as a file
    public class Data
    {
        string url = ""; //full url that want to be scrapped
        public string URL
        {
            get
            {
                return url;
            }
        }

        string @class = ""; //store this if it's not in id node
        public string @Class
        {
            get
            {
                return @class;
            }
        }

        string id = ""; //store this if it's not in class node
        public string ID //I don't want this id accessable and can be edited
        {
            get
            {
                return id;
            }
        }
        string content = ""; //if content changed store it in this string
        public string Content //I don't want this id accessable and can be edited
        {
            get
            {
                return content;
            }
        }

        string changedContent = ""; //this will stored as comparer if content is different than this variable
        public string ChangedContent //I don't want this id accessable and can be edited
        {
            get
            {
                return changedContent;
            }
        }

        /// <summary>
        /// this will stored if application find some change in web content.
        /// </summary>
        /// <param name="changedContent">content that had been changed</param>
        public void SetChangedContent(string changedContent)
        {
            this.changedContent = changedContent;
        }

        /// <summary>
        /// Set data value when initiated
        /// </summary>
        /// <param name="url">url </param>
        /// <param name="id">id</param>
        /// <param name="class">class</param>
        /// <param name="content">content</param>
        public Data(string url,string id, string @class, string content)
        {
            this.url = url;
            this.@class = @class;
            this.content = content;
            this.id = id;
        }

        /// <summary>
        /// For inputing, I don't want to add first content. Just let the application detect it. So
        /// It probably best to not input it at first
        /// </summary>
        /// <param name="url"></param>
        /// <param name="id"></param>
        /// <param name="class"></param>
        public Data(string url,string id, string @class)
        {
            this.url = url;
            this.id = id;
            this.@class = @class;
            
        }
        
        /// <summary>
        /// If you click done button in main for. This will called.
        /// Last changed content already confirmed
        /// </summary>
        public void ReviewLastContent()
        {
            content = changedContent;
        }

        /// <summary>
        /// Check if web already seen and reviewed. If it's different from last input it will return false
        /// </summary>
        /// <returns>is content changed</returns>
        public bool IsTextReviewed()
        {
            return content == changedContent;
        }
    }
}

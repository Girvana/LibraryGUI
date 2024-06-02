using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace LibraryGUI
{
    internal class GoogleBooksRetriever
    {
        public static (string title, string description, List<string> authors) GetInfoFromISBN(string isbn)
        {
            var client = new WebClient();
            string apiResponse = client.DownloadString($"https://www.googleapis.com/books/v1/volumes?q=isbn:{isbn}"); //google books api call
            
            var json = JObject.Parse(apiResponse);
            if ((int)json["totalItems"] == 0)
            {
                Program.errorHandler.Add("Book data not found for specified ISBN", "Invalid ISBN");
                throw new Exception("Invalid ISBN"); //throw invalid isbn exception if isbn is not found
            }
            var info = json["items"][0]["volumeInfo"]; //get just the volumeinfo object

            string description = "[Not in Record]";
            string title = "[Not in Record]";
            List<string> authors = new();
            //pull required info from the json object
            if (info["title"] is not null) title = info["title"].ToString();
            if (info["description"] is not null) description = info["description"].ToString();
            if (info["authors"] is not null)
            {
                var authorList = info["authors"].ToList();
                foreach (var author in authorList)
                {
                    authors.Add(author.ToString());
                }
            }
            else authors.Add("[Not in Record]");
            return (title, description, authors);
        }

    }
}

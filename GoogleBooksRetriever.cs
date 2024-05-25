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
        public static (string title, string description, List<string> authors) GetInfoFromISBN(int isbn)
        {
            var client = new WebClient();
            string apiResponse = client.DownloadString($"https://www.googleapis.com/books/v1/volumes?q=isbn:{isbn}"); //google books api call
            
            var json = JObject.Parse(apiResponse);
            if ((int)json["totalItems"] != 1) throw new Exception("Invalid ISBN"); //throw invalid isbn exception if isbn is not found
            var info = json["items"][0]["volumeInfo"]; //get just the volumeinfo object

            //pull required info from the json object
            string title = info["title"].ToString();
            string description = info["description"].ToString();
            List<string> authors = new();
            var authorList = info["authors"].ToList();
            foreach (var author in authorList)
            {
                authors.Add(author.ToString());
            }

            return (title, description, authors);
        }

    }
}

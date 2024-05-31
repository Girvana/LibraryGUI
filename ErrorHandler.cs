using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LibraryGUI
{
    internal class ErrorHandler
    {
        public string title = "";
        public bool hasError = false;
        public List<string> errors = new List<string>();
        
        public ErrorHandler()
        {
        }
        
        public void Add(string message)
        {
            errors.Add(message);
            hasError = true;
        }
        public void Title(string title) 
        {
            if (this.title == "" || this.title == title)
            {
                this.title = title;
            }
            else
            {
                this.title = "Multiple Issues";
            }
        }

        public void Clear()
        {
            errors.Clear();
            title = "";
            hasError = false;
        }
        public void Display()
        {
            if (hasError)
            {
                StringBuilder sb = new StringBuilder();
                foreach (string error in errors)
                {
                    sb.Append("• " + error + "\n\n");
                }
                MessageBox.Show(sb.ToString(), title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Clear();
            }
            else return;
        }
    }
}

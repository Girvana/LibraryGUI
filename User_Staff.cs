using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryGUI
{
    internal class Staff : User
    {
        //## Fields ##
        private static int NextID = -1;
        private bool isAdmin = false;
        //## Properties ##

        //## Constructors ##
        public Staff(string name, bool isAdmin = false) : base(name)
        {
            id = NextID--;
            this.isAdmin = isAdmin;
        }
        internal Staff(int id, string name, int feesOwed, bool isAdmin) : base(id, name, feesOwed)
        {
            this.isAdmin = isAdmin;
        } //To be used for Storage Loading

        /// <summary>
        /// <c>ForceNextID</c> should NOT be called by anything other than the storage manager.
        /// </summary>
        internal static void ForceNextID(int id)
        {
            NextID = id;
        }
    }
}

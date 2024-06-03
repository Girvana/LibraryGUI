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
        static new int maxBorrows = int.MaxValue;
        static new int maxSimultaneousBorrows = 10;
        private static int NextID = -1;
        //## Properties ##
        public override string BorrowMax
        {
            get
            {
                if (maxBorrows != int.MaxValue)
                    return maxBorrows.ToString();
                else return "No Maximum Borrows";
            }
        }
        public override string BorrowMaxSimultaneous
        {
            get
            {
                if (maxSimultaneousBorrows != int.MaxValue)
                    return maxSimultaneousBorrows.ToString();
                else return "No Maximum";
            }
        }
        //## Constructors ##
        public Staff(string firstName, string lastName) : base(firstName, lastName)
        {
            id = NextID--;
        }
        internal Staff(int id, string firstName,string lastName, int feesOwed) : base(id, firstName, lastName, feesOwed)
        {

        } //To be used for Storage Loading

        /// <summary>
        /// <c>ForceNextID</c> should NOT be called by anything other than the storage manager.
        /// </summary>
        internal static void ForceNextID(int id)
        {
            NextID = id;
        }

        public override bool CanBorrow()
        {
            return base.CanBorrow();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Configuration.Internal;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LibraryGUI
{
    internal class Staff : User
    {
        //## Fields ##
        static new int maxBorrows = int.MaxValue;
        static new int maxSimultaneousBorrows = 10;
        private static int nextID = -1;
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
        public static int NextID
        {
            get => nextID;
        }
        public static int[] BorrowInfo
        {
            get
            {
                var borrowInfo = new int[2];
                borrowInfo[0] = maxBorrows;
                borrowInfo[1] = maxSimultaneousBorrows;
                return borrowInfo.ToArray();
            }
        }
        //## Constructors ##
        public Staff(string firstName, string lastName) : base(firstName, lastName)
        {
            id = nextID--;
        }
        internal Staff(int id, string firstName,string lastName, int feesOwed, int borrowCount, string username) : base(id, firstName, lastName, feesOwed, borrowCount, username)
        {

        } //To be used for Storage Loading

        /// <summary>
        /// <c>ForceNextID</c> should NOT be called by anything other than the storage manager.
        /// </summary>
        internal static void ForceNextID(int id)
        {
            nextID = id;
        }
        internal static void SetBorrowValues(int maxBorrows, int maxSimultaneousBorrows)
        {
            Staff.maxBorrows = maxBorrows;
            Staff.maxSimultaneousBorrows = maxSimultaneousBorrows;
        }
        public override bool CanBorrow()
        {
            return base.CanBorrow();
        }
        
    }
}

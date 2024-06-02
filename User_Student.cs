using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryGUI
{
    internal class Student : User
    {
        //## Fields ##
        static new int maxBorrows = 5;
        static new int maxSimultaneousBorrows = 3;
        private static int NextID = 1;
        //## Properties ##
        public int BorrowCount
        {
            get => borrowCount;
        }
        public int BorrowMax
        {
            get => maxBorrows;
        }
        //## Constructors ##
        public Student(string firstName, string lastName) : base(firstName, lastName)
        {
            id = NextID++;
        }
        internal Student(int id, string firstName, string lastName, int feesOwed, int borrowCount) : base(id, firstName, lastName, feesOwed)//To be used for Storage Loading
        {
            this.borrowCount = borrowCount;
        }
        //## Methods ##

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

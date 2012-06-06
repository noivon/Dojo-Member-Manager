using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DojoMemberManager
{
    class Member
    {
        String fName {get; set; }
        String lName { get; set; }
        DateTime dateOfBirth { get; set; }
        DateTime signatureWaiver { get; set; }
        Address address { get; set; }
        PhoneNumber phoneNumber { get; set; }
        String emailAddress { get; set; }
        double monthlyDue { get; set; }
        


        /*
         * Default Constructor for a Member
         */
        public Member()
        {
            fName = String.Empty;
            lName = String.Empty;
            dateOfBirth = DateTime.MinValue;
            signatureWaiver = DateTime.MinValue;
            address = new Address();
        }
        


        /*
         * Returns the age of this member (in years) calculated from the DOB.
         */
        public int getAge()
        {
            int age;
            age = (int) (DateTime.Now.Subtract(dateOfBirth).Days/365.25);
            return age;
        }
    }
}

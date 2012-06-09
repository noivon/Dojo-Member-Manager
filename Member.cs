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
        String phoneNumber { get; set; }
        String emailAddress { get; set; }
        double dues { get; set; }
        DateTime dateOfBirth { get; set; }
        DateTime signatureWaiver { get; set; }
        Address address { get; set; }
        


        /*
         * Default Constructor for a Member
         */
        public Member(String first = "", String last = "", 
            String phNumber = "555-5555", String email = "yoda@dagobah.net", double dues = 0.00)
        {
            fName = first;
            lName = last;
            dateOfBirth = DateTime.MinValue;
            signatureWaiver = DateTime.MinValue;
            address = new Address();
            this.dues = dues;
        }
        /*
         * Constructor for fielding all values of a member
         */
        public Member(String first, String last,
            String phNumber, String email, double dues, DateTime doB, DateTime sig,
            int house = 123, String street = "Fake St.", String city = "City", String state = "ST", int zip = 55555)
        {
            fName = first;
            lName = last;
            dateOfBirth = DateTime.MinValue;
            signatureWaiver = DateTime.MinValue;
            address = new Address(house, street, city, state, zip);
            this.dues = dues;
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DojoMemberManager
{
    class Address
    {
        int houseNumber { get; set; }
        String street { get; set; }
        string city;
        string state;
        int zipcode;

        public Address(int house, String street, String city, String state, int zip)
        {
            houseNumber = house;
            this.street = street;
            this.city = city;
            this.state = state;
            zipcode = zip;
        }
    }
}

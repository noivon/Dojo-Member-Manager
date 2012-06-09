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

        public Address(int house = 123, String street = "Fake St.", String city = "City", String state = "ST", int zip= 55555)
        {
            houseNumber = house;
            this.street = street;
            this.city = city;
            this.state = state;
            zipcode = zip;
        }
    }
}

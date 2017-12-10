using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WCFEcommerceRest
{
    [DataContract (Name ="Customer")]
    public class Customer
    {
        //private int _id;
        //private string FirstName;
        //private string lastName;
        [DataMember (Name ="id")]
        public int ID
        {
            get;set;

        }
        [DataMember (Name ="firstname")]
        public string FirstName
        {
            get; set;

        }
        [DataMember(Name ="lastname")]
        public string LastName
        {
            get; set;

        }
    }
}
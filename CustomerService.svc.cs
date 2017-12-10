using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFEcommerceRest
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
 
        [DataContract (Namespace ="Customer")]
    public class CustomerRequest
    {
        [DataMember (Name ="Customer")]
        public Customer custobj { get;   set; }
    }

    public class CustomerService : ICustomer
    {
        CustomerRequest cr = new CustomerRequest();

        public Customer GetOrderOfCustomerJSON(string id)
        {
            Customer cs = new Customer();
            try
            {
                cs.FirstName = "abc";
                cs.LastName = "abc";
            }
            catch (Exception)
            {


            }
            return cs;
        }

        public List<Customer> GetOrderOfCustomerList(string id)
        {
            List<Customer> cs = new List<Customer>();
            try
            {
                cs.Add(new Customer() { FirstName="aa",LastName="bb"});
                cs.Add(new Customer() { FirstName = "ss", LastName = "ss" });
            }
            catch (Exception)
            {


            }
            return cs;
        }
        //public CustomerRequest GetOrderOfCustomerJSON(string id)
        //{

        //    try
        //    {
        //        cr.custobj = new Customer();
        //        cr.custobj.FirstName = "ABC";
        //        cr.custobj.LastName = "DEF";
        //    }
        //    catch (Exception ex)
        //    {


        //    }
        //    return cr;
        //}        
    }
}

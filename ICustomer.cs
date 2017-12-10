using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Web;
using System.Web.Services;

namespace WCFEcommerceRest
{
    [ServiceContract]
    interface ICustomer
    {
        [WebInvoke(UriTemplate ="/GetCustomer/{id}" ,Method ="GET",RequestFormat =WebMessageFormat.Json,ResponseFormat =WebMessageFormat.Json,BodyStyle =WebMessageBodyStyle.WrappedRequest)]
        Customer GetOrderOfCustomerJSON(string id);

        [WebInvoke(UriTemplate = "/GetCustomerlist/{id}", Method = "GET", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.WrappedRequest)]
        List<Customer> GetOrderOfCustomerList(string id);
    }
}
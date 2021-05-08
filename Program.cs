using System;
using System.Collections.Generic;
//using Twilio;
//using Twilio.Rest.Api.V2010.Account;
//using Twilio.Rest.Lookups.V1;

namespace TestingConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            ////Country Codes : https://gist.github.com/Goles/3196253

            ////https://www.twilio.com/docs/lookup/api#lookups-instance-properties

            //string accountSid = "ACeabbe37f734bae2220686360065cc4aa";
            //string authToken = "8f6d6b8eea3d5dd2fea4e6089b0fb41c";

            //TwilioClient.Init(accountSid, authToken);

            //string[] phoneNumbers = new string[] { "+33109758351", "+447911123456", "+15108675310", "+919595312542", "8329769431", "+4930901820" };

            //var type = new List<string> { "carrier" };

            //foreach (var number in phoneNumbers)
            //{
            //    var phoneNumber = PhoneNumberResource.Fetch(
            //    //type: type,
            //    pathPhoneNumber: new Twilio.Types.PhoneNumber(number)
            //);

            //    Console.WriteLine("Phone Number : " + number);
            //    Console.WriteLine("Country Code : " + phoneNumber.CountryCode);
            //    Console.WriteLine("-------------------------------------------------");
            //}


            //Console.ReadKey();



            ////Routee lookup (Chargable)
            ////https://docs.routee.net/docs/request-a-lookup
            ////var client = new RestClient("https://connect.routee.net/lookup");
            ////var request = new RestRequest(Method.POST);
            ////request.AddHeader("content-type", "application/json");
            ////request.AddHeader("authorization", "Bearer 12dc9fe4-7df4-4786-8d7a-a46d307687f4");
            ////request.AddParameter("application/json", "{ \"to\": \"+4475XXXXXXX\",\"label\" : \"HLR Tagging Label\"}", ParameterType.RequestBody);
            ////IRestResponse response = client.Execute(request);


            ////Telny Lookup (Free of charge)
            ////https://developers.telnyx.com/docs/api/v1/number-lookup#number-lookup-public
            ////https://developers.telnyx.com/docs/api/v1/number-lookup#number-lookup-private
            ////https://developers.telnyx.com/docs/api/v2/number-lookup


            //// 3 collections

            //// we need to maintain providers configuration against country code in db or some where (virtual numbers)

            //// provider with multiple virtual numbers

            ////country specific use virtual number or alpha numeric code

            ////Resend msg (msg track by id b4 resend)
            //// check if there is entry against channel, receiver & current date in messagelog for passing tenant
            //// then this is resend request
            //// now send msg against virtual number instead of alpha numeric code
        }
    }
}

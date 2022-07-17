namespace Telephony.Core
{
    using System;
    using System.Collections.Generic;


    public class Engine
    {
        private Smartphone smartphone;
        private IList<string> phoneNumbers;
        private IList<string> urls;

        public Engine()
        {
            this.smartphone = new Smartphone();
            this.phoneNumbers = new List<string>();
            this.urls = new List<string>();
        }

        public void Run()
        {
            phoneNumbers = Console.ReadLine().Split();
            urls = Console.ReadLine().Split();

            CallTelephone();
            BrowseUrl();
        }

        private void CallTelephone()
        {
            foreach (var phoneNumber in phoneNumbers)
            {
                try
                {
                    Console.WriteLine(this.smartphone.Call(phoneNumber));
                }
                catch (ArgumentException ae)
                {

                    Console.WriteLine(ae.Message);
                }
            }
        }

        private void BrowseUrl()
        {
            foreach (var url in urls)
            {
                try
                {
                    Console.WriteLine(this.smartphone.Browse(url));
                }
                catch (ArgumentException ae)
                {

                    Console.WriteLine(ae.Message);
                }
            }
        }


    }
}

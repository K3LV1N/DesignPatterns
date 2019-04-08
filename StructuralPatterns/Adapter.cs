using System;
using System.Collections.Generic;

namespace StructuralPatterns
{
    public interface ICustomerSource
    {
        List<string> GetCustomers();
    }

    //This is the ADAPTER CLIENT CLASS
    public class CustomerManagement
    {
        private ICustomerSource adapter; 

        public CustomerManagement(ICustomerSource adapter) { this.adapter = adapter; }

        public List<string> DisplayCustomers() => adapter.GetCustomers();
    }

    public class ExternalCustomerStore
    {
        private List<string> customers = new List<string>()
        {
            "Notorious BIG",
            "Tupac Shakur",
            "Faith Evans",
            "Puff Daddy"
        };

        public List<string> GetCustomers() => customers;
    }

    public class CustomerAdapter : ICustomerSource
    {
        private List<string> adaptedCustomers = new List<string>();

        private ExternalCustomerStore _customerStore;

        public CustomerAdapter(ExternalCustomerStore customerStore)
        {
            _customerStore = customerStore;
        }

        public List<string> GetCustomers()
        {
            var sourceData = _customerStore.GetCustomers();

            foreach(string customer in sourceData)
                adaptedCustomers.Add($"{customer} - adapted");

            return adaptedCustomers;
        }
    }
}

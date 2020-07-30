using System;
using System.Collections.Generic;

namespace ACM.BL
{
    public class Customer
    {
        public int CustomerId { get; private set; }
        public string EmailAddress { get; set; }

        public string FirstName { get; set; }

        public string FullName
        {
            get
            {
                string fullName = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += ", ";
                    }
                    fullName += FirstName;
                }

                return fullName;
            }
        }

        private string _lastName;
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }


        ///<summary>
        ///Retrieve one customer.</summary>
        ///<returns></returns>///
        public Customer Retrieve(int CustomerId)
        {
            // code that defines retrieved customer
            return new Customer();
        }

        ///<summary>Returns a list of all the customers</summary>
        ///<returns></returns>
        public List<Customer> Retrieve()
        {
            return new List<Customer>();
        }

        ///<summary>Saves the current customer</summary>
        ///<returns></returns>
        public bool Save()
        {
            // code that saves the defined customer
            return true;
        }

        /// <summary>
        /// Validates the customer data.
        /// </summary>
        ///<returns></returns>
        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

            return isValid;
        }

        public static int InstanceCount { get; set; }
    }

}

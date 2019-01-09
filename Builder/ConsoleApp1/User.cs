using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class User
    {
        private readonly string username;
        private readonly string password;
        private readonly string firstName;
        private readonly string lastName;
        private readonly string email;
        private readonly string phone;
        private readonly string address;

        private User(Builder builder)
        {
            this.username = builder.username;
            this.password = builder.password;
            this.firstName = builder.firstName;
            this.lastName = builder.lastName;
            this.email = builder.email;
            this.phone = builder.phone;
            this.address = builder.address;
        }

        override public string ToString()
        {
            return this.username + ", " + this.password + ", " + this.firstName + ", " + this.lastName + ", " + this.email + ", " + this.phone + ", " + this.address;
        }

        public class Builder
        {
            internal string username { get; set; }
            internal string password { get; set; }
            internal string firstName { get; set; }
            internal string lastName { get; set; }
            internal string email { get; set; }
            internal string phone { get; set; }
            internal string address { get; set; }

            public Builder(string username, string password)
            {
                this.username = username;
                this.password = password;
            }

            public Builder setFirstName(string firstName)
            {
                this.firstName = firstName;
                return this;
            }

            public Builder setLastName(string lastName)
            {
                this.lastName = lastName;
                return this;
            }
            public Builder setEmail(string email)
            {
                this.email = email;
                return this;
            }

            public Builder setPhone(string phone)
            {
                this.phone = phone;
                return this;
            }
            public Builder setAddress(string address)
            {
                this.address = address;
                return this;
            }

            public User createUser()
            {
                return new User(this);
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creatianal.Builder
{
    public class Student
    {
        private string Name;
        private string Surname;
        private int Age;
        private int Birthday;
        private string Address;
        private string Phone;
        private string Email;

        // getter of all varible
        public string GetName()
        {
            return Name;
        }
        public string GetSurname()
        {
            return Surname;
        }
        public int GetAge()
        {
            return Age;
        }
        public int GetBirthday()
        {
            return Birthday;
        }
        public string GetAddress()
        {
            return Address;
        }
        public string GetPhone()
        {
            return Phone;
        }
        public string GetEmail()
        {
            return Email;
        }


        public Student(Builder Build)
        {
            this.Name = Build.Name;
            this.Surname = Build.Surname;
            this.Age = Build.Age;
            this.Birthday = Build.Birthday;
            this.Address = Build.Address;
            this.Phone = Build.Phone;
            this.Email = Build.Email;


        }

    
        public  class Builder
        {
            public string Name;
          public string Surname;
            public int Age;
            public int Birthday;
            public string Address;
            public string Phone;
            public string Email;

            public Builder SetName(string name)
            {
                this.Name = name;
                return this;
            }
            public Builder SetSurname(string surname)
            {
                this.Surname = surname;
                return this;
            }
            public Builder SetAge(int age)
            {
                this.Age = age;
                return this;
            }
            public Builder SetBirthday(int birthday)
            {
                this.Birthday = birthday;
                return this;
            }
            public Builder SetAddress(string address)
            {
                this.Address = address;
                return this;
            }
            public Builder SetPhone(string phone)
            {
                this.Phone = phone;
                return this;
            }
            public Builder SetEmail(string email)
            {
                this.Email = email;
                return this;
            }

            public Student build() {

                return new Student(this);
            }

            

        }
        public string tostring()
        {
            return "Name: " + Name + " Surname: " + Surname + " Age: " + Age + " Birthday: " + Birthday + " Address: " + Address + " Phone: " + Phone + " Email: " + Email;
        }



    }
}

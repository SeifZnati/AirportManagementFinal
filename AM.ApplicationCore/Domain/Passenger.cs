using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Passenger
    {
        public int PassengerId { get; set; }
        public DateTime BirthDate { get; set; }
        public String EmailAddress { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String PassportNumber { get; set; }
        public String TelNumber { get; set; }
        public ICollection<Flight> Flights { get; set; }

        public override string ToString()
        {
            return " First Name: " + FirstName
                + " Last Name: " + LastName;
        }

        //public bool CheckProfile(String fn, String ln)
        //{
        //    return FirstName == fn 
        //        && LastName == ln;
        //}

        //public bool CheckProfile(String fn, String ln,String em)
        //{
        //    return FirstName == fn 
        //        && LastName == ln 
        //        && EmailAddress == em;
        //}

        public bool CheckProfile(String fn, String ln, String em=null)
        {
            if (em == null) {
                return FirstName == fn
                    && LastName == ln;
            } else {
               return FirstName == fn
                    && LastName == ln 
                    && EmailAddress == em;
            }
        }
        public virtual void PassengerType()
        {
            Console.WriteLine("I am a Passenger");
        }
    }


}
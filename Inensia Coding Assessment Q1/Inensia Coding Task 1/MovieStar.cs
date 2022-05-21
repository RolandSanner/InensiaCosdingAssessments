using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inensia_Coding_Task_1
{
    [Serializable]
    public class MovieStar
    {
        public DateTime dateOfBirth { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Sex { get; set; }
        public string Nationality { get; set; }
        
        public int Age
        {
            get
            {
                // assuming there are no null birthday values;
                DateTime zero = new DateTime(1, 1, 1);
                
                DateTime today = DateTime.Today;
                TimeSpan span = today - dateOfBirth;

                int years = (zero + span).Year - 1;
                return years;
            }
        }
    }
}

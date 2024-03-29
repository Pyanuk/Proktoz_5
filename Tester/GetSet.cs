using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST
{
    internal class GetSet
    {
        public GetSet(string Title, string Desc, string Answ1, string Answ2, string Answ3, TestEnum Correct_answ)
        {
            title = Title;
            desc = Desc;
            answ1 = Answ1;
            answ2 = Answ2;
            answ3 = Answ3;
            correct_answ = Correct_answ;
        }

        public string title { get; set; }
        public string desc { get; set; }
        public string answ1 { get; set; }
        public string answ2 { get; set; }
        public string answ3 { get; set; }
        public Enum correct_answ { get; set; }

        
    }
}

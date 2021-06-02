using System;
using System.Collections.Generic;
using System.Text;

namespace WpfApp_LAB4_zadanie1_w61933
{
    public class Student
    {
        public string imie { get; set; }
        public string nazwisko { get; set; }
        public int nrIndeksu { get; set; }
        public string wydzial { get; set; }

        public Student(string imie, string nazwisko, int nrIndeksu, string wydzial) {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.nrIndeksu = nrIndeksu;
            this.wydzial = wydzial;
        }
        public Student() : this( "","",0,"")
        {}
        
            
        

    }
}

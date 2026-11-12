using System;
using System.Collections.Generic;
using System.Text;

namespace CLI20261112doga
{
    internal class Videogame
    {
        public string Cim { get; set; }
        public string Mufaj { get; set; }
        public DateTime KiadasDatum { get; set; }
        public int AktivJatekosok { get; set; }
        public float Ertekeles { get; set; }

        public override string ToString() =>
            $"\tCim:     {Cim}\n" +
            $"\tMufaj: {Mufaj}\n" +
            $"\tKiadasDatum:        {KiadasDatum}\n" +
            $"\tAktivJatekosok:        {AktivJatekosok}\n" +
            $"\tErtekeles:        {Ertekeles}\n";

        public Videogame(string row)    
        {
            var data = row.Split(',');
            Cim = data[0];
            Mufaj = data[1];
            KiadasDatum = Convert.ToDateTime(data[2]);
            AktivJatekosok = int.Parse(data[3]);
            Ertekeles = float.Parse(data[4].Replace('.', ','));
        }
    }
}

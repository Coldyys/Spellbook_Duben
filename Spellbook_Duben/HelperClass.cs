using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpellBook
{
    internal class HelperClass
    {
        public Random generator = new Random();

        public string[] PoleZTextu(string adresaSouboru)
        {
            string obsahTxt = File.ReadAllText(adresaSouboru);
            return obsahTxt.Split(';');
        }
        //vygeneruje spellname z txt
        public string VygenerujSpellname(string[] poleForma, string[] poleTypy)
        {

            int randomName = generator.Next(23);
            string spellName = $"{poleForma[randomName]} {poleTypy[randomName]}";
            return spellName;


        }
        //vygeneruje random číslo
        public int VygenerujCislo(int max)
        {
            int randomCislo = generator.Next(max);
            return randomCislo;
        }

    }
}

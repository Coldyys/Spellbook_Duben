global using SpellBook;

Console.WriteLine("Generátor náhodných spellů");

List<Spell> seznamSpellu = new List<Spell>();
HelperClass pomocneMetody = new HelperClass();
Spell Spell = new Spell();

string[] poleForma = pomocneMetody.PoleZTextu("txt/spellform.txt");
string[] poleTypy = pomocneMetody.PoleZTextu("txt/spelltypes.txt");

while (true)
{
    Console.WriteLine("1. vygenerovat nový spell a přidat do Spellbook");
    Console.WriteLine("2. zobrazit Spellbook");
    Console.WriteLine("3. smazat poslední záznam ve SpellBooku");
    Console.WriteLine("4. smazat celý SpellBook");
    Console.WriteLine("5. ukončit aplikaci");

    string input = Console.ReadLine();
    //vygeneruje nový spel a přidá ho do spellbooku
    if (input == "1")
    {
        Spell newSpell = new Spell();
        newSpell.ManaCost = pomocneMetody.VygenerujCislo(100);
        newSpell.Name = pomocneMetody.VygenerujSpellname(poleForma, poleTypy);
        seznamSpellu.Add(newSpell);
        Console.Clear();
    }
    //zobrazí spellbook
    else if (input == "2")
    {
        foreach (var spell in seznamSpellu)
        {
            ;
            Console.WriteLine($"Spell: {spell.Name}, Mana: {spell.ManaCost}");
        }
    }
    //smaže poslední záznam ve spellbooku
    else if (input == "3")
    {
        int indexPosledniho = seznamSpellu.Count - 1;
        Spell posledni = seznamSpellu[indexPosledniho];
        seznamSpellu.Remove(posledni);
        Console.Clear();
    }
    //smaže celý spellbook
    else if (input == "4")
    {
        seznamSpellu.Clear();
        Console.Clear();
    }
    //vypne aplikaci
    else if (input == "5")
    {
        break;
    }



}
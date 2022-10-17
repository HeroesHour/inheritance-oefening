using System;

// field/property/method in de hoofdclass
// werken met base om field/method van hoofdclass aan te roepen in een child class
// ik wil constructor overloading zien
// ik wil method overriding zien (met of zonder virtual/override)


// Maak alle objecten aan
Voertuig voertuig = new Voertuig("None");
LandVoertuig landVoertuig1 = new LandVoertuig("Auto");
LandVoertuig landVoertuig2 = new LandVoertuig("Truck", 6);
LuchtVoertuig luchtVoertuig = new LuchtVoertuig("Vliegtuig");
WaterVoertuig waterVoertuig = new WaterVoertuig("Boot");
RuimteVoertuig ruimteVoertuig = new RuimteVoertuig("Raket");

// Print alle info van de voertuigen
//voertuig.Print();
Console.WriteLine("  VOERTUIGEN:");
landVoertuig1.Print();
landVoertuig2.Print();
luchtVoertuig.Print();
waterVoertuig.Print();
ruimteVoertuig.Print();



class Voertuig // Parent
{
    public string naam = "test";
    public int aantalWielen = 0;
    public bool kanVliegen = false;
    public bool kanVaren = false;

    public Voertuig(string naam)
    {
        this.naam = naam;
    }

    public virtual void Print()
    {
        // Dit print het object-type uit
        Console.WriteLine($"Dit {this.GetType()} ({naam}) heeft:");
        // De child-classes voegen hun eigen waarden toe
    }
}

class LandVoertuig : Voertuig // Child
{
    public LandVoertuig(string naam, int aantalWielen) : base(naam)
    {
        this.aantalWielen = aantalWielen;
    }

    public LandVoertuig(string naam) : base(naam)
    {
        aantalWielen = 4;
    }

    public override void Print()
    {
        base.Print();
        Console.WriteLine($"- De mogelijkheid om te rijden \n- Heeft {aantalWielen} wielen \n");
    }
}

class LuchtVoertuig : Voertuig // Child
{
    public LuchtVoertuig(string naam, int aantalWielen = 6) : base(naam)
    {
        this.aantalWielen = aantalWielen;
        kanVliegen = true;
    }

    public override void Print()
    {
        base.Print();
        Console.WriteLine($"- De mogelijkheid om te vliegen \n- Heeft {aantalWielen} wielen \n");
    }
}

class WaterVoertuig : Voertuig // Child
{
    public WaterVoertuig(string naam) : base(naam)
    {
        kanVaren = true;
    }

    public override void Print()
    {
        base.Print();
        Console.WriteLine("- De mogelijkheid om te varen \n");
    }
}

class RuimteVoertuig : Voertuig
{
    public RuimteVoertuig(string naam) : base(naam)
    {
        kanVliegen = true;
        aantalWielen = 0;
    }

    public override void Print()
    {
        base.Print();
        Console.WriteLine($"- De mogelijkheid om te vliegen \n");
    }
}
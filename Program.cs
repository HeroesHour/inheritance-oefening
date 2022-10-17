using System;

// field/property/method in de hoofdclass
// werken met base om field/method van hoofdclass aan te roepen in een child class
// ik wil constructor overloading zien
// ik wil method overriding zien (met of zonder virtual/override)


// Maak alle objecten aan
Voertuig voertuig = new Voertuig();
LandVoertuig landVoertuig1 = new LandVoertuig("Auto", 4);
LandVoertuig landVoertuig2 = new LandVoertuig("Truck", 6);
LuchtVoertuig luchtVoertuig = new LuchtVoertuig("Vliegtuig");
WaterVoertuig waterVoertuig = new WaterVoertuig("Boot");
RuimteVoertuig ruimteVoertuig = new RuimteVoertuig("Raket");

// Print alle info van de voertuigen
voertuig.Print();

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

    public virtual void Print()
    {
        // Dit print het object-type uit
        Console.WriteLine($"Dit {this.GetType()} heeft:");
        // De child-classes voegen hun eigen waarden toe
    }
}

class LandVoertuig : Voertuig // Child
{
    public LandVoertuig(string naam, int aantalWielen)
    {
        this.aantalWielen = aantalWielen;
    }

    public override void Print()
    {
        base.Print();
        Console.WriteLine("Test");
    }
}

class LuchtVoertuig : Voertuig // Child
{
    public LuchtVoertuig(string naam, int aantalWielen = 6)
    {
        this.aantalWielen = aantalWielen;
        kanVliegen = true;
    }

    public override void Print()
    {
        base.Print();
        Console.WriteLine();
    }
}

class WaterVoertuig : Voertuig // Child
{
    public WaterVoertuig(string naam)
    {
        kanVaren = true;
    }

    public override void Print()
    {
        base.Print();
        Console.WriteLine();
    }
}

class RuimteVoertuig : Voertuig
{
    public RuimteVoertuig(string naam)
    {
        kanVliegen = true;
        aantalWielen = 0;
    }

    public override void Print()
    {
        base.Print();
        Console.WriteLine($"De mogelijkheid om te vliegen");
    }
}
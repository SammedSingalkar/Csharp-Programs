using System;

class Country
{
    public string CountryName { get; set; }
    public int Population { get; set; }

    public Country(string countryName, int population)
    {
        CountryName = countryName;
        Population = population;
    }

    public virtual void DisplayInformation()
    {
        Console.WriteLine("Country Name: " + CountryName);
        Console.WriteLine("Population: " + Population);
    }
}

class State : Country
{
    public string StateName { get; set; }
    public int StatePopulation { get; set; }

    public State(string countryName, int population, string stateName, int statePopulation)
        : base(countryName, population)
    {
        StateName = stateName;
        StatePopulation = statePopulation;
    }

    public new void DisplayInformation()
    {
        base.DisplayInformation();
        Console.WriteLine("State Name: " + StateName);
        Console.WriteLine("State Population: " + StatePopulation);
    }
}

class Program
{
    static void Main()
    {
        Country country = new Country("USA", 328200000);
        Console.WriteLine("Country Information:");
        country.DisplayInformation();

        Console.WriteLine();

        State state = new State("USA", 328200000, "California", 39538223);
        Console.WriteLine("State Information:");
        state.DisplayInformation();
    }
}

using GuitarProject.Model;
using System.Reflection;

public class Program
{
    public static GuitarSpec GetDetailsFromUser()
    {
       
        GuitarSpec WhatCustomerWants = new GuitarSpec(Builder.Collings,"Stratocastor", Types.Acoustic, Wood.Maple, Wood.Cedar);
        return WhatCustomerWants;
    }
    public static void AddToInventory(Inventory inventory)
    {    
        inventory.AddGuitarToInventory("12AC", 7000, new GuitarSpec(Builder.Collings, "A1", Types.Acoustic, Wood.Mahogany, Wood.Maple));
        inventory.AddGuitarToInventory("13AC", 10000, new GuitarSpec(Builder.Ryan, "A2", Types.Electric, Wood.Mahogany, Wood.Maple));
        inventory.AddGuitarToInventory("14RC", 2000, new GuitarSpec(Builder.PRS, "A3", Types.Acoustic, Wood.Mahogany, Wood.Maple));
        inventory.AddGuitarToInventory("345P", 5000, new GuitarSpec(Builder.Collings, "Stratocastor", Types.Acoustic, Wood.Maple, Wood.Cedar));
        inventory.AddGuitarToInventory("12TY", 9000, new GuitarSpec(Builder.Collings, "Stratocastor", Types.Acoustic, Wood.Maple, Wood.Cedar));

    }
    public static void FindMatchingGuitar()
    {
        Inventory inventory = new Inventory();
        AddToInventory(inventory);
        List<Guitar> matchingGuitar = inventory.Search(GetDetailsFromUser());

        if (matchingGuitar.Count > 0)
        {
            Console.WriteLine("You May Like:");
            foreach (var guitar in matchingGuitar)
            {
                PrintGuitarDetails(guitar);
                Console.WriteLine();

            }
        }
        else
        {
            Console.WriteLine("WE dont have what you want");
        }

    }
    public static void PrintGuitarDetails(Guitar guitar)
    {
        GuitarSpec spec = guitar.Spec;
        Console.WriteLine(new String('-', 85));
        Console.WriteLine($"{"Serial No",-10} | {"Builder",-10} | {"Model",-10} | {"Type",-10} | {"TopWood",-10} | {"BackWood",-10} | {"Price",-10} ");
        Console.WriteLine(new String('-', 85));
        Console.WriteLine($"{guitar.SerialNumber,-10} | {spec.Builder,-10} | {spec.Model,-10} | {spec.Types,-10} | {spec.TopWood,-10} | {spec.BackWood,-10} | {guitar.Price,-10}");
        Console.WriteLine(new String('-', 85));
    }
    public static void Main(string[] args)
    {
        FindMatchingGuitar();

    }
  
}
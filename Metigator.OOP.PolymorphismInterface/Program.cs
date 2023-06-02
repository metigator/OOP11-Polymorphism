public class Program
{
    public static void Main(string[] args)
    {
        List<IReceipe> receipies = new List<IReceipe>
        {
            new Pizza(),
            new Falafel(),
            new Spaghetti(),
        };

        foreach (var receipy in receipies)
        {
            Console.WriteLine();
            Console.WriteLine($"######## receipy ({receipy.GetType().Name}) ##############");
            Console.WriteLine();
            Console.WriteLine(receipy.Prepare());
        }

    }
}

public interface IReceipe
{
    string Prepare();
}


public class Pizza : IReceipe
{
    public string Prepare()
    {
        return "1. Roll out the pizza dough.\n" +
                 "2. Spread the pizza sauce on the dough.\n" +
                 "3. Add desired toppings.\n" +
                 "4. Bake the pizza in the oven.\n" +
                 "5. Slice and serve.";
    }
}

public class Falafel : IReceipe
{
    public string Prepare()
    {
        return "1. Soak chickpeas overnight.\n" +
              "2. Drain and blend chickpeas with spices and herbs.\n" +
              "3. Form the mixture into small balls or patties.\n" +
              "4. Fry the falafel until golden brown.\n" +
              "5. Serve in pita bread with tahini sauce and vegetables.";
    }
}

public class Spaghetti : IReceipe
{
    public string Prepare()
    {
        return "1. Boil water in a pot.\n" +
               "2. Add spaghetti noodles to the boiling water.\n" +
               "3. Cook the noodles until al dente.\n" +
               "4. Drain the cooked noodles.\n" +
               "5. Serve with your favorite sauce and toppings.";
    }
}









string choice ="";

Console.WriteLine("Det är sommarlov och tillsammans med dina vänner så har ni bestämmt er att gå till den lokala sjön för att bada.");
Console.WriteLine("Du och dina kompisar Abel, Cain och Noah Söng bestämmer er för att ta bilen till sjön.");
Console.WriteLine("Ni kommer till en korsning");
Console.WriteLine("Åker ni vänster eller höger?");

Console.ReadLine();

if (choice == "vänster")
{

    Console.WriteLine("Ni bestämmer er för att åka vänster");
    Console.WriteLine("Efter ett tag så kommer ni fram till tät skog och det börjar bli mörkt");
    Console.WriteLine("Väljer ni att fortsätta framåt till fots eller slå läger");

    Console.ReadLine();

    if (choice == "fortsätta")
    {
        Console.WriteLine("Ni fortsätter in i skogen i hopp att sjön ligger nära");
        Console.WriteLine("När ni går där i skogen så hör ni en massa oväsen runt omkring er");
        Console.WriteLine("Ni börjar bli lite nyfikna men fortfarande lite rädda");
        Console.WriteLine("Undersöker ni ljudet eller försöker ni undvika ljuden");

        if (choice == "undersök")
        {
            Console.WriteLine("Ljudet blir högre och högre");
            Console.WriteLine("Ni känner hur tinnitussen smyger fram");
            Console.WriteLine("Det blir så illa att ni blir helt döva");
            Console.WriteLine("Eftersom att ni är döva och det har blivit kolsvart i skogen så hör och ser ni inte när det är någon eller något som smyger upp på er");
            Console.WriteLine("En efter en så kidnappas ni utan att ens se det komma och ni hittades aldrig igen");

        }

        else if (choice == "undvika")
        {


            
        }

    }


}


var animals = new Animal?[]
{
    new Cat { name = "Whiskers", Born = new DateTime(2015, 6, 1), Legs = 4, isDomestic = true },
    null, 
    new Cat { name = "Felix", Born = new DateTime(2019, 7, 1), isDomestic = false },
    new Spider { name = "Charlotte", Born = new DateTime(2018, 5, 1), isPoisonous = true },
    new Spider { name = "Shelob", Born = new DateTime(2020, 8, 1) }
};

// foreach (Animal? animal in animals)
// {
//     string message;

//     switch (animal)
//     {
//         case Cat { Legs : 4 } fourLeggedCat:
//             message = $"The cat named {fourLeggedCat.name} has four legs.";
//             break;
//         case Cat { isDomestic: false} wildCat:
//             message = $"The cat named {wildCat.name} is wild.";
//             break;
//         case Cat cat:
//             message = $"The cat is named {cat.name}.";
//             break;
//         default:
//             message = $"{animal.name} is a {animal.GetType().Name}.";
//             break;
//         case Spider { isPoisonous: true } spider:
//             message = $"The spider named {spider.name} is poisonous. Run!!";
//             break;
//         case null:
//             message = "The animal is null";
//             break;
//     }
//     Console.WriteLine($"Switch statement: {message}");
// }

// using switch expression

foreach (Animal? animal in animals)
{
    string message = animal switch
    {
        Cat { Legs : 4 } fourLeggedCat => $"The cat named {fourLeggedCat.name} has four legs.",
        Cat { isDomestic: false} wildCat => $"The cat named {wildCat.name} is wild.",
        Cat cat => $"The cat is named {cat.name}.",
        Spider { isPoisonous: true } spider => $"The spider named {spider.name} is poisonous. Run!!",
        null => "The animal is null",
        _ => $"{animal.name} is a {animal.GetType().Name}."
    };
    Console.WriteLine($"Switch expression: {message}");
}
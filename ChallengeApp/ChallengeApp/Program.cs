List<string> names = new List<string> { "Łukasz", "Daria", "Łukasz", "Patryk", "Paweł", "Kasia", "Michał", "Ania", "Łukasz", "Łukasz", "Kasia", "Daria", "Paweł", "Adam", "Daria", "Michał", "Patryk", "Łukasz", "Daria", "Michał"};

var nameCounts = names.GroupBy(name => name)
                             .Select(group => new { Name = group.Key, Count = group.Count() })
                             .ToList();
foreach (var item in nameCounts)
    Console.WriteLine("{0}: {1}", item.Name, item.Count);
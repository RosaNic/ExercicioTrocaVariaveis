Console.WriteLine
    ("Escreva seu nome");

String nome = Console.ReadLine()!;

Console.WriteLine
    ("");

Console.WriteLine
    ("Escreva seu sobrenome");

String sobrenome = Console.ReadLine()!;

Console.WriteLine
    ("");

String completo = nome + " " + sobrenome;

Console.WriteLine
    ("Nome Completo: "
        +
            completo);

Console.WriteLine
    ("");

Console.WriteLine
    ("Nome de Catalálogo: "
        + 
            $"{sobrenome.ToUpper() + " " + nome}");

using static System.Console;

WriteLine("\n\n Pressione ENTER para finalizar");
ReadLine();

static void CriarCsv()
{
    var path = Path.Combine(Environment.CurrentDirectory, "Saída");

    var pessoas = new List<Pessoa>(){
        new Pessoa
        {
            Nome = "Sandro Araújo",
            Email = "sa@email.com",
            Telefone = 35546998,
            Nascimento = new DateOnly(year: 1984, month: 2, day: 14)
        }
    };

    var di = new DirectoryInfo(path);
    if(!di.Exists)
    {
        di.Create();
        path = Path.Combine(path, "usuarios.csv");
    }

    var sw = new StreamWriter(path);
    sw.WriteLine("nome,email,telefone,nascimento");
    foreach(var pessoa in pessoas)
    {
        var linha = $"{pessoa.Nome},{pessoa.Email},{pessoa.Telefone},{pessoa.Nascimento};";
        sr.WriteLine(linha);
    }
}

class Pessoa
{
    public string Nome { get; set; }
    public string Email { get; set; }
    public int Telefone { get; set; }
    public DateOnly Nascimento { get; set; }
}

// var path = Path.Combine(Environment.CurrentDirectory, "Entrada", "usuarios-exportacao.csv");

// if(File.Exists(path))
// {
//     using var sr = new StreamReader(path);
//     var cabecalho = sr.ReadLine()?.Split(",");
//     while (true)
//     {
//         var registro = sr.ReadLine()?.Split(",");
//         if (registro == null) break;
//         if (cabecalho.Length != registro.Length)
//         {
//             WriteLine("Arquivo fora do padrão.");
//         }
//         for (int i = 0; i < registro.Length; i++)
//         {
//             WriteLine($"{cabecalho?[i]}:{registro[i]}");
//         }
//         WriteLine("--------------");
//     }
// }
// else
// {
//     WriteLine($"O arquivo {path} não existe.");
// }

// WriteLine("\n\n Pressione ENTER para finalizar.");
// ReadLine();
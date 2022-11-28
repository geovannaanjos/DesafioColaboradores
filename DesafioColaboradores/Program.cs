using DesafioColaboradores;


string nome;
string cargo;
double salarioatual;

string message = "";

try
{
    while (true)
    {
        Console.WriteLine("Informe o nome do colaborador: ");
        nome = Console.ReadLine();

        Console.WriteLine("Informe o cargo do colaborador: ");
        cargo = Console.ReadLine();

        Console.WriteLine("Informe o seu salário atual: ");
        salarioatual = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Voce é colaborador antigo ou colaborador novo?");
        Console.WriteLine("Suas opções: Colaborador antigo ou Colaborador novo");

        string colaboradoresna = Console.ReadLine();

        
         if (colaboradoresna == "Colaborador antigo" && salarioatual > 7000)
         {
            salarioatual += salarioatual * 0.1;
            Console.WriteLine("Reajuste aplicado");
         }
         else if(colaboradoresna == "Colaborador antigo" && salarioatual <= 7000)
         {
            Console.WriteLine("Voce deverá solicitar reajuste no seu salário");
         }
         else if(colaboradoresna == "Colaborador novo")
         {
            Console.WriteLine("Voce não receberá reajuste");
         }
         else if(colaboradoresna != "Colaborador antigo" && colaboradoresna != "Colaborador novo")
         {
            Console.WriteLine("Hmm, parece que voce digitou algo errado!");
         }




        Colaboradores colaboradores = new Colaboradores(nome, cargo, salarioatual);

        ColaboradoresAntigos cantigos = new ColaboradoresAntigos(nome, cargo, salarioatual);

        cantigos.NomeFuncionario();

        Console.WriteLine("Deseja encerrar as consultas? (S/N)");
        string endprogram = Console.ReadLine();

        if (endprogram == "S" || endprogram == "s")
        {
            break;
        }


    }
}
catch (Exception e)
{
    message = "Houve um problema:" + e.Message;
}
finally
{
    Console.WriteLine(message);
}



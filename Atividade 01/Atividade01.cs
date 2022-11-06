namespace AT02
{
    class Atividade02
    {
static void Main(string[] args)
{
Console.WriteLine("---------Inicio do Programa-----------");
int[] habitantes = new int[1000];
int sexo = 0;
int homen = 0;
int mulher = 0;
double altura = 0;
double alturam = 0;
double alturah = 0;
int idade = 0;
int idadem = 0;
int idadeh = 0;
double porcent = 0;
for (int i = 0; i < habitantes.Length; i++)
{
Console.WriteLine("Digite 1 para homen e 2 para mulher:");
sexo = int.Parse(Console.ReadLine());
Console.WriteLine("Digite a altura: ");
altura = double.Parse(Console.ReadLine());
Console.WriteLine("Digite a idade:");
idade = int.Parse(Console.ReadLine());
if (sexo == 1)
{
homen++;
alturah += altura;
idadeh += idade;
}
else
{
mulher++;
alturam += altura;
idadem += idade;
}
if (idade > 18 && idade < 35)
{
porcent++;
}
i++;
}
Console.WriteLine($"Média de idade do grupo: {(idadem + idadeh) / habitantes.Length}");
Console.WriteLine($"Média de altura das mulheres: {alturam / mulher}");
Console.WriteLine($"Média de idade dos homens: {idadeh / homen}");
Console.WriteLine($"Parcentagem de pessoas entre 18 e 35 anos: {porcent * 200 / habitantes.Length}%");
Console.ReadKey();
}
}
}
namespace AT02
{
    class Atividade02{
      static void Main(string[]args)
      {
        Console.WriteLine("---------Inicio do Programa-----------");
        int[] N = new int[10];
        int[] quadrado = new int[10];

        for (int i = 0; i < N.Length; i++){
                Console.WriteLine("Digite o numero:");
                N[i] = int.Parse(Console.ReadLine());
                quadrado[i] = N[i] * N[i];
        }
        for (int i = 0; i < 10; i++){
                Console.WriteLine("{0} * {0} = {1}", N[i], quadrado[i]);
            }
      }  
      Console.ReadKey();
    }
}
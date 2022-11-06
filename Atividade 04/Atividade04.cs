namespace AT04
{
  class Atividade04
  {

    static void Main (string[]args)
    {
      Console.WriteLine ("--------Inicio de Programa-------");
      int[] v = new int[6];
      for (int i = 0; i < 6; i++)

	{
	  v[i] = int.Parse (Console.ReadLine ());
	}
      Console.WriteLine ("Numeros invertidos:");
      for (int i = 5; i >= 0; i--)
	{
	  Console.WriteLine (v[i]);
	}
      Console.ReadKey ();
    }
  }
}
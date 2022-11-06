namespace AT03
{
  class Atividade03
  {
    static void Main (string[]args)
    {
      Console.WriteLine ("--------Inicio de Programa-------");
      int[] v = new int[8];
      int x = 0;
      int y = 0;
      int z = 0;
        Console.WriteLine ("Digite os numeros desejados: ");
      for (int i = 0; i < 8; i++)
	{
	  v[i] = int.Parse (Console.ReadLine ());
	    x = v[2];
	    y = v[3];
	    z = x + y;
	}
      Console.
	WriteLine ($
		   "Os valores das posiC'oes X e Y somados C):{x} + {y} = {z}");
        Console.ReadKey ();
    }
  }
}
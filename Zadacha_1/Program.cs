// Zadacha 1


    Console.Write("Введите N = ");
    int N = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите M = ");
    int M = Convert.ToInt32(Console.ReadLine());
    fun (N,M);
  
  static int fun(int N , int M)
  {
      if (N==M)
      {
          Console.Write(N + " ");
          return 0;
      }
      Console.Write(N + " ");
      N++;
      return fun(N , M);    
  }

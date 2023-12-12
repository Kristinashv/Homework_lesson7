// Zadacha 2
 
    Console.Write("Введите N = ");
    int N = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите M = ");
    int M = Convert.ToInt32(Console.ReadLine());
    fun (N,M);
    Console.Write(fun (N,M));
  
  static int fun(int N , int M)
  {
      if (N==0)
      {
          return M+1;
      }
      if ((N>0)&&(M==0))
      {
          return fun(N-1,1);
      }
      if ((N>0)&&(M>0))
      {
          return fun(N-1,fun(N,M-1));
      }
      return fun(N , M);    
  }


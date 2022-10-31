using System.Runtime.CompilerServices;


public class Program
{
    public static void Main(string [] args)
    {
        // Aqui primeiro deu erro, porque o meu denominador era um 0, nesse caso o b
        int a=100, b=0;
        int resultado =0;

        
      /*   
           
          }

          if(b>0){
             try{
         
            resultado= Dividir(a,b);
                Console.WriteLine("{0} dividido por {1} {2}", a, b, resultado);
              
        }catch(Exception ex){
          throw new Exception($"Verificar Numero de divisor ", ex.Message);
            
           
        }
    }else{
         while(b<=0){
            Console.WriteLine("Insira um valor Superior a 0");
            b = Int16.Parse(Console.ReadLine());
           
    }
         resultado= Dividir(a,b);
      */

      // Resolução da Aula
    try{
        resultado= Dividir(a,b);
       Console.WriteLine("{0} dividido por {1} {2}", a, b, resultado);
         
    } catch(DivideByZeroException ex1) // when (a<0) // O when é para criar condições, muito bom
        {
        Console.WriteLine(ex1.Message);
            Console.WriteLine("Pk");
        }
        // Exception é uma exceção generica, colocar ela entes das outras excepções faz com que as outras não sejam capturadas. 
        catch(Exception ex){
        Console.WriteLine(ex.Message);
    }
        // Aqui em baixo vamos testar a liberação de recursos, finaly
        finally
        {
            Console.WriteLine("Finalizada com Sucesso! ");
        }
    

    }
      static int Dividir(int x, int z)
        {
        if (z==0)
        {
      //  throw new DivideByZeroException(); // Isso é muito gostoso de se entender, aqui ela chama a exceção que definimos acima, o thow chama ele.
       throw new MyClassExceptionException("Minha Mensagem de Erro");
        }
            return (x/z);
        }
    }

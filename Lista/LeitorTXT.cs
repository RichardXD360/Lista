using System.IO;
class Leitor
{
     public void Ler(string texto)
     {
        try
        {
            StreamReader reader = new StreamReader($"C:\\Users\\richard.reis\\Desktop\\TestePad\\{texto}");
            string linha = reader.ReadLine(); /* "C:\\Titulo_do_texto.txt"   */

            while (linha != null) //Ler todas as linhas até o retorno ser NULL
            {
                Console.WriteLine(linha);
                linha = reader.ReadLine();
            }
            reader.Close();
            Console.ReadLine();

        }
        catch (Exception e) { 
            Console.WriteLine("Exception: "+ e.Message);
        }
        finally {
            Console.WriteLine("Sucesso na execução");
            Console.ReadLine();
        }

    }
}
     

using System.IO;
class Escrever
{
    public void Escreva(string titulo, string txt)
    {
        try
        {
            StreamWriter esc = new StreamWriter($"C:\\Users\\richard.reis\\Desktop\\TestePad\\{titulo}"); //  "C:\\Teste.txt"
            esc.WriteLine(txt);
            Console.WriteLine("Texto escrito!");
            Console.ReadLine();
            esc.Close();
        }
        catch(Exception ex) 
        {
            Console.WriteLine("Exception: "+ ex.Message);
            Console.ReadLine();
        }
        finally
        {
            Console.WriteLine("Sucesso");
            Thread.Sleep(1000);
            Console.Clear();
        }
    }
}
namespace CClip
{
    using System;
    using System.Windows.Forms;

    class Program
    {
        [STAThread]
        static void Main()
        {
            try 
            {
                var consoleInput = Console.In.ReadToEnd();
                Console.WriteLine("Copied to Clipboard\n{0}", consoleInput);
                Clipboard.SetText(consoleInput);
            } 
            catch(Exception ex)
            {
                Console.WriteLine("Something went terribly wrong\n{0}", ex.Message);
            }
        }
    }
}

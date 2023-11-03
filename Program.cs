using System;

class Program
{
    static void Main()
    {
        try
        {
            var mc = new System.Management.ManagementClass("Win32_Processor");
            var moc = mc.GetInstances();

            foreach (System.Management.ManagementObject mo in moc)
            {
                foreach (var m in mo.Properties)
                {
                    Console.WriteLine(m.Name); 
                }
                
                Console.WriteLine(mo.Properties["SocketDesignation"].Value);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Ocorreu um erro ao tentar obter informações do processador: " + e.Message);
        }
    }
}
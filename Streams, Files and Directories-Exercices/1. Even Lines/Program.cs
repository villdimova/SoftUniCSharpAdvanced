using System;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;

namespace _1._Even_Lines
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var reader =new StreamReader("../../../input.txt"))
            {
                var line = reader.ReadLine();
                 
               
                int counter = 0;
                using (var writer=new StreamWriter("../../../output.txt"))
                {
                    while (line!=null)
                    {
                        if (counter%2==0)
                        {
                           line = line.Replace("-", "@").Replace(",", "@").Replace(".", "@").Replace("!", "@").Replace("?", "@");
                            var reversedLines = line.Split().Reverse().ToList();

                            foreach (var item in reversedLines)
                            {
                                writer.Write(item+ " ");
                            }
                        }
                        counter++;
                        line = reader.ReadLine();
                       
                    }
                }
                
            }
        }
    }
}

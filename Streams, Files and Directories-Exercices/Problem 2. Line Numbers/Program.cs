using System;
using System.IO;
using System.Linq;

namespace Problem_2._Line_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string textPath = "../../../text.txt";
            string outputpath = "../../../output.txt";
            var inputText = File.ReadAllLines(textPath);

            int lineCounter = 1;

           
            foreach (var currentLine in inputText)
            {
                
                var lettersCount = currentLine.Count(x=>char.IsLetter(x));
                var punctsCount = currentLine.Count(x => char.IsPunctuation(x));
                var linesCount = inputText.Count();
                //Line 1: -I was quick to judge him, but it wasn't his fault. (37)(4)
                File.AppendAllTextAsync(outputpath,$"Line  { lineCounter} {currentLine} ({lettersCount}) ({punctsCount}) {Environment.NewLine}");
                lineCounter++;
            }



        }
    }
}

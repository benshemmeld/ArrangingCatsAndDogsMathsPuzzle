using System;

namespace ArrangingCatsAndDogsMathsPuzzle
{
    class Program
    {
        static void Main(string[] args)
        {
            var possibleArrangments = Math.Pow(2, 10);
            var validArrangements = 0;

            for(var i=0;i < possibleArrangments; i++)
            {
                var binaryString = Convert.ToString(i, 2);
                binaryString = $"{int.Parse(binaryString):0000000000}";
                
                if(!binaryString.Contains("00"))
                {
                    binaryString = binaryString.Replace("0", " Cat ").Replace("1", " Dog ");
                    Console.WriteLine(binaryString.Trim());
                    validArrangements++;
                }
            }

            Console.WriteLine($"Found {validArrangements} possible arrangements");
        }
    }
}

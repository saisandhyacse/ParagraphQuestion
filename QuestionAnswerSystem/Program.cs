using System;
using System.Text.RegularExpressions;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace QuestionAnswerSystem
{
    class Program
    {
        public static void Main()
        {
            // 
            // Sample Input files (Input1, Input2.. Input5).
            for (int inputCount = clsConstant.ONE; inputCount <= clsConstant.SEVEN; inputCount++)
            {
                Console.WriteLine("*****************Press any key to read data from Input" + inputCount + ".txt and Display the result ********************");
                Console.ReadKey();

                InputData Ir = new InputData(new InputReader("Input" + inputCount));

                Entities ent = new Entities();
                ent.GetEntities(Ir);

                if (!ent.isValidData)
                {
                    Console.WriteLine("Input Data not in proper format");
                }
                else
                {
                    QASystemDriver QASinstance = new QASystemDriver(ent);
                    QASinstance.GetAnswerSequence();
                }
            }

            // Keep the console window open in debug mode.  
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }


    }

}

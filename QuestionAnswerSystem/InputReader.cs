using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;

namespace QuestionAnswerSystem
{
    public class InputReader : IInputReader
    {
        public InputReader()
        {

        }
        public InputReader(string filePath)
        {
            _filePath = @"E:\" + filePath + ".txt";
        }

        private readonly string _filePath;

       // public string[] lines => GetLines();

        public void ReadFile()
        {
            try
            {
                string text = File.ReadAllText(_filePath);
            }
            catch (FileNotFoundException) { }
            catch (ArgumentException) { }
            catch (IOException) { }
        }


        public string[] GetLines()
        {
            try
            {
                return File.ReadAllLines(_filePath);
            }
            catch (FileNotFoundException) { }
            catch (ArgumentException) { }
            catch (IOException) { }


            return new string[] { };
        }

    }
}
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace QuestionAnswerSystem
{
    public class InputData
    {
        public InputData()
        {
            lines = new string[] { };
            isValidInput = false;
        }

        public InputData(IInputReader inputReader)
        {
            lines = inputReader.GetLines();
            isValidInput = lines != null && lines.Count() == clsConstant.MAXLINES;
        }

        public string[] lines;
        public bool isValidInput { get; set; }

    } 
}
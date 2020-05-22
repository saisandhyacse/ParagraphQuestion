using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace QuestionAnswerSystem
{
    public class Paragraph : InputData, IInputFormatter
    {
        public Paragraph()
        {
            isValidInput = base.isValidInput;
            paragraph = string.Empty;
        }

        public Paragraph(IInputReader inputReader) : base(inputReader)
        {
            isValidInput = base.isValidInput;
        }

        public Paragraph(InputData input)
        {
            lines = input.lines;
            isValidInput = input.isValidInput;
        }

        public string paragraph { get; set; }

        // Get Paragraph from Input
        public void GetEntity()
        {
            if (isValidInput && lines != null && ValidateEntity())
            {
                paragraph = lines[0];
            }
        }

        // Just added minimum Validation criteria
        public bool ValidateEntity()
        {
            // More criteria needed. Just to show the usecase
            isValidInput = lines[0] != null && lines[0].Count() > clsConstant.MINSENTENCESIZE
                && lines[0].Contains('.') && lines[0].Length <= clsConstant.MAXSENTENCELENGTH;

            return isValidInput;
        }
    }
}

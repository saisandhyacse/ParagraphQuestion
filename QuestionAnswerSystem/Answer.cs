using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace QuestionAnswerSystem
{
    public class Answer : InputData, IInputFormatter
    {
        public Answer()
        {
            isValidInput = base.isValidInput;
            answer = string.Empty;
        }

        public Answer(IInputReader inputReader) : base(inputReader)
        {
            isValidInput = base.isValidInput;
        }
        public Answer(InputData input)
        {
            lines = input.lines;
            isValidInput = input.isValidInput;
        }

        public string answer { get; set; }

        // Get Paragraph from Input
        public void GetEntity()
        {
            if (isValidInput && lines != null && ValidateEntity())
            {
                answer = lines[clsConstant.MAXLINES - 1];
            }
        }

        // Just added minimum Validation criteria
        public bool ValidateEntity()
        {
            // More criteria needed. Just to show the usecase
            isValidInput = lines[clsConstant.MAXLINES - 1] != null && lines[clsConstant.MAXLINES - 1].Count() > clsConstant.MINSENTENCESIZE
                             && lines[clsConstant.MAXLINES - 1].Contains(';');

            return isValidInput;
        }
    }
}

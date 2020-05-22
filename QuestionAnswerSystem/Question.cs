using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace QuestionAnswerSystem
{
    public class Question : InputData, IInputFormatter
    {
        public Question()
        {
            isValidInput = base.isValidInput;
            questions = new List<string>();
        }

        public Question(IInputReader inputReader) : base(inputReader)
        {
            isValidInput = base.isValidInput;
        }

        public Question(InputData input)
        {
            lines = input.lines;
            isValidInput = input.isValidInput;
        }
        public List<string> questions { get; set; }

        // Get Paragraph from Input
        public void GetEntity()
        {
            if (questions == null)
                questions = new List<string>();

            if (isValidInput && lines != null && ValidateEntity())
            {
                for (int i = 1; i < clsConstant.MAXLINES - 1; i++)
                {
                    questions.Add(lines[i]);
                }
            }
        }

        // Just added minimum Validation criteria
        public bool ValidateEntity()
        {
            if (lines != null && lines.Count() == clsConstant.MAXLINES)
            {
                for (int i = 1; i < clsConstant.MAXLINES - 1; i++)
                {
                    isValidInput &= lines[i] != null && lines[i].Count() > 1 && lines[i].EndsWith('?');
                    if (!isValidInput)
                    {
                        break;
                    }
                }
            }

            return isValidInput;
        }
    }
}

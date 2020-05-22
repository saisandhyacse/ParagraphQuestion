using System;
using System.Collections.Generic;
using System.Text;

namespace QuestionAnswerSystem
{
    public interface IInputReader
    {
        public void ReadFile();

        public string[] GetLines();
    }
}

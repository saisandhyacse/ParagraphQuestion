using System;
using System.Collections.Generic;
using System.Text;

namespace QuestionAnswerSystem
{
    interface IInputFormatter
    {
        void GetEntity();
        bool ValidateEntity();
    }
}

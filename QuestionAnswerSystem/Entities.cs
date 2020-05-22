using System;
using System.Collections.Generic;
using System.Text;

namespace QuestionAnswerSystem
{
    public class Entities
    {

        public Entities()
        {
            paragraph = string.Empty;
            questions = new List<string>();
            answer = string.Empty;
        }

        public string paragraph { get; set; }
        public List<string> questions { get; set; }
        public string answer { get; set; }
        public bool isValidData { get; set; }
        public void GetEntities(InputData Ir)
        {
            if (Ir.isValidInput)
            {
                isValidData = true;
                Paragraph p = new Paragraph(Ir);
                p.GetEntity();
                if (p.isValidInput)
                {
                    paragraph = p.paragraph;
                }
                else
                {
                    isValidData = false;
                    return;
                }

                Question q = new Question(Ir);
                q.GetEntity();
                if (q.isValidInput)
                {
                    questions = q.questions;
                }
                else
                {
                    isValidData = false;
                    return;
                }

                Answer a = new Answer(Ir);
                a.GetEntity();
                if (a.isValidInput)
                {
                    answer = a.answer;
                }
                else
                {
                    isValidData = false;
                    return;
                }
            }
        }
    }
}

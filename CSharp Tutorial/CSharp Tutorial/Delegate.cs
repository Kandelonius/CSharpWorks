using System;

namespace CSharp_Tutorial
{
    /*
     * A delegate can be used to pass a method as a parameter through another method as
     * long as it has the same return type and parameters as the delegate method.
     */
    public class Delegate
    {
        public delegate void fillTextBox(int x);
        string textvalue = "";
        public void FillMathNote(int ExamNote)
        {
            Console.WriteLine($"Your Math note is: {ExamNote}");
        }

        public void FillChemistryNote(int ExamNote)
        {
            Console.WriteLine($"Your Chemistry note is: {ExamNote}");
        }

        public void CallLogic()
        {
            fillTextBox genericfill = new fillTextBox(FillMathNote);
            genericfill(80);
            genericfill += FillChemistryNote;
            genericfill(65);
        }
    }
}

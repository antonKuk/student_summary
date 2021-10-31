using System;

namespace StudentSummary
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] subjectNames = { "Math", "Phisics", "Chemistry" };
            float[,] studentsResults = new float[3, 4] { { 87.6F, 89.1F, 93.0F, 78.5F }, { 71.2F, 65.4F, 88.6F, 75.0F }, { 42.8F, 93.5F, 68.4F, 78.2F } };
            string yearResults = "";
            char[] charsToTrim = { ',', ' ' };
            float sum;
            Console.WriteLine("End of the year transcript: ");
            for (int i = 0; i < 3; i++)
            {
                yearResults = subjectNames[i] + ": ";
                sum = 0;
                for (int j = 0; j < 4; j++)
                {
                    yearResults += Convert.ToString(studentsResults[i, j]) + "%, ";
                    sum += studentsResults[i, j];
                }
                yearResults = yearResults.TrimEnd(charsToTrim) + " average: " + Convert.ToString(sum / 4.0);
                Console.WriteLine(yearResults);
            }
        }
    }
}

using System;
using System.Collections.Generic;
namespace Homeworks4
{
    class Program
    {
        static void Main()
        {
            #region NotesStore
            //NotesStore.AddNote("active", "active note 1");
            //NotesStore.AddNote("active", "active note 2");
            //NotesStore.AddNote("active", "active note 3");

            //NotesStore.AddNote("completed", "completed note 1");
            //NotesStore.AddNote("completed", "completed note 2");
            //NotesStore.AddNote("completed", "completed note 3");

            //NotesStore.AddNote("others", "other note 1");
            //NotesStore.AddNote("others", "other note 2");
            //NotesStore.AddNote("others", "other note 3");

            //Console.WriteLine("Active Notes List:");
            //NotesStore.PrintActiveNote();
            //Console.WriteLine();
            //Console.WriteLine("Completed Notes List:");
            //NotesStore.PrintCompletedNote();
            //Console.WriteLine($"Number of notes before delete:{NotesStore.Count}");

            //NotesStore.DeleteNote("completed note 1");

            //Console.WriteLine();
            //Console.WriteLine("Completed Notes List after deleting completed note 1:");
            //NotesStore.PrintCompletedNote();
            //Console.WriteLine($"Number of notes after delete:{NotesStore.Count}");

            //Console.WriteLine(NotesStore.GetNotes("error"));
            //NotesStore.AddNote("active","");
            //NotesStore.AddNote("Incompleted","");
            #endregion
            #region Matrix
            //Matrix myMatrix = new Matrix(3, 3);
            //myMatrix.GenerateRandomMatrix();

            //myMatrix.PrintMatrix();
            //Console.WriteLine();

            //for (int i = 0; i < myMatrix.body.Length; i++)
            //{
            //    Console.Write(myMatrix.body[i] + " ");
            //}
            //Console.WriteLine("\n");

            //Matrix TriangularMatrixUpper = myMatrix.GetTriangularMatrix(true);
            //Matrix TriangularMatrixBottom = myMatrix.GetTriangularMatrix(false);

            //TriangularMatrixBottom.PrintMatrix();
            //Console.WriteLine();

            //TriangularMatrixUpper.PrintMatrix();
            //Console.WriteLine();

            //Matrix.Mult(TriangularMatrixBottom, TriangularMatrixUpper).PrintMatrix();
            #endregion
        }

    }
}

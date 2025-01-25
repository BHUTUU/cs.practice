using System;
namespace PercentCalculate {
  class Calculate {
    static void Main(string[] args) {
      int[] marks = new int[5];
      Console.WriteLine("Welcome to the percentage calculator\n\n");
      string[] subjects = { "Maths", "Science", "Hindi", "English", "Social Science" };
      for (int i = 0; i < 5; i++) {
        Console.WriteLine("Enter " + subjects[i] + " marks: ");
        int marksHolder = int.Parse(Console.ReadLine());
        marks[i] = marksHolder;
      }
      Console.WriteLine("\nYour marks are:");
      for (int i = 0; i < 5; i++) {
        Console.WriteLine(subjects[i] + ": " + marks[i]);
      }
      int totalMarks = 0;
      for (int i = 0; i < 5; i++) {
        totalMarks += marks[i];
      }
      float percentage = (totalMarks / 500.0f) * 100;
      Console.WriteLine("\nYour total percentage is: " + percentage + "%");
    }
  }
}


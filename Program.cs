// Resurreccion, Samuel Angelo H.
// BSIT 32E2

// using System;

// class TriangleAreaCalculator
// {
//     static void Main(string[] args)
//     {
//         // Get base and height from the user
//         Console.Write("Enter the base of the triangle: ");
//         double baseValue = Convert.ToDouble(Console.ReadLine());

//         Console.Write("Enter the height of the triangle: ");
//         double heightValue = Convert.ToDouble(Console.ReadLine());

//         // Calculate the area
//         double area = 0.5 * baseValue * heightValue;

//         // Display the calculated area
//         Console.WriteLine("The area of the triangle is: {0:0.00}", area);
//     }
// }


// using System; 

// class Program
// {
//     static void Main (string[] args)
//     {
//             //defining array
//             int ArraySize = 5;
//             //empty array
//             int [] integerArray = new int [ArraySize];  

//             //user define formula of n^2 e.g
//             Func<int, int> formula = n => n * n ;

//             // array with values based on the formula
//             for (int i = 0; i < ArraySize; i++)
//             {
//                 integerArray[i] = formula(i + 1);
//             }

//                 //print array

//                 Console.WriteLine("Array filled with values based on the formula:");
//                 foreach (int num in integerArray)
//                 {
//                     Console.Write(num + " ");
//                 }
//                 Console.WriteLine();


//                 //find largest element

//                 int maxValue = int.MinValue;

//                 foreach (int num in integerArray)
//                 {
//                     if (num > maxValue)
//                     {
//                         maxValue = num;
//                     }
//                 }




//         //print largest element
//         Console.WriteLine("The largest element in the array is: " + maxValue);

//     }
// }

// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         for (int i = 1; i <= 10; i++)
//         {
//             double squareRoot = Math.Sqrt(i);
//             Console.WriteLine($"Number: {i}, Square Root: {squareRoot}");
//         }
//     }
// }

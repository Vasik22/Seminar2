// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет
Console.WriteLine ("Enter number");
int number = Convert.ToInt32(Console.ReadLine());
int[] nums = new int[] { 1, 2, 3, 5, 6, 7 };

if (number >=nums[4]) {
    
    Console.WriteLine ("Yes");
}
else {
    Console.WriteLine ("No");
}
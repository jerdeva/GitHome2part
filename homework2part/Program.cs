// See https://aka.ms/new-console-template for more information
Console.WriteLine("Eneter N");
int n = Convert.ToInt32(Console.ReadLine());
int[] nums = new int[n];
for (int i = 0; i < nums.Length; i++)
{
    nums[i] = new Random().Next(1, 26);
    Console.WriteLine(nums[i]);
}


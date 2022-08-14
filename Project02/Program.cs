int[] numbers = new int[]{1,2,3,4,5,6};
 
for (int x = 0; x < numbers.Length; x++)
{
     int number = numbers[x];
     int cube = (int)Math.Pow(number, 3);
     if (cube % 2 == 0)
          System.Console.WriteLine("Куб числа " + number + " равен " + cube + " и заканчивается на чётную цифру");
}
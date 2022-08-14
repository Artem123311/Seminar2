using System;
 
class Summa {
static void Main() {
int n = Convert.ToInt32(Console.ReadLine());
int i;
int sum = 0;
for (i=1; i <=n; i++) {
sum = sum+i;
}
Console.WriteLine(sum);
}
}
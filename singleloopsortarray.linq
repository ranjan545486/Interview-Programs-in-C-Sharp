<Query Kind="Program" />

 private void singleLoopSort(int[] Ary, int size)
 {
 for (int i = 0; i < size;)
 {
 if (Ary[i] != i)
 {
 int t = Ary[Ary[i]];
 Ary[Ary[i]] = Ary[i];
 Ary[i] = t;
 Console.Write(Ary[i]);
 Console.Write(" ");
 Console.Write(Ary[Ary[i]]);
 Console.Write("\n");
 }
 else
 {
 i++;
 }
 }
 }

void Main(string[] args)
 {
 int[] Ary = {3, 7, 2, 5, 1, 8, 4, 0, 9, 6};
 singleLoopSort(Ary, 10);
 for (int i = 0; i < 10; i++)
 {
 Console.Write(Ary[i]);
 Console.Write(" ");
 }
 }
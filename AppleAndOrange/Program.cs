

//s: integer, starting point of Sam's house location.
//t: integer, ending location of Sam's house location.
//a: integer, location of the Apple tree.
//b: integer, location of the Orange tree.
//apples: integer array, distances at which each apple falls from the tree.
//oranges: integer array, distances at which each orange falls from the tree.

static void countApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges)
{

    int count1 = 0;
    int count2 = 0;

    foreach (int apple in apples)
    {
        int sum = a + apple;
        if (sum >= s && sum <= t)
        {
            count1++;
        }
    }

    foreach (int orange in oranges)
    {
        int sum = b + orange;
        if(sum>=s && sum <= t)
        {
            count2++;
        }
    }

    Console.WriteLine(count1);
    Console.WriteLine(count2);
    

}
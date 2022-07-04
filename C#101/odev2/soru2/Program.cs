int count = 0;
int[] sayilar = new int[20];

while (count < 20)
{
    try
    {
        Console.WriteLine("{0}. sayiyi girin: ", count+1);
        int sayi = Convert.ToInt32(Console.ReadLine());
        sayilar[count] = sayi;
        count++;

    }
    catch (System.Exception)
    {
        Console.WriteLine("Bir sayi girin!");
    }


}

int[] minValues = getThreeMin(sayilar);
int[] maxValues = getThreeMax(sayilar);


Console.WriteLine("En buyuk uc sayinin toplamlari: {0}, ortalamalari: {1}", maxValues.Sum(), maxValues.Average());
Console.WriteLine("En kucuk uc sayinin toplamlari: {0}, ortalamalari: {1}", minValues.Sum(), minValues.Average());



static int[] getThreeMin(int[] arr)
{
    int count = 0;
    int[] minValues = new int[3];

    while (count < 3)
    {
        int minValue = arr.Min();
        minValues[count] = minValue;
        int[] newArray = arr.Where(item => item != minValue).ToArray();
        arr = newArray;
        count++;
    }

    return minValues;
}

static int[] getThreeMax(int[] arr)
{
    int count = 0;
    int[] maxValues = new int[3];

    while (count < 3)
    {
        int maxValue = arr.Max();
        maxValues[count] = maxValue;
        int[] newArray = arr.Where(item => item != maxValue).ToArray();
        arr = newArray;
        count++;
    }

    return maxValues;
}
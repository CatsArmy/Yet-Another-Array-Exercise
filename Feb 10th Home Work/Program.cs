Console.WriteLine("Select Question 0 --> 6");
int select = int.Parse(Console.ReadLine());
bool[] toggle = new bool[7];
for (int i = 0; i < toggle.Length; i++)
{
    toggle[i] = false;
}
toggle[select] = true;
if (toggle[0])
{
    int[] nums = new int[6];
    // Question 1.a
    for (int i = 0; i < nums.Length; i++)
    {
        Console.WriteLine($"Enter a value for the index({i})");
        nums[i] = int.Parse(Console.ReadLine());
    }
    //Question 1.b
    Console.Clear();
    Console.WriteLine("Ascending\n");
    for (int i = 0; i < nums.Length; i++)
    {
        Console.WriteLine($"{nums[i]}[{i}]");
    }
    //Question 1.c
    Console.WriteLine("\nDescending\n");
    for (int i = nums.Length - 1; i >= 0; i--)
    {
        Console.WriteLine($"{nums[i]}[{i}]");
    }
    //Question 1.d
    for (int i = 0; i < nums.Length; i++)
    {
        if (i % 2 == 0)
        {
            Console.WriteLine($"{nums[i]} Index +Zogi");
        }
    }
    //Question 1.e
    for (int i = 0; i < nums.Length; i++)
    {
        if (i % 2 != 0)
        {
            Console.WriteLine($"{nums[i]} Index -Zogi");
        }
    }
    //Question 1.f
    for (int i = 0; i < nums.Length; i++)
    {
        if (nums[i] % 2 == 0)
        {
            Console.WriteLine($"Index[{i}] Number Zogi");
        }
    }
}
// #Question 2.a
if (toggle[1])
{
    Random rng = new Random();
    int[] array = new int[20];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rng.Next(1, 1000);
    }
    int[] barray = Barray(array);
    for (int i = 0; i < barray.Length; i++)
    {
        Console.WriteLine(barray[i]);
    }
    static int[] Barray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] *= array[i];
        }
        return array;
    }
}
// #Question 3.a
if (toggle[2])
{
    Console.WriteLine("enter a number that is zogi");
    int numberOfIndexs = 0;
    int maxValue = 0;
    while (numberOfIndexs < 1)
    {
        numberOfIndexs = int.Parse(Console.ReadLine());
    }
    int[] arrayOfNum = new int[numberOfIndexs];
    for (int i = 0; i < arrayOfNum.Length; i++)
    {
        while (arrayOfNum[i] < 1)
        {
            arrayOfNum[i] = int.Parse(Console.ReadLine());
        }
    }
    int minValue = arrayOfNum[1];
    for (int i = 0; i < arrayOfNum.Length; i++)
    {
        if (arrayOfNum[i] > maxValue)
        {
            maxValue = arrayOfNum[i];
        }
        if (arrayOfNum[i] < minValue)
        {
            minValue = arrayOfNum[i];
        }
    }

    int counter = 0;
    for (int i = 0; i < arrayOfNum.Length; i++)
    {
        if (arrayOfNum[i] == maxValue)
        {
            counter++;
        }
    }
    int[] allIdxsOMaxVal = new int[counter];
    for (int i = 0; i < arrayOfNum.Length; i++)
    {
        if (arrayOfNum[i] == maxValue)
        {
            allIdxsOMaxVal[i] = i;
        }
    }

    Console.WriteLine($"Min Value = {minValue}");
    Console.WriteLine($"Max Value = {maxValue}");
    Console.WriteLine($"The Total Times the max value occures = {allIdxsOMaxVal.Length}");
    Console.WriteLine("All indexs that have the max value");
    for (int i = 0; i < allIdxsOMaxVal.Length; i++)
    {
        Console.Write($"{allIdxsOMaxVal[i]}");
    }
}
// #Question 4.a
if (toggle[3])
{
    static bool IsSumOfArrZogi(int[] arr)
    {
        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }
        if (sum % 2 == 0) {
            return true;
        }
        return false;
    }
    // #Question 4.b
    //dummy arrays
    int[] array = new int[5];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = i++;
    }
    Console.WriteLine(array.ToString());
    if (IsSumOfArrZogi(array)) {
        Console.Write(" is zogi");
    }
    else {
        Console.Write(" isnt zogi");
    }
    int[] exmpleArr = new int[8];
    bool flag = false;
    bool flag2 = false;
    int numToAdd = 2;
    for (int i = 0; i < exmpleArr.Length; i++)
    {
        if (!flag)
        {
            flag = true;
            exmpleArr[i] = numToAdd + 1;
        }
        else if(flag&&flag2)
        {
            flag = false;
            flag2 = false;
            if (i>3)
            {
                numToAdd = 4;
            }
            exmpleArr[i] = numToAdd;
        }
        else
        {
            flag2 = true;
            exmpleArr[i] = numToAdd + 1;
        }
        Console.WriteLine(exmpleArr[i]+" "+i);
    }
    //exmpleArr = { 2,3,3,2,4,5,5,4};
}


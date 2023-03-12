// find largest number, using method

int Max(int arg1, int arg2, int arg3)

{
int result = arg1;
if(arg2>result) result=arg2;
if(arg3>result) result=arg3;
return result;
}

int[] array = {196478, 31, 48, 1634, 555, 155, 400000, 7, 6};
int max1 = Max(array[0], array[1], array[2]);
int max2 = Max(array[3], array[4], array[5]);
int max3 = Max(array[6], array[7], array[8]);

int max = max1;
if (max2>max) max = max2;
if (max3>max) max = max3;

Console.WriteLine(max);

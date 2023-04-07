// возвести число F в степень n через рекурсию

// int NumberDegree (int F, int n)
// {

//     if(n == 1) return F;
//     else return F * NumberDegree(F, n-1);
// }

// Console.WriteLine(NumberDegree(2, 3));

int NumberDegree(int F, int n)
{
    if (n == 0) return 1;
    else if (n%2 == 0) return NumberDegree(F * F, n/2);
    else return NumberDegree (F, n-1)*F;
}

Console.WriteLine(NumberDegree(2, 3));
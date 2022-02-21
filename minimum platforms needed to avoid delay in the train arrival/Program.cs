// See https://aka.ms/new-console-template for more information

double[] A = new double[]{ 2.00, 2.10,2.20, 3.00, 3.20, 3.50, 5.00 };
double[] B = new double[] { 2.30, 3.40, 3.20, 4.30, 4.00, 5.20 };
Console.WriteLine(findMinPlatforms(A, B));

int findMinPlatforms(double[] Arrival, double[] departure)
{
    int i = 0;
    int j = 0;
    int max = 0;
    int tmp = 0;
    Array.Sort(A);
    Array.Sort(B);

    while (i < Arrival.Length)
    {
        
        if (Arrival[i] <= departure[j])
        {
            i++;
            tmp++;
            max = Math.Max(max, tmp);

        }
        else
        {
            j++;
            tmp = 0;
        }
        
    }
    return max;
}
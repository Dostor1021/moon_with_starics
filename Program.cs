namespace MoonByStars
{
    class Program
    {
        static void Main(string[] args)
        {
            int size =25 ;
            int mid_size = size / 2;
            int upper_part = mid_size + 2;
            int lower_part = mid_size - 2;

            for (int i = 0; i <= size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (i == 0 || i == size)
                    {
                       
                        if (j >=lower_part && j < upper_part+2)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    else if (i > 0 && i <= mid_size / 2+2)
                    {
                  
                        if (j >= lower_part - i  && j <= upper_part - i )
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    else if (i >= mid_size / 2 && i <= mid_size+2)
                    {
                       
                        if (j >= 0 && j <= mid_size / 2-2)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    else if (i > mid_size && i < size+2)
                    {
                       
                        int n = i - size;
                        if (j >= lower_part + n && j <= upper_part + n)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                }
                Console.WriteLine();
            }
        }
    }
}

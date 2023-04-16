namespace Sorts
{
    public static class Sort
    {
        public static int[] SortOrders(int[] orders)
        {
            for (int i = 0; i < orders.Length - 1; i++)
            {
                int maxIndex = i;
                for (int j = i; j < orders.Length; j++)
                {
                    if (orders[maxIndex] < orders[j])
                    {
                        maxIndex = j;
                    }
                }
                int tmp = orders[maxIndex];
                orders[maxIndex] = orders[i];
                orders[i] = tmp;
            }
            return orders;

        }

        public static void WriteResult(int[] orders)
        {
            for (int i = 0; i < orders.Length; i++)
            {
                Console.Write($"{orders[i]} ");
            }
        }
    }
}
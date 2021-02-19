
namespace BxFinTask.Services
{
    public class ProductService : IProductService
    {
        public int[] Reverse(int[] array)
        {
            int lenght = array.Length - 1;

            for (int i = 0; i < array.Length / 2; i++)
            {
                int tempValue = array[i];
                array[i] = array[lenght - i];
                array[lenght - i] = tempValue;
            }
            return array;
        }


        public int[] Delete(int position, int[] array)
        {
            int[] temp = new int[array.Length - 1];
            int i = 0, j = 0;

            while (i < array.Length)
            {
                if (i != position)
                {
                    temp[j] = array[i];
                    j++;
                }
                i++;
            }
            return temp;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_4
{
    public class Calculation
    {
        static Random random = new Random();

        /// <summary>
        /// Находит минимум из count целых случайных чисел, распределенных в диапазоне от
        /// 10 до 40
        /// </summary>
        /// <param name="count">Количество чисел</param>
        /// <returns>Минимальное число и сгенерированные числа</returns>
        public static (int minimum, string numbers) GetMinimun(int count)
        {
            int minimum = 40;
            string numbers = string.Empty;
            for (int i = 0; i < count; i++)
            {
                int currentValue = random.Next(10, 40);
                if (currentValue < minimum)
                {
                    minimum = currentValue;
                }
                numbers += currentValue.ToString() + " ";
            }

            return (minimum, numbers);
        }
    }
}

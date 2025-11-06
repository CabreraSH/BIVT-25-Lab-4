using System.Runtime.InteropServices;

namespace Lab4
{
    public class Blue
    {
        public void Task1(int[] array)
        {

            // code here

            int negativePosition = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    negativePosition = i;
                    break
                }
            }

            int maxValue = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (maxValue < Math.Max(array[i], array[i+1])
                    {
                        maxValue = Math.Max(array[i], array[i+1]);
                    }
            }

            int maxPosition = 0;
            for (int i = 0; i < array.Length; i++)
                    {
                        if (array[i] == maxValue)
                        {
                            maxPosition = i;
                            break;
                        }
                    }

            int sum = 0;

            if (maxPosition != array.Length - 1)
                    {
                        for (int i = maxPosition + 1; i < array.Length; i++)
                        {
                            sum += array[i];
                        }
                    }

            array[maxPosition] = sum;
            
            
            // end

        }
        public int[] Task2(int[] array, int P)
        {
            int[] answer = null;

            // code here

            // end

            return answer;
        }
        public int[] Task3(int[] array)
        {
            int[] answer = null;

            // code here

            // end

            return answer;
        }
        public void Task4(double[] array)
        {

            // code here

            // end

        }
        public int Task5(int[] A, int[] B)
        {
            int sum = 0;

            // code here

            // end

            return sum;
        }
        public int[] Task6(int[] array)
        {
            int[] indexes = null;

            // code here

            // end

            return indexes;
        }
        public int Task7(int[] array)
        {
            int count = 0;

            // code here

            // end

            return count;
        }
        public int[] Task8(int[] array)
        {
            int[] answer = null;

            // code here

            // end

            return answer;
        }
        public double[] Task9(int[] array)
        {
            double[] normalized = null;

            // code here

            // end

            return normalized;
        }
        public int Task10(int[] array, int P)
        {
            int index = 0;

            // code here

            // end

            return index;
        }
        public int[] Task11(int a, int b, int c)
        {
            int[] array = null;

            // code here

            // end

            return array;
        }

        public int[] Task12(int[] magazine)
        {
            int[] indexes = null;

            // code here

            // end

            return indexes;
        }
    }

}

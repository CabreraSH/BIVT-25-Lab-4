 ﻿using System.Runtime.InteropServices;

namespace Lab4
{
    public class Blue
    {
        public void Task1(int[] array)
        {

            // code here
// PROBLEM ONE----------------------------------------------------------------------------------------------------------------------------------------------------------------------------START

            // В метод передается одномерный массив array. Первый отрицательный элемент массива заменить суммой элементов, расположенных после максимального элемента массива.
            // Если максимальный элемент последний, сумма после него считается равной 0.

            // The first negative element is replaced by the sum of the elements that follow the highest positive number
            // If there is no element after the highest positive number, the sum will be treated as 0
            
            //----------------------------------------------------------------------------------------------------------------------------------------------------------------

            // We begin by finding out the position of the first negative number
            
            int negativePosition = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    negativePosition = i;
                    break;
                }
            }

            // Now that we have found it, we need to find the highest positive number, we begin by finding it's value
            // We scour through the array and make successive comparasions, this brings up a problem however, as it seems we cannot do a holistic comparison
            // That's why we define a variable where we will store the value and ensure that it's constantly compared through the loops
            
            int maxValue = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (maxValue < Math.Max(array[i], array[i+1])
                    {
                        maxValue = Math.Max(array[i], array[i+1]);
                    }
            }

            // Now that we know the maximum value, we need to find it's position

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

            array [maxPosition] = sum;
            
//---------------------------------------------------------------------------------------------------------------------------------------------
            // end

        }
        public int[] Task2(int[] array, int P)
        {
            int[] answer = null;

            // code here
// PROBLEM TWO----------------------------------------------------------------------------------------------------------------------------------------------------------------------------START
            // В метод передается одномерный массив array и число P. Вставить заданный элемент P после последнего положительного элемента массива и вернуть как новый массив.
            // Если в массиве нет положительных элементов, вернуть копию исходного массива.

            // Insert the element P after the last positive element and return it as a new array.
            // If the array doesn't have positive elements, return a copy of the array
            //--------------------------------------------------------------------------------------------------------------------------------------------------------------

            // We begin by searching for the last positive element, since we want the last one, we begin from the end of the array
            int positivePosition = 0;
            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (array[i] > 0)
                {
                    positivePosition = i;
                    break;
                }
            }

            // If our array did not had any positive elements, then it would not have changed the value of our variable
            // Therefore we set up a conditional, declare our answer array and use a for loop to copy the elements (we need to do this manually)
            if (positivePosition == 0)
            {
                int[] answer = new int[array.Length];
                    for (int i = 0; i < array.Length; i++)
                    {
                        answer[i] = array[i];
                    }
                return answer;
            }

            // Now we create our new array, which is the same size as the original one but bigger by one (we added P)
            // We make a new variable for the size
            int n = array.Length + 1;

            // Here is the array
            int[] answer = new int[n];

            // Now we need to populate it
            // We are going to do so in three steps
                // PART ONE: We are going to make a for loop, that runs until we reach the highest number (inclusive), we will just copy the elements
                // PART TWO: We are going to assign "P" to the next position
                // PART THREE: We are going to make a new loop again, but this time, we will begin onwards from P (exclusive) and we will copy the elements
                // BUT we need to take into account that the original array is smaller, so we are going to copy the elements "i-1" (adding P created an offset)
            for (int i = 0; i <= positivePosition; i++)
            {
                answer[i] = array[i];
            }

            answer[positivePosition + 1] = P;

            for (int i = positivePosition + 2; i < answer.Length; i++)
            {
                answer[i] = array[i - 1];
            }

            
            
//---------------------------------------------------------------------------------------------------------------------------------------------
            // end

            return answer;
        }
        public int[] Task3(int[] array)
        {
            int[] answer = null;

            // code here
// PROBLEM THREE----------------------------------------------------------------------------------------------------------------------------------------------------------------------------START
			// В метод передается одномерный массив array. Удалить минимальный среди положительных элементов массива.
			// Если в массиве нет положительных элементов, вернуть копию исходного массива.
			
			// 
			// 
			
			
            
            
            
//---------------------------------------------------------------------------------------------------------------------------------------------
            // end

            return answer;
        }
        public void Task4(double[] array)
        {

            // code here
// PROBLEM FOUR----------------------------------------------------------------------------------------------------------------------------------------------------------------------------START
			// В метод передается одномерный массив array. Найти среднее значение элементов массива.
			// Преобразовать элементы исходного массива, вычитая из каждого элемента полученное значение.
			
			// 
			// 
			
			
            
            
            
//---------------------------------------------------------------------------------------------------------------------------------------------
            // end

        }
        public int Task5(int[] A, int[] B)
        {
            int sum = 0;

            // code here
// PROBLEM FIVE----------------------------------------------------------------------------------------------------------------------------------------------------------------------------START
			// В метод передаются одномерные массивы A и B. Вычислить скалярное произведение массивов A и B.
			// Скалярным произведением называется сумма попарных произведений соответствующих элементов массивов.
			
			// 
			// 
			
			
            
            
            
//---------------------------------------------------------------------------------------------------------------------------------------------
            // end

            return sum;
        }
        public int[] Task6(int[] array)
        {
            int[] indexes = null;

            // code here
// PROBLEM SIX----------------------------------------------------------------------------------------------------------------------------------------------------------------------------START
			// В метод передается одномерный массив array. Индексы элементов массива, меньших среднего, поместить в новый массив.
			
			// 
			
			
            
            
            
//---------------------------------------------------------------------------------------------------------------------------------------------
            // end

            return indexes;
        }
        public int Task7(int[] array)
        {
            int count = 0;

            // code here
// PROBLEM SEVEN----------------------------------------------------------------------------------------------------------------------------------------------------------------------------START
			// В метод передается одномерный массив array. Определить длину самой большой непрерывнойупорядоченной (по возрастанию или по убыванию) последовательности. 
			// Последовательность считается непрерывной, если её элементы равны или их попарная разность одного знака.
			
			// 
			// 
			
			
            
            
            
//---------------------------------------------------------------------------------------------------------------------------------------------
            // end

            return count;
        }
        public int[] Task8(int[] array)
        {
            int[] answer = null;

            // code here
// PROBLEM EIGHT----------------------------------------------------------------------------------------------------------------------------------------------------------------------------START
			// В метод передается одномерный массив array. Продублировать все элементы с сохранением порядка следования.
			// Например, передается array = {3, 8, ...}, получить array = {3, 3, 8, 8, ...}.
			
			// 
			// 
			
			
            
            
            
//---------------------------------------------------------------------------------------------------------------------------------------------
            // end

            return answer;
        }
        public double[] Task9(int[] array)
        {
            double[] normalized = null;

            // code here
// PROBLEM NINE----------------------------------------------------------------------------------------------------------------------------------------------------------------------------START
			// В метод передается одномерный массив array. Нормировать значения массива, чтобы его элементы принадлежали отрезку [0, 1]. 
			// Если все элементы массива равны, вернуть null.
			
			// 
			// 
			
			
            
            
            
//---------------------------------------------------------------------------------------------------------------------------------------------
            // end

            return normalized;
        }
        public int Task10(int[] array, int P)
        {
            int index = 0;

            // code here
// PROBLEM TEN----------------------------------------------------------------------------------------------------------------------------------------------------------------------------START
			// В метод передается одномерный массив array и число P. Отсортировать массив по возрастанию и найти индекс числа P бинарным поиском в отсортированном массиве. 
			// Вернуть -1, если число не найдено.
			
			// 
			// 
			
			
            
            
            
//---------------------------------------------------------------------------------------------------------------------------------------------
            // end

            return index;
        }
        public int[] Task11(int a, int b, int c)
        {
            int[] array = null;

            // code here
// PROBLEM ELEVEN----------------------------------------------------------------------------------------------------------------------------------------------------------------------------START
			// В метод передаются целые числа a, b, c. 
            // Сформировать массив из элементов, начинающийся с элемента a, увеличивая значение каждого последующего элемента на b до тех пор, пока элемент не превысит значение c. 
			// Число b должно быть положительным.
			
			// 
			// 
			
			
            
            
            
//---------------------------------------------------------------------------------------------------------------------------------------------
            // end

            return array;
        }

        public int[] Task12(int[] magazine)
        {
            int[] indexes = null;

            // code here
// PROBLEM TWELVE----------------------------------------------------------------------------------------------------------------------------------------------------------------------------START
			// Группа археологов исследуют древнюю египетскую гробницу. 
			// Внутри они обнаружили несколько запечатанных комнат, в каждой из которых, по слухам, хранятся золотые слитки фараона. 
            // Однако не все комнаты сохранились нетронутыми — некоторые были разграблены еще в древности. 
            // Записи о количестве золотых слитков в каждой пронумерованной комнате были записаны в журнал magazine.
            // Нулевые значения означают, что комната пуста. У археологов есть время посетить только 3 соседние комнаты и забрать оттуда золото.
            // Помогите им выбрать, какие 3 комнаты нужно посетить, чтобы забрать как можно больше золотых слитков. 
            // Если комнат меньше 3-х, то посетить все, что есть.
            // Ответ представить в виде массива индексов комнат. 
			
			// 
			// 
			
			
            
            
            
//---------------------------------------------------------------------------------------------------------------------------------------------
            // end

            return indexes;
        }
    }

}


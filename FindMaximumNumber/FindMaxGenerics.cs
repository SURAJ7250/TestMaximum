using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximumNumber
{
    public class FindMaxGenerics<T> where T : IComparable<T>
    {
        public T firstNum, secondNum, thirdNum;
        public FindMaxGenerics(T firstNum, T secondNum, T thirdNum)
        {
            this.firstNum = firstNum;
            this.secondNum = secondNum;
            this.thirdNum = thirdNum;
        }
        public T FindMax()
        {
            if (firstNum.CompareTo(secondNum) > 0 && firstNum.CompareTo(thirdNum) > 0)
                return firstNum;
            if (secondNum.CompareTo(firstNum) > 0 && secondNum.CompareTo(thirdNum) > 0)
                return secondNum;
            else
                return thirdNum;
        }
    }
}

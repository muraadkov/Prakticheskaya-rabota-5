﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR
{
    class RangeOfArray
    {
        public int _start;
        public int _end;
        public int[] _arr;
        public RangeOfArray(int end, int start)
        {
            this._start = start;
            this._end = end;
            _arr = new int[Math.Abs(_end - _start) + 1];
        }
        public void Print(RangeOfArray arr, int start)
        {
            for (int i = 0; i < _arr.Length; i++)
            {
                Console.WriteLine($"{i + start} элемент массива равен = " + _arr[i]);
            }
        }

    }

}
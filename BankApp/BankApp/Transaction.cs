﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp
{
    class Transaction
    {
        public double Sum { get; }
        public DateTime TimeStamp { get; }

        public Transaction(double sum, DateTime timestamp)
        {
            Sum = sum;
            TimeStamp = timestamp;
        }


    }
}
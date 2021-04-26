using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Task2_ClassLibrary
{
    public class NumericCounter
    {
        public string Text { get; set; }
        public int Summa { get; set; }
        public int Count { get; set; }

        public NumericCounter()
        {

        }

        public void Compute()
        {
            var numbers = new Regex("[+-]*\\d+").Matches(Text).Cast<Group>().Select(x => Int32.Parse(x.Value));
            Summa = numbers.Sum();
            Count = numbers.Count();
        }
    }
}

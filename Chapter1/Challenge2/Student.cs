using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter1.Challenge2
{
    public class Student
    {
        private readonly int _position;
        private readonly string _name;        
        private readonly int _englishMarks;
        private readonly int _mathMarks;
        private readonly int _computerMarks;

        public Student(int position, string name, int englishMark, int mathMark, int computerMark)
        {
            _position = position;
            _name = name;
            _englishMarks = englishMark;
            _mathMarks = mathMark;
            _computerMarks = computerMark;
        }

        public int CalculateTotalMarks()
        {
            return _englishMarks + _mathMarks + _computerMarks;
        }

        public override string ToString()
        {
            return $@"Student Name: {_name}, Position: {_position}, Total: {CalculateTotalMarks()}/300";
        }
    }
}

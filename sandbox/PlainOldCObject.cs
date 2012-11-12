using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sandbox
{
    public class PlainOldCObject
    {
        private string _stringObject;                   // length upto 2 billion bytes;
        private int _intObject;                         // -2 billion to 2 billion;
        private bool _boolObject;                       // true || false
        private List<string> _listStringObject;         // list object
        private DateTime _dateTimeObject;               // 0:00:00am 1/1/01 to 11:59:59pm 12/31/9999
        private decimal _decimalObject;                 // 28 to 29 significant digits
        private uint _uintObject;                       // 0 to 4 billion
        private float _floatObject;                     // 7 significant digits
        private double _doubleObject;                   // 15 significant digits
        private char _charObject;                       // Unicode characters

        public string StringObject
        {
            set { this._stringObject = value; }
            get { return this._stringObject; }
        }

        public int IntObject
        {
            set { this._intObject = value; }
            get { return this._intObject; }
        }

        public bool BoolObject
        {
            set { this._boolObject = value; }
            get { return this._boolObject; }
        }

        public List<string> ListStringObject
        {
            set { this._listStringObject = value; }
            get { return this._listStringObject; }
        }

        public DateTime DateTimeObject
        {
            set { this._dateTimeObject = value; }
            get { return this._dateTimeObject; }
        }

        public decimal DecimalObject
        {
            set { this._decimalObject = value; }
            get { return this._decimalObject; }
        }

        public uint UIntObject
        {
            set { this._uintObject = value; }
            get { return this._uintObject; }
        }

        public float FloatObject
        {
            set { this._floatObject = value; }
            get { return this._floatObject; }
        }

        public double DoubleObject
        {
            set { this._doubleObject = value; }
            get { return this._doubleObject; }
        }

        public char CharObject
        {
            set { this._charObject = value; }
            get { return this._charObject; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Security;

namespace _7.Diary
{
    /// <summary>
    /// Структура ежедневника
    /// </summary>
    struct Diary
    {
        public int Index { get; private set; }
        public DateTime Date { get; private set; }
        public float Sum { get; private set; }
        public float Income { get; private set; }
        public float Profit { get; private set; }
        public float Turnover { get; private set; }
        public string Note { get; private set; }

        public Diary(int Index, DateTime Date, float Sum, float Income, float Profit, float Turnover, string Note) 
        {
            this.Index = Index;
            this.Date = Date;
            this.Sum = Sum;
            this.Income = Income;
            this.Profit = Profit;
            this.Turnover = Turnover;
            this.Note = Note;
        }
    }
}

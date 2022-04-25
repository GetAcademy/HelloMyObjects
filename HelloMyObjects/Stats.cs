namespace HelloMyObjects
{
    internal class Stats
    {
        public int Count { get; private set; }
        private int _sum;
        private int _max;
        private int _min;

        public Stats()
        {
            Count = 0;
            _sum = 0;
            _max = -1;
            _min = -1;
        }

        //public int GetCount()
        //{
        //    return _count;
        //}

        //public void SetCount(int newCount)
        //{
        //    _count = newCount;
        //}

        public void Add(int number)
        {
            if (_max == -1 || number > _max) _max = number;
            if (_min == -1 || number < _min) _min = number;
            Count++;
            _sum += number;
        }

        public float GetAvg()
        {
            return (float)_sum / Count;
        }

        public string GetDesription()
        {
            var avg = GetAvg();
            return
                Format("Antall tall", Count) +
                Format("Sum", _sum) +
                Format("Max", _max) +
                Format("Min", _min) +
                Format("Gjennomsnitt", avg);
            //return $"Antall tall:  {count:####}\n" +
            //    $"Sum:          {sum:###}\n" +
            //    $"Max:          {max:####}\n" +
            //    $"Min:          {min:####}\n" +
            //    $"Gjennomsnitt: {avg:####.##}\n";
        }

        private static string Format(string label, float number)
        {
            return label.PadRight(12, ' ')
                   + ": "
                   + number.ToString("####.##")
                   + '\n';
        }

        private static string Format(string label, int number)
        {
            return label.PadRight(12, ' ')
                   + ": "
                   + number.ToString("####")
                   + '\n';
        }
    }
}

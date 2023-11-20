using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace MovieLibrary
{
    public class MovieLibrary : IEnumerable<KeyValuePair<int, string>>
    {
        //public static readonly TimeSpan StartTime = new TimeSpan(23, 0, 0);
        //public static readonly TimeSpan EndTime = new TimeSpan(7, 0, 0);
        //public static readonly DateTime CurrentTime = DateTime.Now;

        private Dictionary<int, string> _ordinaryMovies = new Dictionary<int, string>
        {
        { 0001, "ordinaryMovie_1" },
        { 0002, "ordinaryMovie_2" },
        { 0003, "ordinaryMovie_3" },
        { 0004, "ordinaryMovie_4" }
        };

        private Dictionary<int, string> _onlyAdultMovies = new Dictionary<int, string>
        {
        { 0005, "onlyAdultMovie_1" },
        { 0006, "onlyAdultMovie_2" },
        { 0007, "onlyAdultMovie_3" },
        { 0008, "onlyAdultMovie_4" }
        };

        public Dictionary<int, string> OrdinaryMovies
        {
            get => _ordinaryMovies;

        }

        public Dictionary<int, string> OnlyAdultMovies
        {
            get => _onlyAdultMovies;

        }


        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public IEnumerator<KeyValuePair<int, string>> GetEnumerator()
        {
            TimeSpan StartTime = new TimeSpan(23, 0, 0);
            TimeSpan EndTime = new TimeSpan(7, 0, 0);
            DateTime CurrentTime = DateTime.Now;

            if (IsTimeInRange(CurrentTime, StartTime, EndTime))
            {
                return _ordinaryMovies.Concat(_onlyAdultMovies).GetEnumerator();
            }
            else
            {
                return _ordinaryMovies.GetEnumerator();
            }
        }
        public IEnumerator<KeyValuePair<int, string>> GetEnumerator1()
        {
            return _ordinaryMovies.GetEnumerator();
        }
        public IEnumerator<KeyValuePair<int, string>> GetEnumerator2()
        {
            return _onlyAdultMovies.GetEnumerator();
        }
        public string GetMovie(int movieNum)
        {

            if (_ordinaryMovies.TryGetValue(movieNum, out string? value))
            {
                return value;
            }
            else

            {
                Console.WriteLine($"The film with unique key {movieNum} is not found in ordinary list ");

                TimeSpan StartTime = new TimeSpan(23, 0, 0);
                TimeSpan EndTime = new TimeSpan(7, 0, 0);
                DateTime CurrentTime = DateTime.Now;

                if (IsTimeInRange(CurrentTime, StartTime, EndTime))

                {
                    if (_onlyAdultMovies.TryGetValue(movieNum, out string? value1))

                    {
                        return value1;
                    }
                    else

                    {
                        return $"The film with unique key {movieNum} is not found in adult films list as well ";
                    }
                }
                else

                {
                    return "It is not the time for adult movie";
                }
            }

        }

        static bool IsTimeInRange(DateTime currentTime, TimeSpan startTime, TimeSpan endTime)
    {
        TimeSpan currentTimeOfDay = currentTime.TimeOfDay;

        return ((currentTimeOfDay >= startTime) && (currentTimeOfDay <= endTime));
    }
        
            }
}



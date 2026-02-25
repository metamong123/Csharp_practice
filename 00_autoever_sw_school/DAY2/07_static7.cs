using static System.Console;

class Date {
    private static int[] days = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
    private int year;
    private int month;
    private int day;

    public int Month {
        get => month;
        set {
            if (value > 0 && value < 13) month = value;
            else throw new Exception("bad argument");
        }
    }

    public int Year {
        get => year;
        set {
            if (value > 0) year = value;
            else throw new Exception("bad argument");
        }
    }

    public int Day {
        get => day;
        set {
            int max_days = days[month - 1];
            if (month == 2 && Date.IsLeapYear(year)) ++max_days;
            if (value > 0 && value <= max_days) day = value;
            else throw new Exception("bad argument");
        }
    }

    public Date(int y, int m, int d) => (Year, Month, Day) = (y, m, d);

    // 동일 기능을 instance method, static method 로 모두제공
    // 하는 것도 많이 사용되는 기술입니다.
    public static bool IsLeapYear(int y) {
        return (y % 400 == 0) || ((y % 4 == 0) && (y % 100 != 0));
    }

    public bool IsLeapYear() {
        // static method 호출하면서 자신의 Year 전달
        return IsLeapYear(Year);
    }

    public static int HowManyDays(int m) {
        if (0 < m && m < 13) return days[m - 1];
        else throw new Exception("Out of range(1 <= month <= 12)");
    }
    public int HowManyDays() {
        if (Month == 2) {
            if (this.IsLeapYear()) return 29;
            else return 28;
        }
        else return days[Month - 1];
    }

    public Date Tomorrow() {
        (int n_year, int n_month, int n_day) = (Year, Month, Day + 1);
        int max_days = days[Month - 1];
        if (Month == 2 && this.IsLeapYear()) ++max_days;
        if (n_day > max_days) {
            n_day = 1;
            ++n_month;
        }
        if (n_month > 12) {
            n_month = 1;
            ++n_year;
        }

        Date tmp = new Date(n_year, n_month, n_day);
        return tmp;
    }

    public Date AfterDays(int ds) {
        Date tmp = new Date(Year, Month, Day);
        int n_month = Month;
        int n_days = ds + Day;

        while (n_days > tmp.HowManyDays()) {
            n_days -= tmp.HowManyDays();
            if (++n_month > 12) {
                ++tmp.Year;
                n_month = 1;
            }
            tmp.Month = n_month;
        }
        tmp.Day = n_days;
        return tmp;
    }
}

class Program {
    public static void Main() {
        // 윤년인지 조사하는 IsLeapYear() 메소드를 제공하고싶다.

        // 다음중 좋은 방법은 ?
        // #1. instance method 로 제공
        Date d = new Date(2026, 2, 28);
        bool b1 = d.IsLeapYear();

        // #2. static method 로 제공
        bool b2 = Date.IsLeapYear(2026);

        Date d1 = new Date(2025, 6, 23);

        int ds = 1000;
        Date d2 = d1.AfterDays(ds);
        WriteLine($"from: {d1.Year}.{d1.Month}.{d1.Day}, add {ds} days");
        WriteLine($"result: {d2.Year}.{d2.Month}.{d2.Day}");
    }
}
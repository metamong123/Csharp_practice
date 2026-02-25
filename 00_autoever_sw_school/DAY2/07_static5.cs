using static System.Console;
using static System.Net.Mime.MediaTypeNames;

class Date {
    // 날짜 관련 메소드를 만들기 위해 월별 날짜수 정보 필요
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
            if (value > 0 && value <= days[month - 1]) day = value;
            else throw new Exception("bad argument");
        }
    }

    public Date(int y, int m, int d) => (Year, Month, Day) = (y, m, d);

    // Date 타입 사용자가 유용하게 사용할 수 있는 다양한 메소드를 제공해야 함
    public Date AfterDays(int ds) { // ds 이후의 날짜
        int n_year = Year + ds / 365;
        int n_month = Month;
        int n_days = ds % 365 + Day;

        while (n_days > days[n_month - 1]) {
            n_days -= days[n_month++ - 1];
            if (n_month > 12) {
                ++n_year;
                n_month = 1;
            }
        }

        Date tmp = new Date(n_year, n_month, n_days);
        return tmp;
    }
}

class Program {
    public static void Main() {
        Date d1 = new Date(2025, 4, 23);
        Date d2 = new Date(2025, 5, 22);

        int ds = 1000;
        Date d = d1.AfterDays(ds);
        WriteLine($"from: {d1.Year}.{d1.Month}.{d1.Day}, add {ds} days");
        WriteLine($"result: {d.Year}.{d.Month}.{d.Day}");
    }
}
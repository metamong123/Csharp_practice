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
            if (value > 0 && value <= days[month - 1]) day = value;
            else throw new Exception("bad argument");
        }
    }

    public Date(int y, int m, int d) => (Year, Month, Day) = (y, m, d);

    // static method
    // => 기준 객체와는 관련 없는 기능
    // => Date와 관련된 기능을 구현하는 것
    public static int HowManyDays(int m) {
        if (0 < m && m < 13) return days[m - 1];
        else throw new Exception("Out of range(1 <= month <= 12)");
    }
    public int HowManyDays() {
        return days[Month - 1];
    }

    // ======================================================
    // 내일 날짜를 구하는 메소드
    // => 기준이 되는 객체를 만들고 호출해야 한다.
    // => instance method
    public Date Tomorrow() {
        (int n_year, int n_month, int n_day) = (Year, Month, Day + 1);

        if (n_day > days[Month - 1]) {
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
        Date d1 = new Date(2025, 2, 23);

        // 5월이 몇일까지 있는지 알고 싶다
        // 다음중 사용자 입장에서 편한 코드는 ?

        // 방법 #1. 5월로 초기화된 객체를 만들어서 메소드 호출
        Date d = new Date(2025, 5, 1);
        int n1 = d.HowManyDays();
        WriteLine($"n1: {n1}");

        // 방법 #2. 객체 없이 클래스 이름으로만 호출가능한 메소드 사용
        int n2 = Date.HowManyDays(5);
        WriteLine($"n2: {n2}");

        // 내일 날짜를 알고 싶다
        // => 이 작업은 기준이 되는 날짜(객체) 가 필요
        Date today = new Date(2025, 12, 31);
        Date tom = today.Tomorrow();   // instance method!
        WriteLine($"today: {today.Year}.{today.Month}.{today.Day}");
        WriteLine($"tom  : {tom.Year}.{tom.Month}.{tom.Day}");
    }
}
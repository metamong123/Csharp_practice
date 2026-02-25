using static System.Console;

// 프로그램에서 날짜 를 많이 사용한다.
// => "Date" 라는 타입을 설계 하자
class Date {
    // 날짜 관련 메소드를 만들기 위해 월별 날짜수 정보 필요
    private static int[] days = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
    // 1. 필드는 private으로 보호
    private int year;
    private int month;
    private int day;

    // 2. getter/setter 제공
    //    => C#에서는 property가 관례
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

    // 3. 생성자로 필드 초기화
    // => 대부분의 경우 코딩 관례
    public Date(int y, int m, int d) => (year, month, day) = (y, m, d);
}

class Program {
    public static void Main() {
        Date d1 = new Date(2025, 3, 23);

        d1.Day = 32; // 예외 발생, 비정상 종료

        WriteLine(d1.Day); // 2
    }
}
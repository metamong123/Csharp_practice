using System.Diagnostics;
using static System.Console;

// 실패를 호출자에게 보고하는 방법

// C: 반환값으로 실패 전달
//    => 호출자가 오류를 무시할 수 있음 => 더 큰 문제 발생
//    => DB 백업에 실패했는데 DB가 제거됨

// 호출자에게 반드시 오류를 처리하도록 강제하는 방법
// => 오류 처리를 생략하면 프로그램 종료

class Database {
    public Database(string dbname) { }

    public bool Backup() {
        bool success = false;

        if (success == false) // 실패라고 가정
            return false;
        return true;
    }
    public void Remove() => WriteLine("Remove DB");
}

class Program {
    public static void Main() {
        Database db = new Database("product.db");

        bool ret = db.Backup();

        if (ret == false) {
            WriteLine("False");
        }

        db.Remove();
    }
}

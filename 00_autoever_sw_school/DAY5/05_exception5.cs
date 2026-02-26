using System.Diagnostics;
using static System.Console;

// 예외 클래스
// Exception: C#에서 예외를 던질 때 사용하도록 제공하는 표준 타입
// => 보통 직접 사용하지 않고, 파생 클래스를 만들어서 사용

class DBBackupException: Exception {
    // 이 안에 에러의 원인을 최대한 보관
    public string backupfilename = "a.txt";
}

class NetworkException: Exception {
    // 네트워크 장애 발생 시 사용할 예외
    // 다양한 정보를 담기 위한 필드, 메소드 제공
}

class Database {
    public Database(string dbname) { }

    public bool Backup() {
        bool success = false;

        if (success == false) throw new NetworkException(); // 네트워크 장애

        //if (... ) throw new DBBackupException(); // 백업 문제

        return true;
    }
    public void Remove() => WriteLine("Remove DB");
}

class Program {
    public static void Main() {
        Database db = new Database("product.db");

        // 예외 가능성이 있는 메소드 호출 시 try{} 사용
        try {
            db.Backup();
        }
        catch (DBBackupException ex) {
            WriteLine("DB Backup 실패");
        }
        catch (NetworkException ex) {
            WriteLine("NetworkException");
        }
        catch (Exception ex) {           // 위에서 잡히지 않은 모든 예외
            WriteLine("알 수 없는 예외"); // 모든 예외는 Exception의 파생 글래스!
        }

        db.Remove();
    }
}
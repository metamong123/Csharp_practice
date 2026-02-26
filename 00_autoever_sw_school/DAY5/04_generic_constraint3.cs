class List<T> where T : struct { // T 는 value type 이어야 한다.

}

class Program 
{
	public static void Main()
	{
		List<int>    c1 = new List<int>();		// ok
		List<string> c2 = new List<string>();	// error

		Nullable<int> n = null;
	}	
}

/*
class C1<T> where T : struct           {} // value
class C2<T> where T : class            {} // reference
class C3<T> where T : class?           {} // null 가능
class C4<T> where T : notnull          {} // null 불가능 타입
class C5<T> where T : unmanaged        {} // value type + 참조 타입 필드를 포함하지 않는 구조체

class C6<T> where T : new() { // 디폴트 생성자(인자없는 생성자)
							  // T는 매개변수가 없는 public 생성자를 가져야 함
	public void Foo() {
		T a = new T(); // 제약이 없으면 안됨
	}
}

// class C7<T> where T : base_class_name  {} //BaseClass이거나, 그 클래스를 상속받은 자식 클래스
// class C8<T> where T : base_class_name? {}
// class C9<T> where T : interface_name   {}
// class C10<T> where T : interface_name?  {}

class C11<T> where T : class, IComparable<T> { } reference + IComparable

class C12<T, U> where T : struct  
			    where U : class { } // 두 개의 서로 다른 제네릭 타입(T, U)에 대해
									// 각각 서로 다른 규칙을 적용
*/
# 델리게이트
## 델리게이트(대리자) : delegate
* 함수를 가질 수 있는 자료형
* 대리자 인스턴스를 통해 함수를 호출 할 수 있음
* 여러개의 함수를 가질 수 있음
  * 델리게이트 체인
#### 델리게이트 정의
* delegatr 반환형 델리게이트 이름(매개변수)
```
public delagate int Mydel(int a, int b);
public delagate void Mydel1();
```
```
Mydel delegate1 = Plus; // Plus: 매개변수 두개를 더하는 함수라고 가정
delegate1(10,20); // 델리게이트에 저장된 함수가 호출이 된다. 콘솔 출력을 안해서 출력값은 없음

Mydel1 delegate2 = Message; // text를 출력하는 함수
delegate2("Hi") // 델리게이트에 저장된 함수 호출. output: Hi
```

### 제네릭 델리게이트
어처피 델리게이트 많이 쓸건데 C#에서 미리 일반화 시켜둔 델리게이트 쓰면 편함
* 반환형이 있는 델리게이트
```
public static void GenericDel() 
    {
        Func<float, double/*여기까진 매개변수*/, int/*마지막이 반환형*/> func1 = Function;
    }
public static int Function(float a, double b) { return 0; }
```
* 반환형이 없는 델리게이트
```
public static void GenericDel() 
    {
        Action<int, float> action1 = Action; // 반환형이 없는경우는 Action 사용
    }
public staitc void Action1(int a, float b) { }
```
### 콜백 함수
* 델리게이트를 이용하여 특정조건에서 구현하는 함수 
* 함수의 호출이 아닌 역으로 호출받을 때 반응을 참조하여 역호출

### 지정자(Specifier)
* 델리게이트를 사용하여 미완성 상태의 함수를 구성
* 매개변수로 전달한 지정자를 기준으로 함수를 완성하여 동작시킴
* 기준을 정해주는 것으로 다양한 결과가 나올 수 있는 함수를 구성 가능
* ```
        public static bool Compare(int left, int right, Func<int, int, bool> comperer)
        // 델리게이트를 매개변수로 전달. comperer에 따라 결과 달라짐
        {
            return comperer(left, right);
        }
```
    public class Program
    {
        static void Main(string[] args)
        {
            bool bigger = Compare(3, 2, Bigger); // compare에 Bigger 함수 넣어서 사용
            bool less = Compare(3, 5, Less);
            bool equal = Compare(3, 3, Equal);
            int[] array1 = { 1, 3, 5, 7, 9 };
            int less1 = CountIf(array1, 4, Less);
            Console.WriteLine(less1);
        }
        public static bool Bigger(int left, int right)
        {
            return left > right;
        }
        public static bool Less(int left, int right)
        {
            return left < right;
        }
        public static bool Equal(int left, int right)
        {
            return left == right;
        }
        public static bool Compare(int left, int right, Func<int, int, bool> comperer)
        // 델리게이트를 매개변수로 전달. comperer에 따라 결과 달라짐
        {
            return comperer(left, right);
        }
        public static int CountIf(int[] array, int value, Func<int, int, bool> comparer)
        {
            int count = 0;
            foreach (int item in array)
            {
                if (item <= value)
                {
                    count++;
                }
            }
            return count;
        }
    }
```
### 델리게이트 체인
* 여러개의 함수를 가질 수 있음
 ```
public static void Main()
{
    Action action;
    action = AAA;
    action += BBB;
    action += CCC;
    action(); // 출력: ABC
    action -= CCC;
    action(); // 출력: AB
    action = BBB; // 더하는게 아니라 BBB로 덮어씌워 저장
    action(); // 출력: B
}
    public static void AAA()
    {
        Console.Write("A");
    }
    public static void BBB()
    {
        Console.Write("B");
    }
    public static void CCC()
    {
        Console.Write("C");
    }
```
* 단 델리게이트내 함수를 모두 빼버리면 에러 발생함 
    ```
    if(action != null)
    {
        action
    }
    ```
* 이런 방법으로 에러를 막는다



## 이벤트
* 일련의 사건이 발생했다는 사실을 다른 객체들에게 전달
* 델리게이트의 일부 기능을 제한하여 이벤트의 용도로 사용
    * 델리게이트 체인 활용
* 예시 코드
```
public static void Main()
{
    Player player = new Player();
    UI ui = new UI();
    Sound sound = new Sound();
    player.Ondied = ui.GameOverUI;
    player.Ondied += sound.DeadSound;

    player.Die();
}

public class Player
{
    public Action Ondied;
    public void Die()
    {
        // 나 주거따!!
        Console.WriteLine("플레이어가 죽었습니다");
        // >>
        if(Ondied != null)
        {
            Ondied(); // 일련이 사건이 발생했을떄 이벤트 발생
        }
        // 음악실행
        // 게임오버 UI
        // 등등 효과
    }
}

public class UI
{
    public void GameOverUI()
    {
        Console.WriteLine("게임오버");
    }
}
public class Sound
{
    public void DeadSound()
    {
        Console.WriteLine("슬픈 bgm");
    }
}
```
* 추가가 아닌 대입하는 것을 주의할 것
  * 대입을 하게되면 이전에 추가했던 것이 모두 사라짐
* 이벤트는 접근제한자가 public일 수 밖에 없음

### 델리게이트를 그대로 이벤트로서 쓸 때 문제점
* =(대입) 연산을 통해 기존 반응할 객체들이 사라질 위험
* 외부에서 이벤트를 발생시켜 의도치 않은 반응들을 이끌어낼수 있음

### 문제 해결 방법
event 키워드
```
public event Action Ondied;
```
* =(대입) 연산이 불가능해짐, 기존 반응할 객체들이 사라지는 것 방지
* 외부에서 이벤트 직접 발생을 금지. 의도치 않은 외부 사용 방지
  * 개방,폐쇄의 원칙

### 이벤트의 장,단점
* 장점 : 개방폐쇄의 원칙이 지켜지며, 불필요한 연산을 필요로 하지 않음
* 단점 : 이벤트를 구성하기 위한 추가적인 소스를 작성해야 함



#### 델리게이트 사용시 주의점
* 두 세개정도까지만 연결
  *  헷갈릴 수 있음: 콜백 연쇄
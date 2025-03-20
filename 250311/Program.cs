using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _250311
{
    class Program
    {
    //여기부터
    static bool male = true;
    static string sex;
    static string Sex(bool male)
    {
        if (male == true)
            sex = "남자";
        else
            sex = "여자";
        return sex;
    }
    //여기까지는  오늘 안 배운거
    //bool 타입을 어떻게 쓸까 생각하다가 성별이 좋다고 생각했는데...
    //하나하나 넣기 귀찮아서 함수를 만들어서 사용해서 했습니다.

    static void Main(string[] args)
    {

        char lastName;              //char타입 변수를 사용하기 위해 이름을 성과 이름으로 나누어서 표현
        string firstName;
        int age;                    //나이
        float height;               //키, float함수를 활용하기 위해 키의 단위는 cm가 아닌 m로 정했습니다.
        float weight;               //몸무게
        string hobby;               //취미
        string nbti;                //NBTI
        string gameGenre;           //좋아하는 게임 장르
        string programingExp;       //프로그래밍 경험 유무
        string bloodType;           //혈액형

        //홍치우 프로파일
        lastName = '홍';
        firstName = "치우";
        age = 32;
        height = 1.69f;
        hobby = "게임";
        gameGenre = "로그라이크와 카드게임";
        programingExp = "초보자";
        nbti = "INTJ";
        bloodType = "A";
        Sex(true);

        Console.WriteLine("\n<{0}{1} 프로파일링>", lastName, firstName);
        Console.WriteLine("성 {0}, 이름 {1}\n성별은 {2}, 나이는 {3}살, 키는 {4}m, 혈액형은 {5}형"
            , lastName, firstName, sex, age, height, bloodType);
        Console.WriteLine("취미는 {0}, 좋아하는 게임 장르는 {1}이고", hobby, gameGenre);
        Console.WriteLine("프로그래밍 경험은 {0}이고, NBTI는 {0}이다.\n", programingExp, nbti);


        //정재영 프로파일
        lastName = '정';
        firstName = "재영";
        age = 25;
        height = 1.77f;
        hobby = "게임";
        gameGenre = "로그라이크와 RPG";
        programingExp = "초보자";
        nbti = "I,T";
        bloodType = "O";
        Sex(true);

        Console.WriteLine("\n<{0}{1} 프로파일링>", lastName, firstName);
        Console.WriteLine("성 {0}, 이름 {1}\n성별은 {2}, 나이는 {3}살, 키는 {4}m, 혈액형은 {5}형"
            , lastName, firstName, sex, age, height, bloodType);
        Console.WriteLine("취미는 {0}, 좋아하는 게임 장르는 {1}이고", hobby, gameGenre);
        Console.WriteLine("프로그래밍 경험은 {0}이고, NBTI는 {0}이다.\n", programingExp, nbti);


        //권종근 프로파일
        lastName = '권';
        firstName = "종근";
        age = 27;
        height = 1.61f;
        weight = 55;
        hobby = "게임과 AI공부";
        programingExp = "경험자";
        nbti = "INTP";
        bloodType = "O";
        Sex(true);

        Console.WriteLine("\n<{0}{1} 프로파일링>", lastName, firstName);
        Console.WriteLine("성 {0}, 이름 {1}\n성별은 {2}, 나이는 {3}살, 키는 {4}m, 몸무게는 {5}kg, 혈액형은 {6}형이고"
            , lastName, firstName, sex, age, height, weight, bloodType);
        Console.WriteLine("취미는 {0}, 좋아하는 게임 장르는 {1}이고", hobby, gameGenre);
        Console.WriteLine("프로그래밍 경험은 {0}이고, NBTI는 {0}이다.\n", programingExp, nbti);


        //최혜성 프로파일
        lastName = '최';
        firstName = "혜성";
        age = 25;
        height = 1.60f;
        hobby = "게임";
        gameGenre = "PRG와 FPS";
        programingExp = "초보자";
        nbti = "ISTP";
        bloodType = "A";
        Sex(false);

        Console.WriteLine("\n<{0}{1} 프로파일링>", lastName, firstName);
        Console.WriteLine("성 {0}, 이름 {1}\n성별은 {2}, 나이는 {3}살, 키는 {4}m, 혈액형은 {5}형"
            , lastName, firstName, sex, age, height, bloodType);
        Console.WriteLine("취미는 {0}, 좋아하는 게임 장르는 {1}이고", hobby, gameGenre);
        Console.WriteLine("프로그래밍 경험은 {0}이고, NBTI는 {0}이다.\n", programingExp, nbti);


        //김경태 프로파일
        lastName = '김';
        firstName = "경태";
        age = 32;
        height = 1.78f;
        weight = 58;
        hobby = "게임";
        gameGenre = "PRG";
        programingExp = "경험자";
        nbti = "ISFP";
        bloodType = "A";
        Sex(true);

        Console.WriteLine("\n<{0}{1} 프로파일링>", lastName, firstName);
        Console.WriteLine("성 {0}, 이름 {1}\n성별은 {2}, 나이는 {3}살, 키는 {4}m, 몸무게는 {5}kg, 혈액형은 {6}형이고"
            , lastName, firstName, sex, age, height, weight, bloodType);
        Console.WriteLine("취미는 {0}, 좋아하는 게임 장르는 {1}이고", hobby, gameGenre);
        Console.WriteLine("프로그래밍 경험은 {0}이고, NBTI는 {0}이다.\n", programingExp, nbti);
    }
    }
}

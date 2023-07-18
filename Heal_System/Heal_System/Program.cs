using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heal_System
{
    public class Program
    {
        static void Main(string[] args)     // 힐 주기 시스템
        {
            int heal = 100;     // 힐 량
            int maxhp = 50;     // 최대 HP
            int hp = 20;        // 남은 HP

            hp = hp + heal;        // 남은 HP 에서 힐 량을 더해준다.
            int boolresult;        // 연산 조건식 추가

            boolresult = (hp < 50) ? hp : maxhp;        // 연산 조건식으로 힐을 받은 HP 가 최대 HP를 넘는지 확인한다.
            Console.WriteLine("힐 량 : {0}", heal);      // 힐 량 출력
            Console.WriteLine("현재 HP : {0}", boolresult);     // 변화한 HP 출력
        }
    }
}

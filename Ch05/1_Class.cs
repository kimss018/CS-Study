using Ch05.Sub1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 날짜 : 2022/06/08
 * 이름 : 김효경 
 * 내용 : 클래스와 객체 실습하기 교재p203
 * 
 * 클래스와 객체 
 * - 클래스는 객체를 생성하는 구조체이며, 필드와 메서드로 구성된다.
 * - 객체는 클래스의 실제 인스턴스이며, new 연산자로 생성한다.
 */
namespace Ch05
{
    internal class _1_Class
    {
        static void Main1(string[] args)
        {
            // 객체 생생
            Car sonata = new Car();

            // 객체 초기화
            sonata.name = "소나타";
            sonata.color = "흰색";
            sonata.speed = 0;

            // 객체 기능
            sonata.SpeedUp(10);
            sonata.SpeedUp(50);
            sonata.SpeedDown(20);
            sonata.Show();

            // 객체 생성 (bmw, 검정색)
            Car bmw = new Car();

            // 객체 초기화 
            bmw.name = "bmw 520d";
            bmw.color = "검정";
            bmw.speed = 0;

            // 객체 기능
            bmw.SpeedUp(50);
            bmw.SpeedDown(20);
            bmw.Show();

            // Account 객체생성
            Account kb = new Account();

            // 객체 초기화
            kb.bank = "국민은행";
            kb.id = "101-12-1234";
            kb.name = "김유신";
            kb.balance = 10000;

            // 기능
            kb.Deposit(25000);
            kb.Withdraw(5000);
            kb.Show();

            // nh 객체 생성
            Account nh = new Account();
            nh.bank = "농협";
            nh.id = "120-11-1424";
            nh.name = "김춘추";
            nh.balance = 30000;

            // 기능
            nh.Deposit(70000);
            nh.Withdraw(20000);
            nh.Show();
        }
    }
}

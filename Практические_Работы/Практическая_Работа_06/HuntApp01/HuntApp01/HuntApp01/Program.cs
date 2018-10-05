using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuntApp01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Если Ты это читаешь - значит Ты пришёл пострелять из лука. Не будем тормозить. Поехали...");
            Console.ReadLine();
            Console.WriteLine("Готов?");
            Console.ReadLine();
            Console.WriteLine("Вот Тебе лук...");
            Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("             000\n            0  00\n           0    00\n          0      00\n         0        00                                                 _\n        0          00                                               I I\n       0            00                                              I I\n      0              00                                             I I\n     0                00                                            I I\n    0ЖЖЖ--------------00--->                                        I I\n     0                00                                            I I\n      0              00                                             I I\n       0            00                                              I I\n        0          00                                               I_I\n         0        00\n          0      00\n           0    00\n            0  00\n             000");
            Console.WriteLine();
            Console.WriteLine();
            Console.ReadLine();
            Console.WriteLine("Видишь мишень? А она есть...");
            Console.ReadLine();
            Console.WriteLine("В общем: Тебе надо в неё попасть. У тебя три попытки. Чем ближе к центру тем больше очков.");
            Console.ReadLine();
            Console.WriteLine("В конце очки сумируются и ...");
            Console.ReadLine();
            Console.WriteLine("...ну как бы и всё.");
            Console.ReadLine();
            Console.WriteLine("Ладно приступим...Можешь стрелять.");
            Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("          00\n          000\n          0 00\n          0  00\n          0   00                                               _\n          0    00                                             I I\n          0     00                                            I I\n          0      00                                           I I\n          0       00                                          I I\n          0       00                          ЖЖЖ-------------I I------->\n          0       00                                          I I\n          0      00                                           I I\n          0     00                                            I I\n          0    00                                             I_I\n          0   00\n          0  00\n          0 00\n          000\n          00");
            Console.WriteLine();
            Console.WriteLine();
            Random rnd = new Random();
            int p = 0;
            int x = rnd.Next(-4, 4);
            int y = rnd.Next(-4, 4);

            double R = (x * x + y * y);


            if (R <= 16 && R > 9)
            {
                p = 1;

                Console.WriteLine("ПОПАЛ!!!");
            }
            else if (R <= 9 && R > 4)
            {
                p = 2;
                Console.WriteLine("ПОПАЛ!!!");
            }


            else if (R <= 4 && R > 1)
            {

                p = 3;
                Console.WriteLine("ПОПАЛ!!!");
            }

            else if (R <= 1 && R>=0)
            {

                p = 4;
                Console.WriteLine("ПОПАЛ!!!");

            }
            else
            {
                Console.WriteLine("ЛОХ! Не попал.");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Ты попал в точку : ("+ x +";"+ y +")");
            

            Console.WriteLine("Колличество набранных очков : " +p);
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Ладно. Попытка № 2. Поехали.");
            Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("             000\n            0  00\n           0    00\n          0      00\n         0        00                                                 _\n        0          00                                               I I\n       0            00                                              I I\n      0              00                                             I I\n     0                00                                            I I\n    0ЖЖЖ--------------00--->                                        I I\n     0                00                                            I I\n      0              00                                             I I\n       0            00                                              I I\n        0          00                                               I_I\n         0        00\n          0      00\n           0    00\n            0  00\n             000");
            Console.WriteLine();
            Console.WriteLine();
            Console.ReadLine();
            Console.WriteLine("          00\n          000\n          0 00\n          0  00\n          0   00                                               _\n          0    00                                             I I\n          0     00                                            I I\n          0      00                                           I I\n          0       00                                          I I\n          0       00                          ЖЖЖ-------------I I------->\n          0       00                                          I I\n          0      00                                           I I\n          0     00                                            I I\n          0    00                                             I_I\n          0   00\n          0  00\n          0 00\n          000\n          00");
            Console.WriteLine();
            Console.WriteLine();
            int pp = 0;
            int xx = rnd.Next(-4, 4);
            int yy = rnd.Next(-4, 4);

            double RR = (xx * xx + yy * yy);


            if (RR <= 16 && RR > 9)
            {
                pp = 1;
                Console.WriteLine("Я НЕ ВЕРЮ СВОИМ ГЛАЗАМ! ТЫ ПОПАЛ!!!");

            }
            else if (RR <= 9 && RR > 4)
            {
                pp = 2;
                Console.WriteLine("Я НЕ ВЕРЮ СВОИМ ГЛАЗАМ! ТЫ ПОПАЛ!!!");
            }


            else if (RR <= 4 && RR > 1)
            {

                pp = 3;
                Console.WriteLine("Я НЕ ВЕРЮ СВОИМ ГЛАЗАМ! ТЫ ПОПАЛ!!!");
            }

            else if (RR <= 1 && RR >= 0)
            {

                pp = 4;
                Console.WriteLine("Я НЕ ВЕРЮ СВОИМ ГЛАЗАМ! ТЫ ПОПАЛ!!!");
            }
            else
            {
                Console.WriteLine("ЛОХ! Не попал.");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Ты попал в точку : (" + xx + ";" + yy + ")");


            Console.WriteLine("Колличество набранных очков : " + pp);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Всё. Приготовься. Последняя попытка. Бахай...");
            Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("             000\n            0  00\n           0    00\n          0      00\n         0        00                                                 _\n        0          00                                               I I\n       0            00                                              I I\n      0              00                                             I I\n     0                00                                            I I\n    0ЖЖЖ--------------00--->                                        I I\n     0                00                                            I I\n      0              00                                             I I\n       0            00                                              I I\n        0          00                                               I_I\n         0        00\n          0      00\n           0    00\n            0  00\n             000");
            Console.WriteLine();
            Console.WriteLine();
            Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("          00\n          000\n          0 00\n          0  00\n          0   00                                               _\n          0    00                                             I I\n          0     00                                            I I\n          0      00                                           I I\n          0       00                                          I I\n          0       00                          ЖЖЖ-------------I I------->\n          0       00                                          I I\n          0      00                                           I I\n          0     00                                            I I\n          0    00                                             I_I\n          0   00\n          0  00\n          0 00\n          000\n          00");
            Console.WriteLine();
            Console.WriteLine();
            int ppp = 0;
            int xxx = rnd.Next(-4, 4);
            int yyy = rnd.Next(-4, 4);

            double RRR = (xxx * xxx + yyy * yyy);


            if (RRR <= 16 && RRR > 9)
            {
                ppp = 1;
                Console.WriteLine("ПОПАДАНИЕ!!!");

            }
            else if (RRR <= 9 && RRR > 4)
            {
                ppp = 2;
                Console.WriteLine("ПОПАДАНИЕ!!!");
            }


            else if (RRR <= 4 && RRR > 1)
            {

                ppp = 3;
                Console.WriteLine("ПОПАДАНИЕ!!!");
            }

            else if (RRR <= 1 && RRR >= 0)
            {

                ppp = 4;
                Console.WriteLine("ПОПАДАНИЕ!!!");
            }
            else
            {
                Console.WriteLine("ЛОХ! Не попал.");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Ты попал в точку : (" + xxx + ";" + yyy + ")");


            Console.WriteLine("Колличество набранных очков : " + ppp);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("УУУУУААААА. Ты просто убийца. Хуууух. Ладно...пора подвести итоги. Вот, смотри: ");
            Console.ReadLine();
            Console.WriteLine("Выстрел     №1     №2     №3\nОчки         " + p + "      " + pp + "      " + ppp + "\nИтого   " + (p + pp + ppp));
            Console.ReadLine();

        }
    }
}

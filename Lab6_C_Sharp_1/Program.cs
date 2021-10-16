using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using info_motor;
using info_obchee;
using info_korobka;
using info_koleso;
using info_voditel;
using info_avto;

namespace ConsoleApp1
{
    class Program
    {


        static void Main(string[] args)
        {
			Console.Clear();
			Motor Motorishe = new Motor();
			Obchee Obchie = new Obchee();
			Voditel Vod = new Voditel();
			Koleso Kolesiko = new Koleso();
			Korobka Korobas = new Korobka();
			Avto Avt = new Avto();
			int podmenu, glmenu;
			int menu;
			do
			{
				Console.Clear();
				podmenu = 0;
				Console.WriteLine("1) Общее\n2) Двигатель\n3) Коробка\n4) Колеса\n5) Автомобиль\n6) Водитель\n7) Создание нескольких автомобилей с увеличенным диаметром колес\n\nESC - выход");
				glmenu = Console.ReadKey().KeyChar;
				//Console.ReadKey(true);			ожидание нажатия
				if (glmenu == '1')
				{
					do
					{
						Console.Clear();
						Console.WriteLine("1) Добавление общей информации\n2) Просмотр общей информации\n3) Изменение названия\n\nESC - Возврат в меню");
						podmenu = Console.ReadKey().KeyChar;
						Console.Clear();
						if (podmenu == '1')
						{
							do
							{
								Console.Clear();
								Console.WriteLine("1) Ввод собственных данных об общем\n2) Создание по конструктору");
								menu = Console.ReadKey().KeyChar;
							} while (menu != '1' && menu != '2');

							Console.Clear();
							if (menu == '1')
							{
								Obchie.new_obchee_info();
								Console.Clear();
							}
							else
							{
								Obchie.new_obchee(1500, 65, 7, 5, "Subaru", "Бензин", "4WD");
							}
							Obchie.prosmotr_obchee();
							Console.Write("\n\nОбщая информация успешно добавлена.");
						}
						else if (podmenu == '2')
						{
							Obchie.prosmotr_obchee();
						}
						else if (podmenu == '3')
						{
							Obchie.obchee_name();
						}
						if (podmenu > '0' && podmenu < '4')
						{
							Console.WriteLine("\n\nНажмите любую клавишу для возврата в меню.");
							Console.ReadKey(true);
						}
					} while (podmenu != 27);
				}
				else if (glmenu == '2')
				{
					do
					{
						Console.Clear();
						Console.WriteLine("1) Добавление информации о двигателе\n2) Просмотр информации о двигателе\n3) Увеличение мощности\n\nESC - Возврат в меню");
						podmenu = Console.ReadKey().KeyChar;
						if (podmenu == '1')
						{
							do
							{
								Console.Clear();
								Console.WriteLine("1) Ввод собственных данных о двигателе\n2) Создание по конструктору");
								menu = Console.ReadKey().KeyChar;
							} while (menu != '1' && menu != '2');
							Console.Clear();
							if (menu == '1')
							{
								Motorishe.New_Motor_Info();
							}
							else
							{
								Motorishe.new_motor("stok", 150, 2, 4, 10, 4);
							}
							Console.Clear();
							Motorishe.prosmotr_motor();
							Console.Write("\n\nИнформацияо двигателе успешно добавлена.");
						}
						else if (podmenu == '2')
						{
							Console.Clear();
							Motorishe.prosmotr_motor();
						}
						else if (podmenu == '3')
						{
							Console.Clear();
							Motorishe.force_motor();
						}
						if (podmenu > '0' && podmenu < '4')
						{
							Console.WriteLine("\n\nНажмите любую клавишу для возврата в меню.");
							Console.ReadKey(true);
						}
					} while (podmenu != 27);
				}
				
				else if (glmenu == '3')
				{
					do
					{
						Console.Clear();
						Console.WriteLine("1) Добавление информации о коробке\n2) Просмотр информации о коробке\n3) Изменение количества передач\n\nESC - Возврат в меню");
						podmenu = Console.ReadKey().KeyChar;
						if (podmenu == '1')
						{
							do
							{
								Console.Clear();
								Console.WriteLine("1) Ввод собственных данных о коробке\n2) Создание по конструктору");
								menu = Console.ReadKey().KeyChar;
							} while (menu != '1' && menu != '2');
							Console.Clear();
							if (menu == '1')
							{
								Korobas.new_korobka_info();
							}
							else
							{
								Korobas.korobka_new("АКПП", 6);
							}
							Console.Clear();
							Korobas.prosmotr_korobka();
							Console.WriteLine("\n\nИнформация о коробке передач успешно добавлена");
						}
						else if (podmenu == '2')
						{
							Console.Clear();
							Korobas.prosmotr_korobka();
						}
						else if (podmenu == '3')
						{
							Console.Clear();
							Korobas.korobka_peredch_red();
						}
						if (podmenu > '0' && podmenu < '4')
						{
							Console.WriteLine("\n\nНажмите любую клавишу для возврата в меню.");
							Console.ReadKey(true);
						}
					} while (podmenu != 27);
				}
				else if (glmenu == '4')
				{
					do
					{
						Console.Clear();
						Console.WriteLine("1) Добавление информации о колесах\n2) Просмотр информации о колесах\n3) Изменение диаметра колеса\n\nESC - Возврат в меню");
						podmenu = Console.ReadKey().KeyChar;
						if (podmenu == '1')
						{
							do
							{
								Console.Clear();
								Console.WriteLine("1) Ввод собственных данных о колесах\n2) Создание по конструктору");
								menu = Console.ReadKey().KeyChar;
							} while (menu != '1' && menu != '2');
							Console.Clear();
							if (menu == '1')
							{
								Kolesiko.new_koleso_info();
							}
							else
							{
								Kolesiko.new_koleso(225, 55, 17, "Литье");
							}
							Console.Clear();
							Kolesiko.prosmotr_koleso();
							Console.WriteLine("Информация о колесах успешно добавлена");
						}
						else if (podmenu == '2')
						{
							Console.Clear();
							Kolesiko.prosmotr_koleso();
						}
						else if (podmenu == '3')
						{
							Console.Clear();
							Kolesiko.koleso_diametr();
						}
						if (podmenu > '0' && podmenu < '4')
						{
							Console.WriteLine("\n\nНажмите любую клавишу для возврата в меню.");
							Console.ReadKey(true);
						}
					} while (podmenu != 27);
				}
				else if (glmenu == '5')
				{
					do
					{
						Console.Clear();
						Console.Write("1) Сборка автомобиля из существующих компонентов\n2) Просмотр информации об автомобиле\n3) Привязка/отвязка водителя\n\nESC - выход в меню");
						podmenu = Console.ReadKey().KeyChar;
						Console.Clear();
						if (podmenu == '1')
						{
							Avt.new_avto(Motorishe, Obchie, Korobas, Kolesiko);
							if (Avt.avto_get() == 1)
							{
								Console.WriteLine("Автомобиль успешно собран");
							}
							else
							{
								Console.WriteLine("Автомобиль не был собран");
							}
						}
						else if (podmenu == '2')
						{
							Avt.prosmotr_avto();
						}
						else if (podmenu == '3')
						{
							do
							{
								Console.Clear();
								Console.Write("1) Привязать водителя к автомобилю\n2) Отвязать водителя от автомобиля\n\nESC - выход");
								menu = Console.ReadKey().KeyChar;
								if (menu == '1')
								{
									Console.Clear();
									Avt.avto_priv(Vod);
								}
								else if (menu == '2')
								{
									Console.Clear();
									Avt.avto_otv();
								}
							} while (menu != '1' && menu != '2');
						}
						if (podmenu > '0' && podmenu < '4')
						{
							Console.WriteLine("\n\nНажмите любую клавишу для возврата в меню.");
							Console.ReadKey(true);
						}
					} while (podmenu != 27);
				}
				else if (glmenu == '6')
				{
					do
					{
						Console.Clear();
						Console.Write("1) Добавление информации о водителе\n2) Просмотр информации о водителе\n3) Изменение состояния у водителя\n\nESC - Возврат в меню");
						podmenu = Console.ReadKey().KeyChar;
						if (podmenu == '1')
						{
							do
							{
								Console.Clear();
								Console.Write("\n1) Ввод собственных данных о водителе\n2) Создание по конструктору");
								menu = Console.ReadKey().KeyChar;
							} while (menu != '1' && menu != '2');
							Console.Clear();
							if (menu == '1')
							{
								Vod.new_voditel_info();
							}
							else
							{
								Vod.new_voditel("Иванов И.И.", 26, "М", 3, "Переболел");
							}
							Console.Clear();
							Vod.prosmotr_voditel();
							Console.WriteLine("Информация о водителе успешно добавлена");
						}
						else if (podmenu == '2')
						{
							Console.Clear();
							Vod.prosmotr_voditel();
						}
						else if (podmenu == '3')
						{
							Console.Clear();
							Vod.voditel_covid();
						}
						if (podmenu > '0' && podmenu < '4')
						{
							Console.WriteLine("\n\nНажмите любую клавишу для возврата в меню.");
							Console.ReadKey(true);
						}
					} while (podmenu != 27);
				}
				else if (glmenu == '7')
				{
					if (Motorishe.motor_get() == 1 && Kolesiko.koleso_get() == 1 && Korobas.korobka_get() == 1 && Obchie.obchee_get() == 1)
					{
						Console.Clear();
						int n = 0, i;
						double temp, hag;
						List<Avto> results = new List<Avto>();      //создание динамического массива
						Console.Write("Введите количество автомобилей для создания: ");
						do
						{
							n = Convert.ToInt32(Console.ReadLine());
							if (n <= 0)
							{
								Console.Write("Неверно введено количество, попробуйте еще: ");
							}
						} while (n <= 0);

						Console.Write("Введите шаг увеличения диаметра колеса: ");
						do
						{
							hag = Convert.ToDouble(Console.ReadLine());
							if (hag < 0)
							{
								Console.Write("Неверно введен шаг изменения диаметра колеса. Повторите ввод: ");
							}
						} while (hag < 0);

						temp = Kolesiko.diametr;


						Avt.new_avto(Motorishe, Obchie, Korobas, Kolesiko);
						results.Add(Avt);
						if (results[0].avto_get() == 1)
						{
							for (i = 1; i <= n; i++)
							{
								Console.WriteLine("\nАвто №" + i);
								results[i - 1].prosmotr_avto();
								Kolesiko.diametr = temp + hag * i;
								Avt.new_avto(Motorishe, Obchie, Korobas, Kolesiko);
								results.Add(Avt);
							}
						}
						
						Kolesiko.diametr = temp;
						Avt.new_avto(Motorishe, Obchie, Korobas, Kolesiko);
					}
					else 
					{
						Console.Clear();
						Console.WriteLine("Создание нескольких автомобилей невозможно из-за отсутствия информации о всех комплектующих.");
					}
					Console.WriteLine("\n\nНажите любую клавишу для возврата в меню");
					Console.ReadKey(true);
				}

			} while (glmenu != 27);
					
        }
    }
}

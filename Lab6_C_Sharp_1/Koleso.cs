﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace info_koleso
{
    class Koleso
    {
        public double visota = -1;
        public double shirina = -1;
        public double diametr = -1;
        public string tip_diska = "";

        public void new_koleso_info()
        {
			Console.WriteLine("Добавление информации о колесах автомобиля\n\nВведите ширину колеса: ");

			do
			{
				shirina = Convert.ToDouble(Console.ReadLine());
				if (shirina < 0)
				{
					Console.WriteLine("Неверно введено значение ширины колеса, попробуйте еще: ");
				}
			} while (shirina < 0);
			
			
			Console.WriteLine("Введите высоту колеса: ");
			do
			{
				visota = Convert.ToDouble(Console.ReadLine());
				if (visota < 0)
				{
					Console.WriteLine("Неверно введено значение высоты колеса, попробуйте еще: ");
				}
			} while (visota < 0);

			Console.WriteLine("Введите диаметр колеса в дюймах: ");
			do
			{
				diametr = Convert.ToDouble(Console.ReadLine());
				if (diametr < 0)
				{
					Console.WriteLine("Неверно введено значение диаметра колеса, попробуйте еще: ");
				}
			} while (diametr < 0);


			Console.WriteLine("Введите тип колесного диска (штамповка/литье/ковка): ");
			do
			{
				tip_diska = Console.ReadLine();
                if (tip_diska == "") 
				{
					Console.WriteLine("Неверно введен тип колесного диска, попробуйте еще: ");
				}
            } while (tip_diska == "");
		}

		public void new_koleso(double visota, double shirina, double diametr, string tip_diska)
		{
			this.tip_diska = tip_diska;
			this.shirina = shirina;
			this.visota = visota;
			this.diametr = diametr;
		}

		public void prosmotr_koleso()
        {
			if (visota >= 0)
			{
				Console.WriteLine("\n\nИНФОРМАЦИЯ О КОЛЕСАХ\nШирина колеса: " + shirina);
				Console.WriteLine("\nДиаметр колеса: " + diametr);
				Console.WriteLine("\nВысота колеса: " + visota);
				Console.WriteLine("\nТип диска: " + tip_diska);
			}
			else
			{
				Console.WriteLine("Информация о колесе еще не была добавлена");
			}
		}

		public void koleso_diametr()
		{
			if (visota >= 0)
			{
				Console.WriteLine("Введите новый диаметр колеса: ");
				do
				{
					if (diametr < 0)
					{
						Console.WriteLine("Неверно введено значение диаметра, попробуйте еще: ");
					}
				} while (diametr < 0);
			}
			else
			{
				Console.WriteLine("Информация о колесе еще не была добавлена");
			}

		}

	}
}

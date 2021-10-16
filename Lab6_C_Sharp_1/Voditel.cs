using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace info_voditel
{
    class Voditel
    {
        public string name = "";
        public double age = -1;
        public double stag = -1;
        public string pol = "";
        public string covid_19 = "";

        public void new_voditel_info()
        {
			Console.Write("Введите ФИО водителя : ");
			do
			{
				name = Console.ReadLine();
				if (name == "")
				{
					Console.Write("Неверно введен ФИО водителя, попробуйте еще: ");
				}
			} while (name == "");
			
			Console.Write("Введите возраст: ");
			do
			{
				age = Convert.ToDouble(Console.ReadLine());
				if (age < 0)
				{
					Console.Write("Неверно введен возраст водителя, попробуйте еще: ");
				}
			} while (age < 0);

			Console.Write("Введите пол водителя (М/Ж): ");
			do
			{
				pol = Console.ReadLine();
				if (pol == "")
                {
					Console.Write("Неверно введен пол водителя, попробуйте еще: ");
				}
			} while (pol == "");
			
			Console.Write("Введите статус Covid-19 (переболел/привит/неизвестно): ");
			do
			{
				covid_19 = Console.ReadLine();
				if (covid_19 == "")
				{
					Console.Write("Неверно введен статус COVID-19, попробуйте еще: ");
				}
			} while (covid_19 == "");
			
			Console.Write("Введите стаж водителя: ");
			do
			{
				stag = Convert.ToDouble(Console.ReadLine());
				if (stag < 0)
				{
					Console.Write("Неверно введен стаж водителя, попробуйте еще: ");
				}
			} while (stag < 0);
		}

		public void new_voditel(string name, double age, string pol, double stag, string covid_19)
		{
			this.name = name;
			this.pol = pol;
			this.stag = stag;
			this.covid_19 = covid_19;
			this.age = age;
		}

        public void prosmotr_voditel()
        {
            if (age >= 0)
            {
                Console.Write("\n\nИНФОРМАЦИЯ О ВОДИТЕЛЕ" + "\nФИО: " + name + "\nВозраст: " + age + "\nПол: " + pol + "\nСтатус Covid-19: " + covid_19 + "\nСтаж: " + stag + "\n***************************************\n\n");
            }
            else
            {
                Console.WriteLine("Информация о водителе отсутствует");
            }
        }

		public void voditel_covid()
		{
			if (age >= 0)
			{
				Console.Write("Введите новое состояние Covid-19 у водителя: ");
				do
				{
					covid_19 = Console.ReadLine();
					if (covid_19 == "")
					{
						Console.Write("Неверно введено состояние COVID-19 у водителя, попробуйте еще: ");
					}
					Console.WriteLine("Состояние водителя обновлено");
				} while (covid_19 == "");
			}
			else
			{
				Console.WriteLine("Информация о водителе отсутствует");
			}
		}

		public Int32 voditel_get()
        {
			if (age > 0)
            {
				return 1;
            }
            else
            {
				return 0;
            }
        }

    }

    
}

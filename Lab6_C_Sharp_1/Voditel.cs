using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_C_Sharp_1
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
			Console.WriteLine("Введите ФИО водителя : ");
			do
			{
				name = Console.ReadLine();
				if (name == "")
				{
					Console.WriteLine("Неверно введен ФИО водителя, попробуйте еще: ");
				}
			} while (name == "");
			
			Console.WriteLine("Введите возраст: ");
			do
			{
				age = Convert.ToDouble(Console.ReadLine());
				if (age < 0)
				{
					Console.WriteLine("Неверно введен возраст водителя, попробуйте еще: ");
				}
			} while (age < 0);

			Console.WriteLine("Введите пол водителя (М/Ж): ");
			do
			{
				pol = Console.ReadLine();
				if (pol == "")
                {
					Console.WriteLine("Неверно введен пол водителя, попробуйте еще: ");
				}
			} while (pol == "");
			
			Console.WriteLine("Введите статус Covid-19 (переболел/привит/неизвестно): ");
			do
			{
				covid_19 = Console.ReadLine();
				if (covid_19 == "")
				{
					Console.WriteLine("Неверно введен статус COVID-19, попробуйте еще: ");
				}
			} while (covid_19 == "");
			
			Console.WriteLine("Введите стаж водителя: ");
			do
			{
				stag = Convert.ToDouble(Console.ReadLine());
				if (stag < 0)
				{
					Console.WriteLine("Неверно введен стаж водителя, попробуйте еще: ");
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
                Console.WriteLine("\n\nИНФОРМАЦИЯ О ВОДИТЕЛЕ");
                Console.WriteLine("\nФИО: " + name);
                Console.WriteLine("\nВозраст: " + age);
                Console.WriteLine("\nПол: " + pol);
                Console.WriteLine("\nСтатус Covid-19: " + covid_19);
                Console.WriteLine("\nСтаж: " + stag + "\n***************************************\n\n");
            }
            else
            {
                Console.WriteLine("Информация о водителе отсутствует");
            }
        }

    }

    
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace info_obchee
{
    class Obchee
    {
        public string name = "";
        public string tip_privoda = "";
        public string tip_topliva = "";
        public double massa = -1;
        public double obem_benzobaka = -1;
        public double kolvo_mest = -1;
        public double razgon_do_100 = -1;

        public void new_obchee_info()
        {
			Console.Write("Добавление общей информации об автомобиле\n\nВведите модель автомобиля: ");

			do
			{
				name = Console.ReadLine();
				if (name == "")
				{
					Console.WriteLine("Неверно введена модель автомобиля, попробуйте еще: ");
				}
			} while (name == "");

			Console.Write("Введите тип привода (2WD/4WD): ");
			do
			{

				tip_privoda = Console.ReadLine();
				if (tip_privoda == "")
				{
					Console.WriteLine("Неверно введен тип привода, попробуйте еще: ");
				}
			} while (tip_privoda == "");

			Console.Write("Введите тип топлива (бензин/дизель/электро): ");
			do
			{
				tip_topliva = Console.ReadLine();
				if (tip_topliva == "")
                {
					Console.WriteLine("Неверно введен тип топлива, попробуйте еще: ");
				}
			} while (tip_topliva == "");

			Console.Write("Введите количество посадочных мест: ");

			do
			{
				kolvo_mest = Convert.ToDouble(Console.ReadLine());
				if (kolvo_mest < 0)
                {
					Console.WriteLine("Неверно введенно значение количества посадочных мест, попробуйте еще: ");
				}
			} while (kolvo_mest < 0);

			Console.Write("Введите время разгона до 100км/ч: ");
			do
			{
				razgon_do_100 = Convert.ToDouble(Console.ReadLine());
				if (razgon_do_100 < 0)
				{ Console.WriteLine("Неверно введенно значение разгона до 100км/ч, попробуйте еще: "); }
			} while (razgon_do_100 < 0);

			Console.Write("Введите массу автомобиля: ");
			do
			{
				massa = Convert.ToDouble(Console.ReadLine());
				if (massa < 0)
                {
					Console.WriteLine("Неверно введенно значение массы, попробуйте еще: ");
				}
			} while (massa < 0);

			Console.Write("Введите объем бензобака в литрах: ");
			do
			{
				obem_benzobaka = Convert.ToDouble(Console.ReadLine());
				if (obem_benzobaka < 0)
                {
					Console.WriteLine("Неверно введенно значение объема бензобака, попробуйте еще: ");
				}
			} while (obem_benzobaka < 0);
			
		}

		public void new_obchee(double massa, double obem_benzobaka, double razgon_do_100, double kolvo_mest, string name, string tip_topliva, string tip_privoda)
        {
			this.obem_benzobaka = obem_benzobaka;
			this.name = name;
			this.massa = massa;
			this.kolvo_mest = kolvo_mest;
			this.razgon_do_100 = razgon_do_100;
			this.tip_privoda = tip_privoda;
			this.tip_topliva = tip_topliva;
        }

		public void prosmotr_obchee()
		{
			if (obem_benzobaka >= 0)
			{
				Console.Write("ОБЩАЯ ИНФОРМАЦИЯ:\n\nМодель: " + name + "\nТип привода: " + tip_privoda + "\nТип топлива: " + tip_topliva + "\nКоличество посадочных мест: " + kolvo_mest + "\nВремя разгона до 100км/ч: " + razgon_do_100 + "\nОбъем бензобака: " + obem_benzobaka + "\nМасса: " + massa);
			}
			else
			{
				Console.Write("Общая информация отсутствует.");
			}
		}

		public void obchee_name()
        {
			if (obem_benzobaka >= 0)
			{
				Console.Write("Введите новое название модели: ");
				do
				{
					name = Console.ReadLine();
					if (name == "")
					{ 
						Console.Write("Неверно введена модель автомобиля, попробуйте еще: "); 
					}
				} while (name == "");
				Console.Write("Модель автомобиля успешно изменена.");
			}
			else
			{
				Console.WriteLine("Общая информация не найдена.\n\nНажмите любую клавишу для возврата в основное меню.");
				Console.ReadKey(true);
			}
		}

		public Int32 obchee_get()
        {
			if (this.massa >= 0)
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

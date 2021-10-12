using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace info_motor
{
	class Motor
	{
		public string name = "";
		public double koni = -1;
		public double rab_obem = -1;
		public double rasxod = -1;
		public double kol_vo_cilindr = -1;
		public double klapan = -1;


		public void New_Motor_Info()
		{
			Console.WriteLine("Введите маркировку двигателя: ");
			do
			{
				name = Console.ReadLine();
				if (name.Length == 0)
				{
					Console.WriteLine("Неверно введена маркировка двигателя, попробуйте еще: ");
				}
			} while (name.Length == 0);

			Console.WriteLine("Введите рабочий объем двигателя в литрах: ");
			do
			{
				rab_obem = Convert.ToDouble(Console.ReadLine());
				if (rab_obem < 0)
				{
					Console.WriteLine("Неверно введено значение объема двигателя, попробуйте еще: ");
				}
			} while (rab_obem < 0);

			Console.WriteLine("Введите количество лошадинных сил: ");
			do
			{
				koni = Convert.ToDouble(Console.ReadLine());
				if (koni < 0)
				{
					Console.WriteLine("Неверно введено значение количества лошадиных сил, попробуйте еще: ");
				}
			} while (koni < 0);

			Console.WriteLine("Введите средний расход топлива на 100км в литрах: ");
			do
			{
				rasxod = Convert.ToDouble(Console.ReadLine());
				if (rasxod < 0)
				{
					Console.WriteLine("Неверно введено значение расхода на 100км, попробуйте еще: ");
				}
			} while (rasxod < 0);


			Console.WriteLine("Введите количество цилиндров: ");
			do
			{
				kol_vo_cilindr = Convert.ToDouble(Console.ReadLine());
				if (kol_vo_cilindr < 0)
				{
					Console.WriteLine("Неверно введено значение количества цилиндров, попробуйте еще: ");
				}
			} while (kol_vo_cilindr < 0);

			Console.WriteLine("Введите количество клапанов на один цилиндр: ");
			do
			{
				klapan = Convert.ToDouble(Console.ReadLine());
				if (klapan < 0)
				{
					Console.WriteLine("Неверно введено значение количества клапанов, попробуйте еще: ");
				}
			} while (klapan < 0);
		}

		public void prosmotr_motor()
		{
			if (koni < 0)
			{
				Console.WriteLine("\n\nИНФОРАЦИЯ О ДВИГАТЕЛЕ:\nМаркировка двигателя: " + name);
				Console.WriteLine("\nРабочий объем: " + rab_obem);
				Console.WriteLine("\nМощность (л.с.): " + koni);
				Console.WriteLine("\nСредний расход на 100км: " + rasxod);
				Console.WriteLine("\nКоличество цилиндров: " + kol_vo_cilindr);
				Console.WriteLine("\nКоличество клапанов на 1 цилиндр: " + klapan);
			}
			else
			{
				Console.WriteLine("Информация о двигателе отсутствует");
			}
		}

		public void new_motor(string name, double koni, double rab_obem, double klapan, double rasxod, double kol_vo_cilindr)
		{
			this.koni = koni;
			this.kol_vo_cilindr = kol_vo_cilindr;
			this.name = name;
			this.rab_obem = rab_obem;
			this.rasxod = rasxod;
			this.klapan = klapan;
		}

		public void force_motor()
		{
			if (koni >= 0)
			{
				double koni1 = -1;
				Console.WriteLine("Введите новое количество лошадиных сил.");
				do
				{
					koni = Convert.ToDouble(Console.ReadLine());
				} while (koni1 < 0);
				this.koni = koni1;
            }
			else
			{
				Console.WriteLine("Информация о двигателе отсутствует");
			}
		}

	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace info_korobka
{
    class Korobka
    {
		public double kolvo_peredach = -1;
		public string tip_korobki = "";


		public void new_korobka_info()
        {
			Console.WriteLine("Добавление информации о коробке передач автомобиля\n\nВведите тип коробки передач (АКПП/МКПП): ");
			do
			{
				tip_korobki = Console.ReadLine();
				if (tip_korobki == "")
				{
					Console.WriteLine("Неверно введена модель автомобиля, попробуйте еще: ");
				}
			} while (tip_korobki == "");

			Console.WriteLine("Введите количество передач коробки: ");
			do
			{
				kolvo_peredach = Convert.ToDouble(Console.ReadLine());
				if (kolvo_peredach < 0)
				{
					Console.WriteLine("Неверно введено значение количества передач, попробуйте еще: ");
				}
			} while (kolvo_peredach < 0);
		}

		public void korobka_new(string tip_korobki, double kolvo_peredach)
        {
			this.kolvo_peredach = kolvo_peredach;
			this.tip_korobki = tip_korobki;
        }

		public void prosmotr_korobka()
        {
			if (kolvo_peredach >= 0)
			{
				Console.WriteLine("\n\nИНФОРМАЦИЯ О КОРОБКЕ ПЕРЕКЛЮЧЕНИЯ ПЕРЕДАЧ\nТип коробки переключения передач: " + tip_korobki);
				Console.WriteLine("\nКоличество передач коробки: " + kolvo_peredach);
			}
			else
			{
				Console.WriteLine("Информации о коробках передач отсутствует");
			}
		}

		public void korobka_peredch_red()
        {
			if (kolvo_peredach >= 0)
			{
				Console.WriteLine("Введите количество передач: ");
				do
				{
					kolvo_peredach = Convert.ToDouble(Console.ReadLine());
					if (kolvo_peredach < 0)
					{
						Console.WriteLine("Неверно введено значение количества передач, попробуйте еще: "); 
					}
				} while (kolvo_peredach < 0);
			}
			else
			{
				Console.WriteLine("Информации о коробках передач отсутствует");
			}
		}
    }
}

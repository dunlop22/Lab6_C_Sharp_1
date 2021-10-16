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

namespace info_avto
{
    class Avto
    {
        
        Motor Motorishe = new Motor();
        Obchee Obchie = new Obchee();
        Korobka Korobas = new Korobka();
        Koleso Kolesiki = new Koleso();
        Voditel Vod = new Voditel();

        //создание автомобиля на основании создданных агрегатов
        public void new_avto(Motor Motorishe1, Obchee Obchie1, Korobka Korobas1, Koleso Kolesiki1)
        {
            if (Motorishe1.motor_get() == 1 && Kolesiki1.koleso_get() == 1 && Korobas1.korobka_get() == 1 && Obchie1.obchee_get() == 1)
            {
                this.Motorishe = Motorishe1;
                this.Korobas = Korobas1;
                this.Kolesiki = Kolesiki1;
                this.Obchie = Obchie1;
                
            }
            else
            {
                Console.Write("Сборка автомобиля невозможна из-за отсутствия информации об агрегатах");
            }
        }

        //просмотр информации об автомобиле
        public void prosmotr_avto()
        {
            if (this.Motorishe.motor_get() == 1)
            {
                this.Motorishe.prosmotr_motor();
                Console.WriteLine("\n");
                this.Korobas.prosmotr_korobka();
                Console.WriteLine("\n");
                this.Kolesiki.prosmotr_koleso();
                Console.WriteLine("\n");
                this.Obchie.prosmotr_obchee();
                Console.WriteLine("\n");
                if (this.Vod.voditel_get() == 1)
                {
                    this.Vod.prosmotr_voditel();
                }
            }
            else
            {
                Console.WriteLine("Информация об автомобиле не найдена");
            }
        }
        public Int32 avto_get()
        {
            if (this.Motorishe.motor_get() == 1)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        //привязка водителя к автомобилю
        public void avto_priv(Voditel vod1)
        {
            if (this.avto_get() == 1 && vod1.voditel_get() == 1)
            {
                this.Vod = vod1;
                if (this.Vod.voditel_get() == 1)
                {
                    Console.WriteLine("Водитель успешно привязан к автомобилю");
                }
            }
            else 
            {
                Console.WriteLine("Информация об автомобиле или водителе не найдена. Привязка невозможна.");
            }
        }
        
        //отвязка водителя от автомобиля
        public void avto_otv()
        {
            if (this.avto_get() == 1)
            {
                Voditel Vod1 = new Voditel();
                this.Vod = Vod1;
                Console.WriteLine("Водитель успешно отвязан от автомобиля");
            }
            else
            {
                Console.WriteLine("Информация об автомобиле не найдена. Отвязка невозможна.");
            }
            
        }
    }
}

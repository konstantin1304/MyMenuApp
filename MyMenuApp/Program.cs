using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMenuApp
{
    class Program
    {
        /// <summary>
        /// Флаг для выхода из меню
        /// </summary>
        private static bool cont = true;
        static void Main(string[] args)
        {
            MyMenu item = new MyMenu();
            item.Add("1", new MyItem("Новый документ", New));
            item.Add("2", new MyItem("Сохранить документ", Save));
            item.Add("3", new MyItem("Выход", Quit));
            item.ItemList();
            string itemKey;

            while(cont)
            {
                itemKey = Console.ReadLine();
                item.RunItem(itemKey);
            }
            
            Console.ReadLine();

        }

        public static void New()
        {
            Console.WriteLine("Создаем документ...");
        }
        public static void Save()
        {
            Console.WriteLine("Сохраняем документ...");
        }
        public static void Quit()
        {
            Console.WriteLine("Выходим...");
            cont = false;
        }
    }
}

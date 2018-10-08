using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMenuApp
{
    /// <summary>
    /// Представляет собой коллекцию MyItem-ов
    /// </summary>
    class MyMenu : Dictionary<string,MyItem>
    {
        /// <summary>
        /// Выводит коллекцию на экран
        /// </summary>
        public void ItemList()
        {
            foreach (var keyValuePair in this)
            {
                Console.WriteLine($"{keyValuePair.Key} {keyValuePair.Value}");
            }
        }
        /// <summary>
        /// Вызвать пункт меню по ключу
        /// </summary>
        /// <param name="Key">Ключ</param>
        public void RunItem(string Key)
        {
            this[Key].OnMenuItem();
        }

    }
}

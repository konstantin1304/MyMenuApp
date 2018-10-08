using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMenuApp
{
    class MyItem
    {
        /// <summary>
        /// Делегат описывающий сигнатуру метода, который используется в качестве события
        /// при вызове пункта меню
        /// </summary>
        public delegate void MyItemEventDelegate();
        /// <summary>
        /// Событие, которое возбуждается при вызове пункта меню
        /// </summary>
        private event MyItemEventDelegate itemEvent;
        /// <summary>
        /// Имя пункта меню
        /// </summary>
        public string ItemName { get; private set; }
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="itemName">Имя пункта меню</param>
        /// <param name="itemEvent">Делегат метода</param>
        public MyItem(string itemName, MyItemEventDelegate itemEvent)
        {
            ItemName = itemName;
            this.itemEvent += itemEvent; 
        }
        /// <summary>
        /// Метод, который возбуждает событие при вызове пункта меню
        /// </summary>
        public void OnMenuItem()
        {
            itemEvent();
        }
        /// <summary>
        /// Переопределяет ToString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return ItemName;
        }
    }
}

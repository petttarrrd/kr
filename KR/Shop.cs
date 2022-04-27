using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KR
{
    interface ISubjectObserverable
    {
        void Add(IpropertyObserver observer);
        void Remove(IpropertyObserver observer);
        void Notify();
    }
    internal class Shop: ISubjectObserverable
    {	
		
		private List<IpropertyObserver> _observers = new List<IpropertyObserver>();

		
		public void Add(IpropertyObserver observer)
		{
			Console.WriteLine("Пользователь добавлен");
			this._observers.Add(observer);
		}

		
		public void Remove(IpropertyObserver observer)
		{
			this._observers.Remove(observer);
			Console.WriteLine("Пользователь удалён");
		}
		
		public void Notify()
		{

			foreach (var observer in _observers)
			{
				observer.Masseg();
			}
		}

	}
}

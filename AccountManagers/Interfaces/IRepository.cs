using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManagers.Interfaces
{
	public interface IRepository<T>
	{
		IEnumerable<T> GetEntities();
		T SelectById(int id);
		void Insert(T obj);
	}
}

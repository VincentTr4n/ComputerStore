using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAOClassesLibrary
{
	public interface IDAO<T>
	{
		List<T> getList();
		System.Data.DataTable getTable();
		bool AddObject(T o);
		bool UpdateObject(T o);
		bool DeleteObject(string id);
		bool checkID(string id);
		T getObject(string id);
	}
}

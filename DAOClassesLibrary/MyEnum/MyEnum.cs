using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAOClassesLibrary
{
	public enum EnumShowProduct
	{
		ShowByType,
		ShowWithName,
		ShowAll,
		ShowReportQuantily
	}
	public enum EnumStateAction
	{
		Insert,
		Update,
		Delete,
		Cancel
	}
	public enum EnumPickDateTime
	{
		PickDays,
		PickMoth,
		PickYear
	}
	public enum EnumReportState
	{
		Price,
		Quantiy,
		ProductTypes,
		RevenueOfMonth,
		RevenueOfDays
	}
}

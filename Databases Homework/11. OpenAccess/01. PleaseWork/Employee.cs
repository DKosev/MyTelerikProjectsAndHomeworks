#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the ClassGenerator.ttinclude code generation file.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Data.Common;
using System.Collections.Generic;
using Telerik.OpenAccess;
using Telerik.OpenAccess.Metadata;
using Telerik.OpenAccess.Data.Common;
using Telerik.OpenAccess.Metadata.Fluent;
using Telerik.OpenAccess.Metadata.Fluent.Advanced;
using _01.PleaseWork;

namespace _01.PleaseWork	
{
	public partial class Employee
	{
		private int _employeeID;
		public virtual int EmployeeID
		{
			get
			{
				return this._employeeID;
			}
			set
			{
				this._employeeID = value;
			}
		}
		
		private string _employeeNumber;
		public virtual string EmployeeNumber
		{
			get
			{
				return this._employeeNumber;
			}
			set
			{
				this._employeeNumber = value;
			}
		}
		
		private string _firstName;
		public virtual string FirstName
		{
			get
			{
				return this._firstName;
			}
			set
			{
				this._firstName = value;
			}
		}
		
		private string _lastName;
		public virtual string LastName
		{
			get
			{
				return this._lastName;
			}
			set
			{
				this._lastName = value;
			}
		}
		
		private string _fullName;
		public virtual string FullName
		{
			get
			{
				return this._fullName;
			}
			set
			{
				this._fullName = value;
			}
		}
		
		private string _title;
		public virtual string Title
		{
			get
			{
				return this._title;
			}
			set
			{
				this._title = value;
			}
		}
		
		private decimal? _hourlySalary;
		public virtual decimal? HourlySalary
		{
			get
			{
				return this._hourlySalary;
			}
			set
			{
				this._hourlySalary = value;
			}
		}
		
		private IList<RentalOrder> _rentalOrders = new List<RentalOrder>();
		public virtual IList<RentalOrder> RentalOrders
		{
			get
			{
				return this._rentalOrders;
			}
		}
		
	}
}
#pragma warning restore 1591

﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AttendanceManager.Models
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="SubjectDatabase")]
	public partial class SubjectDataClassesDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertSubjectTable(SubjectTable instance);
    partial void UpdateSubjectTable(SubjectTable instance);
    partial void DeleteSubjectTable(SubjectTable instance);
    #endregion
		
		public SubjectDataClassesDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["SubjectDatabaseConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public SubjectDataClassesDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SubjectDataClassesDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SubjectDataClassesDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SubjectDataClassesDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<SubjectTable> SubjectTables
		{
			get
			{
				return this.GetTable<SubjectTable>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.SubjectTable")]
	public partial class SubjectTable : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Subject;
		
		private System.Nullable<int> _Total_lectures;
		
		private System.Nullable<double> _Required_attendance;
		
		private System.Nullable<int> _Attended_lectures;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnSubjectChanging(string value);
    partial void OnSubjectChanged();
    partial void OnTotal_lecturesChanging(System.Nullable<int> value);
    partial void OnTotal_lecturesChanged();
    partial void OnRequired_attendanceChanging(System.Nullable<double> value);
    partial void OnRequired_attendanceChanged();
    partial void OnAttended_lecturesChanging(System.Nullable<int> value);
    partial void OnAttended_lecturesChanged();
    #endregion
		
		public SubjectTable()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Subject", DbType="VarChar(50)")]
		public string Subject
		{
			get
			{
				return this._Subject;
			}
			set
			{
				if ((this._Subject != value))
				{
					this.OnSubjectChanging(value);
					this.SendPropertyChanging();
					this._Subject = value;
					this.SendPropertyChanged("Subject");
					this.OnSubjectChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Total_lectures", DbType="Int")]
		public System.Nullable<int> Total_lectures
		{
			get
			{
				return this._Total_lectures;
			}
			set
			{
				if ((this._Total_lectures != value))
				{
					this.OnTotal_lecturesChanging(value);
					this.SendPropertyChanging();
					this._Total_lectures = value;
					this.SendPropertyChanged("Total_lectures");
					this.OnTotal_lecturesChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Required_attendance", DbType="Float")]
		public System.Nullable<double> Required_attendance
		{
			get
			{
				return this._Required_attendance;
			}
			set
			{
				if ((this._Required_attendance != value))
				{
					this.OnRequired_attendanceChanging(value);
					this.SendPropertyChanging();
					this._Required_attendance = value;
					this.SendPropertyChanged("Required_attendance");
					this.OnRequired_attendanceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Attended_lectures", DbType="Int")]
		public System.Nullable<int> Attended_lectures
		{
			get
			{
				return this._Attended_lectures;
			}
			set
			{
				if ((this._Attended_lectures != value))
				{
					this.OnAttended_lecturesChanging(value);
					this.SendPropertyChanging();
					this._Attended_lectures = value;
					this.SendPropertyChanged("Attended_lectures");
					this.OnAttended_lecturesChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591

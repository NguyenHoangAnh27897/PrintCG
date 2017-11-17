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

namespace SGPWebService.DB
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="SGPAPI")]
	public partial class SGPAPIDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertPMS_MaxMailerID(PMS_MaxMailerID instance);
    partial void UpdatePMS_MaxMailerID(PMS_MaxMailerID instance);
    partial void DeletePMS_MaxMailerID(PMS_MaxMailerID instance);
    partial void InsertSGP_Province_Zone(SGP_Province_Zone instance);
    partial void UpdateSGP_Province_Zone(SGP_Province_Zone instance);
    partial void DeleteSGP_Province_Zone(SGP_Province_Zone instance);
    partial void InsertSGP_Price_Policy(SGP_Price_Policy instance);
    partial void UpdateSGP_Price_Policy(SGP_Price_Policy instance);
    partial void DeleteSGP_Price_Policy(SGP_Price_Policy instance);
    #endregion
		
		public SGPAPIDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["SGPAPIConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public SGPAPIDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SGPAPIDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SGPAPIDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SGPAPIDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<PMS_MaxMailerID> PMS_MaxMailerIDs
		{
			get
			{
				return this.GetTable<PMS_MaxMailerID>();
			}
		}
		
		public System.Data.Linq.Table<SGP_Province_Zone> SGP_Province_Zones
		{
			get
			{
				return this.GetTable<SGP_Province_Zone>();
			}
		}
		
		public System.Data.Linq.Table<SGP_Price_Policy> SGP_Price_Policies
		{
			get
			{
				return this.GetTable<SGP_Price_Policy>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.PMS_MaxMailerID")]
	public partial class PMS_MaxMailerID : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _PostOfficeID;
		
		private string _MaxID;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnPostOfficeIDChanging(string value);
    partial void OnPostOfficeIDChanged();
    partial void OnMaxIDChanging(string value);
    partial void OnMaxIDChanged();
    #endregion
		
		public PMS_MaxMailerID()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PostOfficeID", DbType="NVarChar(20) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string PostOfficeID
		{
			get
			{
				return this._PostOfficeID;
			}
			set
			{
				if ((this._PostOfficeID != value))
				{
					this.OnPostOfficeIDChanging(value);
					this.SendPropertyChanging();
					this._PostOfficeID = value;
					this.SendPropertyChanged("PostOfficeID");
					this.OnPostOfficeIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaxID", DbType="NVarChar(20)")]
		public string MaxID
		{
			get
			{
				return this._MaxID;
			}
			set
			{
				if ((this._MaxID != value))
				{
					this.OnMaxIDChanging(value);
					this.SendPropertyChanging();
					this._MaxID = value;
					this.SendPropertyChanged("MaxID");
					this.OnMaxIDChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.SGP_Province_Zones")]
	public partial class SGP_Province_Zone : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _ZoneID;
		
		private string _ProvinceID;
		
		private System.Nullable<int> _Zone;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnZoneIDChanging(string value);
    partial void OnZoneIDChanged();
    partial void OnProvinceIDChanging(string value);
    partial void OnProvinceIDChanged();
    partial void OnZoneChanging(System.Nullable<int> value);
    partial void OnZoneChanged();
    #endregion
		
		public SGP_Province_Zone()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ZoneID", DbType="NVarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string ZoneID
		{
			get
			{
				return this._ZoneID;
			}
			set
			{
				if ((this._ZoneID != value))
				{
					this.OnZoneIDChanging(value);
					this.SendPropertyChanging();
					this._ZoneID = value;
					this.SendPropertyChanged("ZoneID");
					this.OnZoneIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProvinceID", DbType="NVarChar(3) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string ProvinceID
		{
			get
			{
				return this._ProvinceID;
			}
			set
			{
				if ((this._ProvinceID != value))
				{
					this.OnProvinceIDChanging(value);
					this.SendPropertyChanging();
					this._ProvinceID = value;
					this.SendPropertyChanged("ProvinceID");
					this.OnProvinceIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Zone", DbType="Int")]
		public System.Nullable<int> Zone
		{
			get
			{
				return this._Zone;
			}
			set
			{
				if ((this._Zone != value))
				{
					this.OnZoneChanging(value);
					this.SendPropertyChanging();
					this._Zone = value;
					this.SendPropertyChanged("Zone");
					this.OnZoneChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.SGP_Price_Policy")]
	public partial class SGP_Price_Policy : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _PricePolicyID;
		
		private string _PostOfficeID;
		
		private string _Type;
		
		private System.Nullable<System.DateTime> _CreateDate;
		
		private System.Nullable<int> _Status;
		
		private System.Nullable<int> _Service;
		
		private string _Description;
		
		private string _ZoneID;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnPricePolicyIDChanging(string value);
    partial void OnPricePolicyIDChanged();
    partial void OnPostOfficeIDChanging(string value);
    partial void OnPostOfficeIDChanged();
    partial void OnTypeChanging(string value);
    partial void OnTypeChanged();
    partial void OnCreateDateChanging(System.Nullable<System.DateTime> value);
    partial void OnCreateDateChanged();
    partial void OnStatusChanging(System.Nullable<int> value);
    partial void OnStatusChanged();
    partial void OnServiceChanging(System.Nullable<int> value);
    partial void OnServiceChanged();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    partial void OnZoneIDChanging(string value);
    partial void OnZoneIDChanged();
    #endregion
		
		public SGP_Price_Policy()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PricePolicyID", DbType="NVarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string PricePolicyID
		{
			get
			{
				return this._PricePolicyID;
			}
			set
			{
				if ((this._PricePolicyID != value))
				{
					this.OnPricePolicyIDChanging(value);
					this.SendPropertyChanging();
					this._PricePolicyID = value;
					this.SendPropertyChanged("PricePolicyID");
					this.OnPricePolicyIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PostOfficeID", DbType="NVarChar(4)")]
		public string PostOfficeID
		{
			get
			{
				return this._PostOfficeID;
			}
			set
			{
				if ((this._PostOfficeID != value))
				{
					this.OnPostOfficeIDChanging(value);
					this.SendPropertyChanging();
					this._PostOfficeID = value;
					this.SendPropertyChanged("PostOfficeID");
					this.OnPostOfficeIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Type", DbType="NVarChar(1)")]
		public string Type
		{
			get
			{
				return this._Type;
			}
			set
			{
				if ((this._Type != value))
				{
					this.OnTypeChanging(value);
					this.SendPropertyChanging();
					this._Type = value;
					this.SendPropertyChanged("Type");
					this.OnTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CreateDate", DbType="Date")]
		public System.Nullable<System.DateTime> CreateDate
		{
			get
			{
				return this._CreateDate;
			}
			set
			{
				if ((this._CreateDate != value))
				{
					this.OnCreateDateChanging(value);
					this.SendPropertyChanging();
					this._CreateDate = value;
					this.SendPropertyChanged("CreateDate");
					this.OnCreateDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Status", DbType="Int")]
		public System.Nullable<int> Status
		{
			get
			{
				return this._Status;
			}
			set
			{
				if ((this._Status != value))
				{
					this.OnStatusChanging(value);
					this.SendPropertyChanging();
					this._Status = value;
					this.SendPropertyChanged("Status");
					this.OnStatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Service", DbType="Int")]
		public System.Nullable<int> Service
		{
			get
			{
				return this._Service;
			}
			set
			{
				if ((this._Service != value))
				{
					this.OnServiceChanging(value);
					this.SendPropertyChanging();
					this._Service = value;
					this.SendPropertyChanged("Service");
					this.OnServiceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="NVarChar(100)")]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._Description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ZoneID", DbType="NVarChar(10)")]
		public string ZoneID
		{
			get
			{
				return this._ZoneID;
			}
			set
			{
				if ((this._ZoneID != value))
				{
					this.OnZoneIDChanging(value);
					this.SendPropertyChanging();
					this._ZoneID = value;
					this.SendPropertyChanged("ZoneID");
					this.OnZoneIDChanged();
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

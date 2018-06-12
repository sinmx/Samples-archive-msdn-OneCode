﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CSASPNETEmailAddressValidator.Module
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="EmailValidationDB")]
	public partial class EmailAddressValidationDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InserttblEmailValidation(tblEmailValidation instance);
    partial void UpdatetblEmailValidation(tblEmailValidation instance);
    partial void DeletetblEmailValidation(tblEmailValidation instance);
    #endregion
		
		public EmailAddressValidationDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["EmailValidationDBConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public EmailAddressValidationDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public EmailAddressValidationDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public EmailAddressValidationDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public EmailAddressValidationDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<tblEmailValidation> tblEmailValidations
		{
			get
			{
				return this.GetTable<tblEmailValidation>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tblEmailValidation")]
	public partial class tblEmailValidation : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _EmailAddress;
		
		private bool _IsValidated;
		
		private bool _IsSendCheckEmail;
		
		private System.DateTime _ValidatingStartTime;
		
		private string _ValidateKey;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnEmailAddressChanging(string value);
    partial void OnEmailAddressChanged();
    partial void OnIsValidatedChanging(bool value);
    partial void OnIsValidatedChanged();
    partial void OnIsSendCheckEmailChanging(bool value);
    partial void OnIsSendCheckEmailChanged();
    partial void OnValidatingStartTimeChanging(System.DateTime value);
    partial void OnValidatingStartTimeChanged();
    partial void OnValidateKeyChanging(string value);
    partial void OnValidateKeyChanged();
    #endregion
		
		public tblEmailValidation()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmailAddress", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string EmailAddress
		{
			get
			{
				return this._EmailAddress;
			}
			set
			{
				if ((this._EmailAddress != value))
				{
					this.OnEmailAddressChanging(value);
					this.SendPropertyChanging();
					this._EmailAddress = value;
					this.SendPropertyChanged("EmailAddress");
					this.OnEmailAddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsValidated", DbType="Bit NOT NULL")]
		public bool IsValidated
		{
			get
			{
				return this._IsValidated;
			}
			set
			{
				if ((this._IsValidated != value))
				{
					this.OnIsValidatedChanging(value);
					this.SendPropertyChanging();
					this._IsValidated = value;
					this.SendPropertyChanged("IsValidated");
					this.OnIsValidatedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsSendCheckEmail", DbType="Bit NOT NULL")]
		public bool IsSendCheckEmail
		{
			get
			{
				return this._IsSendCheckEmail;
			}
			set
			{
				if ((this._IsSendCheckEmail != value))
				{
					this.OnIsSendCheckEmailChanging(value);
					this.SendPropertyChanging();
					this._IsSendCheckEmail = value;
					this.SendPropertyChanged("IsSendCheckEmail");
					this.OnIsSendCheckEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ValidatingStartTime", DbType="DateTime NOT NULL")]
		public System.DateTime ValidatingStartTime
		{
			get
			{
				return this._ValidatingStartTime;
			}
			set
			{
				if ((this._ValidatingStartTime != value))
				{
					this.OnValidatingStartTimeChanging(value);
					this.SendPropertyChanging();
					this._ValidatingStartTime = value;
					this.SendPropertyChanged("ValidatingStartTime");
					this.OnValidatingStartTimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ValidateKey", DbType="NVARChar(128) NOT NULL", CanBeNull=false)]
		public string ValidateKey
		{
			get
			{
				return this._ValidateKey;
			}
			set
			{
				if ((this._ValidateKey != value))
				{
					this.OnValidateKeyChanging(value);
					this.SendPropertyChanging();
					this._ValidateKey = value;
					this.SendPropertyChanged("ValidateKey");
					this.OnValidateKeyChanged();
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

// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4x3.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using Xbim.Common.Metadata;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4x3.DateTimeResource;
//## Custom using statements
//##


namespace Xbim.Ifc4x3.DateTimeResource
{
	[ExpressType("IfcRecurrencePattern", 1243)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcRecurrencePattern : PersistEntity, IInstantiableEntity, IContainsEntityReferences, IEquatable<@IfcRecurrencePattern>
	{

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcRecurrencePattern(IModel model, int label, bool activated) : base(model, label, activated)  
		{
			_dayComponent = new OptionalItemSet<IfcDayInMonthNumber>( this, 0,  2);
			_weekdayComponent = new OptionalItemSet<IfcDayInWeekNumber>( this, 0,  3);
			_monthComponent = new OptionalItemSet<IfcMonthInYearNumber>( this, 0,  4);
			_timePeriods = new OptionalItemSet<IfcTimePeriod>( this, 0,  8);
		}

		#region Explicit attribute fields
		private IfcRecurrenceTypeEnum _recurrenceType;
		private readonly OptionalItemSet<IfcDayInMonthNumber> _dayComponent;
		private readonly OptionalItemSet<IfcDayInWeekNumber> _weekdayComponent;
		private readonly OptionalItemSet<IfcMonthInYearNumber> _monthComponent;
		private IfcInteger? _position;
		private IfcInteger? _interval;
		private IfcInteger? _occurrences;
		private readonly OptionalItemSet<IfcTimePeriod> _timePeriods;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, null, null, 1)]
		public IfcRecurrenceTypeEnum @RecurrenceType 
		{ 
			get 
			{
				if(_activated) return _recurrenceType;
				Activate();
				return _recurrenceType;
			} 
			set
			{
				SetValue( v =>  _recurrenceType = v, _recurrenceType, value,  "RecurrenceType", 1);
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.Set, EntityAttributeType.None, new int [] { 1 }, new int [] { -1 }, 2)]
		public IOptionalItemSet<IfcDayInMonthNumber> @DayComponent 
		{ 
			get 
			{
				if(_activated) return _dayComponent;
				Activate();
				return _dayComponent;
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.Set, EntityAttributeType.None, new int [] { 1 }, new int [] { -1 }, 3)]
		public IOptionalItemSet<IfcDayInWeekNumber> @WeekdayComponent 
		{ 
			get 
			{
				if(_activated) return _weekdayComponent;
				Activate();
				return _weekdayComponent;
			} 
		}	
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.Set, EntityAttributeType.None, new int [] { 1 }, new int [] { -1 }, 4)]
		public IOptionalItemSet<IfcMonthInYearNumber> @MonthComponent 
		{ 
			get 
			{
				if(_activated) return _monthComponent;
				Activate();
				return _monthComponent;
			} 
		}	
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 5)]
		public IfcInteger? @Position 
		{ 
			get 
			{
				if(_activated) return _position;
				Activate();
				return _position;
			} 
			set
			{
				SetValue( v =>  _position = v, _position, value,  "Position", 5);
			} 
		}	
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 6)]
		public IfcInteger? @Interval 
		{ 
			get 
			{
				if(_activated) return _interval;
				Activate();
				return _interval;
			} 
			set
			{
				SetValue( v =>  _interval = v, _interval, value,  "Interval", 6);
			} 
		}	
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 7)]
		public IfcInteger? @Occurrences 
		{ 
			get 
			{
				if(_activated) return _occurrences;
				Activate();
				return _occurrences;
			} 
			set
			{
				SetValue( v =>  _occurrences = v, _occurrences, value,  "Occurrences", 7);
			} 
		}	
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.List, EntityAttributeType.Class, new int [] { 1 }, new int [] { -1 }, 8)]
		public IOptionalItemSet<IfcTimePeriod> @TimePeriods 
		{ 
			get 
			{
				if(_activated) return _timePeriods;
				Activate();
				return _timePeriods;
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
                    _recurrenceType = (IfcRecurrenceTypeEnum) System.Enum.Parse(typeof (IfcRecurrenceTypeEnum), value.EnumVal, true);
					return;
				case 1: 
					_dayComponent.InternalAdd(value.IntegerVal);
					return;
				case 2: 
					_weekdayComponent.InternalAdd(value.IntegerVal);
					return;
				case 3: 
					_monthComponent.InternalAdd(value.IntegerVal);
					return;
				case 4: 
					_position = value.IntegerVal;
					return;
				case 5: 
					_interval = value.IntegerVal;
					return;
				case 6: 
					_occurrences = value.IntegerVal;
					return;
				case 7: 
					_timePeriods.InternalAdd((IfcTimePeriod)value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcRecurrencePattern other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				foreach(var entity in @TimePeriods)
					yield return entity;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}
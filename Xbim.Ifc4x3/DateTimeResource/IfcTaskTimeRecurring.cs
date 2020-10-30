// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4x3.DateTimeResource;
//## Custom using statements
//##


namespace Xbim.Ifc4x3.DateTimeResource
{
	[ExpressType("IfcTaskTimeRecurring", 1295)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcTaskTimeRecurring : IfcTaskTime, IInstantiableEntity, IContainsEntityReferences, IEquatable<@IfcTaskTimeRecurring>
	{

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcTaskTimeRecurring(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcRecurrencePattern _recurrence;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(21, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, null, null, 21)]
		public IfcRecurrencePattern @Recurrence 
		{ 
			get 
			{
				if(_activated) return _recurrence;
				Activate();
				return _recurrence;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _recurrence = v, _recurrence, value,  "Recurrence", 21);
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
				case 1: 
				case 2: 
				case 3: 
				case 4: 
				case 5: 
				case 6: 
				case 7: 
				case 8: 
				case 9: 
				case 10: 
				case 11: 
				case 12: 
				case 13: 
				case 14: 
				case 15: 
				case 16: 
				case 17: 
				case 18: 
				case 19: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 20: 
					_recurrence = (IfcRecurrencePattern)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcTaskTimeRecurring other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@Recurrence != null)
					yield return @Recurrence;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}
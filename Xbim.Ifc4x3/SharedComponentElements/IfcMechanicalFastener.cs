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
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4x3.SharedComponentElements;
//## Custom using statements
//##


namespace Xbim.Ifc4x3.SharedComponentElements
{
	[ExpressType("IfcMechanicalFastener", 536)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcMechanicalFastener : IfcElementComponent, IInstantiableEntity, IContainsEntityReferences, IContainsIndexedReferences, IEquatable<@IfcMechanicalFastener>
	{

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcMechanicalFastener(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcPositiveLengthMeasure? _nominalDiameter;
		private IfcPositiveLengthMeasure? _nominalLength;
		private IfcMechanicalFastenerTypeEnum? _predefinedType;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(9, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 34)]
		public IfcPositiveLengthMeasure? @NominalDiameter 
		{ 
			get 
			{
				if(_activated) return _nominalDiameter;
				Activate();
				return _nominalDiameter;
			} 
			set
			{
				SetValue( v =>  _nominalDiameter = v, _nominalDiameter, value,  "NominalDiameter", 9);
			} 
		}	
		[EntityAttribute(10, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 35)]
		public IfcPositiveLengthMeasure? @NominalLength 
		{ 
			get 
			{
				if(_activated) return _nominalLength;
				Activate();
				return _nominalLength;
			} 
			set
			{
				SetValue( v =>  _nominalLength = v, _nominalLength, value,  "NominalLength", 10);
			} 
		}	
		[EntityAttribute(11, EntityAttributeState.Optional, EntityAttributeType.Enum, EntityAttributeType.None, null, null, 36)]
		public IfcMechanicalFastenerTypeEnum? @PredefinedType 
		{ 
			get 
			{
				if(_activated) return _predefinedType;
				Activate();
				return _predefinedType;
			} 
			set
			{
				SetValue( v =>  _predefinedType = v, _predefinedType, value,  "PredefinedType", 11);
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
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 8: 
					_nominalDiameter = value.RealVal;
					return;
				case 9: 
					_nominalLength = value.RealVal;
					return;
				case 10: 
                    _predefinedType = (IfcMechanicalFastenerTypeEnum) System.Enum.Parse(typeof (IfcMechanicalFastenerTypeEnum), value.EnumVal, true);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcMechanicalFastener other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@OwnerHistory != null)
					yield return @OwnerHistory;
				if (@ObjectPlacement != null)
					yield return @ObjectPlacement;
				if (@Representation != null)
					yield return @Representation;
			}
		}
		#endregion


		#region IContainsIndexedReferences
        IEnumerable<IPersistEntity> IContainsIndexedReferences.IndexedReferences 
		{ 
			get
			{
				if (@ObjectPlacement != null)
					yield return @ObjectPlacement;
				if (@Representation != null)
					yield return @Representation;
				
			} 
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}
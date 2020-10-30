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
using Xbim.Ifc4x3.GeometryResource;
//## Custom using statements
//##


namespace Xbim.Ifc4x3.GeometryResource
{
	[ExpressType("IfcEllipse", 298)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcEllipse : IfcConic, IInstantiableEntity, IContainsEntityReferences, IEquatable<@IfcEllipse>
	{

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcEllipse(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcPositiveLengthMeasure _semiAxis1;
		private IfcPositiveLengthMeasure _semiAxis2;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, null, null, 4)]
		public IfcPositiveLengthMeasure @SemiAxis1 
		{ 
			get 
			{
				if(_activated) return _semiAxis1;
				Activate();
				return _semiAxis1;
			} 
			set
			{
				SetValue( v =>  _semiAxis1 = v, _semiAxis1, value,  "SemiAxis1", 2);
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, null, null, 5)]
		public IfcPositiveLengthMeasure @SemiAxis2 
		{ 
			get 
			{
				if(_activated) return _semiAxis2;
				Activate();
				return _semiAxis2;
			} 
			set
			{
				SetValue( v =>  _semiAxis2 = v, _semiAxis2, value,  "SemiAxis2", 3);
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 1: 
					_semiAxis1 = value.RealVal;
					return;
				case 2: 
					_semiAxis2 = value.RealVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcEllipse other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@Position != null)
					yield return @Position;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}
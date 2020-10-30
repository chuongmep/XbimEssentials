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
	[ExpressType("IfcCartesianTransformationOperator", 146)]
	// ReSharper disable once PartialTypeWithSinglePart
	public abstract partial class @IfcCartesianTransformationOperator : IfcGeometricRepresentationItem, IEquatable<@IfcCartesianTransformationOperator>
	{

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcCartesianTransformationOperator(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcDirection _axis1;
		private IfcDirection _axis2;
		private IfcCartesianPoint _localOrigin;
		private IfcReal? _scale;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, null, null, 3)]
		public IfcDirection @Axis1 
		{ 
			get 
			{
				if(_activated) return _axis1;
				Activate();
				return _axis1;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _axis1 = v, _axis1, value,  "Axis1", 1);
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, null, null, 4)]
		public IfcDirection @Axis2 
		{ 
			get 
			{
				if(_activated) return _axis2;
				Activate();
				return _axis2;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _axis2 = v, _axis2, value,  "Axis2", 2);
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, null, null, 5)]
		public IfcCartesianPoint @LocalOrigin 
		{ 
			get 
			{
				if(_activated) return _localOrigin;
				Activate();
				return _localOrigin;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _localOrigin = v, _localOrigin, value,  "LocalOrigin", 3);
			} 
		}	
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 6)]
		public IfcReal? @Scale 
		{ 
			get 
			{
				if(_activated) return _scale;
				Activate();
				return _scale;
			} 
			set
			{
				SetValue( v =>  _scale = v, _scale, value,  "Scale", 4);
			} 
		}	
		#endregion


		#region Derived attributes
		[EntityAttribute(0, EntityAttributeState.Derived, EntityAttributeType.None, EntityAttributeType.None, null, null, 0)]
		public IfcReal @Scl 
		{
			get 
			{
				//## Getter for Scl
				//TODO: Implement getter for derived attribute Scl
				throw new NotImplementedException();
				//##
			}
		}

		[EntityAttribute(0, EntityAttributeState.Derived, EntityAttributeType.None, EntityAttributeType.None, null, null, 0)]
		public IfcDimensionCount @Dim 
		{
			get 
			{
				//## Getter for Dim
				//TODO: Implement getter for derived attribute Dim
				throw new NotImplementedException();
				//##
			}
		}

		#endregion


		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_axis1 = (IfcDirection)(value.EntityVal);
					return;
				case 1: 
					_axis2 = (IfcDirection)(value.EntityVal);
					return;
				case 2: 
					_localOrigin = (IfcCartesianPoint)(value.EntityVal);
					return;
				case 3: 
					_scale = value.RealVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcCartesianTransformationOperator other)
	    {
	        return this == other;
	    }
        #endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}
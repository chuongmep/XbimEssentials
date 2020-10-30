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
	[ExpressType("IfcCompositeCurve", 279)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcCompositeCurve : IfcBoundedCurve, IInstantiableEntity, IContainsEntityReferences, IContainsIndexedReferences, IEquatable<@IfcCompositeCurve>
	{

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcCompositeCurve(IModel model, int label, bool activated) : base(model, label, activated)  
		{
			_segments = new ItemSet<IfcCompositeCurveSegment>( this, 0,  1);
		}

		#region Explicit attribute fields
		private readonly ItemSet<IfcCompositeCurveSegment> _segments;
		private IfcLogical _selfIntersect;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.List, EntityAttributeType.Class, new int [] { 1 }, new int [] { -1 }, 4)]
		public IItemSet<IfcCompositeCurveSegment> @Segments 
		{ 
			get 
			{
				if(_activated) return _segments;
				Activate();
				return _segments;
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, null, null, 5)]
		public IfcLogical @SelfIntersect 
		{ 
			get 
			{
				if(_activated) return _selfIntersect;
				Activate();
				return _selfIntersect;
			} 
			set
			{
				SetValue( v =>  _selfIntersect = v, _selfIntersect, value,  "SelfIntersect", 2);
			} 
		}	
		#endregion


		#region Derived attributes
		[EntityAttribute(0, EntityAttributeState.Derived, EntityAttributeType.None, EntityAttributeType.None, null, null, 0)]
		public IfcInteger @NSegments 
		{
			get 
			{
				//## Getter for NSegments
				//TODO: Implement getter for derived attribute NSegments
				throw new NotImplementedException();
				//##
			}
		}

		[EntityAttribute(0, EntityAttributeState.Derived, EntityAttributeType.None, EntityAttributeType.None, null, null, 0)]
		public IfcLogical @ClosedCurve 
		{
			get 
			{
				//## Getter for ClosedCurve
				//TODO: Implement getter for derived attribute ClosedCurve
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
					_segments.InternalAdd((IfcCompositeCurveSegment)value.EntityVal);
					return;
				case 1: 
					_selfIntersect = value.BooleanVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcCompositeCurve other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				foreach(var entity in @Segments)
					yield return entity;
			}
		}
		#endregion


		#region IContainsIndexedReferences
        IEnumerable<IPersistEntity> IContainsIndexedReferences.IndexedReferences 
		{ 
			get
			{
				foreach(var entity in @Segments)
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
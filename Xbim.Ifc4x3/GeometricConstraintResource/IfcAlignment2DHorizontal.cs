// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4x3.GeometryResource;
using Xbim.Ifc4x3.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4x3.GeometricConstraintResource;
//## Custom using statements
//##


namespace Xbim.Ifc4x3.GeometricConstraintResource
{
	[ExpressType("IfcAlignment2DHorizontal", 1332)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcAlignment2DHorizontal : IfcGeometricRepresentationItem, IInstantiableEntity, IContainsEntityReferences, IContainsIndexedReferences, IEquatable<@IfcAlignment2DHorizontal>
	{

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcAlignment2DHorizontal(IModel model, int label, bool activated) : base(model, label, activated)  
		{
			_segments = new ItemSet<IfcAlignment2DHorizontalSegment>( this, 0,  2);
		}

		#region Explicit attribute fields
		private IfcLengthMeasure? _startDistAlong;
		private readonly ItemSet<IfcAlignment2DHorizontalSegment> _segments;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 3)]
		public IfcLengthMeasure? @StartDistAlong 
		{ 
			get 
			{
				if(_activated) return _startDistAlong;
				Activate();
				return _startDistAlong;
			} 
			set
			{
				SetValue( v =>  _startDistAlong = v, _startDistAlong, value,  "StartDistAlong", 1);
			} 
		}	
		[IndexedProperty]
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.List, EntityAttributeType.Class, new int [] { 1 }, new int [] { -1 }, 4)]
		public IItemSet<IfcAlignment2DHorizontalSegment> @Segments 
		{ 
			get 
			{
				if(_activated) return _segments;
				Activate();
				return _segments;
			} 
		}	
		#endregion



		#region Inverse attributes
		[InverseProperty("Horizontal")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, new int [] { 1 }, new int [] { -1 }, 5)]
		public IEnumerable<IfcAlignmentCurve> @ToAlignmentCurve 
		{ 
			get 
			{
				return Model.Instances.Where<IfcAlignmentCurve>(e => Equals(e.Horizontal), "Horizontal", this);
			} 
		}
		#endregion

		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_startDistAlong = value.RealVal;
					return;
				case 1: 
					_segments.InternalAdd((IfcAlignment2DHorizontalSegment)value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcAlignment2DHorizontal other)
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
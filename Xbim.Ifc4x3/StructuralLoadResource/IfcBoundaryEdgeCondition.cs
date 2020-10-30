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
using Xbim.Ifc4x3.StructuralLoadResource;
//## Custom using statements
//##


namespace Xbim.Ifc4x3.StructuralLoadResource
{
	[ExpressType("IfcBoundaryEdgeCondition", 319)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcBoundaryEdgeCondition : IfcBoundaryCondition, IInstantiableEntity, IEquatable<@IfcBoundaryEdgeCondition>
	{

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcBoundaryEdgeCondition(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcModulusOfTranslationalSubgradeReactionSelect _translationalStiffnessByLengthX;
		private IfcModulusOfTranslationalSubgradeReactionSelect _translationalStiffnessByLengthY;
		private IfcModulusOfTranslationalSubgradeReactionSelect _translationalStiffnessByLengthZ;
		private IfcModulusOfRotationalSubgradeReactionSelect _rotationalStiffnessByLengthX;
		private IfcModulusOfRotationalSubgradeReactionSelect _rotationalStiffnessByLengthY;
		private IfcModulusOfRotationalSubgradeReactionSelect _rotationalStiffnessByLengthZ;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, null, null, 2)]
		public IfcModulusOfTranslationalSubgradeReactionSelect @TranslationalStiffnessByLengthX 
		{ 
			get 
			{
				if(_activated) return _translationalStiffnessByLengthX;
				Activate();
				return _translationalStiffnessByLengthX;
			} 
			set
			{
				SetValue( v =>  _translationalStiffnessByLengthX = v, _translationalStiffnessByLengthX, value,  "TranslationalStiffnessByLengthX", 2);
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, null, null, 3)]
		public IfcModulusOfTranslationalSubgradeReactionSelect @TranslationalStiffnessByLengthY 
		{ 
			get 
			{
				if(_activated) return _translationalStiffnessByLengthY;
				Activate();
				return _translationalStiffnessByLengthY;
			} 
			set
			{
				SetValue( v =>  _translationalStiffnessByLengthY = v, _translationalStiffnessByLengthY, value,  "TranslationalStiffnessByLengthY", 3);
			} 
		}	
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, null, null, 4)]
		public IfcModulusOfTranslationalSubgradeReactionSelect @TranslationalStiffnessByLengthZ 
		{ 
			get 
			{
				if(_activated) return _translationalStiffnessByLengthZ;
				Activate();
				return _translationalStiffnessByLengthZ;
			} 
			set
			{
				SetValue( v =>  _translationalStiffnessByLengthZ = v, _translationalStiffnessByLengthZ, value,  "TranslationalStiffnessByLengthZ", 4);
			} 
		}	
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, null, null, 5)]
		public IfcModulusOfRotationalSubgradeReactionSelect @RotationalStiffnessByLengthX 
		{ 
			get 
			{
				if(_activated) return _rotationalStiffnessByLengthX;
				Activate();
				return _rotationalStiffnessByLengthX;
			} 
			set
			{
				SetValue( v =>  _rotationalStiffnessByLengthX = v, _rotationalStiffnessByLengthX, value,  "RotationalStiffnessByLengthX", 5);
			} 
		}	
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, null, null, 6)]
		public IfcModulusOfRotationalSubgradeReactionSelect @RotationalStiffnessByLengthY 
		{ 
			get 
			{
				if(_activated) return _rotationalStiffnessByLengthY;
				Activate();
				return _rotationalStiffnessByLengthY;
			} 
			set
			{
				SetValue( v =>  _rotationalStiffnessByLengthY = v, _rotationalStiffnessByLengthY, value,  "RotationalStiffnessByLengthY", 6);
			} 
		}	
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, null, null, 7)]
		public IfcModulusOfRotationalSubgradeReactionSelect @RotationalStiffnessByLengthZ 
		{ 
			get 
			{
				if(_activated) return _rotationalStiffnessByLengthZ;
				Activate();
				return _rotationalStiffnessByLengthZ;
			} 
			set
			{
				SetValue( v =>  _rotationalStiffnessByLengthZ = v, _rotationalStiffnessByLengthZ, value,  "RotationalStiffnessByLengthZ", 7);
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
					_translationalStiffnessByLengthX = (IfcModulusOfTranslationalSubgradeReactionSelect)(value.EntityVal);
					return;
				case 2: 
					_translationalStiffnessByLengthY = (IfcModulusOfTranslationalSubgradeReactionSelect)(value.EntityVal);
					return;
				case 3: 
					_translationalStiffnessByLengthZ = (IfcModulusOfTranslationalSubgradeReactionSelect)(value.EntityVal);
					return;
				case 4: 
					_rotationalStiffnessByLengthX = (IfcModulusOfRotationalSubgradeReactionSelect)(value.EntityVal);
					return;
				case 5: 
					_rotationalStiffnessByLengthY = (IfcModulusOfRotationalSubgradeReactionSelect)(value.EntityVal);
					return;
				case 6: 
					_rotationalStiffnessByLengthZ = (IfcModulusOfRotationalSubgradeReactionSelect)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcBoundaryEdgeCondition other)
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
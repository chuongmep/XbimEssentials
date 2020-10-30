// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4x3.MeasureResource;
using Xbim.Ifc4x3.ExternalReferenceResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4x3.ActorResource;
//## Custom using statements
//##


namespace Xbim.Ifc4x3.ActorResource
{
	[ExpressType("IfcTelecomAddress", 553)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcTelecomAddress : IfcAddress, IInstantiableEntity, IEquatable<@IfcTelecomAddress>
	{

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcTelecomAddress(IModel model, int label, bool activated) : base(model, label, activated)  
		{
			_telephoneNumbers = new OptionalItemSet<IfcLabel>( this, 0,  4);
			_facsimileNumbers = new OptionalItemSet<IfcLabel>( this, 0,  5);
			_electronicMailAddresses = new OptionalItemSet<IfcLabel>( this, 0,  7);
			_messagingIDs = new OptionalItemSet<IfcURIReference>( this, 0,  9);
		}

		#region Explicit attribute fields
		private readonly OptionalItemSet<IfcLabel> _telephoneNumbers;
		private readonly OptionalItemSet<IfcLabel> _facsimileNumbers;
		private IfcLabel? _pagerNumber;
		private readonly OptionalItemSet<IfcLabel> _electronicMailAddresses;
		private IfcURIReference? _wWWHomePageURL;
		private readonly OptionalItemSet<IfcURIReference> _messagingIDs;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.List, EntityAttributeType.None, new int [] { 1 }, new int [] { -1 }, 6)]
		public IOptionalItemSet<IfcLabel> @TelephoneNumbers 
		{ 
			get 
			{
				if(_activated) return _telephoneNumbers;
				Activate();
				return _telephoneNumbers;
			} 
		}	
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.List, EntityAttributeType.None, new int [] { 1 }, new int [] { -1 }, 7)]
		public IOptionalItemSet<IfcLabel> @FacsimileNumbers 
		{ 
			get 
			{
				if(_activated) return _facsimileNumbers;
				Activate();
				return _facsimileNumbers;
			} 
		}	
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 8)]
		public IfcLabel? @PagerNumber 
		{ 
			get 
			{
				if(_activated) return _pagerNumber;
				Activate();
				return _pagerNumber;
			} 
			set
			{
				SetValue( v =>  _pagerNumber = v, _pagerNumber, value,  "PagerNumber", 6);
			} 
		}	
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.List, EntityAttributeType.None, new int [] { 1 }, new int [] { -1 }, 9)]
		public IOptionalItemSet<IfcLabel> @ElectronicMailAddresses 
		{ 
			get 
			{
				if(_activated) return _electronicMailAddresses;
				Activate();
				return _electronicMailAddresses;
			} 
		}	
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 10)]
		public IfcURIReference? @WWWHomePageURL 
		{ 
			get 
			{
				if(_activated) return _wWWHomePageURL;
				Activate();
				return _wWWHomePageURL;
			} 
			set
			{
				SetValue( v =>  _wWWHomePageURL = v, _wWWHomePageURL, value,  "WWWHomePageURL", 8);
			} 
		}	
		[EntityAttribute(9, EntityAttributeState.Optional, EntityAttributeType.List, EntityAttributeType.None, new int [] { 1 }, new int [] { -1 }, 11)]
		public IOptionalItemSet<IfcURIReference> @MessagingIDs 
		{ 
			get 
			{
				if(_activated) return _messagingIDs;
				Activate();
				return _messagingIDs;
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
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 3: 
					_telephoneNumbers.InternalAdd(value.StringVal);
					return;
				case 4: 
					_facsimileNumbers.InternalAdd(value.StringVal);
					return;
				case 5: 
					_pagerNumber = value.StringVal;
					return;
				case 6: 
					_electronicMailAddresses.InternalAdd(value.StringVal);
					return;
				case 7: 
					_wWWHomePageURL = value.StringVal;
					return;
				case 8: 
					_messagingIDs.InternalAdd(value.StringVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcTelecomAddress other)
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
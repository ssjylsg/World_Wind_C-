//
// Type_RGBColor2.cs.cs
//
// This file was generated by XMLSpy 2005 Enterprise Edition.
//
// YOU SHOULD NOT MODIFY THIS FILE, BECAUSE IT WILL BE
// OVERWRITTEN WHEN YOU RE-RUN CODE GENERATION.
//
// Refer to the XMLSpy Documentation for further details.
// http://www.altova.com/xmlspy
//


using System;
using System.Collections;
using System.Xml;
using Altova.Types;

namespace LayerSet
{
	public class Type_RGBColor2 : Altova.Xml.Node
	{
		#region Forward constructors
		public Type_RGBColor2() : base() { SetCollectionParents(); }
		public Type_RGBColor2(XmlDocument doc) : base(doc) { SetCollectionParents(); }
		public Type_RGBColor2(XmlNode node) : base(node) { SetCollectionParents(); }
		public Type_RGBColor2(Altova.Xml.Node node) : base(node) { SetCollectionParents(); }
		#endregion // Forward constructors

		public override void AdjustPrefix()
		{

			for (int i = 0; i < DomChildCount(NodeType.Element, "", "Red"); i++)
			{
				XmlNode DOMNode = GetDomChildAt(NodeType.Element, "", "Red", i);
				InternalAdjustPrefix(DOMNode, true);
			}

			for (int i = 0; i < DomChildCount(NodeType.Element, "", "Green"); i++)
			{
				XmlNode DOMNode = GetDomChildAt(NodeType.Element, "", "Green", i);
				InternalAdjustPrefix(DOMNode, true);
			}

			for (int i = 0; i < DomChildCount(NodeType.Element, "", "Blue"); i++)
			{
				XmlNode DOMNode = GetDomChildAt(NodeType.Element, "", "Blue", i);
				InternalAdjustPrefix(DOMNode, true);
			}
		}


		#region Red accessor methods
		public int GetRedMinCount()
		{
			return 1;
		}

		public int RedMinCount
		{
			get
			{
				return 1;
			}
		}

		public int GetRedMaxCount()
		{
			return 1;
		}

		public int RedMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetRedCount()
		{
			return DomChildCount(NodeType.Element, "", "Red");
		}

		public int RedCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "", "Red");
			}
		}

		public bool HasRed()
		{
			return HasDomChild(NodeType.Element, "", "Red");
		}

		public RedType2 GetRedAt(int index)
		{
			return new RedType2(GetDomNodeValue(GetDomChildAt(NodeType.Element, "", "Red", index)));
		}

		public XmlNode GetStartingRedCursor()
		{
			return GetDomFirstChild( NodeType.Element, "", "Red" );
		}

		public XmlNode GetAdvancedRedCursor( XmlNode curNode )
		{
			return GetDomNextChild( NodeType.Element, "", "Red", curNode );
		}

		public RedType2 GetRedValueAtCursor( XmlNode curNode )
		{
			if( curNode == null )
				  throw new Altova.Xml.XmlException("Out of range");
			else
				return new RedType2( curNode.InnerText );
		}


		public RedType2 GetRed()
		{
			return GetRedAt(0);
		}

		public RedType2 Red
		{
			get
			{
				return GetRedAt(0);
			}
		}

		public void RemoveRedAt(int index)
		{
			RemoveDomChildAt(NodeType.Element, "", "Red", index);
		}

		public void RemoveRed()
		{
			while (HasRed())
				RemoveRedAt(0);
		}

		public void AddRed(RedType2 newValue)
		{
			AppendDomChild(NodeType.Element, "", "Red", newValue.ToString());
		}

		public void InsertRedAt(RedType2 newValue, int index)
		{
			InsertDomChildAt(NodeType.Element, "", "Red", index, newValue.ToString());
		}

		public void ReplaceRedAt(RedType2 newValue, int index)
		{
			ReplaceDomChildAt(NodeType.Element, "", "Red", index, newValue.ToString());
		}
		#endregion // Red accessor methods

		#region Red collection
        public RedCollection	MyReds = new RedCollection( );

        public class RedCollection: IEnumerable
        {
            Type_RGBColor2 parent;
            public Type_RGBColor2 Parent
			{
				set
				{
					parent = value;
				}
			}
			public RedEnumerator GetEnumerator() 
			{
				return new RedEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class RedEnumerator: IEnumerator 
        {
			int nIndex;
			Type_RGBColor2 parent;
			public RedEnumerator(Type_RGBColor2 par) 
			{
				parent = par;
				nIndex = -1;
			}
			public void Reset() 
			{
				nIndex = -1;
			}
			public bool MoveNext() 
			{
				nIndex++;
				return(nIndex < parent.RedCount );
			}
			public RedType2  Current 
			{
				get 
				{
					return(parent.GetRedAt(nIndex));
				}
			}
			object IEnumerator.Current 
			{
				get 
				{
					return(Current);
				}
			}
    	}

        #endregion // Red collection

		#region Green accessor methods
		public int GetGreenMinCount()
		{
			return 1;
		}

		public int GreenMinCount
		{
			get
			{
				return 1;
			}
		}

		public int GetGreenMaxCount()
		{
			return 1;
		}

		public int GreenMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetGreenCount()
		{
			return DomChildCount(NodeType.Element, "", "Green");
		}

		public int GreenCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "", "Green");
			}
		}

		public bool HasGreen()
		{
			return HasDomChild(NodeType.Element, "", "Green");
		}

		public GreenType2 GetGreenAt(int index)
		{
			return new GreenType2(GetDomNodeValue(GetDomChildAt(NodeType.Element, "", "Green", index)));
		}

		public XmlNode GetStartingGreenCursor()
		{
			return GetDomFirstChild( NodeType.Element, "", "Green" );
		}

		public XmlNode GetAdvancedGreenCursor( XmlNode curNode )
		{
			return GetDomNextChild( NodeType.Element, "", "Green", curNode );
		}

		public GreenType2 GetGreenValueAtCursor( XmlNode curNode )
		{
			if( curNode == null )
				  throw new Altova.Xml.XmlException("Out of range");
			else
				return new GreenType2( curNode.InnerText );
		}


		public GreenType2 GetGreen()
		{
			return GetGreenAt(0);
		}

		public GreenType2 Green
		{
			get
			{
				return GetGreenAt(0);
			}
		}

		public void RemoveGreenAt(int index)
		{
			RemoveDomChildAt(NodeType.Element, "", "Green", index);
		}

		public void RemoveGreen()
		{
			while (HasGreen())
				RemoveGreenAt(0);
		}

		public void AddGreen(GreenType2 newValue)
		{
			AppendDomChild(NodeType.Element, "", "Green", newValue.ToString());
		}

		public void InsertGreenAt(GreenType2 newValue, int index)
		{
			InsertDomChildAt(NodeType.Element, "", "Green", index, newValue.ToString());
		}

		public void ReplaceGreenAt(GreenType2 newValue, int index)
		{
			ReplaceDomChildAt(NodeType.Element, "", "Green", index, newValue.ToString());
		}
		#endregion // Green accessor methods

		#region Green collection
        public GreenCollection	MyGreens = new GreenCollection( );

        public class GreenCollection: IEnumerable
        {
            Type_RGBColor2 parent;
            public Type_RGBColor2 Parent
			{
				set
				{
					parent = value;
				}
			}
			public GreenEnumerator GetEnumerator() 
			{
				return new GreenEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class GreenEnumerator: IEnumerator 
        {
			int nIndex;
			Type_RGBColor2 parent;
			public GreenEnumerator(Type_RGBColor2 par) 
			{
				parent = par;
				nIndex = -1;
			}
			public void Reset() 
			{
				nIndex = -1;
			}
			public bool MoveNext() 
			{
				nIndex++;
				return(nIndex < parent.GreenCount );
			}
			public GreenType2  Current 
			{
				get 
				{
					return(parent.GetGreenAt(nIndex));
				}
			}
			object IEnumerator.Current 
			{
				get 
				{
					return(Current);
				}
			}
    	}

        #endregion // Green collection

		#region Blue accessor methods
		public int GetBlueMinCount()
		{
			return 1;
		}

		public int BlueMinCount
		{
			get
			{
				return 1;
			}
		}

		public int GetBlueMaxCount()
		{
			return 1;
		}

		public int BlueMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetBlueCount()
		{
			return DomChildCount(NodeType.Element, "", "Blue");
		}

		public int BlueCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "", "Blue");
			}
		}

		public bool HasBlue()
		{
			return HasDomChild(NodeType.Element, "", "Blue");
		}

		public BlueType2 GetBlueAt(int index)
		{
			return new BlueType2(GetDomNodeValue(GetDomChildAt(NodeType.Element, "", "Blue", index)));
		}

		public XmlNode GetStartingBlueCursor()
		{
			return GetDomFirstChild( NodeType.Element, "", "Blue" );
		}

		public XmlNode GetAdvancedBlueCursor( XmlNode curNode )
		{
			return GetDomNextChild( NodeType.Element, "", "Blue", curNode );
		}

		public BlueType2 GetBlueValueAtCursor( XmlNode curNode )
		{
			if( curNode == null )
				  throw new Altova.Xml.XmlException("Out of range");
			else
				return new BlueType2( curNode.InnerText );
		}


		public BlueType2 GetBlue()
		{
			return GetBlueAt(0);
		}

		public BlueType2 Blue
		{
			get
			{
				return GetBlueAt(0);
			}
		}

		public void RemoveBlueAt(int index)
		{
			RemoveDomChildAt(NodeType.Element, "", "Blue", index);
		}

		public void RemoveBlue()
		{
			while (HasBlue())
				RemoveBlueAt(0);
		}

		public void AddBlue(BlueType2 newValue)
		{
			AppendDomChild(NodeType.Element, "", "Blue", newValue.ToString());
		}

		public void InsertBlueAt(BlueType2 newValue, int index)
		{
			InsertDomChildAt(NodeType.Element, "", "Blue", index, newValue.ToString());
		}

		public void ReplaceBlueAt(BlueType2 newValue, int index)
		{
			ReplaceDomChildAt(NodeType.Element, "", "Blue", index, newValue.ToString());
		}
		#endregion // Blue accessor methods

		#region Blue collection
        public BlueCollection	MyBlues = new BlueCollection( );

        public class BlueCollection: IEnumerable
        {
            Type_RGBColor2 parent;
            public Type_RGBColor2 Parent
			{
				set
				{
					parent = value;
				}
			}
			public BlueEnumerator GetEnumerator() 
			{
				return new BlueEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class BlueEnumerator: IEnumerator 
        {
			int nIndex;
			Type_RGBColor2 parent;
			public BlueEnumerator(Type_RGBColor2 par) 
			{
				parent = par;
				nIndex = -1;
			}
			public void Reset() 
			{
				nIndex = -1;
			}
			public bool MoveNext() 
			{
				nIndex++;
				return(nIndex < parent.BlueCount );
			}
			public BlueType2  Current 
			{
				get 
				{
					return(parent.GetBlueAt(nIndex));
				}
			}
			object IEnumerator.Current 
			{
				get 
				{
					return(Current);
				}
			}
    	}

        #endregion // Blue collection

        private void SetCollectionParents()
        {
            MyReds.Parent = this; 
            MyGreens.Parent = this; 
            MyBlues.Parent = this; 
	}
}
}

//
// TerrainTileService.cs.cs
//
// This file was generated by XMLSPY 2004 Enterprise Edition.
//
// YOU SHOULD NOT MODIFY THIS FILE, BECAUSE IT WILL BE
// OVERWRITTEN WHEN YOU RE-RUN CODE GENERATION.
//
// Refer to the XMLSPY Documentation for further details.
// http://www.altova.com/xmlspy
//


using System;
using System.Collections;
using System.Xml;
using Altova.Types;

namespace WorldXmlDescriptor
{
	public class TerrainTileService : Altova.Xml.Node
	{
		#region Forward constructors
		public TerrainTileService() : base() { SetCollectionParents(); }
		public TerrainTileService(XmlDocument doc) : base(doc) { SetCollectionParents(); }
		public TerrainTileService(XmlNode node) : base(node) { SetCollectionParents(); }
		public TerrainTileService(Altova.Xml.Node node) : base(node) { SetCollectionParents(); }
		#endregion // Forward constructors

		public override void AdjustPrefix()
		{

			for (int i = 0; i < DomChildCount(NodeType.Element, "", "ServerUrl"); i++)
			{
				XmlNode DOMNode = GetDomChildAt(NodeType.Element, "", "ServerUrl", i);
				InternalAdjustPrefix(DOMNode, true);
			}

			for (int i = 0; i < DomChildCount(NodeType.Element, "", "DataSetName"); i++)
			{
				XmlNode DOMNode = GetDomChildAt(NodeType.Element, "", "DataSetName", i);
				InternalAdjustPrefix(DOMNode, true);
			}

			for (int i = 0; i < DomChildCount(NodeType.Element, "", "LevelZeroTileSizeDegrees"); i++)
			{
				XmlNode DOMNode = GetDomChildAt(NodeType.Element, "", "LevelZeroTileSizeDegrees", i);
				InternalAdjustPrefix(DOMNode, true);
			}

			for (int i = 0; i < DomChildCount(NodeType.Element, "", "NumberLevels"); i++)
			{
				XmlNode DOMNode = GetDomChildAt(NodeType.Element, "", "NumberLevels", i);
				InternalAdjustPrefix(DOMNode, true);
			}

			for (int i = 0; i < DomChildCount(NodeType.Element, "", "SamplesPerTile"); i++)
			{
				XmlNode DOMNode = GetDomChildAt(NodeType.Element, "", "SamplesPerTile", i);
				InternalAdjustPrefix(DOMNode, true);
			}

			for (int i = 0; i < DomChildCount(NodeType.Element, "", "DataFormat"); i++)
			{
				XmlNode DOMNode = GetDomChildAt(NodeType.Element, "", "DataFormat", i);
				InternalAdjustPrefix(DOMNode, true);
			}

			for (int i = 0; i < DomChildCount(NodeType.Element, "", "FileExtension"); i++)
			{
				XmlNode DOMNode = GetDomChildAt(NodeType.Element, "", "FileExtension", i);
				InternalAdjustPrefix(DOMNode, true);
			}

			for (int i = 0; i < DomChildCount(NodeType.Element, "", "CompressonType"); i++)
			{
				XmlNode DOMNode = GetDomChildAt(NodeType.Element, "", "CompressonType", i);
				InternalAdjustPrefix(DOMNode, true);
			}
		}


		#region ServerUrl accessor methods
		public int GetServerUrlMinCount()
		{
			return 1;
		}

		public int ServerUrlMinCount
		{
			get
			{
				return 1;
			}
		}

		public int GetServerUrlMaxCount()
		{
			return 1;
		}

		public int ServerUrlMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetServerUrlCount()
		{
			return DomChildCount(NodeType.Element, "", "ServerUrl");
		}

		public int ServerUrlCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "", "ServerUrl");
			}
		}

		public bool HasServerUrl()
		{
			return HasDomChild(NodeType.Element, "", "ServerUrl");
		}

		public SchemaString GetServerUrlAt(int index)
		{
			return new SchemaString(GetDomNodeValue(GetDomChildAt(NodeType.Element, "", "ServerUrl", index)));
		}

		public SchemaString GetServerUrl()
		{
			return GetServerUrlAt(0);
		}

		public SchemaString ServerUrl
		{
			get
			{
				return GetServerUrlAt(0);
			}
		}

		public void RemoveServerUrlAt(int index)
		{
			RemoveDomChildAt(NodeType.Element, "", "ServerUrl", index);
		}

		public void RemoveServerUrl()
		{
			while (HasServerUrl())
				RemoveServerUrlAt(0);
		}

		public void AddServerUrl(SchemaString newValue)
		{
			AppendDomChild(NodeType.Element, "", "ServerUrl", newValue.ToString());
		}

		public void InsertServerUrlAt(SchemaString newValue, int index)
		{
			InsertDomChildAt(NodeType.Element, "", "ServerUrl", index, newValue.ToString());
		}

		public void ReplaceServerUrlAt(SchemaString newValue, int index)
		{
			ReplaceDomChildAt(NodeType.Element, "", "ServerUrl", index, newValue.ToString());
		}
		#endregion // ServerUrl accessor methods

		#region ServerUrl collection
        public ServerUrlCollection	MyServerUrls = new ServerUrlCollection( );

        public class ServerUrlCollection: IEnumerable
        {
            TerrainTileService parent;
            public TerrainTileService Parent
			{
				set
				{
					parent = value;
				}
			}
			public ServerUrlEnumerator GetEnumerator() 
			{
				return new ServerUrlEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class ServerUrlEnumerator: IEnumerator 
        {
			int nIndex;
			TerrainTileService parent;
			public ServerUrlEnumerator(TerrainTileService par) 
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
				return(nIndex < parent.ServerUrlCount );
			}
			public SchemaString  Current 
			{
				get 
				{
					return(parent.GetServerUrlAt(nIndex));
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

        #endregion // ServerUrl collection

		#region DataSetName accessor methods
		public int GetDataSetNameMinCount()
		{
			return 1;
		}

		public int DataSetNameMinCount
		{
			get
			{
				return 1;
			}
		}

		public int GetDataSetNameMaxCount()
		{
			return 1;
		}

		public int DataSetNameMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetDataSetNameCount()
		{
			return DomChildCount(NodeType.Element, "", "DataSetName");
		}

		public int DataSetNameCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "", "DataSetName");
			}
		}

		public bool HasDataSetName()
		{
			return HasDomChild(NodeType.Element, "", "DataSetName");
		}

		public SchemaString GetDataSetNameAt(int index)
		{
			return new SchemaString(GetDomNodeValue(GetDomChildAt(NodeType.Element, "", "DataSetName", index)));
		}

		public SchemaString GetDataSetName()
		{
			return GetDataSetNameAt(0);
		}

		public SchemaString DataSetName
		{
			get
			{
				return GetDataSetNameAt(0);
			}
		}

		public void RemoveDataSetNameAt(int index)
		{
			RemoveDomChildAt(NodeType.Element, "", "DataSetName", index);
		}

		public void RemoveDataSetName()
		{
			while (HasDataSetName())
				RemoveDataSetNameAt(0);
		}

		public void AddDataSetName(SchemaString newValue)
		{
			AppendDomChild(NodeType.Element, "", "DataSetName", newValue.ToString());
		}

		public void InsertDataSetNameAt(SchemaString newValue, int index)
		{
			InsertDomChildAt(NodeType.Element, "", "DataSetName", index, newValue.ToString());
		}

		public void ReplaceDataSetNameAt(SchemaString newValue, int index)
		{
			ReplaceDomChildAt(NodeType.Element, "", "DataSetName", index, newValue.ToString());
		}
		#endregion // DataSetName accessor methods

		#region DataSetName collection
        public DataSetNameCollection	MyDataSetNames = new DataSetNameCollection( );

        public class DataSetNameCollection: IEnumerable
        {
            TerrainTileService parent;
            public TerrainTileService Parent
			{
				set
				{
					parent = value;
				}
			}
			public DataSetNameEnumerator GetEnumerator() 
			{
				return new DataSetNameEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class DataSetNameEnumerator: IEnumerator 
        {
			int nIndex;
			TerrainTileService parent;
			public DataSetNameEnumerator(TerrainTileService par) 
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
				return(nIndex < parent.DataSetNameCount );
			}
			public SchemaString  Current 
			{
				get 
				{
					return(parent.GetDataSetNameAt(nIndex));
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

        #endregion // DataSetName collection

		#region LevelZeroTileSizeDegrees accessor methods
		public int GetLevelZeroTileSizeDegreesMinCount()
		{
			return 1;
		}

		public int LevelZeroTileSizeDegreesMinCount
		{
			get
			{
				return 1;
			}
		}

		public int GetLevelZeroTileSizeDegreesMaxCount()
		{
			return 1;
		}

		public int LevelZeroTileSizeDegreesMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetLevelZeroTileSizeDegreesCount()
		{
			return DomChildCount(NodeType.Element, "", "LevelZeroTileSizeDegrees");
		}

		public int LevelZeroTileSizeDegreesCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "", "LevelZeroTileSizeDegrees");
			}
		}

		public bool HasLevelZeroTileSizeDegrees()
		{
			return HasDomChild(NodeType.Element, "", "LevelZeroTileSizeDegrees");
		}

		public SchemaDecimal GetLevelZeroTileSizeDegreesAt(int index)
		{
			return new SchemaDecimal(GetDomNodeValue(GetDomChildAt(NodeType.Element, "", "LevelZeroTileSizeDegrees", index)));
		}

		public SchemaDecimal GetLevelZeroTileSizeDegrees()
		{
			return GetLevelZeroTileSizeDegreesAt(0);
		}

		public SchemaDecimal LevelZeroTileSizeDegrees
		{
			get
			{
				return GetLevelZeroTileSizeDegreesAt(0);
			}
		}

		public void RemoveLevelZeroTileSizeDegreesAt(int index)
		{
			RemoveDomChildAt(NodeType.Element, "", "LevelZeroTileSizeDegrees", index);
		}

		public void RemoveLevelZeroTileSizeDegrees()
		{
			while (HasLevelZeroTileSizeDegrees())
				RemoveLevelZeroTileSizeDegreesAt(0);
		}

		public void AddLevelZeroTileSizeDegrees(SchemaDecimal newValue)
		{
			AppendDomChild(NodeType.Element, "", "LevelZeroTileSizeDegrees", newValue.ToString());
		}

		public void InsertLevelZeroTileSizeDegreesAt(SchemaDecimal newValue, int index)
		{
			InsertDomChildAt(NodeType.Element, "", "LevelZeroTileSizeDegrees", index, newValue.ToString());
		}

		public void ReplaceLevelZeroTileSizeDegreesAt(SchemaDecimal newValue, int index)
		{
			ReplaceDomChildAt(NodeType.Element, "", "LevelZeroTileSizeDegrees", index, newValue.ToString());
		}
		#endregion // LevelZeroTileSizeDegrees accessor methods

		#region LevelZeroTileSizeDegrees collection
        public LevelZeroTileSizeDegreesCollection	MyLevelZeroTileSizeDegreess = new LevelZeroTileSizeDegreesCollection( );

        public class LevelZeroTileSizeDegreesCollection: IEnumerable
        {
            TerrainTileService parent;
            public TerrainTileService Parent
			{
				set
				{
					parent = value;
				}
			}
			public LevelZeroTileSizeDegreesEnumerator GetEnumerator() 
			{
				return new LevelZeroTileSizeDegreesEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class LevelZeroTileSizeDegreesEnumerator: IEnumerator 
        {
			int nIndex;
			TerrainTileService parent;
			public LevelZeroTileSizeDegreesEnumerator(TerrainTileService par) 
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
				return(nIndex < parent.LevelZeroTileSizeDegreesCount );
			}
			public SchemaDecimal  Current 
			{
				get 
				{
					return(parent.GetLevelZeroTileSizeDegreesAt(nIndex));
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

        #endregion // LevelZeroTileSizeDegrees collection

		#region NumberLevels accessor methods
		public int GetNumberLevelsMinCount()
		{
			return 1;
		}

		public int NumberLevelsMinCount
		{
			get
			{
				return 1;
			}
		}

		public int GetNumberLevelsMaxCount()
		{
			return 1;
		}

		public int NumberLevelsMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetNumberLevelsCount()
		{
			return DomChildCount(NodeType.Element, "", "NumberLevels");
		}

		public int NumberLevelsCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "", "NumberLevels");
			}
		}

		public bool HasNumberLevels()
		{
			return HasDomChild(NodeType.Element, "", "NumberLevels");
		}

		public SchemaInt GetNumberLevelsAt(int index)
		{
			return new SchemaInt(GetDomNodeValue(GetDomChildAt(NodeType.Element, "", "NumberLevels", index)));
		}

		public SchemaInt GetNumberLevels()
		{
			return GetNumberLevelsAt(0);
		}

		public SchemaInt NumberLevels
		{
			get
			{
				return GetNumberLevelsAt(0);
			}
		}

		public void RemoveNumberLevelsAt(int index)
		{
			RemoveDomChildAt(NodeType.Element, "", "NumberLevels", index);
		}

		public void RemoveNumberLevels()
		{
			while (HasNumberLevels())
				RemoveNumberLevelsAt(0);
		}

		public void AddNumberLevels(SchemaInt newValue)
		{
			AppendDomChild(NodeType.Element, "", "NumberLevels", newValue.ToString());
		}

		public void InsertNumberLevelsAt(SchemaInt newValue, int index)
		{
			InsertDomChildAt(NodeType.Element, "", "NumberLevels", index, newValue.ToString());
		}

		public void ReplaceNumberLevelsAt(SchemaInt newValue, int index)
		{
			ReplaceDomChildAt(NodeType.Element, "", "NumberLevels", index, newValue.ToString());
		}
		#endregion // NumberLevels accessor methods

		#region NumberLevels collection
        public NumberLevelsCollection	MyNumberLevelss = new NumberLevelsCollection( );

        public class NumberLevelsCollection: IEnumerable
        {
            TerrainTileService parent;
            public TerrainTileService Parent
			{
				set
				{
					parent = value;
				}
			}
			public NumberLevelsEnumerator GetEnumerator() 
			{
				return new NumberLevelsEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class NumberLevelsEnumerator: IEnumerator 
        {
			int nIndex;
			TerrainTileService parent;
			public NumberLevelsEnumerator(TerrainTileService par) 
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
				return(nIndex < parent.NumberLevelsCount );
			}
			public SchemaInt  Current 
			{
				get 
				{
					return(parent.GetNumberLevelsAt(nIndex));
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

        #endregion // NumberLevels collection

		#region SamplesPerTile accessor methods
		public int GetSamplesPerTileMinCount()
		{
			return 1;
		}

		public int SamplesPerTileMinCount
		{
			get
			{
				return 1;
			}
		}

		public int GetSamplesPerTileMaxCount()
		{
			return 1;
		}

		public int SamplesPerTileMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetSamplesPerTileCount()
		{
			return DomChildCount(NodeType.Element, "", "SamplesPerTile");
		}

		public int SamplesPerTileCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "", "SamplesPerTile");
			}
		}

		public bool HasSamplesPerTile()
		{
			return HasDomChild(NodeType.Element, "", "SamplesPerTile");
		}

		public SchemaInt GetSamplesPerTileAt(int index)
		{
			return new SchemaInt(GetDomNodeValue(GetDomChildAt(NodeType.Element, "", "SamplesPerTile", index)));
		}

		public SchemaInt GetSamplesPerTile()
		{
			return GetSamplesPerTileAt(0);
		}

		public SchemaInt SamplesPerTile
		{
			get
			{
				return GetSamplesPerTileAt(0);
			}
		}

		public void RemoveSamplesPerTileAt(int index)
		{
			RemoveDomChildAt(NodeType.Element, "", "SamplesPerTile", index);
		}

		public void RemoveSamplesPerTile()
		{
			while (HasSamplesPerTile())
				RemoveSamplesPerTileAt(0);
		}

		public void AddSamplesPerTile(SchemaInt newValue)
		{
			AppendDomChild(NodeType.Element, "", "SamplesPerTile", newValue.ToString());
		}

		public void InsertSamplesPerTileAt(SchemaInt newValue, int index)
		{
			InsertDomChildAt(NodeType.Element, "", "SamplesPerTile", index, newValue.ToString());
		}

		public void ReplaceSamplesPerTileAt(SchemaInt newValue, int index)
		{
			ReplaceDomChildAt(NodeType.Element, "", "SamplesPerTile", index, newValue.ToString());
		}
		#endregion // SamplesPerTile accessor methods

		#region SamplesPerTile collection
        public SamplesPerTileCollection	MySamplesPerTiles = new SamplesPerTileCollection( );

        public class SamplesPerTileCollection: IEnumerable
        {
            TerrainTileService parent;
            public TerrainTileService Parent
			{
				set
				{
					parent = value;
				}
			}
			public SamplesPerTileEnumerator GetEnumerator() 
			{
				return new SamplesPerTileEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class SamplesPerTileEnumerator: IEnumerator 
        {
			int nIndex;
			TerrainTileService parent;
			public SamplesPerTileEnumerator(TerrainTileService par) 
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
				return(nIndex < parent.SamplesPerTileCount );
			}
			public SchemaInt  Current 
			{
				get 
				{
					return(parent.GetSamplesPerTileAt(nIndex));
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

        #endregion // SamplesPerTile collection

		#region DataFormat accessor methods
		public int GetDataFormatMinCount()
		{
			return 1;
		}

		public int DataFormatMinCount
		{
			get
			{
				return 1;
			}
		}

		public int GetDataFormatMaxCount()
		{
			return 1;
		}

		public int DataFormatMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetDataFormatCount()
		{
			return DomChildCount(NodeType.Element, "", "DataFormat");
		}

		public int DataFormatCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "", "DataFormat");
			}
		}

		public bool HasDataFormat()
		{
			return HasDomChild(NodeType.Element, "", "DataFormat");
		}

		public SchemaString GetDataFormatAt(int index)
		{
			return new SchemaString(GetDomNodeValue(GetDomChildAt(NodeType.Element, "", "DataFormat", index)));
		}

		public SchemaString GetDataFormat()
		{
			return GetDataFormatAt(0);
		}

		public SchemaString DataFormat
		{
			get
			{
				return GetDataFormatAt(0);
			}
		}

		public void RemoveDataFormatAt(int index)
		{
			RemoveDomChildAt(NodeType.Element, "", "DataFormat", index);
		}

		public void RemoveDataFormat()
		{
			while (HasDataFormat())
				RemoveDataFormatAt(0);
		}

		public void AddDataFormat(SchemaString newValue)
		{
			AppendDomChild(NodeType.Element, "", "DataFormat", newValue.ToString());
		}

		public void InsertDataFormatAt(SchemaString newValue, int index)
		{
			InsertDomChildAt(NodeType.Element, "", "DataFormat", index, newValue.ToString());
		}

		public void ReplaceDataFormatAt(SchemaString newValue, int index)
		{
			ReplaceDomChildAt(NodeType.Element, "", "DataFormat", index, newValue.ToString());
		}
		#endregion // DataFormat accessor methods

		#region DataFormat collection
        public DataFormatCollection	MyDataFormats = new DataFormatCollection( );

        public class DataFormatCollection: IEnumerable
        {
            TerrainTileService parent;
            public TerrainTileService Parent
			{
				set
				{
					parent = value;
				}
			}
			public DataFormatEnumerator GetEnumerator() 
			{
				return new DataFormatEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class DataFormatEnumerator: IEnumerator 
        {
			int nIndex;
			TerrainTileService parent;
			public DataFormatEnumerator(TerrainTileService par) 
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
				return(nIndex < parent.DataFormatCount );
			}
			public SchemaString  Current 
			{
				get 
				{
					return(parent.GetDataFormatAt(nIndex));
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

        #endregion // DataFormat collection

		#region FileExtension accessor methods
		public int GetFileExtensionMinCount()
		{
			return 1;
		}

		public int FileExtensionMinCount
		{
			get
			{
				return 1;
			}
		}

		public int GetFileExtensionMaxCount()
		{
			return 1;
		}

		public int FileExtensionMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetFileExtensionCount()
		{
			return DomChildCount(NodeType.Element, "", "FileExtension");
		}

		public int FileExtensionCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "", "FileExtension");
			}
		}

		public bool HasFileExtension()
		{
			return HasDomChild(NodeType.Element, "", "FileExtension");
		}

		public SchemaString GetFileExtensionAt(int index)
		{
			return new SchemaString(GetDomNodeValue(GetDomChildAt(NodeType.Element, "", "FileExtension", index)));
		}

		public SchemaString GetFileExtension()
		{
			return GetFileExtensionAt(0);
		}

		public SchemaString FileExtension
		{
			get
			{
				return GetFileExtensionAt(0);
			}
		}

		public void RemoveFileExtensionAt(int index)
		{
			RemoveDomChildAt(NodeType.Element, "", "FileExtension", index);
		}

		public void RemoveFileExtension()
		{
			while (HasFileExtension())
				RemoveFileExtensionAt(0);
		}

		public void AddFileExtension(SchemaString newValue)
		{
			AppendDomChild(NodeType.Element, "", "FileExtension", newValue.ToString());
		}

		public void InsertFileExtensionAt(SchemaString newValue, int index)
		{
			InsertDomChildAt(NodeType.Element, "", "FileExtension", index, newValue.ToString());
		}

		public void ReplaceFileExtensionAt(SchemaString newValue, int index)
		{
			ReplaceDomChildAt(NodeType.Element, "", "FileExtension", index, newValue.ToString());
		}
		#endregion // FileExtension accessor methods

		#region FileExtension collection
        public FileExtensionCollection	MyFileExtensions = new FileExtensionCollection( );

        public class FileExtensionCollection: IEnumerable
        {
            TerrainTileService parent;
            public TerrainTileService Parent
			{
				set
				{
					parent = value;
				}
			}
			public FileExtensionEnumerator GetEnumerator() 
			{
				return new FileExtensionEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class FileExtensionEnumerator: IEnumerator 
        {
			int nIndex;
			TerrainTileService parent;
			public FileExtensionEnumerator(TerrainTileService par) 
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
				return(nIndex < parent.FileExtensionCount );
			}
			public SchemaString  Current 
			{
				get 
				{
					return(parent.GetFileExtensionAt(nIndex));
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

        #endregion // FileExtension collection

		#region CompressonType accessor methods
		public int GetCompressonTypeMinCount()
		{
			return 0;
		}

		public int CompressonTypeMinCount
		{
			get
			{
				return 0;
			}
		}

		public int GetCompressonTypeMaxCount()
		{
			return 1;
		}

		public int CompressonTypeMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetCompressonTypeCount()
		{
			return DomChildCount(NodeType.Element, "", "CompressonType");
		}

		public int CompressonTypeCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "", "CompressonType");
			}
		}

		public bool HasCompressonType()
		{
			return HasDomChild(NodeType.Element, "", "CompressonType");
		}

		public SchemaString GetCompressonTypeAt(int index)
		{
			return new SchemaString(GetDomNodeValue(GetDomChildAt(NodeType.Element, "", "CompressonType", index)));
		}

		public SchemaString GetCompressonType()
		{
			return GetCompressonTypeAt(0);
		}

		public SchemaString CompressonType
		{
			get
			{
				return GetCompressonTypeAt(0);
			}
		}

		public void RemoveCompressonTypeAt(int index)
		{
			RemoveDomChildAt(NodeType.Element, "", "CompressonType", index);
		}

		public void RemoveCompressonType()
		{
			while (HasCompressonType())
				RemoveCompressonTypeAt(0);
		}

		public void AddCompressonType(SchemaString newValue)
		{
			AppendDomChild(NodeType.Element, "", "CompressonType", newValue.ToString());
		}

		public void InsertCompressonTypeAt(SchemaString newValue, int index)
		{
			InsertDomChildAt(NodeType.Element, "", "CompressonType", index, newValue.ToString());
		}

		public void ReplaceCompressonTypeAt(SchemaString newValue, int index)
		{
			ReplaceDomChildAt(NodeType.Element, "", "CompressonType", index, newValue.ToString());
		}
		#endregion // CompressonType accessor methods

		#region CompressonType collection
        public CompressonTypeCollection	MyCompressonTypes = new CompressonTypeCollection( );

        public class CompressonTypeCollection: IEnumerable
        {
            TerrainTileService parent;
            public TerrainTileService Parent
			{
				set
				{
					parent = value;
				}
			}
			public CompressonTypeEnumerator GetEnumerator() 
			{
				return new CompressonTypeEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class CompressonTypeEnumerator: IEnumerator 
        {
			int nIndex;
			TerrainTileService parent;
			public CompressonTypeEnumerator(TerrainTileService par) 
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
				return(nIndex < parent.CompressonTypeCount );
			}
			public SchemaString  Current 
			{
				get 
				{
					return(parent.GetCompressonTypeAt(nIndex));
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

        #endregion // CompressonType collection

        private void SetCollectionParents()
        {
            MyServerUrls.Parent = this; 
            MyDataSetNames.Parent = this; 
            MyLevelZeroTileSizeDegreess.Parent = this; 
            MyNumberLevelss.Parent = this; 
            MySamplesPerTiles.Parent = this; 
            MyDataFormats.Parent = this; 
            MyFileExtensions.Parent = this; 
            MyCompressonTypes.Parent = this; 
	}
}
}

Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.CodeDom.Compiler
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.ComponentModel.Design
Imports System.Data
Imports System.Diagnostics
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Runtime.Serialization
Imports System.Threading
Imports System.Xml
Imports System.Xml.Schema
Imports System.Xml.Serialization
	<HelpKeyword("vs.data.DataSet"), XmlSchemaProvider("GetTypedDataSetSchema"), DesignerCategory("code"), XmlRoot("dsCustomers"), ToolboxItem(True), Serializable()>
	Public Class dsCustomers
		Inherits DataSet

		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		Private tableDataTable1 As dsCustomers.DataTable1DataTable

		Private _schemaSerializationMode As SchemaSerializationMode
		Shared Sub New()
		End Sub
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = dsCustomers.__ENCList
			Dim flag As Boolean = False
			Try
				Monitor.Enter(_ENCList, flag)
				Dim flag2 As Boolean = dsCustomers.__ENCList.Count = dsCustomers.__ENCList.Capacity
				If flag2 Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = dsCustomers.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit While
						End If
						Dim weakReference As WeakReference = dsCustomers.__ENCList(num4)
						flag2 = weakReference.IsAlive
						If flag2 Then
							Dim flag3 As Boolean = num4 <> num
							If flag3 Then
								dsCustomers.__ENCList(num) = dsCustomers.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					dsCustomers.__ENCList.RemoveRange(num, dsCustomers.__ENCList.Count - num)
					dsCustomers.__ENCList.Capacity = dsCustomers.__ENCList.Count
				End If
				dsCustomers.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			Finally
				Dim flag3 As Boolean = flag
				If flag3 Then
					Monitor.[Exit](_ENCList)
				End If
			End Try
		End Sub

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
		Public Sub New()
			dsCustomers.__ENCAddToList(Me)
			Me._schemaSerializationMode = SchemaSerializationMode.IncludeSchema
			Me.BeginInit()
			Me.InitClass()
			Dim value As CollectionChangeEventHandler = AddressOf Me.SchemaChanged
			AddHandler MyBase.Tables.CollectionChanged, value
			AddHandler MyBase.Relations.CollectionChanged, value
			Me.EndInit()
		End Sub

		<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
		Protected Sub New(info As SerializationInfo, context As StreamingContext)
			MyBase.New(info, context, False)
			dsCustomers.__ENCAddToList(Me)
			Me._schemaSerializationMode = SchemaSerializationMode.IncludeSchema
			Dim flag As Boolean = Me.IsBinarySerialized(info, context)
			If flag Then
				Me.InitVars(False)
				Dim value As CollectionChangeEventHandler = AddressOf Me.SchemaChanged
				AddHandler Me.Tables.CollectionChanged, value
				AddHandler Me.Relations.CollectionChanged, value
			Else
				Dim s As String = Conversions.ToString(info.GetValue("XmlSchema", GetType(String)))
				flag = (Me.DetermineSchemaSerializationMode(info, context) = SchemaSerializationMode.IncludeSchema)
				If flag Then
					Dim dataSet As DataSet = New DataSet()
					dataSet.ReadXmlSchema(New XmlTextReader(New StringReader(s)))
					flag = (dataSet.Tables("DataTable1") IsNot Nothing)
					If flag Then
						MyBase.Tables.Add(New dsCustomers.DataTable1DataTable(dataSet.Tables("DataTable1")))
					End If
					Me.DataSetName = dataSet.DataSetName
					Me.Prefix = dataSet.Prefix
					Me.[Namespace] = dataSet.[Namespace]
					Me.Locale = dataSet.Locale
					Me.CaseSensitive = dataSet.CaseSensitive
					Me.EnforceConstraints = dataSet.EnforceConstraints
					Me.Merge(dataSet, False, MissingSchemaAction.Add)
					Me.InitVars()
				Else
					Me.ReadXmlSchema(New XmlTextReader(New StringReader(s)))
				End If
				Me.GetSerializationData(info, context)
				Dim value2 As CollectionChangeEventHandler = AddressOf Me.SchemaChanged
				AddHandler MyBase.Tables.CollectionChanged, value2
				AddHandler Me.Relations.CollectionChanged, value2
			End If
		End Sub

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode(), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), Browsable(False)>
		Public ReadOnly Property DataTable1 As dsCustomers.DataTable1DataTable
			Get
				Return Me.tableDataTable1
			End Get
		End Property

		<DebuggerNonUserCode(), DesignerSerializationVisibility(DesignerSerializationVisibility.Visible), Browsable(True), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
		Public Overrides Property SchemaSerializationMode As SchemaSerializationMode
			Get
				Return Me._schemaSerializationMode
			End Get
			Set(value As SchemaSerializationMode)
				Me._schemaSerializationMode = value
			End Set
		End Property

		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
		Public ReadOnly Property Tables As DataTableCollection
			Get
				Return MyBase.Tables
			End Get
		End Property

		<DebuggerNonUserCode(), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
		Public ReadOnly Property Relations As DataRelationCollection
			Get
				Return MyBase.Relations
			End Get
		End Property

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
		Protected Overrides Sub InitializeDerivedDataSet()
			Me.BeginInit()
			Me.InitClass()
			Me.EndInit()
		End Sub

		<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
		Public Overrides Function Clone() As DataSet
			Dim dsCustomers As dsCustomers = CType(MyBase.Clone(), dsCustomers)
			dsCustomers.InitVars()
			dsCustomers.SchemaSerializationMode = Me.SchemaSerializationMode
			Return dsCustomers
		End Function

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
		Protected Overrides Function ShouldSerializeTables() As Boolean
			Return False
		End Function

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
		Protected Overrides Function ShouldSerializeRelations() As Boolean
			Return False
		End Function

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
		Protected Overrides Sub ReadXmlSerializable(reader As XmlReader)
			Dim flag As Boolean = Me.DetermineSchemaSerializationMode(reader) = SchemaSerializationMode.IncludeSchema
			If flag Then
				Me.Reset()
				Dim dataSet As DataSet = New DataSet()
				dataSet.ReadXml(reader)
				flag = (dataSet.Tables("DataTable1") IsNot Nothing)
				If flag Then
					MyBase.Tables.Add(New dsCustomers.DataTable1DataTable(dataSet.Tables("DataTable1")))
				End If
				Me.DataSetName = dataSet.DataSetName
				Me.Prefix = dataSet.Prefix
				Me.[Namespace] = dataSet.[Namespace]
				Me.Locale = dataSet.Locale
				Me.CaseSensitive = dataSet.CaseSensitive
				Me.EnforceConstraints = dataSet.EnforceConstraints
				Me.Merge(dataSet, False, MissingSchemaAction.Add)
				Me.InitVars()
			Else
				Me.ReadXml(reader)
				Me.InitVars()
			End If
		End Sub

		<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
		Protected Overrides Function GetSchemaSerializable() As XmlSchema
			Dim memoryStream As MemoryStream = New MemoryStream()
			Me.WriteXmlSchema(New XmlTextWriter(memoryStream, Nothing))
			memoryStream.Position = 0L
			Return XmlSchema.Read(New XmlTextReader(memoryStream), Nothing)
		End Function

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
		Friend Sub InitVars()
			Me.InitVars(True)
		End Sub

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
		Friend Sub InitVars(initTable As Boolean)
			Me.tableDataTable1 = CType(MyBase.Tables("DataTable1"), dsCustomers.DataTable1DataTable)
			If initTable Then
				Dim flag As Boolean = Me.tableDataTable1 IsNot Nothing
				If flag Then
					Me.tableDataTable1.InitVars()
				End If
			End If
		End Sub

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
		Private Sub InitClass()
			Me.DataSetName = "dsCustomers"
			Me.Prefix = ""
			Me.[Namespace] = "http://tempuri.org/dsCustomers.xsd"
			Me.EnforceConstraints = True
			Me.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema
			Me.tableDataTable1 = New dsCustomers.DataTable1DataTable()
			MyBase.Tables.Add(Me.tableDataTable1)
		End Sub

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
		Private Function ShouldSerializeDataTable1() As Boolean
			Return False
		End Function

		<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
		Private Sub SchemaChanged(sender As Object, e As CollectionChangeEventArgs)
			Dim flag As Boolean = e.Action = CollectionChangeAction.Remove
			If flag Then
				Me.InitVars()
			End If
		End Sub

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
		Public Shared Function GetTypedDataSetSchema(xs As XmlSchemaSet) As XmlSchemaComplexType
			Dim dsCustomers As dsCustomers = New dsCustomers()
			Dim xmlSchemaComplexType As XmlSchemaComplexType = New XmlSchemaComplexType()
			Dim xmlSchemaSequence As XmlSchemaSequence = New XmlSchemaSequence()
			Dim xmlSchemaAny As XmlSchemaAny = New XmlSchemaAny()
			xmlSchemaAny.[Namespace] = dsCustomers.[Namespace]
			xmlSchemaSequence.Items.Add(xmlSchemaAny)
			xmlSchemaComplexType.Particle = xmlSchemaSequence
			Dim schemaSerializable As XmlSchema = dsCustomers.GetSchemaSerializable()
			Dim flag As Boolean = xs.Contains(schemaSerializable.TargetNamespace)
			If flag Then
				Dim memoryStream As MemoryStream = New MemoryStream()
				Dim memoryStream2 As MemoryStream = New MemoryStream()
				Try
					schemaSerializable.Write(memoryStream)
					For Each obj As Object In xs.Schemas(schemaSerializable.TargetNamespace)
						Dim xmlSchema As XmlSchema = CType(obj, XmlSchema)
						memoryStream2.SetLength(0L)
						xmlSchema.Write(memoryStream2)
						flag = (memoryStream.Length = memoryStream2.Length)
						If flag Then
							memoryStream.Position = 0L
							memoryStream2.Position = 0L
							While memoryStream.Position <> memoryStream.Length AndAlso memoryStream.ReadByte() = memoryStream2.ReadByte()
							End While
							flag = (memoryStream.Position = memoryStream.Length)
							If flag Then
								Return xmlSchemaComplexType
							End If
						End If
					Next
				Finally
					flag = (memoryStream IsNot Nothing)
					If flag Then
						memoryStream.Close()
					End If
					flag = (memoryStream2 IsNot Nothing)
					If flag Then
						memoryStream2.Close()
					End If
				End Try
			End If
			xs.Add(schemaSerializable)
			Return xmlSchemaComplexType
		End Function

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
		Public Delegate Sub DataTable1RowChangeEventHandler(sender As Object, e As dsCustomers.DataTable1RowChangeEvent)

		<XmlSchemaProvider("GetTypedTableSchema"), Serializable()>
		Public Class DataTable1DataTable
			Inherits TypedTableBase(Of dsCustomers.DataTable1Row)

			Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

			Private columnname As DataColumn

			Private columnID As DataColumn

			Private columntel As DataColumn

			Private columnmobile As DataColumn

			Private columncountry As DataColumn

			Private columncity As DataColumn

			Private columnarea As DataColumn

			Private columnact As DataColumn

			Private columnDataColumn1 As DataColumn
			Shared Sub New()
			End Sub
			Private Shared Sub __ENCAddToList(value As Object)
				Dim _ENCList As List(Of WeakReference) = dsCustomers.DataTable1DataTable.__ENCList
				Dim flag As Boolean = False
				Try
					Monitor.Enter(_ENCList, flag)
					Dim flag2 As Boolean = dsCustomers.DataTable1DataTable.__ENCList.Count = dsCustomers.DataTable1DataTable.__ENCList.Capacity
					If flag2 Then
						Dim num As Integer = 0
						Dim num2 As Integer = 0
						Dim num3 As Integer = dsCustomers.DataTable1DataTable.__ENCList.Count - 1
						Dim num4 As Integer = num2
						While True
							Dim num5 As Integer = num4
							Dim num6 As Integer = num3
							If num5 > num6 Then
								Exit While
							End If
							Dim weakReference As WeakReference = dsCustomers.DataTable1DataTable.__ENCList(num4)
							flag2 = weakReference.IsAlive
							If flag2 Then
								Dim flag3 As Boolean = num4 <> num
								If flag3 Then
									dsCustomers.DataTable1DataTable.__ENCList(num) = dsCustomers.DataTable1DataTable.__ENCList(num4)
								End If
								num += 1
							End If
							num4 += 1
						End While
						dsCustomers.DataTable1DataTable.__ENCList.RemoveRange(num, dsCustomers.DataTable1DataTable.__ENCList.Count - num)
						dsCustomers.DataTable1DataTable.__ENCList.Capacity = dsCustomers.DataTable1DataTable.__ENCList.Count
					End If
					dsCustomers.DataTable1DataTable.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
				Finally
					Dim flag3 As Boolean = flag
					If flag3 Then
						Monitor.[Exit](_ENCList)
					End If
				End Try
			End Sub

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Sub New()
				dsCustomers.DataTable1DataTable.__ENCAddToList(Me)
				Me.TableName = "DataTable1"
				Me.BeginInit()
				Me.InitClass()
				Me.EndInit()
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Friend Sub New(table As DataTable)
				dsCustomers.DataTable1DataTable.__ENCAddToList(Me)
				Me.TableName = table.TableName
				Dim flag As Boolean = table.CaseSensitive <> table.DataSet.CaseSensitive
				If flag Then
					Me.CaseSensitive = table.CaseSensitive
				End If
				flag = (Operators.CompareString(table.Locale.ToString(), table.DataSet.Locale.ToString(), False) <> 0)
				If flag Then
					Me.Locale = table.Locale
				End If
				flag = (Operators.CompareString(table.[Namespace], table.DataSet.[Namespace], False) <> 0)
				If flag Then
					Me.[Namespace] = table.[Namespace]
				End If
				Me.Prefix = table.Prefix
				Me.MinimumCapacity = table.MinimumCapacity
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Sub New(info As SerializationInfo, context As StreamingContext)
				MyBase.New(info, context)
				dsCustomers.DataTable1DataTable.__ENCAddToList(Me)
				Me.InitVars()
			End Sub

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public ReadOnly Property nameColumn As DataColumn
				Get
					Return Me.columnname
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property IDColumn As DataColumn
				Get
					Return Me.columnID
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property telColumn As DataColumn
				Get
					Return Me.columntel
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property mobileColumn As DataColumn
				Get
					Return Me.columnmobile
				End Get
			End Property

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public ReadOnly Property countryColumn As DataColumn
				Get
					Return Me.columncountry
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property cityColumn As DataColumn
				Get
					Return Me.columncity
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property areaColumn As DataColumn
				Get
					Return Me.columnarea
				End Get
			End Property

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public ReadOnly Property actColumn As DataColumn
				Get
					Return Me.columnact
				End Get
			End Property

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public ReadOnly Property DataColumn1Column As DataColumn
				Get
					Return Me.columnDataColumn1
				End Get
			End Property

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Browsable(False)>
			Public ReadOnly Property Count As Integer
				Get
					Return Me.Rows.Count
				End Get
			End Property

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public ReadOnly Default Property Item(index As Integer) As dsCustomers.DataTable1Row
				Get
					Return CType(Me.Rows(index), dsCustomers.DataTable1Row)
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Event DataTable1RowChanging As dsCustomers.DataTable1RowChangeEventHandler

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Event DataTable1RowChanged As dsCustomers.DataTable1RowChangeEventHandler

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Event DataTable1RowDeleting As dsCustomers.DataTable1RowChangeEventHandler

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Event DataTable1RowDeleted As dsCustomers.DataTable1RowChangeEventHandler

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub AddDataTable1Row(row As dsCustomers.DataTable1Row)
				Me.Rows.Add(row)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function AddDataTable1Row(name As String, ID As String, tel As String, mobile As String, country As String, city As String, area As String, act As String, DataColumn1 As String) As dsCustomers.DataTable1Row
				Dim dataTable1Row As dsCustomers.DataTable1Row = CType(Me.NewRow(), dsCustomers.DataTable1Row)
				Dim itemArray As Object() = New Object() { name, ID, tel, mobile, country, city, area, act, DataColumn1 }
				dataTable1Row.ItemArray = itemArray
				Me.Rows.Add(dataTable1Row)
				Return dataTable1Row
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Overrides Function Clone() As DataTable
				Dim dataTable1DataTable As dsCustomers.DataTable1DataTable = CType(MyBase.Clone(), dsCustomers.DataTable1DataTable)
				dataTable1DataTable.InitVars()
				Return dataTable1DataTable
			End Function

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Protected Overrides Function CreateInstance() As DataTable
				Return New dsCustomers.DataTable1DataTable()
			End Function

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Friend Sub InitVars()
				Me.columnname = MyBase.Columns("name")
				Me.columnID = MyBase.Columns("ID")
				Me.columntel = MyBase.Columns("tel")
				Me.columnmobile = MyBase.Columns("mobile")
				Me.columncountry = MyBase.Columns("country")
				Me.columncity = MyBase.Columns("city")
				Me.columnarea = MyBase.Columns("area")
				Me.columnact = MyBase.Columns("act")
				Me.columnDataColumn1 = MyBase.Columns("DataColumn1")
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Private Sub InitClass()
				Me.columnname = New DataColumn("name", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnname)
				Me.columnID = New DataColumn("ID", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnID)
				Me.columntel = New DataColumn("tel", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columntel)
				Me.columnmobile = New DataColumn("mobile", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnmobile)
				Me.columncountry = New DataColumn("country", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columncountry)
				Me.columncity = New DataColumn("city", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columncity)
				Me.columnarea = New DataColumn("area", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnarea)
				Me.columnact = New DataColumn("act", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnact)
				Me.columnDataColumn1 = New DataColumn("DataColumn1", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnDataColumn1)
				Me.columnname.Caption = "DataColumn1"
				Me.columnID.Caption = "DataColumn1"
				Me.columntel.Caption = "DataColumn1"
				Me.columnmobile.Caption = "DataColumn1"
				Me.columncountry.Caption = "DataColumn1"
				Me.columncity.Caption = "DataColumn1"
				Me.columnarea.Caption = "DataColumn1"
				Me.columnact.Caption = "DataColumn1"
			End Sub

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Function NewDataTable1Row() As dsCustomers.DataTable1Row
				Return CType(Me.NewRow(), dsCustomers.DataTable1Row)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Overrides Function NewRowFromBuilder(builder As DataRowBuilder) As DataRow
				Return New dsCustomers.DataTable1Row(builder)
			End Function

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Protected Overrides Function GetRowType() As Type
				Return GetType(dsCustomers.DataTable1Row)
			End Function

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Protected Overrides Sub OnRowChanged(e As DataRowChangeEventArgs)
				MyBase.OnRowChanged(e)
				Dim flag As Boolean = Me.DataTable1RowChangedEvent IsNot Nothing
				If flag Then
					Dim dataTable1RowChangedEvent As dsCustomers.DataTable1RowChangeEventHandler = Me.DataTable1RowChangedEvent
					flag = (dataTable1RowChangedEvent IsNot Nothing)
					If flag Then
						dataTable1RowChangedEvent(Me, New dsCustomers.DataTable1RowChangeEvent(CType(e.Row, dsCustomers.DataTable1Row), e.Action))
					End If
				End If
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Overrides Sub OnRowChanging(e As DataRowChangeEventArgs)
				MyBase.OnRowChanging(e)
				Dim flag As Boolean = Me.DataTable1RowChangingEvent IsNot Nothing
				If flag Then
					Dim dataTable1RowChangingEvent As dsCustomers.DataTable1RowChangeEventHandler = Me.DataTable1RowChangingEvent
					flag = (dataTable1RowChangingEvent IsNot Nothing)
					If flag Then
						dataTable1RowChangingEvent(Me, New dsCustomers.DataTable1RowChangeEvent(CType(e.Row, dsCustomers.DataTable1Row), e.Action))
					End If
				End If
			End Sub

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Protected Overrides Sub OnRowDeleted(e As DataRowChangeEventArgs)
				MyBase.OnRowDeleted(e)
				Dim flag As Boolean = Me.DataTable1RowDeletedEvent IsNot Nothing
				If flag Then
					Dim dataTable1RowDeletedEvent As dsCustomers.DataTable1RowChangeEventHandler = Me.DataTable1RowDeletedEvent
					flag = (dataTable1RowDeletedEvent IsNot Nothing)
					If flag Then
						dataTable1RowDeletedEvent(Me, New dsCustomers.DataTable1RowChangeEvent(CType(e.Row, dsCustomers.DataTable1Row), e.Action))
					End If
				End If
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Overrides Sub OnRowDeleting(e As DataRowChangeEventArgs)
				MyBase.OnRowDeleting(e)
				Dim flag As Boolean = Me.DataTable1RowDeletingEvent IsNot Nothing
				If flag Then
					Dim dataTable1RowDeletingEvent As dsCustomers.DataTable1RowChangeEventHandler = Me.DataTable1RowDeletingEvent
					flag = (dataTable1RowDeletingEvent IsNot Nothing)
					If flag Then
						dataTable1RowDeletingEvent(Me, New dsCustomers.DataTable1RowChangeEvent(CType(e.Row, dsCustomers.DataTable1Row), e.Action))
					End If
				End If
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub RemoveDataTable1Row(row As dsCustomers.DataTable1Row)
				Me.Rows.Remove(row)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Shared Function GetTypedTableSchema(xs As XmlSchemaSet) As XmlSchemaComplexType
				Dim xmlSchemaComplexType As XmlSchemaComplexType = New XmlSchemaComplexType()
				Dim xmlSchemaSequence As XmlSchemaSequence = New XmlSchemaSequence()
				Dim dsCustomers As dsCustomers = New dsCustomers()
				Dim xmlSchemaAny As XmlSchemaAny = New XmlSchemaAny()
				xmlSchemaAny.[Namespace] = "http://www.w3.org/2001/XMLSchema"
				Dim xmlSchemaParticle As XmlSchemaParticle = xmlSchemaAny
				Dim minOccurs As Decimal = 0D
				xmlSchemaParticle.MinOccurs = minOccurs
				xmlSchemaAny.MaxOccurs = Decimal.MaxValue
				xmlSchemaAny.ProcessContents = XmlSchemaContentProcessing.Lax
				xmlSchemaSequence.Items.Add(xmlSchemaAny)
				Dim xmlSchemaAny2 As XmlSchemaAny = New XmlSchemaAny()
				xmlSchemaAny2.[Namespace] = "urn:schemas-microsoft-com:xml-diffgram-v1"
				Dim xmlSchemaParticle2 As XmlSchemaParticle = xmlSchemaAny2
				minOccurs = 1D
				xmlSchemaParticle2.MinOccurs = minOccurs
				xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax
				xmlSchemaSequence.Items.Add(xmlSchemaAny2)
				Dim xmlSchemaAttribute As XmlSchemaAttribute = New XmlSchemaAttribute()
				xmlSchemaAttribute.Name = "namespace"
				xmlSchemaAttribute.FixedValue = dsCustomers.[Namespace]
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute)
				Dim xmlSchemaAttribute2 As XmlSchemaAttribute = New XmlSchemaAttribute()
				xmlSchemaAttribute2.Name = "tableTypeName"
				xmlSchemaAttribute2.FixedValue = "DataTable1DataTable"
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2)
				xmlSchemaComplexType.Particle = xmlSchemaSequence
				Dim schemaSerializable As XmlSchema = dsCustomers.GetSchemaSerializable()
				Dim flag As Boolean = xs.Contains(schemaSerializable.TargetNamespace)
				If flag Then
					Dim memoryStream As MemoryStream = New MemoryStream()
					Dim memoryStream2 As MemoryStream = New MemoryStream()
					Try
						schemaSerializable.Write(memoryStream)
						For Each obj As Object In xs.Schemas(schemaSerializable.TargetNamespace)
							Dim xmlSchema As XmlSchema = CType(obj, XmlSchema)
							memoryStream2.SetLength(0L)
							xmlSchema.Write(memoryStream2)
							flag = (memoryStream.Length = memoryStream2.Length)
							If flag Then
								memoryStream.Position = 0L
								memoryStream2.Position = 0L
								While memoryStream.Position <> memoryStream.Length AndAlso memoryStream.ReadByte() = memoryStream2.ReadByte()
								End While
								flag = (memoryStream.Position = memoryStream.Length)
								If flag Then
									Return xmlSchemaComplexType
								End If
							End If
						Next
					Finally
						flag = (memoryStream IsNot Nothing)
						If flag Then
							memoryStream.Close()
						End If
						flag = (memoryStream2 IsNot Nothing)
						If flag Then
							memoryStream2.Close()
						End If
					End Try
				End If
				xs.Add(schemaSerializable)
				Return xmlSchemaComplexType
			End Function
		End Class

		Public Class DataTable1Row
			Inherits DataRow

			Private tableDataTable1 As dsCustomers.DataTable1DataTable

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Friend Sub New(rb As DataRowBuilder)
				MyBase.New(rb)
				Me.tableDataTable1 = CType(Me.Table, dsCustomers.DataTable1DataTable)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Property name As String
				Get
					Dim result As String
					Try
						result = Conversions.ToString(Me(Me.tableDataTable1.nameColumn))
					Catch innerException As InvalidCastException
						Throw New StrongTypingException("The value for column 'name' in table 'DataTable1' is DBNull.", innerException)
					End Try
					Return result
				End Get
				Set(value As String)
					Me(Me.tableDataTable1.nameColumn) = value
				End Set
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Property ID As String
				Get
					Dim result As String
					Try
						result = Conversions.ToString(Me(Me.tableDataTable1.IDColumn))
					Catch innerException As InvalidCastException
						Throw New StrongTypingException("The value for column 'ID' in table 'DataTable1' is DBNull.", innerException)
					End Try
					Return result
				End Get
				Set(value As String)
					Me(Me.tableDataTable1.IDColumn) = value
				End Set
			End Property

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Property tel As String
				Get
					Dim result As String
					Try
						result = Conversions.ToString(Me(Me.tableDataTable1.telColumn))
					Catch innerException As InvalidCastException
						Throw New StrongTypingException("The value for column 'tel' in table 'DataTable1' is DBNull.", innerException)
					End Try
					Return result
				End Get
				Set(value As String)
					Me(Me.tableDataTable1.telColumn) = value
				End Set
			End Property

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Property mobile As String
				Get
					Dim result As String
					Try
						result = Conversions.ToString(Me(Me.tableDataTable1.mobileColumn))
					Catch innerException As InvalidCastException
						Throw New StrongTypingException("The value for column 'mobile' in table 'DataTable1' is DBNull.", innerException)
					End Try
					Return result
				End Get
				Set(value As String)
					Me(Me.tableDataTable1.mobileColumn) = value
				End Set
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Property country As String
				Get
					Dim result As String
					Try
						result = Conversions.ToString(Me(Me.tableDataTable1.countryColumn))
					Catch innerException As InvalidCastException
						Throw New StrongTypingException("The value for column 'country' in table 'DataTable1' is DBNull.", innerException)
					End Try
					Return result
				End Get
				Set(value As String)
					Me(Me.tableDataTable1.countryColumn) = value
				End Set
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Property city As String
				Get
					Dim result As String
					Try
						result = Conversions.ToString(Me(Me.tableDataTable1.cityColumn))
					Catch innerException As InvalidCastException
						Throw New StrongTypingException("The value for column 'city' in table 'DataTable1' is DBNull.", innerException)
					End Try
					Return result
				End Get
				Set(value As String)
					Me(Me.tableDataTable1.cityColumn) = value
				End Set
			End Property

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Property area As String
				Get
					Dim result As String
					Try
						result = Conversions.ToString(Me(Me.tableDataTable1.areaColumn))
					Catch innerException As InvalidCastException
						Throw New StrongTypingException("The value for column 'area' in table 'DataTable1' is DBNull.", innerException)
					End Try
					Return result
				End Get
				Set(value As String)
					Me(Me.tableDataTable1.areaColumn) = value
				End Set
			End Property

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Property act As String
				Get
					Dim result As String
					Try
						result = Conversions.ToString(Me(Me.tableDataTable1.actColumn))
					Catch innerException As InvalidCastException
						Throw New StrongTypingException("The value for column 'act' in table 'DataTable1' is DBNull.", innerException)
					End Try
					Return result
				End Get
				Set(value As String)
					Me(Me.tableDataTable1.actColumn) = value
				End Set
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Property DataColumn1 As String
				Get
					Dim result As String
					Try
						result = Conversions.ToString(Me(Me.tableDataTable1.DataColumn1Column))
					Catch innerException As InvalidCastException
						Throw New StrongTypingException("The value for column 'DataColumn1' in table 'DataTable1' is DBNull.", innerException)
					End Try
					Return result
				End Get
				Set(value As String)
					Me(Me.tableDataTable1.DataColumn1Column) = value
				End Set
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function IsnameNull() As Boolean
				Return Me.IsNull(Me.tableDataTable1.nameColumn)
			End Function

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Sub SetnameNull()
				Me(Me.tableDataTable1.nameColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function IsIDNull() As Boolean
				Return Me.IsNull(Me.tableDataTable1.IDColumn)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub SetIDNull()
				Me(Me.tableDataTable1.IDColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function IstelNull() As Boolean
				Return Me.IsNull(Me.tableDataTable1.telColumn)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub SettelNull()
				Me(Me.tableDataTable1.telColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Function IsmobileNull() As Boolean
				Return Me.IsNull(Me.tableDataTable1.mobileColumn)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub SetmobileNull()
				Me(Me.tableDataTable1.mobileColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Function IscountryNull() As Boolean
				Return Me.IsNull(Me.tableDataTable1.countryColumn)
			End Function

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Sub SetcountryNull()
				Me(Me.tableDataTable1.countryColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Function IscityNull() As Boolean
				Return Me.IsNull(Me.tableDataTable1.cityColumn)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub SetcityNull()
				Me(Me.tableDataTable1.cityColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function IsareaNull() As Boolean
				Return Me.IsNull(Me.tableDataTable1.areaColumn)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub SetareaNull()
				Me(Me.tableDataTable1.areaColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Function IsactNull() As Boolean
				Return Me.IsNull(Me.tableDataTable1.actColumn)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub SetactNull()
				Me(Me.tableDataTable1.actColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Function IsDataColumn1Null() As Boolean
				Return Me.IsNull(Me.tableDataTable1.DataColumn1Column)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub SetDataColumn1Null()
				Me(Me.tableDataTable1.DataColumn1Column) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub
		End Class

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
		Public Class DataTable1RowChangeEvent
			Inherits EventArgs

			Private eventRow As dsCustomers.DataTable1Row

			Private eventAction As DataRowAction

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub New(row As dsCustomers.DataTable1Row, action As DataRowAction)
				Me.eventRow = row
				Me.eventAction = action
			End Sub

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public ReadOnly Property Row As dsCustomers.DataTable1Row
				Get
					Return Me.eventRow
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property Action As DataRowAction
				Get
					Return Me.eventAction
				End Get
			End Property
		End Class
	End Class

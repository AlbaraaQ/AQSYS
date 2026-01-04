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
	<XmlSchemaProvider("GetTypedDataSetSchema"), DesignerCategory("code"), HelpKeyword("vs.data.DataSet"), XmlRoot("dsArba7Details"), ToolboxItem(True), Serializable()>
	Public Class dsArba7Details
		Inherits DataSet

		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		Private tableDataTable1 As dsArba7Details.DataTable1DataTable

		Private tableDataTable11 As dsArba7Details.DataTable11DataTable

		Private _schemaSerializationMode As SchemaSerializationMode
		Shared Sub New()
		End Sub
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = dsArba7Details.__ENCList
			Dim flag As Boolean = False
			Try
				Monitor.Enter(_ENCList, flag)
				Dim flag2 As Boolean = dsArba7Details.__ENCList.Count = dsArba7Details.__ENCList.Capacity
				If flag2 Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = dsArba7Details.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit While
						End If
						Dim weakReference As WeakReference = dsArba7Details.__ENCList(num4)
						flag2 = weakReference.IsAlive
						If flag2 Then
							Dim flag3 As Boolean = num4 <> num
							If flag3 Then
								dsArba7Details.__ENCList(num) = dsArba7Details.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					dsArba7Details.__ENCList.RemoveRange(num, dsArba7Details.__ENCList.Count - num)
					dsArba7Details.__ENCList.Capacity = dsArba7Details.__ENCList.Count
				End If
				dsArba7Details.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			Finally
				Dim flag3 As Boolean = flag
				If flag3 Then
					Monitor.[Exit](_ENCList)
				End If
			End Try
		End Sub

		<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
		Public Sub New()
			dsArba7Details.__ENCAddToList(Me)
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
			dsArba7Details.__ENCAddToList(Me)
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
						MyBase.Tables.Add(New dsArba7Details.DataTable1DataTable(dataSet.Tables("DataTable1")))
					End If
					flag = (dataSet.Tables("DataTable11") IsNot Nothing)
					If flag Then
						MyBase.Tables.Add(New dsArba7Details.DataTable11DataTable(dataSet.Tables("DataTable11")))
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

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), Browsable(False), DebuggerNonUserCode()>
		Public ReadOnly Property DataTable1 As dsArba7Details.DataTable1DataTable
			Get
				Return Me.tableDataTable1
			End Get
		End Property

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Browsable(False), DebuggerNonUserCode(), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)>
		Public ReadOnly Property DataTable11 As dsArba7Details.DataTable11DataTable
			Get
				Return Me.tableDataTable11
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

		<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		Public ReadOnly Property Tables As DataTableCollection
			Get
				Return MyBase.Tables
			End Get
		End Property

		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
		Public ReadOnly Property Relations As DataRelationCollection
			Get
				Return MyBase.Relations
			End Get
		End Property

		<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
		Protected Overrides Sub InitializeDerivedDataSet()
			Me.BeginInit()
			Me.InitClass()
			Me.EndInit()
		End Sub

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
		Public Overrides Function Clone() As DataSet
			Dim dsArba7Details As dsArba7Details = CType(MyBase.Clone(), dsArba7Details)
			dsArba7Details.InitVars()
			dsArba7Details.SchemaSerializationMode = Me.SchemaSerializationMode
			Return dsArba7Details
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
					MyBase.Tables.Add(New dsArba7Details.DataTable1DataTable(dataSet.Tables("DataTable1")))
				End If
				flag = (dataSet.Tables("DataTable11") IsNot Nothing)
				If flag Then
					MyBase.Tables.Add(New dsArba7Details.DataTable11DataTable(dataSet.Tables("DataTable11")))
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

		<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
		Friend Sub InitVars(initTable As Boolean)
			Me.tableDataTable1 = CType(MyBase.Tables("DataTable1"), dsArba7Details.DataTable1DataTable)
			If initTable Then
				Dim flag As Boolean = Me.tableDataTable1 IsNot Nothing
				If flag Then
					Me.tableDataTable1.InitVars()
				End If
			End If
			Me.tableDataTable11 = CType(MyBase.Tables("DataTable11"), dsArba7Details.DataTable11DataTable)
			If initTable Then
				Dim flag2 As Boolean = Me.tableDataTable11 IsNot Nothing
				If flag2 Then
					Me.tableDataTable11.InitVars()
				End If
			End If
		End Sub

		<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
		Private Sub InitClass()
			Me.DataSetName = "dsArba7Details"
			Me.Prefix = ""
			Me.[Namespace] = "http://tempuri.org/dsArba7Details.xsd"
			Me.EnforceConstraints = True
			Me.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema
			Me.tableDataTable1 = New dsArba7Details.DataTable1DataTable()
			MyBase.Tables.Add(Me.tableDataTable1)
			Me.tableDataTable11 = New dsArba7Details.DataTable11DataTable()
			MyBase.Tables.Add(Me.tableDataTable11)
		End Sub

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
		Private Function ShouldSerializeDataTable1() As Boolean
			Return False
		End Function

		<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
		Private Function ShouldSerializeDataTable11() As Boolean
			Return False
		End Function

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
		Private Sub SchemaChanged(sender As Object, e As CollectionChangeEventArgs)
			Dim flag As Boolean = e.Action = CollectionChangeAction.Remove
			If flag Then
				Me.InitVars()
			End If
		End Sub

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
		Public Shared Function GetTypedDataSetSchema(xs As XmlSchemaSet) As XmlSchemaComplexType
			Dim dsArba7Details As dsArba7Details = New dsArba7Details()
			Dim xmlSchemaComplexType As XmlSchemaComplexType = New XmlSchemaComplexType()
			Dim xmlSchemaSequence As XmlSchemaSequence = New XmlSchemaSequence()
			Dim xmlSchemaAny As XmlSchemaAny = New XmlSchemaAny()
			xmlSchemaAny.[Namespace] = dsArba7Details.[Namespace]
			xmlSchemaSequence.Items.Add(xmlSchemaAny)
			xmlSchemaComplexType.Particle = xmlSchemaSequence
			Dim schemaSerializable As XmlSchema = dsArba7Details.GetSchemaSerializable()
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
		Public Delegate Sub DataTable1RowChangeEventHandler(sender As Object, e As dsArba7Details.DataTable1RowChangeEvent)

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
		Public Delegate Sub DataTable11RowChangeEventHandler(sender As Object, e As dsArba7Details.DataTable11RowChangeEvent)

		<XmlSchemaProvider("GetTypedTableSchema"), Serializable()>
		Public Class DataTable1DataTable
			Inherits TypedTableBase(Of dsArba7Details.DataTable1Row)

			Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

			Private columncode As DataColumn

			Private columnname As DataColumn

			Private columndept1 As DataColumn

			Private columncredit1 As DataColumn

			Private columndept2 As DataColumn

			Private columncredit2 As DataColumn

			Private columnDataColumn11 As DataColumn

			Private columnDataColumn110 As DataColumn

			Private columnDataColumn19 As DataColumn

			Private columnDataColumn18 As DataColumn

			Private columnDataColumn17 As DataColumn

			Private columnDataColumn16 As DataColumn

			Private columnDataColumn15 As DataColumn

			Private columnDataColumn14 As DataColumn

			Private columnDataColumn13 As DataColumn

			Private columnDataColumn12 As DataColumn

			Private columnDataColumn1 As DataColumn
			Shared Sub New()
			End Sub
			Private Shared Sub __ENCAddToList(value As Object)
				Dim _ENCList As List(Of WeakReference) = dsArba7Details.DataTable1DataTable.__ENCList
				Dim flag As Boolean = False
				Try
					Monitor.Enter(_ENCList, flag)
					Dim flag2 As Boolean = dsArba7Details.DataTable1DataTable.__ENCList.Count = dsArba7Details.DataTable1DataTable.__ENCList.Capacity
					If flag2 Then
						Dim num As Integer = 0
						Dim num2 As Integer = 0
						Dim num3 As Integer = dsArba7Details.DataTable1DataTable.__ENCList.Count - 1
						Dim num4 As Integer = num2
						While True
							Dim num5 As Integer = num4
							Dim num6 As Integer = num3
							If num5 > num6 Then
								Exit While
							End If
							Dim weakReference As WeakReference = dsArba7Details.DataTable1DataTable.__ENCList(num4)
							flag2 = weakReference.IsAlive
							If flag2 Then
								Dim flag3 As Boolean = num4 <> num
								If flag3 Then
									dsArba7Details.DataTable1DataTable.__ENCList(num) = dsArba7Details.DataTable1DataTable.__ENCList(num4)
								End If
								num += 1
							End If
							num4 += 1
						End While
						dsArba7Details.DataTable1DataTable.__ENCList.RemoveRange(num, dsArba7Details.DataTable1DataTable.__ENCList.Count - num)
						dsArba7Details.DataTable1DataTable.__ENCList.Capacity = dsArba7Details.DataTable1DataTable.__ENCList.Count
					End If
					dsArba7Details.DataTable1DataTable.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
				Finally
					Dim flag3 As Boolean = flag
					If flag3 Then
						Monitor.[Exit](_ENCList)
					End If
				End Try
			End Sub

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Sub New()
				dsArba7Details.DataTable1DataTable.__ENCAddToList(Me)
				Me.TableName = "DataTable1"
				Me.BeginInit()
				Me.InitClass()
				Me.EndInit()
			End Sub

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Friend Sub New(table As DataTable)
				dsArba7Details.DataTable1DataTable.__ENCAddToList(Me)
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

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Protected Sub New(info As SerializationInfo, context As StreamingContext)
				MyBase.New(info, context)
				dsArba7Details.DataTable1DataTable.__ENCAddToList(Me)
				Me.InitVars()
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property codeColumn As DataColumn
				Get
					Return Me.columncode
				End Get
			End Property

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public ReadOnly Property nameColumn As DataColumn
				Get
					Return Me.columnname
				End Get
			End Property

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public ReadOnly Property dept1Column As DataColumn
				Get
					Return Me.columndept1
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property credit1Column As DataColumn
				Get
					Return Me.columncredit1
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property dept2Column As DataColumn
				Get
					Return Me.columndept2
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property credit2Column As DataColumn
				Get
					Return Me.columncredit2
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property DataColumn11Column As DataColumn
				Get
					Return Me.columnDataColumn11
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property DataColumn110Column As DataColumn
				Get
					Return Me.columnDataColumn110
				End Get
			End Property

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public ReadOnly Property DataColumn19Column As DataColumn
				Get
					Return Me.columnDataColumn19
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property DataColumn18Column As DataColumn
				Get
					Return Me.columnDataColumn18
				End Get
			End Property

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public ReadOnly Property DataColumn17Column As DataColumn
				Get
					Return Me.columnDataColumn17
				End Get
			End Property

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public ReadOnly Property DataColumn16Column As DataColumn
				Get
					Return Me.columnDataColumn16
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property DataColumn15Column As DataColumn
				Get
					Return Me.columnDataColumn15
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property DataColumn14Column As DataColumn
				Get
					Return Me.columnDataColumn14
				End Get
			End Property

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public ReadOnly Property DataColumn13Column As DataColumn
				Get
					Return Me.columnDataColumn13
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property DataColumn12Column As DataColumn
				Get
					Return Me.columnDataColumn12
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property DataColumn1Column As DataColumn
				Get
					Return Me.columnDataColumn1
				End Get
			End Property

			<Browsable(False), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property Count As Integer
				Get
					Return Me.Rows.Count
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Default Property Item(index As Integer) As dsArba7Details.DataTable1Row
				Get
					Return CType(Me.Rows(index), dsArba7Details.DataTable1Row)
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Event DataTable1RowChanging As dsArba7Details.DataTable1RowChangeEventHandler

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Event DataTable1RowChanged As dsArba7Details.DataTable1RowChangeEventHandler

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Event DataTable1RowDeleting As dsArba7Details.DataTable1RowChangeEventHandler

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Event DataTable1RowDeleted As dsArba7Details.DataTable1RowChangeEventHandler

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Sub AddDataTable1Row(row As dsArba7Details.DataTable1Row)
				Me.Rows.Add(row)
			End Sub

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Function AddDataTable1Row(code As String, name As String, dept1 As String, credit1 As String, dept2 As String, credit2 As String, DataColumn11 As String, DataColumn110 As String, DataColumn19 As String, DataColumn18 As String, DataColumn17 As String, DataColumn16 As String, DataColumn15 As String, DataColumn14 As String, DataColumn13 As String, DataColumn12 As String, DataColumn1 As String) As dsArba7Details.DataTable1Row
				Dim dataTable1Row As dsArba7Details.DataTable1Row = CType(Me.NewRow(), dsArba7Details.DataTable1Row)
				Dim itemArray As Object() = New Object() { code, name, dept1, credit1, dept2, credit2, DataColumn11, DataColumn110, DataColumn19, DataColumn18, DataColumn17, DataColumn16, DataColumn15, DataColumn14, DataColumn13, DataColumn12, DataColumn1 }
				dataTable1Row.ItemArray = itemArray
				Me.Rows.Add(dataTable1Row)
				Return dataTable1Row
			End Function

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Overrides Function Clone() As DataTable
				Dim dataTable1DataTable As dsArba7Details.DataTable1DataTable = CType(MyBase.Clone(), dsArba7Details.DataTable1DataTable)
				dataTable1DataTable.InitVars()
				Return dataTable1DataTable
			End Function

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Protected Overrides Function CreateInstance() As DataTable
				Return New dsArba7Details.DataTable1DataTable()
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Friend Sub InitVars()
				Me.columncode = MyBase.Columns("code")
				Me.columnname = MyBase.Columns("name")
				Me.columndept1 = MyBase.Columns("dept1")
				Me.columncredit1 = MyBase.Columns("credit1")
				Me.columndept2 = MyBase.Columns("dept2")
				Me.columncredit2 = MyBase.Columns("credit2")
				Me.columnDataColumn11 = MyBase.Columns("DataColumn11")
				Me.columnDataColumn110 = MyBase.Columns("DataColumn110")
				Me.columnDataColumn19 = MyBase.Columns("DataColumn19")
				Me.columnDataColumn18 = MyBase.Columns("DataColumn18")
				Me.columnDataColumn17 = MyBase.Columns("DataColumn17")
				Me.columnDataColumn16 = MyBase.Columns("DataColumn16")
				Me.columnDataColumn15 = MyBase.Columns("DataColumn15")
				Me.columnDataColumn14 = MyBase.Columns("DataColumn14")
				Me.columnDataColumn13 = MyBase.Columns("DataColumn13")
				Me.columnDataColumn12 = MyBase.Columns("DataColumn12")
				Me.columnDataColumn1 = MyBase.Columns("DataColumn1")
			End Sub

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Private Sub InitClass()
				Me.columncode = New DataColumn("code", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columncode)
				Me.columnname = New DataColumn("name", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnname)
				Me.columndept1 = New DataColumn("dept1", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columndept1)
				Me.columncredit1 = New DataColumn("credit1", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columncredit1)
				Me.columndept2 = New DataColumn("dept2", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columndept2)
				Me.columncredit2 = New DataColumn("credit2", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columncredit2)
				Me.columnDataColumn11 = New DataColumn("DataColumn11", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnDataColumn11)
				Me.columnDataColumn110 = New DataColumn("DataColumn110", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnDataColumn110)
				Me.columnDataColumn19 = New DataColumn("DataColumn19", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnDataColumn19)
				Me.columnDataColumn18 = New DataColumn("DataColumn18", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnDataColumn18)
				Me.columnDataColumn17 = New DataColumn("DataColumn17", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnDataColumn17)
				Me.columnDataColumn16 = New DataColumn("DataColumn16", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnDataColumn16)
				Me.columnDataColumn15 = New DataColumn("DataColumn15", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnDataColumn15)
				Me.columnDataColumn14 = New DataColumn("DataColumn14", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnDataColumn14)
				Me.columnDataColumn13 = New DataColumn("DataColumn13", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnDataColumn13)
				Me.columnDataColumn12 = New DataColumn("DataColumn12", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnDataColumn12)
				Me.columnDataColumn1 = New DataColumn("DataColumn1", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnDataColumn1)
				Me.columncode.Caption = "DataColumn1"
				Me.columnname.Caption = "DataColumn1"
				Me.columndept1.Caption = "DataColumn1"
				Me.columncredit1.Caption = "DataColumn1"
				Me.columndept2.Caption = "DataColumn1"
				Me.columncredit2.Caption = "DataColumn1"
				Me.columnDataColumn11.Caption = "DataColumn1"
				Me.columnDataColumn110.Caption = "DataColumn1"
				Me.columnDataColumn19.Caption = "DataColumn1"
				Me.columnDataColumn18.Caption = "DataColumn1"
				Me.columnDataColumn17.Caption = "DataColumn1"
				Me.columnDataColumn16.Caption = "DataColumn1"
				Me.columnDataColumn15.Caption = "DataColumn1"
				Me.columnDataColumn14.Caption = "DataColumn1"
				Me.columnDataColumn13.Caption = "DataColumn1"
				Me.columnDataColumn12.Caption = "DataColumn1"
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function NewDataTable1Row() As dsArba7Details.DataTable1Row
				Return CType(Me.NewRow(), dsArba7Details.DataTable1Row)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Overrides Function NewRowFromBuilder(builder As DataRowBuilder) As DataRow
				Return New dsArba7Details.DataTable1Row(builder)
			End Function

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Protected Overrides Function GetRowType() As Type
				Return GetType(dsArba7Details.DataTable1Row)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Overrides Sub OnRowChanged(e As DataRowChangeEventArgs)
				MyBase.OnRowChanged(e)
				Dim flag As Boolean = Me.DataTable1RowChangedEvent IsNot Nothing
				If flag Then
					Dim dataTable1RowChangedEvent As dsArba7Details.DataTable1RowChangeEventHandler = Me.DataTable1RowChangedEvent
					flag = (dataTable1RowChangedEvent IsNot Nothing)
					If flag Then
						dataTable1RowChangedEvent(Me, New dsArba7Details.DataTable1RowChangeEvent(CType(e.Row, dsArba7Details.DataTable1Row), e.Action))
					End If
				End If
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Overrides Sub OnRowChanging(e As DataRowChangeEventArgs)
				MyBase.OnRowChanging(e)
				Dim flag As Boolean = Me.DataTable1RowChangingEvent IsNot Nothing
				If flag Then
					Dim dataTable1RowChangingEvent As dsArba7Details.DataTable1RowChangeEventHandler = Me.DataTable1RowChangingEvent
					flag = (dataTable1RowChangingEvent IsNot Nothing)
					If flag Then
						dataTable1RowChangingEvent(Me, New dsArba7Details.DataTable1RowChangeEvent(CType(e.Row, dsArba7Details.DataTable1Row), e.Action))
					End If
				End If
			End Sub

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Protected Overrides Sub OnRowDeleted(e As DataRowChangeEventArgs)
				MyBase.OnRowDeleted(e)
				Dim flag As Boolean = Me.DataTable1RowDeletedEvent IsNot Nothing
				If flag Then
					Dim dataTable1RowDeletedEvent As dsArba7Details.DataTable1RowChangeEventHandler = Me.DataTable1RowDeletedEvent
					flag = (dataTable1RowDeletedEvent IsNot Nothing)
					If flag Then
						dataTable1RowDeletedEvent(Me, New dsArba7Details.DataTable1RowChangeEvent(CType(e.Row, dsArba7Details.DataTable1Row), e.Action))
					End If
				End If
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Overrides Sub OnRowDeleting(e As DataRowChangeEventArgs)
				MyBase.OnRowDeleting(e)
				Dim flag As Boolean = Me.DataTable1RowDeletingEvent IsNot Nothing
				If flag Then
					Dim dataTable1RowDeletingEvent As dsArba7Details.DataTable1RowChangeEventHandler = Me.DataTable1RowDeletingEvent
					flag = (dataTable1RowDeletingEvent IsNot Nothing)
					If flag Then
						dataTable1RowDeletingEvent(Me, New dsArba7Details.DataTable1RowChangeEvent(CType(e.Row, dsArba7Details.DataTable1Row), e.Action))
					End If
				End If
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub RemoveDataTable1Row(row As dsArba7Details.DataTable1Row)
				Me.Rows.Remove(row)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Shared Function GetTypedTableSchema(xs As XmlSchemaSet) As XmlSchemaComplexType
				Dim xmlSchemaComplexType As XmlSchemaComplexType = New XmlSchemaComplexType()
				Dim xmlSchemaSequence As XmlSchemaSequence = New XmlSchemaSequence()
				Dim dsArba7Details As dsArba7Details = New dsArba7Details()
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
				xmlSchemaAttribute.FixedValue = dsArba7Details.[Namespace]
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute)
				Dim xmlSchemaAttribute2 As XmlSchemaAttribute = New XmlSchemaAttribute()
				xmlSchemaAttribute2.Name = "tableTypeName"
				xmlSchemaAttribute2.FixedValue = "DataTable1DataTable"
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2)
				xmlSchemaComplexType.Particle = xmlSchemaSequence
				Dim schemaSerializable As XmlSchema = dsArba7Details.GetSchemaSerializable()
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

		<XmlSchemaProvider("GetTypedTableSchema"), Serializable()>
		Public Class DataTable11DataTable
			Inherits TypedTableBase(Of dsArba7Details.DataTable11Row)

			Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

			Private columncode As DataColumn

			Private columnname As DataColumn

			Private columndept1 As DataColumn

			Private columncredit1 As DataColumn

			Private columndept2 As DataColumn

			Private columncredit2 As DataColumn

			Private columnDataColumn11 As DataColumn

			Private columnDataColumn112 As DataColumn

			Private columnDataColumn111 As DataColumn

			Private columnDataColumn110 As DataColumn

			Private columnDataColumn19 As DataColumn

			Private columnDataColumn18 As DataColumn

			Private columnDataColumn17 As DataColumn

			Private columnDataColumn16 As DataColumn

			Private columnDataColumn15 As DataColumn

			Private columnDataColumn14 As DataColumn

			Private columnDataColumn13 As DataColumn

			Private columnDataColumn12 As DataColumn

			Private columnDataColumn1 As DataColumn
			Shared Sub New()
			End Sub
			Private Shared Sub __ENCAddToList(value As Object)
				Dim _ENCList As List(Of WeakReference) = dsArba7Details.DataTable11DataTable.__ENCList
				Dim flag As Boolean = False
				Try
					Monitor.Enter(_ENCList, flag)
					Dim flag2 As Boolean = dsArba7Details.DataTable11DataTable.__ENCList.Count = dsArba7Details.DataTable11DataTable.__ENCList.Capacity
					If flag2 Then
						Dim num As Integer = 0
						Dim num2 As Integer = 0
						Dim num3 As Integer = dsArba7Details.DataTable11DataTable.__ENCList.Count - 1
						Dim num4 As Integer = num2
						While True
							Dim num5 As Integer = num4
							Dim num6 As Integer = num3
							If num5 > num6 Then
								Exit While
							End If
							Dim weakReference As WeakReference = dsArba7Details.DataTable11DataTable.__ENCList(num4)
							flag2 = weakReference.IsAlive
							If flag2 Then
								Dim flag3 As Boolean = num4 <> num
								If flag3 Then
									dsArba7Details.DataTable11DataTable.__ENCList(num) = dsArba7Details.DataTable11DataTable.__ENCList(num4)
								End If
								num += 1
							End If
							num4 += 1
						End While
						dsArba7Details.DataTable11DataTable.__ENCList.RemoveRange(num, dsArba7Details.DataTable11DataTable.__ENCList.Count - num)
						dsArba7Details.DataTable11DataTable.__ENCList.Capacity = dsArba7Details.DataTable11DataTable.__ENCList.Count
					End If
					dsArba7Details.DataTable11DataTable.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
				Finally
					Dim flag3 As Boolean = flag
					If flag3 Then
						Monitor.[Exit](_ENCList)
					End If
				End Try
			End Sub

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Sub New()
				dsArba7Details.DataTable11DataTable.__ENCAddToList(Me)
				Me.TableName = "DataTable11"
				Me.BeginInit()
				Me.InitClass()
				Me.EndInit()
			End Sub

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Friend Sub New(table As DataTable)
				dsArba7Details.DataTable11DataTable.__ENCAddToList(Me)
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
				dsArba7Details.DataTable11DataTable.__ENCAddToList(Me)
				Me.InitVars()
			End Sub

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public ReadOnly Property codeColumn As DataColumn
				Get
					Return Me.columncode
				End Get
			End Property

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public ReadOnly Property nameColumn As DataColumn
				Get
					Return Me.columnname
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property dept1Column As DataColumn
				Get
					Return Me.columndept1
				End Get
			End Property

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public ReadOnly Property credit1Column As DataColumn
				Get
					Return Me.columncredit1
				End Get
			End Property

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public ReadOnly Property dept2Column As DataColumn
				Get
					Return Me.columndept2
				End Get
			End Property

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public ReadOnly Property credit2Column As DataColumn
				Get
					Return Me.columncredit2
				End Get
			End Property

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public ReadOnly Property DataColumn11Column As DataColumn
				Get
					Return Me.columnDataColumn11
				End Get
			End Property

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public ReadOnly Property DataColumn112Column As DataColumn
				Get
					Return Me.columnDataColumn112
				End Get
			End Property

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public ReadOnly Property DataColumn111Column As DataColumn
				Get
					Return Me.columnDataColumn111
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property DataColumn110Column As DataColumn
				Get
					Return Me.columnDataColumn110
				End Get
			End Property

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public ReadOnly Property DataColumn19Column As DataColumn
				Get
					Return Me.columnDataColumn19
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property DataColumn18Column As DataColumn
				Get
					Return Me.columnDataColumn18
				End Get
			End Property

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public ReadOnly Property DataColumn17Column As DataColumn
				Get
					Return Me.columnDataColumn17
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property DataColumn16Column As DataColumn
				Get
					Return Me.columnDataColumn16
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property DataColumn15Column As DataColumn
				Get
					Return Me.columnDataColumn15
				End Get
			End Property

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public ReadOnly Property DataColumn14Column As DataColumn
				Get
					Return Me.columnDataColumn14
				End Get
			End Property

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public ReadOnly Property DataColumn13Column As DataColumn
				Get
					Return Me.columnDataColumn13
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property DataColumn12Column As DataColumn
				Get
					Return Me.columnDataColumn12
				End Get
			End Property

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public ReadOnly Property DataColumn1Column As DataColumn
				Get
					Return Me.columnDataColumn1
				End Get
			End Property

			<Browsable(False), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property Count As Integer
				Get
					Return Me.Rows.Count
				End Get
			End Property

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public ReadOnly Default Property Item(index As Integer) As dsArba7Details.DataTable11Row
				Get
					Return CType(Me.Rows(index), dsArba7Details.DataTable11Row)
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Event DataTable11RowChanging As dsArba7Details.DataTable11RowChangeEventHandler

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Event DataTable11RowChanged As dsArba7Details.DataTable11RowChangeEventHandler

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Event DataTable11RowDeleting As dsArba7Details.DataTable11RowChangeEventHandler

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Event DataTable11RowDeleted As dsArba7Details.DataTable11RowChangeEventHandler

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub AddDataTable11Row(row As dsArba7Details.DataTable11Row)
				Me.Rows.Add(row)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function AddDataTable11Row(code As String, name As String, dept1 As String, credit1 As String, dept2 As String, credit2 As String, DataColumn11 As String, DataColumn112 As String, DataColumn111 As String, DataColumn110 As String, DataColumn19 As String, DataColumn18 As String, DataColumn17 As String, DataColumn16 As String, DataColumn15 As String, DataColumn14 As String, DataColumn13 As String, DataColumn12 As String, DataColumn1 As String) As dsArba7Details.DataTable11Row
				Dim dataTable11Row As dsArba7Details.DataTable11Row = CType(Me.NewRow(), dsArba7Details.DataTable11Row)
				Dim itemArray As Object() = New Object() { code, name, dept1, credit1, dept2, credit2, DataColumn11, DataColumn112, DataColumn111, DataColumn110, DataColumn19, DataColumn18, DataColumn17, DataColumn16, DataColumn15, DataColumn14, DataColumn13, DataColumn12, DataColumn1 }
				dataTable11Row.ItemArray = itemArray
				Me.Rows.Add(dataTable11Row)
				Return dataTable11Row
			End Function

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Overrides Function Clone() As DataTable
				Dim dataTable11DataTable As dsArba7Details.DataTable11DataTable = CType(MyBase.Clone(), dsArba7Details.DataTable11DataTable)
				dataTable11DataTable.InitVars()
				Return dataTable11DataTable
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Overrides Function CreateInstance() As DataTable
				Return New dsArba7Details.DataTable11DataTable()
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Friend Sub InitVars()
				Me.columncode = MyBase.Columns("code")
				Me.columnname = MyBase.Columns("name")
				Me.columndept1 = MyBase.Columns("dept1")
				Me.columncredit1 = MyBase.Columns("credit1")
				Me.columndept2 = MyBase.Columns("dept2")
				Me.columncredit2 = MyBase.Columns("credit2")
				Me.columnDataColumn11 = MyBase.Columns("DataColumn11")
				Me.columnDataColumn112 = MyBase.Columns("DataColumn112")
				Me.columnDataColumn111 = MyBase.Columns("DataColumn111")
				Me.columnDataColumn110 = MyBase.Columns("DataColumn110")
				Me.columnDataColumn19 = MyBase.Columns("DataColumn19")
				Me.columnDataColumn18 = MyBase.Columns("DataColumn18")
				Me.columnDataColumn17 = MyBase.Columns("DataColumn17")
				Me.columnDataColumn16 = MyBase.Columns("DataColumn16")
				Me.columnDataColumn15 = MyBase.Columns("DataColumn15")
				Me.columnDataColumn14 = MyBase.Columns("DataColumn14")
				Me.columnDataColumn13 = MyBase.Columns("DataColumn13")
				Me.columnDataColumn12 = MyBase.Columns("DataColumn12")
				Me.columnDataColumn1 = MyBase.Columns("DataColumn1")
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Private Sub InitClass()
				Me.columncode = New DataColumn("code", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columncode)
				Me.columnname = New DataColumn("name", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnname)
				Me.columndept1 = New DataColumn("dept1", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columndept1)
				Me.columncredit1 = New DataColumn("credit1", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columncredit1)
				Me.columndept2 = New DataColumn("dept2", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columndept2)
				Me.columncredit2 = New DataColumn("credit2", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columncredit2)
				Me.columnDataColumn11 = New DataColumn("DataColumn11", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnDataColumn11)
				Me.columnDataColumn112 = New DataColumn("DataColumn112", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnDataColumn112)
				Me.columnDataColumn111 = New DataColumn("DataColumn111", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnDataColumn111)
				Me.columnDataColumn110 = New DataColumn("DataColumn110", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnDataColumn110)
				Me.columnDataColumn19 = New DataColumn("DataColumn19", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnDataColumn19)
				Me.columnDataColumn18 = New DataColumn("DataColumn18", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnDataColumn18)
				Me.columnDataColumn17 = New DataColumn("DataColumn17", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnDataColumn17)
				Me.columnDataColumn16 = New DataColumn("DataColumn16", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnDataColumn16)
				Me.columnDataColumn15 = New DataColumn("DataColumn15", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnDataColumn15)
				Me.columnDataColumn14 = New DataColumn("DataColumn14", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnDataColumn14)
				Me.columnDataColumn13 = New DataColumn("DataColumn13", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnDataColumn13)
				Me.columnDataColumn12 = New DataColumn("DataColumn12", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnDataColumn12)
				Me.columnDataColumn1 = New DataColumn("DataColumn1", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnDataColumn1)
				Me.columncode.Caption = "DataColumn1"
				Me.columnname.Caption = "DataColumn1"
				Me.columndept1.Caption = "DataColumn1"
				Me.columncredit1.Caption = "DataColumn1"
				Me.columndept2.Caption = "DataColumn1"
				Me.columncredit2.Caption = "DataColumn1"
				Me.columnDataColumn11.Caption = "DataColumn1"
				Me.columnDataColumn112.Caption = "DataColumn1"
				Me.columnDataColumn111.Caption = "DataColumn1"
				Me.columnDataColumn110.Caption = "DataColumn1"
				Me.columnDataColumn19.Caption = "DataColumn1"
				Me.columnDataColumn18.Caption = "DataColumn1"
				Me.columnDataColumn17.Caption = "DataColumn1"
				Me.columnDataColumn16.Caption = "DataColumn1"
				Me.columnDataColumn15.Caption = "DataColumn1"
				Me.columnDataColumn14.Caption = "DataColumn1"
				Me.columnDataColumn13.Caption = "DataColumn1"
				Me.columnDataColumn12.Caption = "DataColumn1"
			End Sub

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Function NewDataTable11Row() As dsArba7Details.DataTable11Row
				Return CType(Me.NewRow(), dsArba7Details.DataTable11Row)
			End Function

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Protected Overrides Function NewRowFromBuilder(builder As DataRowBuilder) As DataRow
				Return New dsArba7Details.DataTable11Row(builder)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Overrides Function GetRowType() As Type
				Return GetType(dsArba7Details.DataTable11Row)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Overrides Sub OnRowChanged(e As DataRowChangeEventArgs)
				MyBase.OnRowChanged(e)
				Dim flag As Boolean = Me.DataTable11RowChangedEvent IsNot Nothing
				If flag Then
					Dim dataTable11RowChangedEvent As dsArba7Details.DataTable11RowChangeEventHandler = Me.DataTable11RowChangedEvent
					flag = (dataTable11RowChangedEvent IsNot Nothing)
					If flag Then
						dataTable11RowChangedEvent(Me, New dsArba7Details.DataTable11RowChangeEvent(CType(e.Row, dsArba7Details.DataTable11Row), e.Action))
					End If
				End If
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Overrides Sub OnRowChanging(e As DataRowChangeEventArgs)
				MyBase.OnRowChanging(e)
				Dim flag As Boolean = Me.DataTable11RowChangingEvent IsNot Nothing
				If flag Then
					Dim dataTable11RowChangingEvent As dsArba7Details.DataTable11RowChangeEventHandler = Me.DataTable11RowChangingEvent
					flag = (dataTable11RowChangingEvent IsNot Nothing)
					If flag Then
						dataTable11RowChangingEvent(Me, New dsArba7Details.DataTable11RowChangeEvent(CType(e.Row, dsArba7Details.DataTable11Row), e.Action))
					End If
				End If
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Overrides Sub OnRowDeleted(e As DataRowChangeEventArgs)
				MyBase.OnRowDeleted(e)
				Dim flag As Boolean = Me.DataTable11RowDeletedEvent IsNot Nothing
				If flag Then
					Dim dataTable11RowDeletedEvent As dsArba7Details.DataTable11RowChangeEventHandler = Me.DataTable11RowDeletedEvent
					flag = (dataTable11RowDeletedEvent IsNot Nothing)
					If flag Then
						dataTable11RowDeletedEvent(Me, New dsArba7Details.DataTable11RowChangeEvent(CType(e.Row, dsArba7Details.DataTable11Row), e.Action))
					End If
				End If
			End Sub

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Protected Overrides Sub OnRowDeleting(e As DataRowChangeEventArgs)
				MyBase.OnRowDeleting(e)
				Dim flag As Boolean = Me.DataTable11RowDeletingEvent IsNot Nothing
				If flag Then
					Dim dataTable11RowDeletingEvent As dsArba7Details.DataTable11RowChangeEventHandler = Me.DataTable11RowDeletingEvent
					flag = (dataTable11RowDeletingEvent IsNot Nothing)
					If flag Then
						dataTable11RowDeletingEvent(Me, New dsArba7Details.DataTable11RowChangeEvent(CType(e.Row, dsArba7Details.DataTable11Row), e.Action))
					End If
				End If
			End Sub

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Sub RemoveDataTable11Row(row As dsArba7Details.DataTable11Row)
				Me.Rows.Remove(row)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Shared Function GetTypedTableSchema(xs As XmlSchemaSet) As XmlSchemaComplexType
				Dim xmlSchemaComplexType As XmlSchemaComplexType = New XmlSchemaComplexType()
				Dim xmlSchemaSequence As XmlSchemaSequence = New XmlSchemaSequence()
				Dim dsArba7Details As dsArba7Details = New dsArba7Details()
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
				xmlSchemaAttribute.FixedValue = dsArba7Details.[Namespace]
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute)
				Dim xmlSchemaAttribute2 As XmlSchemaAttribute = New XmlSchemaAttribute()
				xmlSchemaAttribute2.Name = "tableTypeName"
				xmlSchemaAttribute2.FixedValue = "DataTable11DataTable"
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2)
				xmlSchemaComplexType.Particle = xmlSchemaSequence
				Dim schemaSerializable As XmlSchema = dsArba7Details.GetSchemaSerializable()
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

			Private tableDataTable1 As dsArba7Details.DataTable1DataTable

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Friend Sub New(rb As DataRowBuilder)
				MyBase.New(rb)
				Me.tableDataTable1 = CType(Me.Table, dsArba7Details.DataTable1DataTable)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Property code As String
				Get
					Dim result As String
					Try
						result = Conversions.ToString(Me(Me.tableDataTable1.codeColumn))
					Catch innerException As InvalidCastException
						Throw New StrongTypingException("The value for column 'code' in table 'DataTable1' is DBNull.", innerException)
					End Try
					Return result
				End Get
				Set(value As String)
					Me(Me.tableDataTable1.codeColumn) = value
				End Set
			End Property

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
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

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Property dept1 As String
				Get
					Dim result As String
					Try
						result = Conversions.ToString(Me(Me.tableDataTable1.dept1Column))
					Catch innerException As InvalidCastException
						Throw New StrongTypingException("The value for column 'dept1' in table 'DataTable1' is DBNull.", innerException)
					End Try
					Return result
				End Get
				Set(value As String)
					Me(Me.tableDataTable1.dept1Column) = value
				End Set
			End Property

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Property credit1 As String
				Get
					Dim result As String
					Try
						result = Conversions.ToString(Me(Me.tableDataTable1.credit1Column))
					Catch innerException As InvalidCastException
						Throw New StrongTypingException("The value for column 'credit1' in table 'DataTable1' is DBNull.", innerException)
					End Try
					Return result
				End Get
				Set(value As String)
					Me(Me.tableDataTable1.credit1Column) = value
				End Set
			End Property

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Property dept2 As String
				Get
					Dim result As String
					Try
						result = Conversions.ToString(Me(Me.tableDataTable1.dept2Column))
					Catch innerException As InvalidCastException
						Throw New StrongTypingException("The value for column 'dept2' in table 'DataTable1' is DBNull.", innerException)
					End Try
					Return result
				End Get
				Set(value As String)
					Me(Me.tableDataTable1.dept2Column) = value
				End Set
			End Property

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Property credit2 As String
				Get
					Dim result As String
					Try
						result = Conversions.ToString(Me(Me.tableDataTable1.credit2Column))
					Catch innerException As InvalidCastException
						Throw New StrongTypingException("The value for column 'credit2' in table 'DataTable1' is DBNull.", innerException)
					End Try
					Return result
				End Get
				Set(value As String)
					Me(Me.tableDataTable1.credit2Column) = value
				End Set
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Property DataColumn11 As String
				Get
					Dim result As String
					Try
						result = Conversions.ToString(Me(Me.tableDataTable1.DataColumn11Column))
					Catch innerException As InvalidCastException
						Throw New StrongTypingException("The value for column 'DataColumn11' in table 'DataTable1' is DBNull.", innerException)
					End Try
					Return result
				End Get
				Set(value As String)
					Me(Me.tableDataTable1.DataColumn11Column) = value
				End Set
			End Property

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Property DataColumn110 As String
				Get
					Dim result As String
					Try
						result = Conversions.ToString(Me(Me.tableDataTable1.DataColumn110Column))
					Catch innerException As InvalidCastException
						Throw New StrongTypingException("The value for column 'DataColumn110' in table 'DataTable1' is DBNull.", innerException)
					End Try
					Return result
				End Get
				Set(value As String)
					Me(Me.tableDataTable1.DataColumn110Column) = value
				End Set
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Property DataColumn19 As String
				Get
					Dim result As String
					Try
						result = Conversions.ToString(Me(Me.tableDataTable1.DataColumn19Column))
					Catch innerException As InvalidCastException
						Throw New StrongTypingException("The value for column 'DataColumn19' in table 'DataTable1' is DBNull.", innerException)
					End Try
					Return result
				End Get
				Set(value As String)
					Me(Me.tableDataTable1.DataColumn19Column) = value
				End Set
			End Property

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Property DataColumn18 As String
				Get
					Dim result As String
					Try
						result = Conversions.ToString(Me(Me.tableDataTable1.DataColumn18Column))
					Catch innerException As InvalidCastException
						Throw New StrongTypingException("The value for column 'DataColumn18' in table 'DataTable1' is DBNull.", innerException)
					End Try
					Return result
				End Get
				Set(value As String)
					Me(Me.tableDataTable1.DataColumn18Column) = value
				End Set
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Property DataColumn17 As String
				Get
					Dim result As String
					Try
						result = Conversions.ToString(Me(Me.tableDataTable1.DataColumn17Column))
					Catch innerException As InvalidCastException
						Throw New StrongTypingException("The value for column 'DataColumn17' in table 'DataTable1' is DBNull.", innerException)
					End Try
					Return result
				End Get
				Set(value As String)
					Me(Me.tableDataTable1.DataColumn17Column) = value
				End Set
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Property DataColumn16 As String
				Get
					Dim result As String
					Try
						result = Conversions.ToString(Me(Me.tableDataTable1.DataColumn16Column))
					Catch innerException As InvalidCastException
						Throw New StrongTypingException("The value for column 'DataColumn16' in table 'DataTable1' is DBNull.", innerException)
					End Try
					Return result
				End Get
				Set(value As String)
					Me(Me.tableDataTable1.DataColumn16Column) = value
				End Set
			End Property

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Property DataColumn15 As String
				Get
					Dim result As String
					Try
						result = Conversions.ToString(Me(Me.tableDataTable1.DataColumn15Column))
					Catch innerException As InvalidCastException
						Throw New StrongTypingException("The value for column 'DataColumn15' in table 'DataTable1' is DBNull.", innerException)
					End Try
					Return result
				End Get
				Set(value As String)
					Me(Me.tableDataTable1.DataColumn15Column) = value
				End Set
			End Property

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Property DataColumn14 As String
				Get
					Dim result As String
					Try
						result = Conversions.ToString(Me(Me.tableDataTable1.DataColumn14Column))
					Catch innerException As InvalidCastException
						Throw New StrongTypingException("The value for column 'DataColumn14' in table 'DataTable1' is DBNull.", innerException)
					End Try
					Return result
				End Get
				Set(value As String)
					Me(Me.tableDataTable1.DataColumn14Column) = value
				End Set
			End Property

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Property DataColumn13 As String
				Get
					Dim result As String
					Try
						result = Conversions.ToString(Me(Me.tableDataTable1.DataColumn13Column))
					Catch innerException As InvalidCastException
						Throw New StrongTypingException("The value for column 'DataColumn13' in table 'DataTable1' is DBNull.", innerException)
					End Try
					Return result
				End Get
				Set(value As String)
					Me(Me.tableDataTable1.DataColumn13Column) = value
				End Set
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Property DataColumn12 As String
				Get
					Dim result As String
					Try
						result = Conversions.ToString(Me(Me.tableDataTable1.DataColumn12Column))
					Catch innerException As InvalidCastException
						Throw New StrongTypingException("The value for column 'DataColumn12' in table 'DataTable1' is DBNull.", innerException)
					End Try
					Return result
				End Get
				Set(value As String)
					Me(Me.tableDataTable1.DataColumn12Column) = value
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
			Public Function IscodeNull() As Boolean
				Return Me.IsNull(Me.tableDataTable1.codeColumn)
			End Function

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Sub SetcodeNull()
				Me(Me.tableDataTable1.codeColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function IsnameNull() As Boolean
				Return Me.IsNull(Me.tableDataTable1.nameColumn)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub SetnameNull()
				Me(Me.tableDataTable1.nameColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Function Isdept1Null() As Boolean
				Return Me.IsNull(Me.tableDataTable1.dept1Column)
			End Function

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Sub Setdept1Null()
				Me(Me.tableDataTable1.dept1Column) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Function Iscredit1Null() As Boolean
				Return Me.IsNull(Me.tableDataTable1.credit1Column)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub Setcredit1Null()
				Me(Me.tableDataTable1.credit1Column) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Function Isdept2Null() As Boolean
				Return Me.IsNull(Me.tableDataTable1.dept2Column)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub Setdept2Null()
				Me(Me.tableDataTable1.dept2Column) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Function Iscredit2Null() As Boolean
				Return Me.IsNull(Me.tableDataTable1.credit2Column)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub Setcredit2Null()
				Me(Me.tableDataTable1.credit2Column) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function IsDataColumn11Null() As Boolean
				Return Me.IsNull(Me.tableDataTable1.DataColumn11Column)
			End Function

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Sub SetDataColumn11Null()
				Me(Me.tableDataTable1.DataColumn11Column) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function IsDataColumn110Null() As Boolean
				Return Me.IsNull(Me.tableDataTable1.DataColumn110Column)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub SetDataColumn110Null()
				Me(Me.tableDataTable1.DataColumn110Column) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function IsDataColumn19Null() As Boolean
				Return Me.IsNull(Me.tableDataTable1.DataColumn19Column)
			End Function

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Sub SetDataColumn19Null()
				Me(Me.tableDataTable1.DataColumn19Column) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function IsDataColumn18Null() As Boolean
				Return Me.IsNull(Me.tableDataTable1.DataColumn18Column)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub SetDataColumn18Null()
				Me(Me.tableDataTable1.DataColumn18Column) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Function IsDataColumn17Null() As Boolean
				Return Me.IsNull(Me.tableDataTable1.DataColumn17Column)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub SetDataColumn17Null()
				Me(Me.tableDataTable1.DataColumn17Column) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Function IsDataColumn16Null() As Boolean
				Return Me.IsNull(Me.tableDataTable1.DataColumn16Column)
			End Function

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Sub SetDataColumn16Null()
				Me(Me.tableDataTable1.DataColumn16Column) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function IsDataColumn15Null() As Boolean
				Return Me.IsNull(Me.tableDataTable1.DataColumn15Column)
			End Function

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Sub SetDataColumn15Null()
				Me(Me.tableDataTable1.DataColumn15Column) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function IsDataColumn14Null() As Boolean
				Return Me.IsNull(Me.tableDataTable1.DataColumn14Column)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub SetDataColumn14Null()
				Me(Me.tableDataTable1.DataColumn14Column) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function IsDataColumn13Null() As Boolean
				Return Me.IsNull(Me.tableDataTable1.DataColumn13Column)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub SetDataColumn13Null()
				Me(Me.tableDataTable1.DataColumn13Column) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function IsDataColumn12Null() As Boolean
				Return Me.IsNull(Me.tableDataTable1.DataColumn12Column)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub SetDataColumn12Null()
				Me(Me.tableDataTable1.DataColumn12Column) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function IsDataColumn1Null() As Boolean
				Return Me.IsNull(Me.tableDataTable1.DataColumn1Column)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub SetDataColumn1Null()
				Me(Me.tableDataTable1.DataColumn1Column) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub
		End Class

		Public Class DataTable11Row
			Inherits DataRow

			Private tableDataTable11 As dsArba7Details.DataTable11DataTable

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Friend Sub New(rb As DataRowBuilder)
				MyBase.New(rb)
				Me.tableDataTable11 = CType(Me.Table, dsArba7Details.DataTable11DataTable)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Property code As String
				Get
					Dim result As String
					Try
						result = Conversions.ToString(Me(Me.tableDataTable11.codeColumn))
					Catch innerException As InvalidCastException
						Throw New StrongTypingException("The value for column 'code' in table 'DataTable11' is DBNull.", innerException)
					End Try
					Return result
				End Get
				Set(value As String)
					Me(Me.tableDataTable11.codeColumn) = value
				End Set
			End Property

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Property name As String
				Get
					Dim result As String
					Try
						result = Conversions.ToString(Me(Me.tableDataTable11.nameColumn))
					Catch innerException As InvalidCastException
						Throw New StrongTypingException("The value for column 'name' in table 'DataTable11' is DBNull.", innerException)
					End Try
					Return result
				End Get
				Set(value As String)
					Me(Me.tableDataTable11.nameColumn) = value
				End Set
			End Property

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Property dept1 As String
				Get
					Dim result As String
					Try
						result = Conversions.ToString(Me(Me.tableDataTable11.dept1Column))
					Catch innerException As InvalidCastException
						Throw New StrongTypingException("The value for column 'dept1' in table 'DataTable11' is DBNull.", innerException)
					End Try
					Return result
				End Get
				Set(value As String)
					Me(Me.tableDataTable11.dept1Column) = value
				End Set
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Property credit1 As String
				Get
					Dim result As String
					Try
						result = Conversions.ToString(Me(Me.tableDataTable11.credit1Column))
					Catch innerException As InvalidCastException
						Throw New StrongTypingException("The value for column 'credit1' in table 'DataTable11' is DBNull.", innerException)
					End Try
					Return result
				End Get
				Set(value As String)
					Me(Me.tableDataTable11.credit1Column) = value
				End Set
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Property dept2 As String
				Get
					Dim result As String
					Try
						result = Conversions.ToString(Me(Me.tableDataTable11.dept2Column))
					Catch innerException As InvalidCastException
						Throw New StrongTypingException("The value for column 'dept2' in table 'DataTable11' is DBNull.", innerException)
					End Try
					Return result
				End Get
				Set(value As String)
					Me(Me.tableDataTable11.dept2Column) = value
				End Set
			End Property

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Property credit2 As String
				Get
					Dim result As String
					Try
						result = Conversions.ToString(Me(Me.tableDataTable11.credit2Column))
					Catch innerException As InvalidCastException
						Throw New StrongTypingException("The value for column 'credit2' in table 'DataTable11' is DBNull.", innerException)
					End Try
					Return result
				End Get
				Set(value As String)
					Me(Me.tableDataTable11.credit2Column) = value
				End Set
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Property DataColumn11 As String
				Get
					Dim result As String
					Try
						result = Conversions.ToString(Me(Me.tableDataTable11.DataColumn11Column))
					Catch innerException As InvalidCastException
						Throw New StrongTypingException("The value for column 'DataColumn11' in table 'DataTable11' is DBNull.", innerException)
					End Try
					Return result
				End Get
				Set(value As String)
					Me(Me.tableDataTable11.DataColumn11Column) = value
				End Set
			End Property

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Property DataColumn112 As String
				Get
					Dim result As String
					Try
						result = Conversions.ToString(Me(Me.tableDataTable11.DataColumn112Column))
					Catch innerException As InvalidCastException
						Throw New StrongTypingException("The value for column 'DataColumn112' in table 'DataTable11' is DBNull.", innerException)
					End Try
					Return result
				End Get
				Set(value As String)
					Me(Me.tableDataTable11.DataColumn112Column) = value
				End Set
			End Property

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Property DataColumn111 As String
				Get
					Dim result As String
					Try
						result = Conversions.ToString(Me(Me.tableDataTable11.DataColumn111Column))
					Catch innerException As InvalidCastException
						Throw New StrongTypingException("The value for column 'DataColumn111' in table 'DataTable11' is DBNull.", innerException)
					End Try
					Return result
				End Get
				Set(value As String)
					Me(Me.tableDataTable11.DataColumn111Column) = value
				End Set
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Property DataColumn110 As String
				Get
					Dim result As String
					Try
						result = Conversions.ToString(Me(Me.tableDataTable11.DataColumn110Column))
					Catch innerException As InvalidCastException
						Throw New StrongTypingException("The value for column 'DataColumn110' in table 'DataTable11' is DBNull.", innerException)
					End Try
					Return result
				End Get
				Set(value As String)
					Me(Me.tableDataTable11.DataColumn110Column) = value
				End Set
			End Property

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Property DataColumn19 As String
				Get
					Dim result As String
					Try
						result = Conversions.ToString(Me(Me.tableDataTable11.DataColumn19Column))
					Catch innerException As InvalidCastException
						Throw New StrongTypingException("The value for column 'DataColumn19' in table 'DataTable11' is DBNull.", innerException)
					End Try
					Return result
				End Get
				Set(value As String)
					Me(Me.tableDataTable11.DataColumn19Column) = value
				End Set
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Property DataColumn18 As String
				Get
					Dim result As String
					Try
						result = Conversions.ToString(Me(Me.tableDataTable11.DataColumn18Column))
					Catch innerException As InvalidCastException
						Throw New StrongTypingException("The value for column 'DataColumn18' in table 'DataTable11' is DBNull.", innerException)
					End Try
					Return result
				End Get
				Set(value As String)
					Me(Me.tableDataTable11.DataColumn18Column) = value
				End Set
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Property DataColumn17 As String
				Get
					Dim result As String
					Try
						result = Conversions.ToString(Me(Me.tableDataTable11.DataColumn17Column))
					Catch innerException As InvalidCastException
						Throw New StrongTypingException("The value for column 'DataColumn17' in table 'DataTable11' is DBNull.", innerException)
					End Try
					Return result
				End Get
				Set(value As String)
					Me(Me.tableDataTable11.DataColumn17Column) = value
				End Set
			End Property

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Property DataColumn16 As String
				Get
					Dim result As String
					Try
						result = Conversions.ToString(Me(Me.tableDataTable11.DataColumn16Column))
					Catch innerException As InvalidCastException
						Throw New StrongTypingException("The value for column 'DataColumn16' in table 'DataTable11' is DBNull.", innerException)
					End Try
					Return result
				End Get
				Set(value As String)
					Me(Me.tableDataTable11.DataColumn16Column) = value
				End Set
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Property DataColumn15 As String
				Get
					Dim result As String
					Try
						result = Conversions.ToString(Me(Me.tableDataTable11.DataColumn15Column))
					Catch innerException As InvalidCastException
						Throw New StrongTypingException("The value for column 'DataColumn15' in table 'DataTable11' is DBNull.", innerException)
					End Try
					Return result
				End Get
				Set(value As String)
					Me(Me.tableDataTable11.DataColumn15Column) = value
				End Set
			End Property

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Property DataColumn14 As String
				Get
					Dim result As String
					Try
						result = Conversions.ToString(Me(Me.tableDataTable11.DataColumn14Column))
					Catch innerException As InvalidCastException
						Throw New StrongTypingException("The value for column 'DataColumn14' in table 'DataTable11' is DBNull.", innerException)
					End Try
					Return result
				End Get
				Set(value As String)
					Me(Me.tableDataTable11.DataColumn14Column) = value
				End Set
			End Property

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Property DataColumn13 As String
				Get
					Dim result As String
					Try
						result = Conversions.ToString(Me(Me.tableDataTable11.DataColumn13Column))
					Catch innerException As InvalidCastException
						Throw New StrongTypingException("The value for column 'DataColumn13' in table 'DataTable11' is DBNull.", innerException)
					End Try
					Return result
				End Get
				Set(value As String)
					Me(Me.tableDataTable11.DataColumn13Column) = value
				End Set
			End Property

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Property DataColumn12 As String
				Get
					Dim result As String
					Try
						result = Conversions.ToString(Me(Me.tableDataTable11.DataColumn12Column))
					Catch innerException As InvalidCastException
						Throw New StrongTypingException("The value for column 'DataColumn12' in table 'DataTable11' is DBNull.", innerException)
					End Try
					Return result
				End Get
				Set(value As String)
					Me(Me.tableDataTable11.DataColumn12Column) = value
				End Set
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Property DataColumn1 As String
				Get
					Dim result As String
					Try
						result = Conversions.ToString(Me(Me.tableDataTable11.DataColumn1Column))
					Catch innerException As InvalidCastException
						Throw New StrongTypingException("The value for column 'DataColumn1' in table 'DataTable11' is DBNull.", innerException)
					End Try
					Return result
				End Get
				Set(value As String)
					Me(Me.tableDataTable11.DataColumn1Column) = value
				End Set
			End Property

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Function IscodeNull() As Boolean
				Return Me.IsNull(Me.tableDataTable11.codeColumn)
			End Function

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Sub SetcodeNull()
				Me(Me.tableDataTable11.codeColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Function IsnameNull() As Boolean
				Return Me.IsNull(Me.tableDataTable11.nameColumn)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub SetnameNull()
				Me(Me.tableDataTable11.nameColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Function Isdept1Null() As Boolean
				Return Me.IsNull(Me.tableDataTable11.dept1Column)
			End Function

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Sub Setdept1Null()
				Me(Me.tableDataTable11.dept1Column) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function Iscredit1Null() As Boolean
				Return Me.IsNull(Me.tableDataTable11.credit1Column)
			End Function

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Sub Setcredit1Null()
				Me(Me.tableDataTable11.credit1Column) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Function Isdept2Null() As Boolean
				Return Me.IsNull(Me.tableDataTable11.dept2Column)
			End Function

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Sub Setdept2Null()
				Me(Me.tableDataTable11.dept2Column) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function Iscredit2Null() As Boolean
				Return Me.IsNull(Me.tableDataTable11.credit2Column)
			End Function

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Sub Setcredit2Null()
				Me(Me.tableDataTable11.credit2Column) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function IsDataColumn11Null() As Boolean
				Return Me.IsNull(Me.tableDataTable11.DataColumn11Column)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub SetDataColumn11Null()
				Me(Me.tableDataTable11.DataColumn11Column) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function IsDataColumn112Null() As Boolean
				Return Me.IsNull(Me.tableDataTable11.DataColumn112Column)
			End Function

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Sub SetDataColumn112Null()
				Me(Me.tableDataTable11.DataColumn112Column) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Function IsDataColumn111Null() As Boolean
				Return Me.IsNull(Me.tableDataTable11.DataColumn111Column)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub SetDataColumn111Null()
				Me(Me.tableDataTable11.DataColumn111Column) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function IsDataColumn110Null() As Boolean
				Return Me.IsNull(Me.tableDataTable11.DataColumn110Column)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub SetDataColumn110Null()
				Me(Me.tableDataTable11.DataColumn110Column) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Function IsDataColumn19Null() As Boolean
				Return Me.IsNull(Me.tableDataTable11.DataColumn19Column)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub SetDataColumn19Null()
				Me(Me.tableDataTable11.DataColumn19Column) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Function IsDataColumn18Null() As Boolean
				Return Me.IsNull(Me.tableDataTable11.DataColumn18Column)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub SetDataColumn18Null()
				Me(Me.tableDataTable11.DataColumn18Column) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function IsDataColumn17Null() As Boolean
				Return Me.IsNull(Me.tableDataTable11.DataColumn17Column)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub SetDataColumn17Null()
				Me(Me.tableDataTable11.DataColumn17Column) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function IsDataColumn16Null() As Boolean
				Return Me.IsNull(Me.tableDataTable11.DataColumn16Column)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub SetDataColumn16Null()
				Me(Me.tableDataTable11.DataColumn16Column) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function IsDataColumn15Null() As Boolean
				Return Me.IsNull(Me.tableDataTable11.DataColumn15Column)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub SetDataColumn15Null()
				Me(Me.tableDataTable11.DataColumn15Column) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Function IsDataColumn14Null() As Boolean
				Return Me.IsNull(Me.tableDataTable11.DataColumn14Column)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub SetDataColumn14Null()
				Me(Me.tableDataTable11.DataColumn14Column) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Function IsDataColumn13Null() As Boolean
				Return Me.IsNull(Me.tableDataTable11.DataColumn13Column)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub SetDataColumn13Null()
				Me(Me.tableDataTable11.DataColumn13Column) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function IsDataColumn12Null() As Boolean
				Return Me.IsNull(Me.tableDataTable11.DataColumn12Column)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub SetDataColumn12Null()
				Me(Me.tableDataTable11.DataColumn12Column) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function IsDataColumn1Null() As Boolean
				Return Me.IsNull(Me.tableDataTable11.DataColumn1Column)
			End Function

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Sub SetDataColumn1Null()
				Me(Me.tableDataTable11.DataColumn1Column) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub
		End Class

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
		Public Class DataTable1RowChangeEvent
			Inherits EventArgs

			Private eventRow As dsArba7Details.DataTable1Row

			Private eventAction As DataRowAction

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub New(row As dsArba7Details.DataTable1Row, action As DataRowAction)
				Me.eventRow = row
				Me.eventAction = action
			End Sub

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public ReadOnly Property Row As dsArba7Details.DataTable1Row
				Get
					Return Me.eventRow
				End Get
			End Property

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public ReadOnly Property Action As DataRowAction
				Get
					Return Me.eventAction
				End Get
			End Property
		End Class

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
		Public Class DataTable11RowChangeEvent
			Inherits EventArgs

			Private eventRow As dsArba7Details.DataTable11Row

			Private eventAction As DataRowAction

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub New(row As dsArba7Details.DataTable11Row, action As DataRowAction)
				Me.eventRow = row
				Me.eventAction = action
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property Row As dsArba7Details.DataTable11Row
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

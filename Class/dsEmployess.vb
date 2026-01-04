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
	<DesignerCategory("code"), ToolboxItem(True), HelpKeyword("vs.data.DataSet"), XmlRoot("dsEmployess"), XmlSchemaProvider("GetTypedDataSetSchema"), Serializable()>
	Public Class dsEmployess
		Inherits DataSet

		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		Private tableDataTable1 As dsEmployess.DataTable1DataTable

		Private _schemaSerializationMode As SchemaSerializationMode
		Shared Sub New()
		End Sub
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = dsEmployess.__ENCList
			Dim flag As Boolean = False
			Try
				Monitor.Enter(_ENCList, flag)
				Dim flag2 As Boolean = dsEmployess.__ENCList.Count = dsEmployess.__ENCList.Capacity
				If flag2 Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = dsEmployess.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit While
						End If
						Dim weakReference As WeakReference = dsEmployess.__ENCList(num4)
						flag2 = weakReference.IsAlive
						If flag2 Then
							Dim flag3 As Boolean = num4 <> num
							If flag3 Then
								dsEmployess.__ENCList(num) = dsEmployess.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					dsEmployess.__ENCList.RemoveRange(num, dsEmployess.__ENCList.Count - num)
					dsEmployess.__ENCList.Capacity = dsEmployess.__ENCList.Count
				End If
				dsEmployess.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			Finally
				Dim flag3 As Boolean = flag
				If flag3 Then
					Monitor.[Exit](_ENCList)
				End If
			End Try
		End Sub

		<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
		Public Sub New()
			dsEmployess.__ENCAddToList(Me)
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
			dsEmployess.__ENCAddToList(Me)
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
						MyBase.Tables.Add(New dsEmployess.DataTable1DataTable(dataSet.Tables("DataTable1")))
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

		<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Browsable(False), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)>
		Public ReadOnly Property DataTable1 As dsEmployess.DataTable1DataTable
			Get
				Return Me.tableDataTable1
			End Get
		End Property

		<Browsable(True), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode(), DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
		Public Overrides Property SchemaSerializationMode As SchemaSerializationMode
			Get
				Return Me._schemaSerializationMode
			End Get
			Set(value As SchemaSerializationMode)
				Me._schemaSerializationMode = value
			End Set
		End Property

		<DebuggerNonUserCode(), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
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

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
		Protected Overrides Sub InitializeDerivedDataSet()
			Me.BeginInit()
			Me.InitClass()
			Me.EndInit()
		End Sub

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
		Public Overrides Function Clone() As DataSet
			Dim dsEmployess As dsEmployess = CType(MyBase.Clone(), dsEmployess)
			dsEmployess.InitVars()
			dsEmployess.SchemaSerializationMode = Me.SchemaSerializationMode
			Return dsEmployess
		End Function

		<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
		Protected Overrides Function ShouldSerializeTables() As Boolean
			Return False
		End Function

		<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
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
					MyBase.Tables.Add(New dsEmployess.DataTable1DataTable(dataSet.Tables("DataTable1")))
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

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
		Protected Overrides Function GetSchemaSerializable() As XmlSchema
			Dim memoryStream As MemoryStream = New MemoryStream()
			Me.WriteXmlSchema(New XmlTextWriter(memoryStream, Nothing))
			memoryStream.Position = 0L
			Return XmlSchema.Read(New XmlTextReader(memoryStream), Nothing)
		End Function

		<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
		Friend Sub InitVars()
			Me.InitVars(True)
		End Sub

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
		Friend Sub InitVars(initTable As Boolean)
			Me.tableDataTable1 = CType(MyBase.Tables("DataTable1"), dsEmployess.DataTable1DataTable)
			If initTable Then
				Dim flag As Boolean = Me.tableDataTable1 IsNot Nothing
				If flag Then
					Me.tableDataTable1.InitVars()
				End If
			End If
		End Sub

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
		Private Sub InitClass()
			Me.DataSetName = "dsEmployess"
			Me.Prefix = ""
			Me.[Namespace] = "http://tempuri.org/dsEmployess.xsd"
			Me.EnforceConstraints = True
			Me.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema
			Me.tableDataTable1 = New dsEmployess.DataTable1DataTable()
			MyBase.Tables.Add(Me.tableDataTable1)
		End Sub

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
		Private Function ShouldSerializeDataTable1() As Boolean
			Return False
		End Function

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
		Private Sub SchemaChanged(sender As Object, e As CollectionChangeEventArgs)
			Dim flag As Boolean = e.Action = CollectionChangeAction.Remove
			If flag Then
				Me.InitVars()
			End If
		End Sub

		<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
		Public Shared Function GetTypedDataSetSchema(xs As XmlSchemaSet) As XmlSchemaComplexType
			Dim dsEmployess As dsEmployess = New dsEmployess()
			Dim xmlSchemaComplexType As XmlSchemaComplexType = New XmlSchemaComplexType()
			Dim xmlSchemaSequence As XmlSchemaSequence = New XmlSchemaSequence()
			Dim xmlSchemaAny As XmlSchemaAny = New XmlSchemaAny()
			xmlSchemaAny.[Namespace] = dsEmployess.[Namespace]
			xmlSchemaSequence.Items.Add(xmlSchemaAny)
			xmlSchemaComplexType.Particle = xmlSchemaSequence
			Dim schemaSerializable As XmlSchema = dsEmployess.GetSchemaSerializable()
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
		Public Delegate Sub DataTable1RowChangeEventHandler(sender As Object, e As dsEmployess.DataTable1RowChangeEvent)

		<XmlSchemaProvider("GetTypedTableSchema"), Serializable()>
		Public Class DataTable1DataTable
			Inherits TypedTableBase(Of dsEmployess.DataTable1Row)

			Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

			Private columnname As DataColumn

			Private columnmanag As DataColumn

			Private columndep As DataColumn

			Private columnjob As DataColumn

			Private columnbranch As DataColumn

			Private columnworkdate As DataColumn

			Private columnnationality As DataColumn

			Private columnmobile As DataColumn

			Private columntotsalary As DataColumn

			Private columnDataColumn12 As DataColumn

			Private columnDataColumn11 As DataColumn

			Private columnDataColumn1 As DataColumn
			Shared Sub New()
			End Sub
			Private Shared Sub __ENCAddToList(value As Object)
				Dim _ENCList As List(Of WeakReference) = dsEmployess.DataTable1DataTable.__ENCList
				Dim flag As Boolean = False
				Try
					Monitor.Enter(_ENCList, flag)
					Dim flag2 As Boolean = dsEmployess.DataTable1DataTable.__ENCList.Count = dsEmployess.DataTable1DataTable.__ENCList.Capacity
					If flag2 Then
						Dim num As Integer = 0
						Dim num2 As Integer = 0
						Dim num3 As Integer = dsEmployess.DataTable1DataTable.__ENCList.Count - 1
						Dim num4 As Integer = num2
						While True
							Dim num5 As Integer = num4
							Dim num6 As Integer = num3
							If num5 > num6 Then
								Exit While
							End If
							Dim weakReference As WeakReference = dsEmployess.DataTable1DataTable.__ENCList(num4)
							flag2 = weakReference.IsAlive
							If flag2 Then
								Dim flag3 As Boolean = num4 <> num
								If flag3 Then
									dsEmployess.DataTable1DataTable.__ENCList(num) = dsEmployess.DataTable1DataTable.__ENCList(num4)
								End If
								num += 1
							End If
							num4 += 1
						End While
						dsEmployess.DataTable1DataTable.__ENCList.RemoveRange(num, dsEmployess.DataTable1DataTable.__ENCList.Count - num)
						dsEmployess.DataTable1DataTable.__ENCList.Capacity = dsEmployess.DataTable1DataTable.__ENCList.Count
					End If
					dsEmployess.DataTable1DataTable.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
				Finally
					Dim flag3 As Boolean = flag
					If flag3 Then
						Monitor.[Exit](_ENCList)
					End If
				End Try
			End Sub

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Sub New()
				AddHandler MyBase.ColumnChanging, AddressOf Me.DataTable1DataTable_ColumnChanging
				dsEmployess.DataTable1DataTable.__ENCAddToList(Me)
				Me.TableName = "DataTable1"
				Me.BeginInit()
				Me.InitClass()
				Me.EndInit()
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Friend Sub New(table As DataTable)
				AddHandler MyBase.ColumnChanging, AddressOf Me.DataTable1DataTable_ColumnChanging
				dsEmployess.DataTable1DataTable.__ENCAddToList(Me)
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
				AddHandler MyBase.ColumnChanging, AddressOf Me.DataTable1DataTable_ColumnChanging
				dsEmployess.DataTable1DataTable.__ENCAddToList(Me)
				Me.InitVars()
			End Sub

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public ReadOnly Property nameColumn As DataColumn
				Get
					Return Me.columnname
				End Get
			End Property

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public ReadOnly Property managColumn As DataColumn
				Get
					Return Me.columnmanag
				End Get
			End Property

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public ReadOnly Property depColumn As DataColumn
				Get
					Return Me.columndep
				End Get
			End Property

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public ReadOnly Property jobColumn As DataColumn
				Get
					Return Me.columnjob
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property branchColumn As DataColumn
				Get
					Return Me.columnbranch
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property workdateColumn As DataColumn
				Get
					Return Me.columnworkdate
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property nationalityColumn As DataColumn
				Get
					Return Me.columnnationality
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property mobileColumn As DataColumn
				Get
					Return Me.columnmobile
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property totsalaryColumn As DataColumn
				Get
					Return Me.columntotsalary
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property DataColumn12Column As DataColumn
				Get
					Return Me.columnDataColumn12
				End Get
			End Property

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public ReadOnly Property DataColumn11Column As DataColumn
				Get
					Return Me.columnDataColumn11
				End Get
			End Property

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public ReadOnly Property DataColumn1Column As DataColumn
				Get
					Return Me.columnDataColumn1
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode(), Browsable(False)>
			Public ReadOnly Property Count As Integer
				Get
					Return Me.Rows.Count
				End Get
			End Property

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public ReadOnly Default Property Item(index As Integer) As dsEmployess.DataTable1Row
				Get
					Return CType(Me.Rows(index), dsEmployess.DataTable1Row)
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Event DataTable1RowChanging As dsEmployess.DataTable1RowChangeEventHandler

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Event DataTable1RowChanged As dsEmployess.DataTable1RowChangeEventHandler

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Event DataTable1RowDeleting As dsEmployess.DataTable1RowChangeEventHandler

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Event DataTable1RowDeleted As dsEmployess.DataTable1RowChangeEventHandler

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Sub AddDataTable1Row(row As dsEmployess.DataTable1Row)
				Me.Rows.Add(row)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function AddDataTable1Row(name As String, manag As String, dep As String, job As String, branch As String, workdate As String, nationality As String, mobile As String, totsalary As String, DataColumn12 As String, DataColumn11 As String, DataColumn1 As String) As dsEmployess.DataTable1Row
				Dim dataTable1Row As dsEmployess.DataTable1Row = CType(Me.NewRow(), dsEmployess.DataTable1Row)
				Dim itemArray As Object() = New Object() { name, manag, dep, job, branch, workdate, nationality, mobile, totsalary, DataColumn12, DataColumn11, DataColumn1 }
				dataTable1Row.ItemArray = itemArray
				Me.Rows.Add(dataTable1Row)
				Return dataTable1Row
			End Function

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Overrides Function Clone() As DataTable
				Dim dataTable1DataTable As dsEmployess.DataTable1DataTable = CType(MyBase.Clone(), dsEmployess.DataTable1DataTable)
				dataTable1DataTable.InitVars()
				Return dataTable1DataTable
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Overrides Function CreateInstance() As DataTable
				Return New dsEmployess.DataTable1DataTable()
			End Function

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Friend Sub InitVars()
				Me.columnname = MyBase.Columns("name")
				Me.columnmanag = MyBase.Columns("manag")
				Me.columndep = MyBase.Columns("dep")
				Me.columnjob = MyBase.Columns("job")
				Me.columnbranch = MyBase.Columns("branch")
				Me.columnworkdate = MyBase.Columns("workdate")
				Me.columnnationality = MyBase.Columns("nationality")
				Me.columnmobile = MyBase.Columns("mobile")
				Me.columntotsalary = MyBase.Columns("totsalary")
				Me.columnDataColumn12 = MyBase.Columns("DataColumn12")
				Me.columnDataColumn11 = MyBase.Columns("DataColumn11")
				Me.columnDataColumn1 = MyBase.Columns("DataColumn1")
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Private Sub InitClass()
				Me.columnname = New DataColumn("name", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnname)
				Me.columnmanag = New DataColumn("manag", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnmanag)
				Me.columndep = New DataColumn("dep", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columndep)
				Me.columnjob = New DataColumn("job", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnjob)
				Me.columnbranch = New DataColumn("branch", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnbranch)
				Me.columnworkdate = New DataColumn("workdate", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnworkdate)
				Me.columnnationality = New DataColumn("nationality", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnnationality)
				Me.columnmobile = New DataColumn("mobile", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnmobile)
				Me.columntotsalary = New DataColumn("totsalary", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columntotsalary)
				Me.columnDataColumn12 = New DataColumn("DataColumn12", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnDataColumn12)
				Me.columnDataColumn11 = New DataColumn("DataColumn11", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnDataColumn11)
				Me.columnDataColumn1 = New DataColumn("DataColumn1", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnDataColumn1)
				Me.columnname.Caption = "DataColumn1"
				Me.columnmanag.Caption = "DataColumn1"
				Me.columndep.Caption = "DataColumn1"
				Me.columnjob.Caption = "DataColumn1"
				Me.columnbranch.Caption = "DataColumn1"
				Me.columnworkdate.Caption = "DataColumn1"
				Me.columnnationality.Caption = "DataColumn1"
				Me.columnDataColumn12.Caption = "DataColumn1"
				Me.columnDataColumn11.Caption = "DataColumn1"
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function NewDataTable1Row() As dsEmployess.DataTable1Row
				Return CType(Me.NewRow(), dsEmployess.DataTable1Row)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Overrides Function NewRowFromBuilder(builder As DataRowBuilder) As DataRow
				Return New dsEmployess.DataTable1Row(builder)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Overrides Function GetRowType() As Type
				Return GetType(dsEmployess.DataTable1Row)
			End Function

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Protected Overrides Sub OnRowChanged(e As DataRowChangeEventArgs)
				MyBase.OnRowChanged(e)
				Dim flag As Boolean = Me.DataTable1RowChangedEvent IsNot Nothing
				If flag Then
					Dim dataTable1RowChangedEvent As dsEmployess.DataTable1RowChangeEventHandler = Me.DataTable1RowChangedEvent
					flag = (dataTable1RowChangedEvent IsNot Nothing)
					If flag Then
						dataTable1RowChangedEvent(Me, New dsEmployess.DataTable1RowChangeEvent(CType(e.Row, dsEmployess.DataTable1Row), e.Action))
					End If
				End If
			End Sub

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Protected Overrides Sub OnRowChanging(e As DataRowChangeEventArgs)
				MyBase.OnRowChanging(e)
				Dim flag As Boolean = Me.DataTable1RowChangingEvent IsNot Nothing
				If flag Then
					Dim dataTable1RowChangingEvent As dsEmployess.DataTable1RowChangeEventHandler = Me.DataTable1RowChangingEvent
					flag = (dataTable1RowChangingEvent IsNot Nothing)
					If flag Then
						dataTable1RowChangingEvent(Me, New dsEmployess.DataTable1RowChangeEvent(CType(e.Row, dsEmployess.DataTable1Row), e.Action))
					End If
				End If
			End Sub

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Protected Overrides Sub OnRowDeleted(e As DataRowChangeEventArgs)
				MyBase.OnRowDeleted(e)
				Dim flag As Boolean = Me.DataTable1RowDeletedEvent IsNot Nothing
				If flag Then
					Dim dataTable1RowDeletedEvent As dsEmployess.DataTable1RowChangeEventHandler = Me.DataTable1RowDeletedEvent
					flag = (dataTable1RowDeletedEvent IsNot Nothing)
					If flag Then
						dataTable1RowDeletedEvent(Me, New dsEmployess.DataTable1RowChangeEvent(CType(e.Row, dsEmployess.DataTable1Row), e.Action))
					End If
				End If
			End Sub

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Protected Overrides Sub OnRowDeleting(e As DataRowChangeEventArgs)
				MyBase.OnRowDeleting(e)
				Dim flag As Boolean = Me.DataTable1RowDeletingEvent IsNot Nothing
				If flag Then
					Dim dataTable1RowDeletingEvent As dsEmployess.DataTable1RowChangeEventHandler = Me.DataTable1RowDeletingEvent
					flag = (dataTable1RowDeletingEvent IsNot Nothing)
					If flag Then
						dataTable1RowDeletingEvent(Me, New dsEmployess.DataTable1RowChangeEvent(CType(e.Row, dsEmployess.DataTable1Row), e.Action))
					End If
				End If
			End Sub

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Sub RemoveDataTable1Row(row As dsEmployess.DataTable1Row)
				Me.Rows.Remove(row)
			End Sub

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Shared Function GetTypedTableSchema(xs As XmlSchemaSet) As XmlSchemaComplexType
				Dim xmlSchemaComplexType As XmlSchemaComplexType = New XmlSchemaComplexType()
				Dim xmlSchemaSequence As XmlSchemaSequence = New XmlSchemaSequence()
				Dim dsEmployess As dsEmployess = New dsEmployess()
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
				xmlSchemaAttribute.FixedValue = dsEmployess.[Namespace]
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute)
				Dim xmlSchemaAttribute2 As XmlSchemaAttribute = New XmlSchemaAttribute()
				xmlSchemaAttribute2.Name = "tableTypeName"
				xmlSchemaAttribute2.FixedValue = "DataTable1DataTable"
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2)
				xmlSchemaComplexType.Particle = xmlSchemaSequence
				Dim schemaSerializable As XmlSchema = dsEmployess.GetSchemaSerializable()
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

		Private Sub DataTable1DataTable_ColumnChanging(ByVal sender As Object, ByVal e As DataColumnChangeEventArgs) ' Handles DataTable1DataTable.ColumnChanging
			Dim flag As Boolean = Operators.CompareString(e.Column.ColumnName, Me.DataColumn1Column.ColumnName, False) = 0
			If flag Then
			End If
		End Sub
	End Class

		Public Class DataTable1Row
			Inherits DataRow

			Private tableDataTable1 As dsEmployess.DataTable1DataTable

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Friend Sub New(rb As DataRowBuilder)
				MyBase.New(rb)
				Me.tableDataTable1 = CType(Me.Table, dsEmployess.DataTable1DataTable)
			End Sub

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
			Public Property manag As String
				Get
					Dim result As String
					Try
						result = Conversions.ToString(Me(Me.tableDataTable1.managColumn))
					Catch innerException As InvalidCastException
						Throw New StrongTypingException("The value for column 'manag' in table 'DataTable1' is DBNull.", innerException)
					End Try
					Return result
				End Get
				Set(value As String)
					Me(Me.tableDataTable1.managColumn) = value
				End Set
			End Property

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Property dep As String
				Get
					Dim result As String
					Try
						result = Conversions.ToString(Me(Me.tableDataTable1.depColumn))
					Catch innerException As InvalidCastException
						Throw New StrongTypingException("The value for column 'dep' in table 'DataTable1' is DBNull.", innerException)
					End Try
					Return result
				End Get
				Set(value As String)
					Me(Me.tableDataTable1.depColumn) = value
				End Set
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Property job As String
				Get
					Dim result As String
					Try
						result = Conversions.ToString(Me(Me.tableDataTable1.jobColumn))
					Catch innerException As InvalidCastException
						Throw New StrongTypingException("The value for column 'job' in table 'DataTable1' is DBNull.", innerException)
					End Try
					Return result
				End Get
				Set(value As String)
					Me(Me.tableDataTable1.jobColumn) = value
				End Set
			End Property

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Property branch As String
				Get
					Dim result As String
					Try
						result = Conversions.ToString(Me(Me.tableDataTable1.branchColumn))
					Catch innerException As InvalidCastException
						Throw New StrongTypingException("The value for column 'branch' in table 'DataTable1' is DBNull.", innerException)
					End Try
					Return result
				End Get
				Set(value As String)
					Me(Me.tableDataTable1.branchColumn) = value
				End Set
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Property workdate As String
				Get
					Dim result As String
					Try
						result = Conversions.ToString(Me(Me.tableDataTable1.workdateColumn))
					Catch innerException As InvalidCastException
						Throw New StrongTypingException("The value for column 'workdate' in table 'DataTable1' is DBNull.", innerException)
					End Try
					Return result
				End Get
				Set(value As String)
					Me(Me.tableDataTable1.workdateColumn) = value
				End Set
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Property nationality As String
				Get
					Dim result As String
					Try
						result = Conversions.ToString(Me(Me.tableDataTable1.nationalityColumn))
					Catch innerException As InvalidCastException
						Throw New StrongTypingException("The value for column 'nationality' in table 'DataTable1' is DBNull.", innerException)
					End Try
					Return result
				End Get
				Set(value As String)
					Me(Me.tableDataTable1.nationalityColumn) = value
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
			Public Property totsalary As String
				Get
					Dim result As String
					Try
						result = Conversions.ToString(Me(Me.tableDataTable1.totsalaryColumn))
					Catch innerException As InvalidCastException
						Throw New StrongTypingException("The value for column 'totsalary' in table 'DataTable1' is DBNull.", innerException)
					End Try
					Return result
				End Get
				Set(value As String)
					Me(Me.tableDataTable1.totsalaryColumn) = value
				End Set
			End Property

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
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

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
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

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Function IsnameNull() As Boolean
				Return Me.IsNull(Me.tableDataTable1.nameColumn)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub SetnameNull()
				Me(Me.tableDataTable1.nameColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Function IsmanagNull() As Boolean
				Return Me.IsNull(Me.tableDataTable1.managColumn)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub SetmanagNull()
				Me(Me.tableDataTable1.managColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Function IsdepNull() As Boolean
				Return Me.IsNull(Me.tableDataTable1.depColumn)
			End Function

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Sub SetdepNull()
				Me(Me.tableDataTable1.depColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function IsjobNull() As Boolean
				Return Me.IsNull(Me.tableDataTable1.jobColumn)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub SetjobNull()
				Me(Me.tableDataTable1.jobColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function IsbranchNull() As Boolean
				Return Me.IsNull(Me.tableDataTable1.branchColumn)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub SetbranchNull()
				Me(Me.tableDataTable1.branchColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function IsworkdateNull() As Boolean
				Return Me.IsNull(Me.tableDataTable1.workdateColumn)
			End Function

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Sub SetworkdateNull()
				Me(Me.tableDataTable1.workdateColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Function IsnationalityNull() As Boolean
				Return Me.IsNull(Me.tableDataTable1.nationalityColumn)
			End Function

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Sub SetnationalityNull()
				Me(Me.tableDataTable1.nationalityColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function IsmobileNull() As Boolean
				Return Me.IsNull(Me.tableDataTable1.mobileColumn)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub SetmobileNull()
				Me(Me.tableDataTable1.mobileColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function IstotsalaryNull() As Boolean
				Return Me.IsNull(Me.tableDataTable1.totsalaryColumn)
			End Function

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Sub SettotsalaryNull()
				Me(Me.tableDataTable1.totsalaryColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Function IsDataColumn12Null() As Boolean
				Return Me.IsNull(Me.tableDataTable1.DataColumn12Column)
			End Function

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Sub SetDataColumn12Null()
				Me(Me.tableDataTable1.DataColumn12Column) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Function IsDataColumn11Null() As Boolean
				Return Me.IsNull(Me.tableDataTable1.DataColumn11Column)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub SetDataColumn11Null()
				Me(Me.tableDataTable1.DataColumn11Column) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function IsDataColumn1Null() As Boolean
				Return Me.IsNull(Me.tableDataTable1.DataColumn1Column)
			End Function

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Sub SetDataColumn1Null()
				Me(Me.tableDataTable1.DataColumn1Column) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub
		End Class

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
		Public Class DataTable1RowChangeEvent
			Inherits EventArgs

			Private eventRow As dsEmployess.DataTable1Row

			Private eventAction As DataRowAction

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Sub New(row As dsEmployess.DataTable1Row, action As DataRowAction)
				Me.eventRow = row
				Me.eventAction = action
			End Sub

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public ReadOnly Property Row As dsEmployess.DataTable1Row
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

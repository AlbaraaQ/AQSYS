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
	<DesignerCategory("code"), ToolboxItem(True), XmlSchemaProvider("GetTypedDataSetSchema"), XmlRoot("dsCurrencyDetails"), HelpKeyword("vs.data.DataSet"), Serializable()>
	Public Class dsCurrencyDetails
		Inherits DataSet

		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		Private tableDataTable1 As dsCurrencyDetails.DataTable1DataTable

		Private _schemaSerializationMode As SchemaSerializationMode
		Shared Sub New()
		End Sub
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = dsCurrencyDetails.__ENCList
			Dim flag As Boolean = False
			Try
				Monitor.Enter(_ENCList, flag)
				Dim flag2 As Boolean = dsCurrencyDetails.__ENCList.Count = dsCurrencyDetails.__ENCList.Capacity
				If flag2 Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = dsCurrencyDetails.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit While
						End If
						Dim weakReference As WeakReference = dsCurrencyDetails.__ENCList(num4)
						flag2 = weakReference.IsAlive
						If flag2 Then
							Dim flag3 As Boolean = num4 <> num
							If flag3 Then
								dsCurrencyDetails.__ENCList(num) = dsCurrencyDetails.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					dsCurrencyDetails.__ENCList.RemoveRange(num, dsCurrencyDetails.__ENCList.Count - num)
					dsCurrencyDetails.__ENCList.Capacity = dsCurrencyDetails.__ENCList.Count
				End If
				dsCurrencyDetails.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			Finally
				Dim flag3 As Boolean = flag
				If flag3 Then
					Monitor.[Exit](_ENCList)
				End If
			End Try
		End Sub

		<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
		Public Sub New()
			dsCurrencyDetails.__ENCAddToList(Me)
			Me._schemaSerializationMode = SchemaSerializationMode.IncludeSchema
			Me.BeginInit()
			Me.InitClass()
			Dim value As CollectionChangeEventHandler = AddressOf Me.SchemaChanged
			AddHandler MyBase.Tables.CollectionChanged, value
			AddHandler MyBase.Relations.CollectionChanged, value
			Me.EndInit()
		End Sub

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
		Protected Sub New(info As SerializationInfo, context As StreamingContext)
			MyBase.New(info, context, False)
			dsCurrencyDetails.__ENCAddToList(Me)
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
						MyBase.Tables.Add(New dsCurrencyDetails.DataTable1DataTable(dataSet.Tables("DataTable1")))
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

		<DebuggerNonUserCode(), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), Browsable(False), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
		Public ReadOnly Property DataTable1 As dsCurrencyDetails.DataTable1DataTable
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

		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
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
			Dim dsCurrencyDetails As dsCurrencyDetails = CType(MyBase.Clone(), dsCurrencyDetails)
			dsCurrencyDetails.InitVars()
			dsCurrencyDetails.SchemaSerializationMode = Me.SchemaSerializationMode
			Return dsCurrencyDetails
		End Function

		<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
		Protected Overrides Function ShouldSerializeTables() As Boolean
			Return False
		End Function

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
		Protected Overrides Function ShouldSerializeRelations() As Boolean
			Return False
		End Function

		<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
		Protected Overrides Sub ReadXmlSerializable(reader As XmlReader)
			Dim flag As Boolean = Me.DetermineSchemaSerializationMode(reader) = SchemaSerializationMode.IncludeSchema
			If flag Then
				Me.Reset()
				Dim dataSet As DataSet = New DataSet()
				dataSet.ReadXml(reader)
				flag = (dataSet.Tables("DataTable1") IsNot Nothing)
				If flag Then
					MyBase.Tables.Add(New dsCurrencyDetails.DataTable1DataTable(dataSet.Tables("DataTable1")))
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
			Me.tableDataTable1 = CType(MyBase.Tables("DataTable1"), dsCurrencyDetails.DataTable1DataTable)
			If initTable Then
				Dim flag As Boolean = Me.tableDataTable1 IsNot Nothing
				If flag Then
					Me.tableDataTable1.InitVars()
				End If
			End If
		End Sub

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
		Private Sub InitClass()
			Me.DataSetName = "dsCurrencyDetails"
			Me.Prefix = ""
			Me.[Namespace] = "http://tempuri.org/dsCurrencyDetails.xsd"
			Me.EnforceConstraints = True
			Me.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema
			Me.tableDataTable1 = New dsCurrencyDetails.DataTable1DataTable()
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

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
		Public Shared Function GetTypedDataSetSchema(xs As XmlSchemaSet) As XmlSchemaComplexType
			Dim dsCurrencyDetails As dsCurrencyDetails = New dsCurrencyDetails()
			Dim xmlSchemaComplexType As XmlSchemaComplexType = New XmlSchemaComplexType()
			Dim xmlSchemaSequence As XmlSchemaSequence = New XmlSchemaSequence()
			Dim xmlSchemaAny As XmlSchemaAny = New XmlSchemaAny()
			xmlSchemaAny.[Namespace] = dsCurrencyDetails.[Namespace]
			xmlSchemaSequence.Items.Add(xmlSchemaAny)
			xmlSchemaComplexType.Particle = xmlSchemaSequence
			Dim schemaSerializable As XmlSchema = dsCurrencyDetails.GetSchemaSerializable()
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
		Public Delegate Sub DataTable1RowChangeEventHandler(sender As Object, e As dsCurrencyDetails.DataTable1RowChangeEvent)

		<XmlSchemaProvider("GetTypedTableSchema"), Serializable()>
		Public Class DataTable1DataTable
			Inherits TypedTableBase(Of dsCurrencyDetails.DataTable1Row)

			Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

			Private columndoctype As DataColumn

			Private columnsafe As DataColumn

			Private columninvno As DataColumn

			Private columndate As DataColumn

			Private columnval As DataColumn

			Private columnprice As DataColumn

			Private columntotal As DataColumn

			Private columnDataColumn12 As DataColumn

			Private columnDataColumn11 As DataColumn

			Private columnDataColumn1 As DataColumn
			Shared Sub New()
			End Sub
			Private Shared Sub __ENCAddToList(value As Object)
				Dim _ENCList As List(Of WeakReference) = dsCurrencyDetails.DataTable1DataTable.__ENCList
				Dim flag As Boolean = False
				Try
					Monitor.Enter(_ENCList, flag)
					Dim flag2 As Boolean = dsCurrencyDetails.DataTable1DataTable.__ENCList.Count = dsCurrencyDetails.DataTable1DataTable.__ENCList.Capacity
					If flag2 Then
						Dim num As Integer = 0
						Dim num2 As Integer = 0
						Dim num3 As Integer = dsCurrencyDetails.DataTable1DataTable.__ENCList.Count - 1
						Dim num4 As Integer = num2
						While True
							Dim num5 As Integer = num4
							Dim num6 As Integer = num3
							If num5 > num6 Then
								Exit While
							End If
							Dim weakReference As WeakReference = dsCurrencyDetails.DataTable1DataTable.__ENCList(num4)
							flag2 = weakReference.IsAlive
							If flag2 Then
								Dim flag3 As Boolean = num4 <> num
								If flag3 Then
									dsCurrencyDetails.DataTable1DataTable.__ENCList(num) = dsCurrencyDetails.DataTable1DataTable.__ENCList(num4)
								End If
								num += 1
							End If
							num4 += 1
						End While
						dsCurrencyDetails.DataTable1DataTable.__ENCList.RemoveRange(num, dsCurrencyDetails.DataTable1DataTable.__ENCList.Count - num)
						dsCurrencyDetails.DataTable1DataTable.__ENCList.Capacity = dsCurrencyDetails.DataTable1DataTable.__ENCList.Count
					End If
					dsCurrencyDetails.DataTable1DataTable.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
				Finally
					Dim flag3 As Boolean = flag
					If flag3 Then
						Monitor.[Exit](_ENCList)
					End If
				End Try
			End Sub

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Sub New()
				dsCurrencyDetails.DataTable1DataTable.__ENCAddToList(Me)
				Me.TableName = "DataTable1"
				Me.BeginInit()
				Me.InitClass()
				Me.EndInit()
			End Sub

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Friend Sub New(table As DataTable)
				dsCurrencyDetails.DataTable1DataTable.__ENCAddToList(Me)
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
				dsCurrencyDetails.DataTable1DataTable.__ENCAddToList(Me)
				Me.InitVars()
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property doctypeColumn As DataColumn
				Get
					Return Me.columndoctype
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property safeColumn As DataColumn
				Get
					Return Me.columnsafe
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property invnoColumn As DataColumn
				Get
					Return Me.columninvno
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property dateColumn As DataColumn
				Get
					Return Me.columndate
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property valColumn As DataColumn
				Get
					Return Me.columnval
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property priceColumn As DataColumn
				Get
					Return Me.columnprice
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property totalColumn As DataColumn
				Get
					Return Me.columntotal
				End Get
			End Property

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public ReadOnly Property DataColumn12Column As DataColumn
				Get
					Return Me.columnDataColumn12
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property DataColumn11Column As DataColumn
				Get
					Return Me.columnDataColumn11
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property DataColumn1Column As DataColumn
				Get
					Return Me.columnDataColumn1
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Browsable(False), DebuggerNonUserCode()>
			Public ReadOnly Property Count As Integer
				Get
					Return Me.Rows.Count
				End Get
			End Property

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public ReadOnly Default Property Item(index As Integer) As dsCurrencyDetails.DataTable1Row
				Get
					Return CType(Me.Rows(index), dsCurrencyDetails.DataTable1Row)
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Event DataTable1RowChanging As dsCurrencyDetails.DataTable1RowChangeEventHandler

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Event DataTable1RowChanged As dsCurrencyDetails.DataTable1RowChangeEventHandler

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Event DataTable1RowDeleting As dsCurrencyDetails.DataTable1RowChangeEventHandler

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Event DataTable1RowDeleted As dsCurrencyDetails.DataTable1RowChangeEventHandler

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Sub AddDataTable1Row(row As dsCurrencyDetails.DataTable1Row)
				Me.Rows.Add(row)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function AddDataTable1Row(doctype As String, safe As String, invno As String, _date As String, val As String, price As String, total As String, DataColumn12 As String, DataColumn11 As String, DataColumn1 As String) As dsCurrencyDetails.DataTable1Row
				Dim dataTable1Row As dsCurrencyDetails.DataTable1Row = CType(Me.NewRow(), dsCurrencyDetails.DataTable1Row)
				Dim itemArray As Object() = New Object() { doctype, safe, invno, _date, val, price, total, DataColumn12, DataColumn11, DataColumn1 }
				dataTable1Row.ItemArray = itemArray
				Me.Rows.Add(dataTable1Row)
				Return dataTable1Row
			End Function

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Overrides Function Clone() As DataTable
				Dim dataTable1DataTable As dsCurrencyDetails.DataTable1DataTable = CType(MyBase.Clone(), dsCurrencyDetails.DataTable1DataTable)
				dataTable1DataTable.InitVars()
				Return dataTable1DataTable
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Overrides Function CreateInstance() As DataTable
				Return New dsCurrencyDetails.DataTable1DataTable()
			End Function

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Friend Sub InitVars()
				Me.columndoctype = MyBase.Columns("doctype")
				Me.columnsafe = MyBase.Columns("safe")
				Me.columninvno = MyBase.Columns("invno")
				Me.columndate = MyBase.Columns("date")
				Me.columnval = MyBase.Columns("val")
				Me.columnprice = MyBase.Columns("price")
				Me.columntotal = MyBase.Columns("total")
				Me.columnDataColumn12 = MyBase.Columns("DataColumn12")
				Me.columnDataColumn11 = MyBase.Columns("DataColumn11")
				Me.columnDataColumn1 = MyBase.Columns("DataColumn1")
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Private Sub InitClass()
				Me.columndoctype = New DataColumn("doctype", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columndoctype)
				Me.columnsafe = New DataColumn("safe", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnsafe)
				Me.columninvno = New DataColumn("invno", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columninvno)
				Me.columndate = New DataColumn("date", GetType(String), Nothing, MappingType.Element)
				Me.columndate.ExtendedProperties.Add("Generator_ColumnPropNameInTable", "dateColumn")
				Me.columndate.ExtendedProperties.Add("Generator_ColumnVarNameInTable", "columndate")
				Me.columndate.ExtendedProperties.Add("Generator_UserColumnName", "date")
				MyBase.Columns.Add(Me.columndate)
				Me.columnval = New DataColumn("val", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnval)
				Me.columnprice = New DataColumn("price", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnprice)
				Me.columntotal = New DataColumn("total", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columntotal)
				Me.columnDataColumn12 = New DataColumn("DataColumn12", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnDataColumn12)
				Me.columnDataColumn11 = New DataColumn("DataColumn11", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnDataColumn11)
				Me.columnDataColumn1 = New DataColumn("DataColumn1", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnDataColumn1)
				Me.columndoctype.Caption = "DataColumn1"
				Me.columnsafe.Caption = "DataColumn1"
				Me.columninvno.Caption = "DataColumn1"
				Me.columndate.Caption = "DataColumn1"
				Me.columnval.Caption = "DataColumn1"
				Me.columnprice.Caption = "DataColumn1"
				Me.columntotal.Caption = "DataColumn1"
				Me.columnDataColumn12.Caption = "DataColumn1"
				Me.columnDataColumn11.Caption = "DataColumn1"
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function NewDataTable1Row() As dsCurrencyDetails.DataTable1Row
				Return CType(Me.NewRow(), dsCurrencyDetails.DataTable1Row)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Overrides Function NewRowFromBuilder(builder As DataRowBuilder) As DataRow
				Return New dsCurrencyDetails.DataTable1Row(builder)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Overrides Function GetRowType() As Type
				Return GetType(dsCurrencyDetails.DataTable1Row)
			End Function

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Protected Overrides Sub OnRowChanged(e As DataRowChangeEventArgs)
				MyBase.OnRowChanged(e)
				Dim flag As Boolean = Me.DataTable1RowChangedEvent IsNot Nothing
				If flag Then
					Dim dataTable1RowChangedEvent As dsCurrencyDetails.DataTable1RowChangeEventHandler = Me.DataTable1RowChangedEvent
					flag = (dataTable1RowChangedEvent IsNot Nothing)
					If flag Then
						dataTable1RowChangedEvent(Me, New dsCurrencyDetails.DataTable1RowChangeEvent(CType(e.Row, dsCurrencyDetails.DataTable1Row), e.Action))
					End If
				End If
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Overrides Sub OnRowChanging(e As DataRowChangeEventArgs)
				MyBase.OnRowChanging(e)
				Dim flag As Boolean = Me.DataTable1RowChangingEvent IsNot Nothing
				If flag Then
					Dim dataTable1RowChangingEvent As dsCurrencyDetails.DataTable1RowChangeEventHandler = Me.DataTable1RowChangingEvent
					flag = (dataTable1RowChangingEvent IsNot Nothing)
					If flag Then
						dataTable1RowChangingEvent(Me, New dsCurrencyDetails.DataTable1RowChangeEvent(CType(e.Row, dsCurrencyDetails.DataTable1Row), e.Action))
					End If
				End If
			End Sub

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Protected Overrides Sub OnRowDeleted(e As DataRowChangeEventArgs)
				MyBase.OnRowDeleted(e)
				Dim flag As Boolean = Me.DataTable1RowDeletedEvent IsNot Nothing
				If flag Then
					Dim dataTable1RowDeletedEvent As dsCurrencyDetails.DataTable1RowChangeEventHandler = Me.DataTable1RowDeletedEvent
					flag = (dataTable1RowDeletedEvent IsNot Nothing)
					If flag Then
						dataTable1RowDeletedEvent(Me, New dsCurrencyDetails.DataTable1RowChangeEvent(CType(e.Row, dsCurrencyDetails.DataTable1Row), e.Action))
					End If
				End If
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Overrides Sub OnRowDeleting(e As DataRowChangeEventArgs)
				MyBase.OnRowDeleting(e)
				Dim flag As Boolean = Me.DataTable1RowDeletingEvent IsNot Nothing
				If flag Then
					Dim dataTable1RowDeletingEvent As dsCurrencyDetails.DataTable1RowChangeEventHandler = Me.DataTable1RowDeletingEvent
					flag = (dataTable1RowDeletingEvent IsNot Nothing)
					If flag Then
						dataTable1RowDeletingEvent(Me, New dsCurrencyDetails.DataTable1RowChangeEvent(CType(e.Row, dsCurrencyDetails.DataTable1Row), e.Action))
					End If
				End If
			End Sub

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Sub RemoveDataTable1Row(row As dsCurrencyDetails.DataTable1Row)
				Me.Rows.Remove(row)
			End Sub

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Shared Function GetTypedTableSchema(xs As XmlSchemaSet) As XmlSchemaComplexType
				Dim xmlSchemaComplexType As XmlSchemaComplexType = New XmlSchemaComplexType()
				Dim xmlSchemaSequence As XmlSchemaSequence = New XmlSchemaSequence()
				Dim dsCurrencyDetails As dsCurrencyDetails = New dsCurrencyDetails()
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
				xmlSchemaAttribute.FixedValue = dsCurrencyDetails.[Namespace]
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute)
				Dim xmlSchemaAttribute2 As XmlSchemaAttribute = New XmlSchemaAttribute()
				xmlSchemaAttribute2.Name = "tableTypeName"
				xmlSchemaAttribute2.FixedValue = "DataTable1DataTable"
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2)
				xmlSchemaComplexType.Particle = xmlSchemaSequence
				Dim schemaSerializable As XmlSchema = dsCurrencyDetails.GetSchemaSerializable()
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

			Private tableDataTable1 As dsCurrencyDetails.DataTable1DataTable

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Friend Sub New(rb As DataRowBuilder)
				MyBase.New(rb)
				Me.tableDataTable1 = CType(Me.Table, dsCurrencyDetails.DataTable1DataTable)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Property doctype As String
				Get
					Dim result As String
					Try
						result = Conversions.ToString(Me(Me.tableDataTable1.doctypeColumn))
					Catch innerException As InvalidCastException
						Throw New StrongTypingException("The value for column 'doctype' in table 'DataTable1' is DBNull.", innerException)
					End Try
					Return result
				End Get
				Set(value As String)
					Me(Me.tableDataTable1.doctypeColumn) = value
				End Set
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Property safe As String
				Get
					Dim result As String
					Try
						result = Conversions.ToString(Me(Me.tableDataTable1.safeColumn))
					Catch innerException As InvalidCastException
						Throw New StrongTypingException("The value for column 'safe' in table 'DataTable1' is DBNull.", innerException)
					End Try
					Return result
				End Get
				Set(value As String)
					Me(Me.tableDataTable1.safeColumn) = value
				End Set
			End Property

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Property invno As String
				Get
					Dim result As String
					Try
						result = Conversions.ToString(Me(Me.tableDataTable1.invnoColumn))
					Catch innerException As InvalidCastException
						Throw New StrongTypingException("The value for column 'invno' in table 'DataTable1' is DBNull.", innerException)
					End Try
					Return result
				End Get
				Set(value As String)
					Me(Me.tableDataTable1.invnoColumn) = value
				End Set
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Property _date As String
				Get
					Dim result As String
					Try
						result = Conversions.ToString(Me(Me.tableDataTable1.dateColumn))
					Catch innerException As InvalidCastException
						Throw New StrongTypingException("The value for column 'date' in table 'DataTable1' is DBNull.", innerException)
					End Try
					Return result
				End Get
				Set(value As String)
					Me(Me.tableDataTable1.dateColumn) = value
				End Set
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Property val As String
				Get
					Dim result As String
					Try
						result = Conversions.ToString(Me(Me.tableDataTable1.valColumn))
					Catch innerException As InvalidCastException
						Throw New StrongTypingException("The value for column 'val' in table 'DataTable1' is DBNull.", innerException)
					End Try
					Return result
				End Get
				Set(value As String)
					Me(Me.tableDataTable1.valColumn) = value
				End Set
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Property price As String
				Get
					Dim result As String
					Try
						result = Conversions.ToString(Me(Me.tableDataTable1.priceColumn))
					Catch innerException As InvalidCastException
						Throw New StrongTypingException("The value for column 'price' in table 'DataTable1' is DBNull.", innerException)
					End Try
					Return result
				End Get
				Set(value As String)
					Me(Me.tableDataTable1.priceColumn) = value
				End Set
			End Property

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Property total As String
				Get
					Dim result As String
					Try
						result = Conversions.ToString(Me(Me.tableDataTable1.totalColumn))
					Catch innerException As InvalidCastException
						Throw New StrongTypingException("The value for column 'total' in table 'DataTable1' is DBNull.", innerException)
					End Try
					Return result
				End Get
				Set(value As String)
					Me(Me.tableDataTable1.totalColumn) = value
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

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function IsdoctypeNull() As Boolean
				Return Me.IsNull(Me.tableDataTable1.doctypeColumn)
			End Function

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Sub SetdoctypeNull()
				Me(Me.tableDataTable1.doctypeColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function IssafeNull() As Boolean
				Return Me.IsNull(Me.tableDataTable1.safeColumn)
			End Function

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Sub SetsafeNull()
				Me(Me.tableDataTable1.safeColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Function IsinvnoNull() As Boolean
				Return Me.IsNull(Me.tableDataTable1.invnoColumn)
			End Function

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Sub SetinvnoNull()
				Me(Me.tableDataTable1.invnoColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Function Is_dateNull() As Boolean
				Return Me.IsNull(Me.tableDataTable1.dateColumn)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub Set_dateNull()
				Me(Me.tableDataTable1.dateColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function IsvalNull() As Boolean
				Return Me.IsNull(Me.tableDataTable1.valColumn)
			End Function

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Sub SetvalNull()
				Me(Me.tableDataTable1.valColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Function IspriceNull() As Boolean
				Return Me.IsNull(Me.tableDataTable1.priceColumn)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub SetpriceNull()
				Me(Me.tableDataTable1.priceColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Function IstotalNull() As Boolean
				Return Me.IsNull(Me.tableDataTable1.totalColumn)
			End Function

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Sub SettotalNull()
				Me(Me.tableDataTable1.totalColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
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

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
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

			Private eventRow As dsCurrencyDetails.DataTable1Row

			Private eventAction As DataRowAction

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub New(row As dsCurrencyDetails.DataTable1Row, action As DataRowAction)
				Me.eventRow = row
				Me.eventAction = action
			End Sub

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public ReadOnly Property Row As dsCurrencyDetails.DataTable1Row
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
	End Class

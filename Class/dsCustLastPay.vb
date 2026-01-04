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
	<ToolboxItem(True), XmlSchemaProvider("GetTypedDataSetSchema"), HelpKeyword("vs.data.DataSet"), XmlRoot("dsCustLastPay"), DesignerCategory("code"), Serializable()>
	Public Class dsCustLastPay
		Inherits DataSet

		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		Private tableDataTable1 As dsCustLastPay.DataTable1DataTable

		Private _schemaSerializationMode As SchemaSerializationMode
		Shared Sub New()
		End Sub
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = dsCustLastPay.__ENCList
			Dim flag As Boolean = False
			Try
				Monitor.Enter(_ENCList, flag)
				Dim flag2 As Boolean = dsCustLastPay.__ENCList.Count = dsCustLastPay.__ENCList.Capacity
				If flag2 Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = dsCustLastPay.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit While
						End If
						Dim weakReference As WeakReference = dsCustLastPay.__ENCList(num4)
						flag2 = weakReference.IsAlive
						If flag2 Then
							Dim flag3 As Boolean = num4 <> num
							If flag3 Then
								dsCustLastPay.__ENCList(num) = dsCustLastPay.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					dsCustLastPay.__ENCList.RemoveRange(num, dsCustLastPay.__ENCList.Count - num)
					dsCustLastPay.__ENCList.Capacity = dsCustLastPay.__ENCList.Count
				End If
				dsCustLastPay.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			Finally
				Dim flag3 As Boolean = flag
				If flag3 Then
					Monitor.[Exit](_ENCList)
				End If
			End Try
		End Sub

		<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
		Public Sub New()
			dsCustLastPay.__ENCAddToList(Me)
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
			dsCustLastPay.__ENCAddToList(Me)
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
						MyBase.Tables.Add(New dsCustLastPay.DataTable1DataTable(dataSet.Tables("DataTable1")))
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

		<Browsable(False), DebuggerNonUserCode(), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
		Public ReadOnly Property DataTable1 As dsCustLastPay.DataTable1DataTable
			Get
				Return Me.tableDataTable1
			End Get
		End Property

		<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DesignerSerializationVisibility(DesignerSerializationVisibility.Visible), Browsable(True)>
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
			Dim dsCustLastPay As dsCustLastPay = CType(MyBase.Clone(), dsCustLastPay)
			dsCustLastPay.InitVars()
			dsCustLastPay.SchemaSerializationMode = Me.SchemaSerializationMode
			Return dsCustLastPay
		End Function

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
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
					MyBase.Tables.Add(New dsCustLastPay.DataTable1DataTable(dataSet.Tables("DataTable1")))
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

		<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
		Friend Sub InitVars(initTable As Boolean)
			Me.tableDataTable1 = CType(MyBase.Tables("DataTable1"), dsCustLastPay.DataTable1DataTable)
			If initTable Then
				Dim flag As Boolean = Me.tableDataTable1 IsNot Nothing
				If flag Then
					Me.tableDataTable1.InitVars()
				End If
			End If
		End Sub

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
		Private Sub InitClass()
			Me.DataSetName = "dsCustLastPay"
			Me.Prefix = ""
			Me.[Namespace] = "http://tempuri.org/dsCustLastPay.xsd"
			Me.EnforceConstraints = True
			Me.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema
			Me.tableDataTable1 = New dsCustLastPay.DataTable1DataTable()
			MyBase.Tables.Add(Me.tableDataTable1)
		End Sub

		<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
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
			Dim dsCustLastPay As dsCustLastPay = New dsCustLastPay()
			Dim xmlSchemaComplexType As XmlSchemaComplexType = New XmlSchemaComplexType()
			Dim xmlSchemaSequence As XmlSchemaSequence = New XmlSchemaSequence()
			Dim xmlSchemaAny As XmlSchemaAny = New XmlSchemaAny()
			xmlSchemaAny.[Namespace] = dsCustLastPay.[Namespace]
			xmlSchemaSequence.Items.Add(xmlSchemaAny)
			xmlSchemaComplexType.Particle = xmlSchemaSequence
			Dim schemaSerializable As XmlSchema = dsCustLastPay.GetSchemaSerializable()
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
		Public Delegate Sub DataTable1RowChangeEventHandler(sender As Object, e As dsCustLastPay.DataTable1RowChangeEvent)

		<XmlSchemaProvider("GetTypedTableSchema"), Serializable()>
		Public Class DataTable1DataTable
			Inherits TypedTableBase(Of dsCustLastPay.DataTable1Row)

			Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

			Private columnaccno As DataColumn

			Private columncustname As DataColumn

			Private columntel As DataColumn

			Private columnmobile As DataColumn

			Private columnval As DataColumn

			Private columndate As DataColumn

			Private columndoctype As DataColumn

			Private columnbalance As DataColumn

			Private columnstate As DataColumn

			Private columnDataColumn11 As DataColumn

			Private columnDataColumn1 As DataColumn
			Shared Sub New()
			End Sub
			Private Shared Sub __ENCAddToList(value As Object)
				Dim _ENCList As List(Of WeakReference) = dsCustLastPay.DataTable1DataTable.__ENCList
				Dim flag As Boolean = False
				Try
					Monitor.Enter(_ENCList, flag)
					Dim flag2 As Boolean = dsCustLastPay.DataTable1DataTable.__ENCList.Count = dsCustLastPay.DataTable1DataTable.__ENCList.Capacity
					If flag2 Then
						Dim num As Integer = 0
						Dim num2 As Integer = 0
						Dim num3 As Integer = dsCustLastPay.DataTable1DataTable.__ENCList.Count - 1
						Dim num4 As Integer = num2
						While True
							Dim num5 As Integer = num4
							Dim num6 As Integer = num3
							If num5 > num6 Then
								Exit While
							End If
							Dim weakReference As WeakReference = dsCustLastPay.DataTable1DataTable.__ENCList(num4)
							flag2 = weakReference.IsAlive
							If flag2 Then
								Dim flag3 As Boolean = num4 <> num
								If flag3 Then
									dsCustLastPay.DataTable1DataTable.__ENCList(num) = dsCustLastPay.DataTable1DataTable.__ENCList(num4)
								End If
								num += 1
							End If
							num4 += 1
						End While
						dsCustLastPay.DataTable1DataTable.__ENCList.RemoveRange(num, dsCustLastPay.DataTable1DataTable.__ENCList.Count - num)
						dsCustLastPay.DataTable1DataTable.__ENCList.Capacity = dsCustLastPay.DataTable1DataTable.__ENCList.Count
					End If
					dsCustLastPay.DataTable1DataTable.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
				Finally
					Dim flag3 As Boolean = flag
					If flag3 Then
						Monitor.[Exit](_ENCList)
					End If
				End Try
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub New()
				dsCustLastPay.DataTable1DataTable.__ENCAddToList(Me)
				Me.TableName = "DataTable1"
				Me.BeginInit()
				Me.InitClass()
				Me.EndInit()
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Friend Sub New(table As DataTable)
				dsCustLastPay.DataTable1DataTable.__ENCAddToList(Me)
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
				dsCustLastPay.DataTable1DataTable.__ENCAddToList(Me)
				Me.InitVars()
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property accnoColumn As DataColumn
				Get
					Return Me.columnaccno
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property custnameColumn As DataColumn
				Get
					Return Me.columncustname
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
			Public ReadOnly Property valColumn As DataColumn
				Get
					Return Me.columnval
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property dateColumn As DataColumn
				Get
					Return Me.columndate
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property doctypeColumn As DataColumn
				Get
					Return Me.columndoctype
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property balanceColumn As DataColumn
				Get
					Return Me.columnbalance
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property stateColumn As DataColumn
				Get
					Return Me.columnstate
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

			<DebuggerNonUserCode(), Browsable(False), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public ReadOnly Property Count As Integer
				Get
					Return Me.Rows.Count
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Default Property Item(index As Integer) As dsCustLastPay.DataTable1Row
				Get
					Return CType(Me.Rows(index), dsCustLastPay.DataTable1Row)
				End Get
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Event DataTable1RowChanging As dsCustLastPay.DataTable1RowChangeEventHandler

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Event DataTable1RowChanged As dsCustLastPay.DataTable1RowChangeEventHandler

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Event DataTable1RowDeleting As dsCustLastPay.DataTable1RowChangeEventHandler

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Event DataTable1RowDeleted As dsCustLastPay.DataTable1RowChangeEventHandler

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Sub AddDataTable1Row(row As dsCustLastPay.DataTable1Row)
				Me.Rows.Add(row)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function AddDataTable1Row(accno As String, custname As String, tel As String, mobile As String, val As String, _date As String, doctype As String, balance As String, state As String, DataColumn11 As String, DataColumn1 As String) As dsCustLastPay.DataTable1Row
				Dim dataTable1Row As dsCustLastPay.DataTable1Row = CType(Me.NewRow(), dsCustLastPay.DataTable1Row)
				Dim itemArray As Object() = New Object() { accno, custname, tel, mobile, val, _date, doctype, balance, state, DataColumn11, DataColumn1 }
				dataTable1Row.ItemArray = itemArray
				Me.Rows.Add(dataTable1Row)
				Return dataTable1Row
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Overrides Function Clone() As DataTable
				Dim dataTable1DataTable As dsCustLastPay.DataTable1DataTable = CType(MyBase.Clone(), dsCustLastPay.DataTable1DataTable)
				dataTable1DataTable.InitVars()
				Return dataTable1DataTable
			End Function

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Protected Overrides Function CreateInstance() As DataTable
				Return New dsCustLastPay.DataTable1DataTable()
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Friend Sub InitVars()
				Me.columnaccno = MyBase.Columns("accno")
				Me.columncustname = MyBase.Columns("custname")
				Me.columntel = MyBase.Columns("tel")
				Me.columnmobile = MyBase.Columns("mobile")
				Me.columnval = MyBase.Columns("val")
				Me.columndate = MyBase.Columns("date")
				Me.columndoctype = MyBase.Columns("doctype")
				Me.columnbalance = MyBase.Columns("balance")
				Me.columnstate = MyBase.Columns("state")
				Me.columnDataColumn11 = MyBase.Columns("DataColumn11")
				Me.columnDataColumn1 = MyBase.Columns("DataColumn1")
			End Sub

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Private Sub InitClass()
				Me.columnaccno = New DataColumn("accno", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnaccno)
				Me.columncustname = New DataColumn("custname", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columncustname)
				Me.columntel = New DataColumn("tel", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columntel)
				Me.columnmobile = New DataColumn("mobile", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnmobile)
				Me.columnval = New DataColumn("val", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnval)
				Me.columndate = New DataColumn("date", GetType(String), Nothing, MappingType.Element)
				Me.columndate.ExtendedProperties.Add("Generator_ColumnPropNameInTable", "dateColumn")
				Me.columndate.ExtendedProperties.Add("Generator_ColumnVarNameInTable", "columndate")
				Me.columndate.ExtendedProperties.Add("Generator_UserColumnName", "date")
				MyBase.Columns.Add(Me.columndate)
				Me.columndoctype = New DataColumn("doctype", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columndoctype)
				Me.columnbalance = New DataColumn("balance", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnbalance)
				Me.columnstate = New DataColumn("state", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnstate)
				Me.columnDataColumn11 = New DataColumn("DataColumn11", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnDataColumn11)
				Me.columnDataColumn1 = New DataColumn("DataColumn1", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnDataColumn1)
				Me.columnaccno.Caption = "DataColumn1"
				Me.columncustname.Caption = "DataColumn1"
				Me.columntel.Caption = "DataColumn1"
				Me.columnmobile.Caption = "DataColumn1"
				Me.columnval.Caption = "DataColumn1"
				Me.columndate.Caption = "DataColumn1"
				Me.columndoctype.Caption = "DataColumn1"
				Me.columnbalance.Caption = "DataColumn1"
				Me.columnstate.Caption = "DataColumn1"
				Me.columnDataColumn11.Caption = "DataColumn1"
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function NewDataTable1Row() As dsCustLastPay.DataTable1Row
				Return CType(Me.NewRow(), dsCustLastPay.DataTable1Row)
			End Function

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Protected Overrides Function NewRowFromBuilder(builder As DataRowBuilder) As DataRow
				Return New dsCustLastPay.DataTable1Row(builder)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Overrides Function GetRowType() As Type
				Return GetType(dsCustLastPay.DataTable1Row)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Overrides Sub OnRowChanged(e As DataRowChangeEventArgs)
				MyBase.OnRowChanged(e)
				Dim flag As Boolean = Me.DataTable1RowChangedEvent IsNot Nothing
				If flag Then
					Dim dataTable1RowChangedEvent As dsCustLastPay.DataTable1RowChangeEventHandler = Me.DataTable1RowChangedEvent
					flag = (dataTable1RowChangedEvent IsNot Nothing)
					If flag Then
						dataTable1RowChangedEvent(Me, New dsCustLastPay.DataTable1RowChangeEvent(CType(e.Row, dsCustLastPay.DataTable1Row), e.Action))
					End If
				End If
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Overrides Sub OnRowChanging(e As DataRowChangeEventArgs)
				MyBase.OnRowChanging(e)
				Dim flag As Boolean = Me.DataTable1RowChangingEvent IsNot Nothing
				If flag Then
					Dim dataTable1RowChangingEvent As dsCustLastPay.DataTable1RowChangeEventHandler = Me.DataTable1RowChangingEvent
					flag = (dataTable1RowChangingEvent IsNot Nothing)
					If flag Then
						dataTable1RowChangingEvent(Me, New dsCustLastPay.DataTable1RowChangeEvent(CType(e.Row, dsCustLastPay.DataTable1Row), e.Action))
					End If
				End If
			End Sub

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Protected Overrides Sub OnRowDeleted(e As DataRowChangeEventArgs)
				MyBase.OnRowDeleted(e)
				Dim flag As Boolean = Me.DataTable1RowDeletedEvent IsNot Nothing
				If flag Then
					Dim dataTable1RowDeletedEvent As dsCustLastPay.DataTable1RowChangeEventHandler = Me.DataTable1RowDeletedEvent
					flag = (dataTable1RowDeletedEvent IsNot Nothing)
					If flag Then
						dataTable1RowDeletedEvent(Me, New dsCustLastPay.DataTable1RowChangeEvent(CType(e.Row, dsCustLastPay.DataTable1Row), e.Action))
					End If
				End If
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Protected Overrides Sub OnRowDeleting(e As DataRowChangeEventArgs)
				MyBase.OnRowDeleting(e)
				Dim flag As Boolean = Me.DataTable1RowDeletingEvent IsNot Nothing
				If flag Then
					Dim dataTable1RowDeletingEvent As dsCustLastPay.DataTable1RowChangeEventHandler = Me.DataTable1RowDeletingEvent
					flag = (dataTable1RowDeletingEvent IsNot Nothing)
					If flag Then
						dataTable1RowDeletingEvent(Me, New dsCustLastPay.DataTable1RowChangeEvent(CType(e.Row, dsCustLastPay.DataTable1Row), e.Action))
					End If
				End If
			End Sub

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Sub RemoveDataTable1Row(row As dsCustLastPay.DataTable1Row)
				Me.Rows.Remove(row)
			End Sub

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Shared Function GetTypedTableSchema(xs As XmlSchemaSet) As XmlSchemaComplexType
				Dim xmlSchemaComplexType As XmlSchemaComplexType = New XmlSchemaComplexType()
				Dim xmlSchemaSequence As XmlSchemaSequence = New XmlSchemaSequence()
				Dim dsCustLastPay As dsCustLastPay = New dsCustLastPay()
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
				xmlSchemaAttribute.FixedValue = dsCustLastPay.[Namespace]
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute)
				Dim xmlSchemaAttribute2 As XmlSchemaAttribute = New XmlSchemaAttribute()
				xmlSchemaAttribute2.Name = "tableTypeName"
				xmlSchemaAttribute2.FixedValue = "DataTable1DataTable"
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2)
				xmlSchemaComplexType.Particle = xmlSchemaSequence
				Dim schemaSerializable As XmlSchema = dsCustLastPay.GetSchemaSerializable()
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

			Private tableDataTable1 As dsCustLastPay.DataTable1DataTable

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Friend Sub New(rb As DataRowBuilder)
				MyBase.New(rb)
				Me.tableDataTable1 = CType(Me.Table, dsCustLastPay.DataTable1DataTable)
			End Sub

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Property accno As String
				Get
					Dim result As String
					Try
						result = Conversions.ToString(Me(Me.tableDataTable1.accnoColumn))
					Catch innerException As InvalidCastException
						Throw New StrongTypingException("The value for column 'accno' in table 'DataTable1' is DBNull.", innerException)
					End Try
					Return result
				End Get
				Set(value As String)
					Me(Me.tableDataTable1.accnoColumn) = value
				End Set
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Property custname As String
				Get
					Dim result As String
					Try
						result = Conversions.ToString(Me(Me.tableDataTable1.custnameColumn))
					Catch innerException As InvalidCastException
						Throw New StrongTypingException("The value for column 'custname' in table 'DataTable1' is DBNull.", innerException)
					End Try
					Return result
				End Get
				Set(value As String)
					Me(Me.tableDataTable1.custnameColumn) = value
				End Set
			End Property

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
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

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
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

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
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
			Public Property balance As String
				Get
					Dim result As String
					Try
						result = Conversions.ToString(Me(Me.tableDataTable1.balanceColumn))
					Catch innerException As InvalidCastException
						Throw New StrongTypingException("The value for column 'balance' in table 'DataTable1' is DBNull.", innerException)
					End Try
					Return result
				End Get
				Set(value As String)
					Me(Me.tableDataTable1.balanceColumn) = value
				End Set
			End Property

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Property state As String
				Get
					Dim result As String
					Try
						result = Conversions.ToString(Me(Me.tableDataTable1.stateColumn))
					Catch innerException As InvalidCastException
						Throw New StrongTypingException("The value for column 'state' in table 'DataTable1' is DBNull.", innerException)
					End Try
					Return result
				End Get
				Set(value As String)
					Me(Me.tableDataTable1.stateColumn) = value
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

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Function IsaccnoNull() As Boolean
				Return Me.IsNull(Me.tableDataTable1.accnoColumn)
			End Function

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Sub SetaccnoNull()
				Me(Me.tableDataTable1.accnoColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function IscustnameNull() As Boolean
				Return Me.IsNull(Me.tableDataTable1.custnameColumn)
			End Function

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Sub SetcustnameNull()
				Me(Me.tableDataTable1.custnameColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function IstelNull() As Boolean
				Return Me.IsNull(Me.tableDataTable1.telColumn)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub SettelNull()
				Me(Me.tableDataTable1.telColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function IsmobileNull() As Boolean
				Return Me.IsNull(Me.tableDataTable1.mobileColumn)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub SetmobileNull()
				Me(Me.tableDataTable1.mobileColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Function IsvalNull() As Boolean
				Return Me.IsNull(Me.tableDataTable1.valColumn)
			End Function

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub SetvalNull()
				Me(Me.tableDataTable1.valColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
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
			Public Function IsdoctypeNull() As Boolean
				Return Me.IsNull(Me.tableDataTable1.doctypeColumn)
			End Function

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Sub SetdoctypeNull()
				Me(Me.tableDataTable1.doctypeColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Function IsbalanceNull() As Boolean
				Return Me.IsNull(Me.tableDataTable1.balanceColumn)
			End Function

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Sub SetbalanceNull()
				Me(Me.tableDataTable1.balanceColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Function IsstateNull() As Boolean
				Return Me.IsNull(Me.tableDataTable1.stateColumn)
			End Function

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Sub SetstateNull()
				Me(Me.tableDataTable1.stateColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
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

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public Sub SetDataColumn1Null()
				Me(Me.tableDataTable1.DataColumn1Column) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub
		End Class

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
		Public Class DataTable1RowChangeEvent
			Inherits EventArgs

			Private eventRow As dsCustLastPay.DataTable1Row

			Private eventAction As DataRowAction

			<DebuggerNonUserCode(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
			Public Sub New(row As dsCustLastPay.DataTable1Row, action As DataRowAction)
				Me.eventRow = row
				Me.eventAction = action
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode()>
			Public ReadOnly Property Row As dsCustLastPay.DataTable1Row
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

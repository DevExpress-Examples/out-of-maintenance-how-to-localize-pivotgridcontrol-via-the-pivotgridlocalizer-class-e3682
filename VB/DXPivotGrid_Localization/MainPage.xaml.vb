Imports Microsoft.VisualBasic
Imports System.IO
Imports System.Windows.Controls
Imports System.Xml.Serialization
Imports DevExpress.XtraPivotGrid.Localization

Namespace DXPivotGrid_Localization
	Partial Public Class MainPage
		Inherits UserControl
		Private dataFileName As String = "nwind.xml"
		Public Sub New()
			PivotGridLocalizer.Active = New CustomDXPivotGridLocalizer()
			InitializeComponent()

			' Parses an XML file and creates a collection of data items.
			Dim assembly As System.Reflection.Assembly = _
				System.Reflection.Assembly.GetExecutingAssembly()
			Dim stream As Stream = assembly.GetManifestResourceStream(dataFileName)
			Dim s As New XmlSerializer(GetType(OrderData))
			Dim dataSource As Object = s.Deserialize(stream)

			' Binds a pivot grid to this collection.
			pivotGridControl1.DataSource = dataSource
		End Sub
	End Class
	Public Class CustomDXPivotGridLocalizer
		Inherits PivotGridLocalizer
		Public Overrides Function GetLocalizedString(ByVal id As PivotGridStringId) As String
			Select Case id
				Case PivotGridStringId.GrandTotal
					Return "Aggregate Total"
				Case PivotGridStringId.TotalFormat
					Return "Total for {0}"
				Case PivotGridStringId.FilterHeadersCustomization
					Return "Filter Header Area is currently empty"
				Case Else
					Return MyBase.GetLocalizedString(id)
			End Select
		End Function
	End Class
End Namespace
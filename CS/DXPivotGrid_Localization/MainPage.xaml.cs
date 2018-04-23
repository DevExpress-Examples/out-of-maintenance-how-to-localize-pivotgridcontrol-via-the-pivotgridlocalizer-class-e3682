using System.IO;
using System.Reflection;
using System.Windows.Controls;
using System.Xml.Serialization;
using DevExpress.XtraPivotGrid.Localization;

namespace DXPivotGrid_Localization {
    public partial class MainPage : UserControl {
        string dataFileName = "DXPivotGrid_Localization.nwind.xml";
        public MainPage() {
            PivotGridLocalizer.Active = new CustomDXPivotGridLocalizer();
            InitializeComponent();

            // Parses an XML file and creates a collection of data items.
            Assembly assembly = Assembly.GetExecutingAssembly();
            Stream stream = assembly.GetManifestResourceStream(dataFileName);
            XmlSerializer s = new XmlSerializer(typeof(OrderData));
            object dataSource = s.Deserialize(stream);

            // Binds a pivot grid to this collection.
            pivotGridControl1.DataSource = dataSource;
        }
    }
    public class CustomDXPivotGridLocalizer : PivotGridLocalizer {
        public override string GetLocalizedString(PivotGridStringId id) {
            switch (id) {
                case PivotGridStringId.GrandTotal:
                    return "Aggregate Total";
                case PivotGridStringId.TotalFormat:
                    return "Total for {0}";
                case PivotGridStringId.FilterHeadersCustomization:
                    return "Filter Header Area is currently empty";
                default:
                    return base.GetLocalizedString(id);
            }
        }
    }
}
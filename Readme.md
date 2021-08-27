<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128578210/11.2.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3682)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [MainPage.xaml](./CS/DXPivotGrid_Localization/MainPage.xaml) (VB: [MainPage.xaml](./VB/DXPivotGrid_Localization/MainPage.xaml))
* [MainPage.xaml.cs](./CS/DXPivotGrid_Localization/MainPage.xaml.cs) (VB: [MainPage.xaml.vb](./VB/DXPivotGrid_Localization/MainPage.xaml.vb))
<!-- default file list end -->
# How to localize PivotGridControl via the PivotGridLocalizer class


<p>The following example shows how to localize PivotGridControl via the PivotGridLocalizer class.</p><p>In this example, grand total headers ('Grand Total' by default) are replaced with 'Aggregate Total' strings, automatic total headers' patterns ('{0} Total' by default) are replaced with 'Total for {0}' strings, and the text displayed within the Filter Header Area ('Drop Filter Fields Here' by default) is replaced with 'Filter Header Area is currently empty' string. To do this, a PivotGridLocalizer class descendant (CustomDXPivotGridLocalizer) has been created, and its GetLocalizedString method has been overridden to replace the default strings.</p><br />


<br/>



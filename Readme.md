<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128655237/24.2.1%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T324511)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# WPF Property Grid - Display Object Properties

In this example, a user selects a contact, and the [`PropertyGridControl`](https://docs.devexpress.com/WPF/DevExpress.Xpf.PropertyGrid.PropertyGridControl) displays its properties. The user can modify these properties directly in the panel.

![Display Object Properties](./Images/property-grid.jpg)

## Implementation Details

### Define Data Source

The view model exposes a list of contacts. Each contact includes the following fields: `FirstName`, `LastName`, `Email`, `Phone`, `Address`, `City`, `State`, and `Zip`.

```csharp
public class ViewModel {
    public List<Contact> Items { get; set; }
    public ViewModel() {
        Items = new List<Contact> {
            new Contact() {
                FirstName = "Carolyn",
                LastName = "Baker",
                Email = "carolyn.baker@example.com", 
                Phone = "(555)349-3010",
                Address = "1198 Theresa Cir", 
                City = "Whitinsville", 
                State = "MA", 
                Zip = "01582"
            }, ...
        };
    }
}
```

### Create Editable Object

The `Contact` class defines fields that appear in the `PropertyGridControl`. This class supports property change notifications, so all updates in the UI are immediately applied to the data object:

```csharp
public class Contact : BindableBase {
    string _FirstName;
    public string FirstName {
        get { return _FirstName; }
        set {
            _FirstName = value;
            RaisePropertyChanged(() => FirstName);
        }
    }
    ...
}
```

### Connect UI

Bind the `PropertyGridControl` to the focused or selected row in the `GridControl`:

```csharp
<dxg:GridControl ItemsSource="{Binding Items}" Name="grid">
    <dxg:GridControl.Columns>
        <dxg:GridColumn FieldName="FirstName" />
        <dxg:GridColumn FieldName="LastName" />
    </dxg:GridControl.Columns>
</dxg:GridControl>

<dxprg:PropertyGridControl SelectedObject="{Binding ElementName=grid, Path=CurrentItem}" />
<dxprg:PropertyGridControl SelectedObjects="{Binding ElementName=grid, Path=SelectedItems}" />
```

When the user selects a contact, the PropertyGridControl displays its properties and allows in-place editing.

## Files to Review

* [MainWindow.xaml](./CS/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/MainWindow.xaml.vb))
* [Data.cs](./CS/Data.cs) (VB: [Data.vb](./VB/Data.vb))

## Documentation

* [GridControl](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.GridControl)
* [PropertyGridControl](https://docs.devexpress.com/WPF/DevExpress.Xpf.PropertyGrid.PropertyGridControl)
* [PropertyGridControl.SelectedObject](https://documentation.devexpress.com/#WPF/DevExpressXpfPropertyGridPropertyGridControl_SelectedObjecttopic)
* [DXTabControl](https://docs.devexpress.com/WPF/7975/controls-and-libraries/layout-management/tab-control/fundamentals/dxtabcontrol)

## More Examples

* [WPF Data Grid – Bind to Dynamic Data](https://github.com/DevExpress-Examples/wpf-bind-gridcontrol-to-dynamic-data)
* [WPF Data Grid – Handle Drag and Drop Operations](https://github.com/DevExpress-Examples/wpf-grid-handle-drag-and-drop)
* [WPF Data Grid – Specify Custom Content for Column Chooser Headers](https://github.com/DevExpress-Examples/wpf-data-grid-custom-content-for-column-chooser-headers)

<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-property-grid-display-object-properties&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-property-grid-display-object-properties&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->

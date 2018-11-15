<!-- default file list -->
*Files to look at*:

* [Data.cs](./CS/Data.cs) (VB: [Data.vb](./VB/Data.vb))
* **[MainWindow.xaml](./CS/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/MainWindow.xaml))**
* [MainWindow.xaml.cs](./CS/MainWindow.xaml.cs) (VB: [MainWindow.xaml](./VB/MainWindow.xaml))
<!-- default file list end -->
# How to: Show Object Properties


<p>The PropertyGridControl is the control designed to edit object properties. It can be bound to a specific object as well as a collection of objects.</p><br><p>To browse and manage properties of a specific object, set the  <a href="https://documentation.devexpress.com/#WPF/DevExpressXpfPropertyGridPropertyGridControl_SelectedObjecttopic">PropertyGridControl.SelectedObject</a> property to this object.</p>

```cs
public partial class MainWindow {
    public MainWindow() {
        DataContext = new Contact("Carolyn", "Baker");
        InitializeComponent();
    }
}
public class Contact {
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public Contact(string firstName, string lastName) {
        FirstName = firstName;
        LastName = lastName;
    }
}
```



```xaml
<dxprg:PropertyGridControl SelectedObject="{Binding Path=.}"/>
```

<br><p>To edit properties of multiple objects simultaneously, use <a href="https://documentation.devexpress.com/#WPF/DevExpressXpfPropertyGridPropertyGridControl_SelectedObjectstopic">PropertyGridControl.SelectedObjects</a>.</p>

```cs
public partial class MainWindow {
    public MainWindow() {
        DataContext = new List<Contact> { new Contact("Carolyn", "Baker"), new Contact("Amber", "Seaman") };
        InitializeComponent();
    }
}
```



```xaml
<dxprg:PropertyGridControl SelectedObjects="{Binding Path=.}" ExpandCategoriesWhenSelectedObjectChanged="True"/>
```

<br>

<br/>



<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128632100/24.2.1%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2071)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# WinForms Data Grid - How to toggle row visibility

This example implements a `RowVisibilityHelper` helper class. Its `HideRow` and `ShowRow` methods allow you to hide/show the specified data row:

```csharp
public class RowVisibilityHelper : Component {
    // ...
    public void HideRow(int dataSourceRowIndex) {
        if (!IsRowInvisible(dataSourceRowIndex))
            InvisibleRows.Add(dataSourceRowIndex);
        GridView.RefreshData();
    }
    public void ShowRow(int dataSourceRowIndex) {
        if (IsRowInvisible(dataSourceRowIndex))
            InvisibleRows.Remove(dataSourceRowIndex);
        GridView.RefreshData();
    }
    public void ToggleRowVisibility(int dataSourceRowIndex) {
        if (IsRowInvisible(dataSourceRowIndex))
            ShowRow(dataSourceRowIndex);
        else
            HideRow(dataSourceRowIndex);
    }
}
```

![WinForms Data Grid - Toggle row visibility](https://raw.githubusercontent.com/DevExpress-Examples/how-to-toggle-a-rows-visibility-e2071/17.1.8%2B/media/winforms-grid-toggle-row-visibility.png)


## Files to Review

* [Form1.cs](./CS/WindowsApplication1/Form1.cs) (VB: [Form1.vb](./VB/WindowsApplication1/Form1.vb))
* [RowVisibilityHelper.cs](./CS/WindowsApplication1/RowVisibilityHelper.cs) (VB: [RowVisibilityHelper.vb](./VB/WindowsApplication1/RowVisibilityHelper.vb))
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-grid-toggle-row-visibility&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-grid-toggle-row-visibility&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->

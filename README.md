# How to Set Descriptions for Property Items in WPF PropertyGrid Using Attributes
## Overview
In WPF applications, the PropertyGrid control is widely used to display and edit object properties in a structured and user-friendly way. While property names can be customized using the DisplayName attribute, you can further enhance the user experience by providing descriptions for each property.

These descriptions are typically shown as tooltips or in a description panel within the PropertyGrid, helping users understand the purpose of each property.

## Setting Descriptions with DescriptionAttribute
To set descriptions for property items in the WPF PropertyGrid, use the DescriptionAttribute from the System.ComponentModel namespace. This allows you to annotate each property with a meaningful explanation, which is especially useful in complex forms or enterprise applications.
### Example
```C#
using System.ComponentModel;

public class Product
{
    [Description("The name of the product as it appears in the catalog.")]
    public string Name { get; set; }

    [Description("The retail price of the product in INR.")]
    public double Price { get; set; }

    [Description("The number of items currently available in inventory.")]
    public int Quantity { get; set; }
}
```
When this class is bound to the Syncfusion WPF PropertyGrid, the grid will display:
- User-friendly property names (if DisplayName is also used)
- Descriptions as tooltips or in a dedicated description area

This improves usability and reduces the need for external documentation.

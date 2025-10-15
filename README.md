# How-to-set-description-to-the-property-items-of-WPF-PropertyGrid-through-attributes
In WPF applications, the PropertyGrid control is widely used to display and edit properties of objects in a structured and user-friendly way. While property names can be customized using the DisplayName attribute, you can further enhance the user experience by providing detailed descriptions for each property. These descriptions are typically shown as tooltips or in a description panel within the PropertyGrid, helping users understand the purpose of each property.
To set descriptions for property items in the WPF PropertyGrid, you can use the DescriptionAttribute from the System.ComponentModel namespace. This attribute allows you to annotate each property with a meaningful explanation, which is especially useful in complex forms or enterprise applications.
Here’s a simple example:

using System.ComponentModel;
public class Product
{
    [Display(Description="The name of the product as it appears in the catalog.")]
    public string Name { get; set; }
    [Display(Description="The retail price of the product in INR.")]
    public double Price { get; set; }
    [Display(Description="The number of items currently available in inventory.")]
    public int Quantity { get; set; }
}
When this class is bound to the Syncfusion WPF PropertyGrid, the grid will not only show user-friendly names but also display the descriptions as tooltips or in a dedicated description area. This improves usability and reduces the need for external documentation.
To implement this, ensure your WPF project references the Syncfusion WPF toolkit and that the PropertyGrid is configured to show descriptions. This approach is declarative, clean, and keeps your UI logic separate from your data model.

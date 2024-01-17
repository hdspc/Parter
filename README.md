Parter is an Inventory Management software program built in C# with a Winforms GUI.

![Inventory Screen](https://github.com/hdspc/WGU_C968_1_v001/assets/105600018/fd544b24-8651-4358-974e-d93bad43ab2f)

The main form features buttons for adding, modifying, deleting, and searching for parts and products. Additionally, there are text boxes for searching, lists for parts and products, and title labels.

![Parter GUI Demonstration](https://github.com/hdspc/Parter/assets/105600018/53556d07-e0db-4914-b065-e7c51df59718)

The add part form allows users to specify whether a part is "In-House" or "Outsourced" and provides fields for entering the relevant part details. The modify part form populates with pre-saved data and allows users to make modifications. 

Similarly, the add and modify product forms enable users to enter or modify details for products, associate parts with products, and manage the inventory.

The application implements a class structure based on a provided UML Class Diagram, with five classes and 16 associated instance variables. The main form functionalities include redirecting to other forms, deleting selected parts or products, searching, and exiting. Exception controls have been implemented to handle specific scenarios, such as preventing the minimum string from having a value other than integers and ensuring that the price of a product cannot be less than the cost of the parts.

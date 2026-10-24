# Potion Brewing System

The Custom Potion Brewing System is a C# Windows Forms desktop application for managing ingredients, potion recipes, and brewed potions. It helps users organize ingredient stock, create recipes, brew potions, and manage the available potion inventory.

## Technologies Used

- C#
- Windows Forms (WinForms)
- .NET
- Visual Studio

## Project Structure

The project contains the following model classes and application files:

- `Models/Ingredient.cs` - Stores ingredient details, including name, stock, unit, and price.
- `Models/Recipe.cs` - Stores recipe details, including name, effect, and brewing duration.
- `Models/RecipeIngredient.cs` - Connects recipes to ingredients and stores the quantity required.
- `Models/Potion.cs` - Stores brewed potion details, including name, effect, and brewing date.
- `Models/BrewRecord.cs` - Records brewing activity.
- `Repo/AppRepo.cs` - Manages application data and business logic.
- `Form1.cs` - Contains the Windows Forms event-handling code.
- `Form1.Designer.cs` - Contains the Windows Forms controls and layout.
- `Program.cs` - Starts the application.

## Main Features

### Ingredient Management

The application manages ingredient names, stock quantities, units, and prices. Stock and prices cannot be negative. Ingredients associated with recipes cannot be retired.

### Recipe Management

Recipes contain a name, a potion effect, a brewing duration, and a list of ingredients with their required quantities. Recipes must have a name and at least one ingredient.

### Potion Brewing

Before brewing, the application checks that the selected recipe exists and that sufficient quantities of all required ingredients are available. Ingredient stock is checked before any deductions are made.

When brewing succeeds, the required ingredient quantities are deducted, a potion is added to the potion inventory, and a brewing record is created.

### Potion Management

The application stores brewed potions and allows a selected potion to be consumed. Consuming a potion removes it from the current potion inventory.

### Reporting

Brewing records and ingredient consumption data can support reports about frequently brewed potions, ingredient usage, and total brewing activity over a selected date range. The reporting features must be implemented and tested in the application to be considered complete.

## Setup and Installation

1. Install Visual Studio with the .NET desktop development workload.
2. Open the solution file (`.sln`) or project file (`.csproj`) in Visual Studio.
3. Restore the project dependencies if prompted.
4. Build the solution and resolve any compilation errors.
5. Run the application.

## Data Storage

The current repository implementation uses in-memory lists to store ingredients, recipes, recipe ingredients, potions, and brewing records. Data stored this way is lost when the application closes.

Persistent database storage must be implemented separately if required for the final application. No database connection string is used by the in-memory repository.

## Conclusion

The Custom Potion Brewing System demonstrates the use of C#, Windows Forms, object-oriented programming, domain models, and repository-based business logic to manage potion ingredients, recipes, and brewed potions.

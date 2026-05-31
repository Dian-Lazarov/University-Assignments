# PizzaHub - Pizza Delivery Web Application

## 📋 Requirements
- Visual Studio 2022 (or VS Code with C# extensions)
- .NET 6.0 SDK
- Modern web browser (Chrome, Edge, Firefox)

## 🚀 How to Run

### Method 1: Visual Studio
1. Extract the ZIP file
2. Open `PizzaHub.sln` in Visual Studio
3. Press `F5` or click "Run" (green play button)
4. Browser will open automatically at `https://localhost:5001` or `http://localhost:5000`

### Method 2: Command Line
1. Extract the ZIP file
2. Open terminal/command prompt in the project folder
3. Run: `dotnet restore`
4. Run: `dotnet build`
5. Run: `dotnet run`
6. Open browser to `https://localhost:5001`

## 🌐 Features
- Browse menu (Pizzas, Dishes, Drinks, Desserts)
- Add items to cart
- Favorites system
- Search functionality
- Shopping cart with quantity management
- Responsive design (mobile-friendly)

## 📁 Project Structure
- **Controllers/** - MVC Controllers
- **Pages/** - Razor Pages (Cart, Favorites, Search)
- **Views/** - MVC Views (Home pages)
- **wwwroot/** - Static files (CSS, JS, Images)
  - **wwwroot/images/** - Product images
  - **wwwroot/css/** - Stylesheets
  - **wwwroot/js/** - JavaScript files

## 🔧 Troubleshooting

### If you see gibberish/broken Cyrillic text:
1. In Visual Studio: **File → Advanced Save Options**
2. Select **"UTF-8 with signature - Codepage 65001"**
3. Click OK and save all files

### If build fails:
1. Clean the solution: **Build → Clean Solution**
2. Rebuild: **Build → Rebuild Solution**
3. Ensure .NET 6 SDK is installed

### If images don't load:
- Verify the `wwwroot/images/` folder contains:
  - `pizzas/` (6 images)
  - `dishes/` (3 images)
  - `drinks/` (3 images)
  - `desserts/` (3 images)
  - `logo.png`

## 📝 Key Pages
- **Home** (`/`) - Full menu overview
- **Pizzas** (`/Home/Pizzas`) - Pizza menu
- **Dishes** (`/Home/Dishes`) - Dishes menu
- **Drinks** (`/Home/Drinks`) - Drinks menu
- **Desserts** (`/Home/Desserts`) - Desserts menu
- **Cart** (`/Cart`) - Shopping cart
- **Favorites** (`/Favorites`) - Favorite items
- **Search** (`/Search?q=пица`) - Search results

## 💾 Data Storage
- Cart and Favorites use **localStorage** (browser storage)
- No database required
- Data persists until browser cache is cleared

## 🌍 Language
- Interface: Bulgarian (Cyrillic)
- Encoding: UTF-8 with BOM
- All text properly encoded for Bulgarian characters

## 📧 Support
If you encounter any issues, check:
1. .NET 6 SDK is installed: `dotnet --version`
2. All files extracted properly
3. Visual Studio is up to date
4. Encoding is UTF-8 with BOM

## 🎯 Technologies Used
- ASP.NET Core 6.0 (MVC + Razor Pages)
- Bootstrap 5
- Font Awesome 6
- JavaScript (ES6)
- LocalStorage API

---
**Created for Software Engineering course - 2025**

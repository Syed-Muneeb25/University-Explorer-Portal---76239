# University Explorer Portal

A C# **Blazor Web App (.NET 10)** that lets students explore universities by country and view, create and edit university applications. Built for the CA2 assignment.

## Features

- **Home dashboard** with responsive navigation and a Light/Dark theme switch.
- **University Explorer:** choose a country and view its flag, capital, region and population.
- **University search:** list universities, filter by name, and open a details pop-up with university website and domain.
- **Student Applications (GET):** view existing applications in a table.
- **Create Application (POST):** submit an application with form validation.
- **Edit Application (PUT):** load and update a selected application by its ID.
- **Loading and error states** for API requests, with reusable Blazor components.

## Technologies

- C# and .NET 10
- ASP.NET Core Blazor Web App (Interactive Server)
- Bootstrap 5, HTML and CSS
- `HttpClient`, `System.Net.Http.Json`, and Data Annotations validation

## APIs

| API | Endpoint | Purpose |
| --- | --- | --- |
| Countries API | `https://countries.dev/countries` | GET countries, flags, capital, region and population |
| Hipolabs Universities API | `http://universities.hipolabs.com/search?country={country}` | GET universities for the selected country |
| Edutots Student Applications API | `https://edutots.net/api/studentapplication` | GET applications and POST new applications |
| Edutots Student Applications API | `https://edutots.net/api/studentapplication/{id}` | PUT updates to an existing application |

The application uses `CountryService`, `UniversityService`, and `StudentApplicationService` for these API calls. An internet connection is required. The Edutots endpoint is an external service, so please use test data and avoid submitting sensitive personal information.

## How to run

1. Install **Visual Studio 2022** with the ASP.NET and web development workload and the **.NET 10 SDK**.
2. Clone this repository and open `University Explorer Portal - 76239.slnx` in Visual Studio.
3. Build the solution and run the Blazor application using **F5** or **Ctrl+F5**.
4. Use the sidebar to open University Explorer, Student Applications or Create Application.

Or run from the repository root with the .NET CLI:

```bash
dotnet run --project "University Explorer Portal - 76239/University Explorer Portal - 76239.csproj"
```

## Project structure

```text
University Explorer Portal - 76239/
├── Components/
│   ├── Pages/        # Home, Explorer, Student Applications, Create, Edit
│   ├── Shared/       # CountryDetails, UniversityCard, UniversityDetails, StudentApplicationForm
│   └── Layout/       # Navigation and application layout
├── Models/           # Country, University, StudentApplication
├── Services/         # HTTP API services
├── wwwroot/          # Styles
├── ScreenShots/      # Assignment screenshots
└── Program.cs
```

## Screenshots

### Home dashboard
![Home dashboard](University%20Explorer%20Portal%20-%2076239/ScreenShots/Home.png)

### University Explorer
![University Explorer](University%20Explorer%20Portal%20-%2076239/ScreenShots/Uni%20Explorer%20.png)

### Country details
![Country details](University%20Explorer%20Portal%20-%2076239/ScreenShots/Country%20Detail.png)

### Universities list
![Universities list](University%20Explorer%20Portal%20-%2076239/ScreenShots/Country%20Uni%20List.png)

### University search
![University search](University%20Explorer%20Portal%20-%2076239/ScreenShots/uni%20Search%20Featuer.png)

### University details
![University details](University%20Explorer%20Portal%20-%2076239/ScreenShots/uni%20details.png)

### Student Applications — GET
![Student Applications — GET](University%20Explorer%20Portal%20-%2076239/ScreenShots/Student%20Application%20GET.png)

### Create Student Application — POST
![Create Student Application — POST](University%20Explorer%20Portal%20-%2076239/ScreenShots/Create%20Application%20POST.png)

### Edit Student Application — PUT
![Edit Student Application — PUT](University%20Explorer%20Portal%20-%2076239/ScreenShots/Edit%20Application%20PUT.png)

### Loading state
![Loading state](University%20Explorer%20Portal%20-%2076239/ScreenShots/Loading%20State%20.png)

### Error handling state
![Error handling state](University%20Explorer%20Portal%20-%2076239/ScreenShots/Error%20State.png)

*Loading and error screenshots show the loading interface and a deliberately simulated API failure used to demonstrate error handling; temporary test code was removed from the normal application flow.*

## Notes

The application uses Blazor `EventCallback` for selecting a university, reusable components for its forms and details, and `try`/`catch` handling for API failures. The Light/Dark setting is saved in browser local storage.

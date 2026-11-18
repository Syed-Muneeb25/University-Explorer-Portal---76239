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
└── Program.cs
Screenshots/            # Assignment screenshots
```

## Screenshots

### Home dashboard
![Home dashboard](Screenshots/home.png)

### University Explorer
![University Explorer](Screenshots/university-explorer.png)

### Country details
![Country details](Screenshots/country-details.png)

### Universities list
![Universities list](Screenshots/universities-list.png)

### University search
![University search](Screenshots/university-search.png)

### Student Applications — GET
![Student Applications GET](Screenshots/student-applications-get.png)

### Create Student Application — POST
![Create Application POST](Screenshots/create-application-post.png)

### Edit Student Application — PUT
![Edit Application PUT](Screenshots/edit-application-put.png)

### Loading state
![API loading state](Screenshots/loading-state.png)

### Error handling state
![API error state](Screenshots/error-state.png)

*The loading and error state screenshots demonstrate the UI while waiting for data and while handling a simulated API failure; the temporary testing code is not part of the normal application flow.*

## Notes

The application uses Blazor `EventCallback` for selecting a university, reusable components for its forms and details, and `try`/`catch` handling for API failures. The Light/Dark setting is saved in browser local storage.

# Super Hero API

This is a simple Super Hero API built with .NET 8.0.7 that provides full CRUD operations.

## Table of Contents

- [Features](#features)
- [Technologies](#technologies)
- [Setup](#setup)
- [Usage](#usage)
- [Endpoints](#endpoints)
- [Contributing](#contributing)
- [License](#license)

## Features

- Create, Read, Update, and Delete (CRUD) operations for Super Heroes
- Built with .NET 8.0.7
- Easy to set up and use

## Technologies

- .NET 8.0.7
- C#
- ASP.NET Core Web API
- Entity Framework Core

## Setup

1. **Clone the repository:**
   ```sh
   git clone https://github.com/RavanM2003/SuperHeroAPI.git
   cd SuperHeroAPI
   ```

2. **Install dependencies:**
   ```sh
   dotnet restore
   ```

3. **Update the database connection string:**
   Update the `appsettings.json` file with your database connection string.

4. **Apply migrations:**
   ```sh
   dotnet ef database update
   ```

5. **Run the application:**
   ```sh
   dotnet run
   ```

## Usage

Once the application is running, you can access the API at `https://localhost:5001`.

## Endpoints

### Super Heroes

- **Get all heroes**
  - **GET** `/api/superheroes`
- **Get a hero by ID**
  - **GET** `/api/superheroes/{id}`
- **Create a new hero**
  - **POST** `/api/superheroes`
  - **Body:**
    ```json
    {
      "name": "Superman",
      "firstName": "Clark",
      "lastName": "Kent",
      "place": "Metropolis"
    }
    ```
- **Update a hero**
  - **PUT** `/api/superheroes/{id}`
  - **Body:**
    ```json
    {
      "id": 1,
      "name": "Superman",
      "firstName": "Clark",
      "lastName": "Kent",
      "place": "Metropolis"
    }
    ```
- **Delete a hero**
  - **DELETE** `/api/superheroes/{id}`

## Contributing

Contributions are welcome! Please open an issue or submit a pull request.

1. Fork the repository
2. Create your feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the branch (`git push origin feature/AmazingFeature`)
5. Open a pull request

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.

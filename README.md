# WinFormsApp1
# Submission Management System

This is a Submission Management System built using a TypeScript Express backend and a WinForms frontend. The backend allows for creating, reading, updating, and deleting submissions, while the WinForms application provides a user interface for interacting with these submissions.

## Features

- Create new submissions
- View existing submissions
- Update submissions
- Delete submissions
- Navigate through submissions

## Requirements

- Node.js
- npm (Node Package Manager)
- .NET Framework (for the WinForms application)

## Installation

### Backend (Express Server)

1. **Clone the repository:**

    ```bash
    git clone https://github.com/your-username/your-repo-name.git
    cd your-repo-name/backend
    ```

2. **Install dependencies:**

    ```bash
    npm install
    ```

3. **Run the server:**

    ```bash
    npm start
    ```

    The server should now be running at `http://localhost:3000`.

### Frontend (WinForms Application)

1. **Open the solution in Visual Studio:**

    - Navigate to the `WinFormsApp1` directory.
    - Open the solution file (`WinFormsApp1.sln`) in Visual Studio.

2. **Restore NuGet packages:**

    Visual Studio should automatically restore the necessary NuGet packages. If not, you can manually restore them by right-clicking on the solution in Solution Explorer and selecting `Restore NuGet Packages`.

3. **Build and run the application:**

    - Build the solution by clicking on `Build` -> `Build Solution`.
    - Run the application by clicking on `Debug` -> `Start Debugging` or pressing `F5`.

## Usage

### Backend Endpoints

- **Ping the server:**

    ```http
    GET /ping
    ```

    Response:
    ```json
    {
      "success": true
    }
    ```

- **Submit a new submission:**

    ```http
    POST /submit
    ```

    Request body:
    ```json
    {
      "name": "Your Name",
      "email": "your.email@example.com",
      "phone": "1234567890",
      "githubLink": "https://github.com/yourusername",
      "stopwatchTime": "00:10:30"
    }
    ```

    Response:
    ```json
    {
      "success": true
    }
    ```

- **Read all submissions:**

    ```http
    GET /submissions
    ```

    Response:
    ```json
    [
      {
        "name": "Your Name",
        "email": "your.email@example.com",
        "phone": "1234567890",
        "githubLink": "https://github.com/yourusername",
        "stopwatchTime": "00:10:30"
      },
      ...
    ]
    ```

- **Read a specific submission by index:**

    ```http
    GET /read?index=0
    ```

    Response:
    ```json
    {
      "name": "Your Name",
      "email": "your.email@example.com",
      "phone": "1234567890",
      "githubLink": "https://github.com/yourusername",
      "stopwatchTime": "00:10:30"
    }
    ```

- **Update a submission:**

    ```http
    PUT /update
    ```

    Request body:
    ```json
    {
      "index": 0,
      "submission": {
        "name": "Updated Name",
        "email": "updated.email@example.com",
        "phone": "0987654321",
        "githubLink": "https://github.com/updatedusername",
        "stopwatchTime": "00:20:30"
      }
    }
    ```

    Response:
    ```json
    {
      "success": true
    }
    ```

- **Delete a submission:**

    ```http
    DELETE /delete
    ```

    Request body:
    ```json
    {
      "index": 0
    }
    ```

    Response:
    ```json
    {
      "success": true
    }
    ```

## Contributing

If you'd like to contribute to this project, please fork the repository and use a feature branch. Pull requests are warmly welcome.

## License

This project is licensed under the MIT License.


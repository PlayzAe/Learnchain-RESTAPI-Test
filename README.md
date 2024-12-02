# Backend Developer Skills Assessment API

This repository contains a minimal REST API built using ASP.NET Core. The API includes the following features:

1. User Registration and Login
2. Listing Available Courses
3. Enrolling in a Course

## How to Run the API Locally

Follow these steps to run the API on your local machine:

### Prerequisites

- **.NET Core SDK 6.0** (or newer) installed on your machine. You can download it from the official [Microsoft .NET download page](https://dotnet.microsoft.com/download).
- **Visual Studio 2022** or **Visual Studio Code** with the C# extension installed.

### Steps to Run

1. **Clone the Repository**:
   Open your terminal (or Git Bash) and run the following command to clone the repository to your local machine:
   ```bash
   git clone https://https://github.com/PlayzAe/Learnchain-RESTAPI-Test.git
   ```

2. **Navigate to the Project Directory**:
   After cloning, navigate to the project folder:
   ```bash
   cd Learnchain-RESTAPI-Test
   ```

3. **Build the Project**:
   Use the .NET CLI to build the project:
   ```bash
   dotnet build
   ```

4. **Run the API**:
   To run the API locally, use the following command:
   ```bash
   dotnet run
   ```

   By default, the API will be hosted at `http://localhost:5000`.

5. **Test the Endpoints**:
   You can now test the following endpoints using a tool like **Postman** or **cURL**:

   - **POST /register**: Register a user
     - Example Request Body:
       ```json
       {
         "name": "John Doe",
         "email": "john.doe@example.com",
         "password": "password123"
       }
       ```
     - Response: A `UserId` will be returned if the registration is successful.

   - **GET /courses**: Get a list of available courses
     - Response: A list of courses will be returned.

   - **POST /enroll**: Enroll a user in a course
     - Example Request Body:
       ```json
       {
         "userId": 1,
         "courseId": 101
       }
       ```
     - Response: A success message or an error message if the user is already enrolled or the IDs are invalid.

### Stopping the API

To stop the API from running, press `Ctrl + C` in your terminal.

---

### Sample Data

- **Users**: Users can register with a name, email, and password. Each user is assigned a unique `UserId` automatically.
- **Courses**: The API uses hardcoded sample data for courses, such as "Advanced C#" and "Web Development with ASP.NET."
  
---

### Dependencies

- **ASP.NET Core 6.0** for building the REST API.
- **In-Memory Database** using simple collections like `List<User>`, `List<Course>`, and `List<Enrollment>` to store data.

### License

This project is licensed under the MIT License.
```


# Backend Developer Skills Assessment API

This repository contains a minimal REST API built using ASP.NET Core. The API includes the following features:

1. User Registration and Login
2. Listing Available Courses
3. Enrolling in a Course

## How to Run the API Locally

Follow these steps to run the API on your local machine using **Visual Studio** or **Visual Studio Code**:

### Prerequisites

- **.NET Core SDK 8.0** (or newer) installed on your machine. You can download it from the official [Microsoft .NET download page](https://dotnet.microsoft.com/download).
- **Visual Studio 2022** (Recommended for API development) or **Visual Studio Code** with the C# extension installed. You can download **Visual Studio** from the [official site](https://visualstudio.microsoft.com/downloads/).

### Steps to Run

#### Running the API in **Visual Studio 2022**:

1. **Clone the Repository**:
   Open **Visual Studio** and then clone the repository from GitHub:
   ```bash
   git clone https://github.com/PlayzAe/Learnchain-RESTAPI-Test.git
   ```

2. **Open the Project**:
   After cloning the repository, open the solution file `Learnchain-RESTAPI-Test.sln` in **Visual Studio**.

3. **Build the Project**:
   In **Visual Studio**, go to the **Build** menu and select **Build Solution**. Alternatively, you can press `Ctrl + Shift + B`.

4. **Run the API**:
   Once the solution builds successfully, press `Ctrl + F5` or click the **Start** button in Visual Studio to run the API. By default, the API will be hosted at `http://localhost:5000`.

5. **Test the Endpoints**:
   You can now test the API endpoints using **Postman** or **cURL**:

   - **POST /register**: Register a user
     - Example Request Body:
       ```json
       {
         "name": "George",
         "email": "George@example.com",
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
         "courseId": 1 //This is the default ID given as the courseId is stored in the DataService.cs file
       }
       ```
     - Response: A success message or an error message if the user is already enrolled or the IDs are invalid.

#### Running the API in **Visual Studio Code**:

1. **Clone the Repository**:
   Open your terminal (or Git Bash) and run the following command to clone the repository to your local machine:
   ```bash
   git clone https://github.com/PlayzAe/Learnchain-RESTAPI-Test.git
   ```

2. **Open the Project**:
   Open **Visual Studio Code** and navigate to the cloned repository folder. Open the project folder inside **Visual Studio Code**:
   ```bash
   code Learnchain-RESTAPI-Test
   ```

3. **Install Dependencies**:
   If you haven't already, you will need to install the .NET SDK to run the project. Ensure you have **.NET Core SDK 8.0** (or newer) installed on your machine.

4. **Build the Project**:
   In **Visual Studio Code**, open a terminal window (you can press `Ctrl + ~`), and run the following command to build the project:
   ```bash
   dotnet build
   ```

5. **Run the API**:
   After building the project, run the following command in the terminal to start the API:
   ```bash
   dotnet run
   ```

   By default, the API will be hosted at `http://localhost:5000`.

6. **Test the Endpoints**:
   You can now test the API endpoints using **Postman** or **cURL**:

   - **POST /register**: Register a user
     - Example Request Body:
       ```json
       {
         "name": "George",
         "email": "George@example.com",
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
         "courseId": 1 //This is the default ID given as the courseId is stored in the DataService.cs file
       }
       ```
     - Response: A success message or an error message if the user is already enrolled or the IDs are invalid.

### Stopping the API

To stop the API from running in **Visual Studio** or **Visual Studio Code**, press `Ctrl + C` in the terminal.

---

### Sample Data

- **Users**: Users can register with a name, email, and password. Each user is assigned a unique `UserId` automatically.
- **Courses**: The API uses hardcoded sample data for courses, such as "Advanced C#" and "Web Development with ASP.NET."

---

### Dependencies

- **ASP.NET Core 8.0** for building the REST API.
- **In-Memory Database** using simple collections like `List<User>`, `List<Course>`, and `List<Enrollment>` to store data.

### License

This project is licensed under the MIT License.

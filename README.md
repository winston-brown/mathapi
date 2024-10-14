# MathApi

MathApi is a simple ASP.NET Core Web API that provides basic mathematical operations as endpoints. The API currently supports calculating the average of an array of numbers and can be expanded with additional mathematical functions.

## Features

- **Average Calculation**: Accepts an array of numbers and returns the average.
- Easily extensible to add more mathematical operations.

## Getting Started

### Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download) (version 6.0 or higher)

### Installation

1. Clone the repository:
   ```bash
   git clone https://github.com/winston-brown/MathApi.git
   cd MathApi
   ```

2. Restore dependencies:
   ```bash
   dotnet restore
   ```

### Running the API Locally

1. Start the API server:
   ```bash
   dotnet run
   ```

   By default, the server will start on `http://localhost:5000` (or a different port as indicated in the terminal).

2. Open your browser and navigate to `http://localhost:5000/swagger` to see the API documentation in Swagger UI and test the endpoints interactively.

### Usage

#### Calculate Average

- **Endpoint**: `POST /api/math/average`
- **Description**: Calculates the average of an array of numbers.
- **Request Body**:
  ```json
  [1, 2, 3, 4, 5]
  ```
- **Response**:
  ```json
  {
    "operation": "average",
    "result": 3
  }
  ```

### Example HTTP Request

You can test the `average` endpoint with a tool like `curl`:

```bash
curl -X POST http://localhost:5000/api/math/average \
-H "Content-Type: application/json" \
-d "[1, 2, 3, 4, 5]"
```

### Project Structure

- **Controllers/MathController.cs**: Contains the logic for the `average` endpoint and other mathematical operations.

### Future Development

The API is designed to be extensible. Additional endpoints for other mathematical operations (e.g., sum, product) can be added by extending the `MathController` with new methods.

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for more details.

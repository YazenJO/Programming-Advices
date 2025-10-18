using System.Net.Http.Json;

//take inter input from user


// Create an HTTP client - used to send HTTP requests and receive responses from web APIs
HttpClient client = new HttpClient();

// Set the base URL - all relative URLs in requests will be appended to this
client.BaseAddress = new Uri("https://localhost:7247/api/Students/");

// ⭐ AWAIT: Pauses execution until GetAllStudents() completes
// - Doesn't block the thread (thread can do other work while waiting)
// - Without await, the program would exit before the API call finishes
await GetAllStudents();
await GetPassedStudents();
await GetAverageAge();
Console.WriteLine("Enter Student ID to fetch details:");
int id = int.Parse(Console.ReadLine() ?? "0");
await GetStudentByID(id);
// ⭐ ASYNC TASK METHOD:
// - 'async' keyword: Tells compiler this method performs asynchronous operations
// - 'Task': Represents an ongoing operation that will complete in the future
//   * Think of Task as a "promise" that work will be done
//   * Task (without <T>) = operation that doesn't return a value (like void, but async)
//   * Task<T> = operation that returns a value of type T
// - Together: "This method runs asynchronously and returns nothing when done"
async Task GetAllStudents()
{
    // Start error handling - catches exceptions during API call
    try
    {
        // ⭐ THE HEART OF ASYNC PROGRAMMING:
        // 1. GetFromJsonAsync<List<Student>>() returns a Task<List<Student>?>
        //    - Method starts an HTTP GET request to the API
        //    - Returns immediately with a Task (doesn't wait for response)
        //
        // 2. 'await' unwraps the Task:
        //    - Waits for HTTP request to complete (without blocking thread)
        //    - Extracts the actual List<Student>? from Task<List<Student>?>
        //    - Result is assigned to students
        //
        // 3. Final URL: "https://localhost:7247/api/Students/students" (base + relative)
        //
        // 4. Behind the scenes:
        //    - Sends HTTP GET request
        //    - Waits for response (thread can do other work meanwhile)
        //    - Deserializes JSON response into List<Student>
        var students = await client.GetFromJsonAsync<List<Student>>("ALL");
        
        // Null check - GetFromJsonAsync can return null if response is empty or can't be deserialized
        if (students != null)
        {
            // Loop through each student and print their details
            foreach (var student in students)
            {
                // String interpolation ($"...") - inserts variable values into string
                Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Age: {student.Age}");
            }
        }
    }
    // Catch any errors (connection failures, timeouts, JSON parsing errors, etc.)
    catch (Exception ex)
    {
        // Display error message to user
        Console.WriteLine($"An error occurred: {ex.Message}");

    }
}
async Task GetPassedStudents()
{
    // Start error handling - catches exceptions during API call
    try
    {
        // ⭐ THE HEART OF ASYNC PROGRAMMING:
        // 1. GetFromJsonAsync<List<Student>>() returns a Task<List<Student>?>
        //    - Method starts an HTTP GET request to the API
        //    - Returns immediately with a Task (doesn't wait for response)
        //
        // 2. 'await' unwraps the Task:
        //    - Waits for HTTP request to complete (without blocking thread)
        //    - Extracts the actual List<Student>? from Task<List<Student>?>
        //    - Result is assigned to students
        //
        // 3. Final URL: "https://localhost:7247/api/Students/students" (base + relative)
        //
        // 4. Behind the scenes:
        //    - Sends HTTP GET request
        //    - Waits for response (thread can do other work meanwhile)
        //    - Deserializes JSON response into List<Student>
        var students = await client.GetFromJsonAsync<List<Student>>("Passed");

        // Null check - GetFromJsonAsync can return null if response is empty or can't be deserialized
        if (students != null)
        {
            Console.WriteLine("---------------------\n");
            Console.WriteLine("Passed Students :\n");
            // Loop through each student and print their details
            foreach (var student in students)
            {
                // String interpolation ($"...") - inserts variable values into string
                Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Age: {student.Age}");
            }
        }
    }
    // Catch any errors (connection failures, timeouts, JSON parsing errors, etc.)
    catch (Exception ex)
    {
        // Display error message to user
        Console.WriteLine($"An error occurred: {ex.Message}");

    }
}
async Task<double>GetAverageAge()
{
    try
    {
        var Avarge = await client.GetFromJsonAsync<double>("AvgGrade");
        if (Avarge != null)
        {
            Console.WriteLine($"Average Age of Students is : {Avarge}");
            return Avarge;
        }
        return 0.0;
    }
    catch (Exception ex)
    {
        Console.WriteLine($"An error occurred: {ex.Message}");
        return 0.0;
    }

}
// ⭐ STUDENT MODEL:
// - Defines the data structure for a Student
// - Must match the JSON structure returned by the API
// - Used by GetFromJsonAsync to deserialize JSON into C# objects

async Task GetStudentByID(int id)
{
    try
    {
        var student = await client.GetFromJsonAsync<Student>($"GetStudentByID/{id}");
        if (student != null)
        {
            Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Age: {student.Age}");
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"An error occurred: {ex.Message}");
    }
}
public class Student
{
    public int Id { get; set; }
    
    // = string.Empty prevents null reference warnings in C# 14.0
    public string Name { get; set; } = string.Empty;
    
    public int Age { get; set; }
}

// ═══════════════════════════════════════════════════════════════
// 🔑 KEY ASYNC/TASK CONCEPTS SUMMARY:
// ═══════════════════════════════════════════════════════════════
//
// Task        → Represents asynchronous work in progress
// Task<T>     → Asynchronous work that returns value of type T
// async       → Marks a method that contains asynchronous operations
// await       → Waits for a Task to complete and unwraps the result
//
// WHY USE ASYNC?
// ✅ Keeps app responsive (doesn't freeze while waiting)
// ✅ Efficient use of threads (thread can do other work while waiting)
// ✅ Better for I/O operations (network, disk, database)
//
// THE FLOW:
// 1. Call GetAllStudents() → Returns a Task
// 2. await that Task → Program waits (but doesn't block thread)
// 3. Inside GetAllStudents(), call GetFromJsonAsync() → Returns Task<List<Student>?>
// 4. await that Task → Waits for HTTP response, unwraps to List<Student>?
// 5. Process the data
// 6. Return from GetAllStudents() → Original await completes
// 7. Program ends
// ═══════════════════════════════════════════════════════════════

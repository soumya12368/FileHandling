using System;
using System.IO;

class Program
{
    static string basePath = "C:\\Users\\soums\\OneDrive\\Desktop\\Simplilear\\Day7"; // Change this to the desired base path

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Choose an operation:");
            Console.WriteLine("1. Create File");
            Console.WriteLine("2. Read File");
            Console.WriteLine("3. Append to File");
            Console.WriteLine("4. Delete File");
           

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("slim.txt:");// Enter the file name
                    string createFileName = Console.ReadLine();
                    Console.WriteLine("This is my Content:"); //Enter the content for the file
                    string createFileContent = Console.ReadLine();
                    string createFilePath = Path.Combine(basePath, createFileName);
                    CreateFile(createFilePath, createFileContent);
                    break;

                case 2:
                    Console.WriteLine("slim.txt:"); //Enter the file name to read
                    string readFile = Console.ReadLine();
                    string readFilePath = Path.Combine(basePath, readFile);
                    ReadFile(readFilePath);
                    break;

                case 3:
                    Console.WriteLine("New.txt:");//append
                    string appendFileName = Console.ReadLine();
                    Console.WriteLine("Hii, This is my new append :");
                    string appendContent = Console.ReadLine();
                    string appendFilePath = Path.Combine(basePath, appendFileName);
                    AppendToFile(appendFilePath, appendContent);
                    break;

                case 4:
                    Console.WriteLine("slim.txt:");//delete
                    string deleteFileName = Console.ReadLine();
                    string deleteFilePath = Path.Combine(basePath, deleteFileName);
                    DeleteFile(deleteFilePath);
                    break;

                

                default:
                    Console.WriteLine("Invalid choice. Please choose a valid operation.");
                    break;
            }
        }
    }

    static void CreateFile(string filePath, string content)
    {
        try
        {
            File.WriteAllText(filePath, content);
            Console.WriteLine($"File '{filePath}' created successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error creating file: {ex.Message}");
        }
    }

    static void ReadFile(string filePath)
    {
        try
        {
            string content = File.ReadAllText(filePath);
            Console.WriteLine($"Content of '{filePath}':\n{content}");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine($"File '{filePath}' not found.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error reading file: {ex.Message}");
        }
    }

    static void AppendToFile(string filePath, string content)
    {
        try
        {
            File.AppendAllText(filePath, content);
            Console.WriteLine($"Content appended to '{filePath}' successfully.");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine($"File '{filePath}' not found.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error appending to file: {ex.Message}");
        }
    }

    static void DeleteFile(string filePath)
    {
        try
        {
            File.Delete(filePath);
            Console.WriteLine($"File '{filePath}' deleted successfully.");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine($"File '{filePath}' not found.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error deleting file: {ex.Message}");
        }
    }
}
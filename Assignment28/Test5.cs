using System;
using System.IO;

class Test5 {
    public static void Print() {
        string inputImagePath = "input.jpg";
        string outputImagePath = "output.jpg";

        try {
            byte[] imageBytes = FileToByteArray(inputImagePath);
            ByteArrayToFile(outputImagePath, imageBytes);
            Console.WriteLine("Image successfully converted to byte array and written back to file.");
        } catch (Exception ex) {
            Console.WriteLine("Error: " + ex.Message);
        }
    }

    private static byte[] FileToByteArray(string filePath) {
        if (!File.Exists(filePath)) {
            throw new FileNotFoundException("File not found: " + filePath);
        }
        return File.ReadAllBytes(filePath);
    }

    private static void ByteArrayToFile(string filePath, byte[] byteArray) {
        File.WriteAllBytes(filePath, byteArray);
    }
}

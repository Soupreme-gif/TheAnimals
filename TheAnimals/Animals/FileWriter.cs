namespace Animals.Animals;

public class FileWriter
{
    private String fileName;

    public FileWriter(String fileName) {
        this.fileName = fileName;
    }

    public void FileWrite(String line) {

        using (StreamWriter fileWriter = new StreamWriter(fileName))
        {
            try {
                fileWriter.WriteLine(line + "\n");
            } catch (Exception e) {
                Console.WriteLine("File Write Error: " + fileName + " " + e);
            }
            
            fileWriter.Close();
        }
        
    }
}
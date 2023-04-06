namespace Animals.Animals;

public class FileReader
{

    private string fileName;

    public FileReader(string fileName)
    {

        this.fileName = fileName;

    }

    public void FileRead() {

        using (StreamReader fileReader = new StreamReader(fileName))
        {
            String line;
            try {
                while ((line = fileReader.ReadLine()) != null) {
                    Console.WriteLine(line);
                }
            } catch (Exception e) {
                Console.WriteLine("File Write Error: " + fileName + " " + e);
            }
            
            fileReader.Close();
            
        }
    }
}
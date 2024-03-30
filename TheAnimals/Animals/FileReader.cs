namespace Animals.Animals;

public class FileReader
{

    private string _fileName;

    public FileReader(string fileName)
    {

        this._fileName = fileName;

    }

    public void FileRead() {

        using (StreamReader fileReader = new StreamReader(_fileName))
        {
            String line;
            try {
                while ((line = fileReader.ReadLine()) != null) {
                    Console.WriteLine(line);
                }
            } catch (Exception e) {
                Console.WriteLine("File Write Error: " + _fileName + " " + e);
            }
            
            fileReader.Close();
            
        }
    }
}
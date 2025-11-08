using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
            Console.WriteLine("");
        }
    }
    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            string[] headings = { "Entry Date", "Prompt", "Entry" };
            string cvsHeader = (string.Join(",", headings));
            outputFile.WriteLine(cvsHeader);
            foreach (Entry entry in _entries)
            {
                string[] newLine = {entry._date, entry._promptText, entry._entryText};
                string cvsLine = (string.Join(",", newLine));
                outputFile.WriteLine(cvsLine);
            }
        }
    }
    public void LoadFromFile(string file)
    {
        string[] lines = System.IO.File.ReadAllLines(file);
        foreach (string line in lines)
        {
            string[] parts = line.Split(",");
            Entry newEntry = new Entry();
            newEntry._date = parts[0];
            newEntry._promptText = parts[1];
            newEntry._entryText = parts[2];
            _entries.Add(newEntry);
        }
    }
}
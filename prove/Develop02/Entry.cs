using System;

public class Entry
{
    public string Date { get; private set; }
    public string PromptText { get; private set; }
    public string EntryText { get; set; }

    public Entry(string promptText, string entryText)
    {
        Date = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
        PromptText = promptText;
        EntryText = entryText;
    }

    public override string ToString()
    {
        return $"{Date} - Prompt: {PromptText}\n{EntryText}";
    }

    public string ToCsv()
    {
        return $"{Date.Replace(',', ';')},\"{PromptText.Replace('"', '\'')}\",\"{EntryText.Replace('"', '\'')}\"";
    }

    public static Entry FromCsv(string csvLine)
    {
        string[] parts = csvLine.Split(new char[] { ',' }, 3);
        string date = parts[0];
        string prompt = parts[1].Trim('"').Replace('\'', '"');
        string text = parts[2].Trim('"').Replace('\'', '"');
        return new Entry(prompt, text) { Date = date };
    }
}

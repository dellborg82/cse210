using System;

public class Scripture
{
  private Reference _reference;
  private List<Word> _words;
  private string _text;
  private int wordsLeft;
  private string fileName = "scriptures.csv";

public Scripture(Reference reference, string text)
{
    _reference = reference;
    _text = text;
    _words = SplitText();
}

//   public void LoadFromFile(string fileName)
//     {
//         _words.Clear();

//         using (StreamReader reader = new StreamReader(fileName))
//         {
//             while (!reader.EndOfStream)
//             {
//                 // Read each line
//                 string line = reader.ReadLine();
//                 // Split into parts by spliting from the Comma
//                 string[] eachScripture = line.Split(',');
//                 // Pulls the Saved Entry from the split and store it in a variable
//                 string loadedScripture = eachScripture[1];
//                 // Pulls the prompt used to prompt the entry and store it in a variable
//                 foreach (string scripture in eachScripture)
//                 {
//                     string[] splitScripture = scripture.Split(',');
//                     string _reference = splitScripture[0];

//                 }
//             }
            
//         }
//     }

public List<Word> SplitText()
    {
        string[] words = _text.Split(' ');
        List<Word> ScriptureWords = new List<Word>();
        foreach (string word in words)
        {
            Word newWord = new Word(word);
            ScriptureWords.Add(newWord);

            wordsLeft++;
        }

        return ScriptureWords;
    }

    public string FormScriptureString()
    {
        string currentText = "";

        foreach (Word word in _words)
        {
            currentText += word.GetText() + " ";
        }
        return _reference.FormReference() + " " + currentText;
    }
    public void HideWords()
    {
        if (wordsLeft <= 3)
        {
            foreach (Word word in _words)
            {
                word.Hide();
            }
            wordsLeft = 0;
            Console.Clear();
            Console.WriteLine(FormScriptureString());
            return;
        }
        Random rnd = new Random();

        for (int i = 0; i < 3; i++)
        {
            int randomIndex = rnd.Next(0, _words.Count);
            if (_words[randomIndex].IsHidden() == true)
            {
                i--;
                continue;
            }
            else
            {
                _words[randomIndex].Hide();
                wordsLeft--;
            }
        }
       
    } 
     public int GetWordsleft()
    {
        return wordsLeft;
    }    
}
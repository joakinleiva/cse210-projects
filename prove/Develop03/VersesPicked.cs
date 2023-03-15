using System;

class VersesPicked
{
    private string reference;
    private string[] words;
    private bool[] hidden;

    public string Reference
    {
        get { return reference; }
    }

    public string Verse
    {
        get
        {
            string visibleVerse = "";
            for (int i = 0; i < words.Length; i++)
            {
                visibleVerse += hidden[i] ? " ____" : " " + words[i];
            }
            return visibleVerse;
        }
    }

    public VersesPicked(string reference, string text, bool[] hidden)
    {
        this.reference = reference;
        this.words = text.Split(' ');
        this.hidden = hidden;
    }

    public bool HideRandomWord()
    {
        int visibleWords = 0;
        for (int i = 0; i < hidden.Length; i++)
        {
            if (!hidden[i])
            {
                visibleWords++;
            }
        }

        if (visibleWords == 0)
        {
            return false;
        }

        Random random = new Random();
        int wordIndex = random.Next(words.Length);
        while (hidden[wordIndex])
        {
            wordIndex = random.Next(words.Length);
        }

        hidden[wordIndex] = true;
        return true;
    }

    static VersesPicked GetRandomVerse()
    {
        Random random = new Random();
        string verseString = VerseList.Verses[random.Next(VerseList.Verses.Length)];
        string[] verseParts = verseString.Split('|');
        string[] referenceParts = verseParts[0].Split(' ');

        bool[] hidden = new bool[verseParts[1].Split(' ').Length];
        for (int i = 0; i < hidden.Length; i++)
        {
            hidden[i] = false;
        }

        return new VersesPicked(referenceParts[0], verseParts[1], hidden);
    }
}

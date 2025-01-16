using System.Linq;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class WordBank : MonoBehaviour
{
    private List<string> originalWords = new List<string>()
    {
        "Apple", "banana", "Cherry", "dog", "Elephant",
        "fox", "Giraffe", "house", "Ice", "jungle",
        "kite", "Lemon", "mountain", "Night", "Ocean",
        "pencil", "Queen", "river", "Star", "Tiger",
        "umbrella", "Valley", "water", "Xylophone", "yellow",
        "zebra", "Ant", "bubble", "Cloud", "Dance",
        "Earth", "Flame", "Garden", "Hill", "Island",
        "Joy", "King", "Ladder", "Magic", "Nest",
        "Orange", "Paint", "Quest", "Rain", "Stone",
        "Tree", "Unity", "Victory", "Whale", "Xray"
    };

    private List<string> workingWords = new List<string>();
    private void Awake()
    {
        workingWords.AddRange(originalWords);
        Shuffle(workingWords);
        ConvertToLower(workingWords);
    }

    private void Shuffle(List<string> list)
    {
        for(int i = 0; i <  list.Count; i++)
        {
            int random = Random.Range(i, list.Count);
            string temporary = list[i];

            list[i] = list[random];
            list[random] = temporary;
        }
    }

    private void ConvertToLower(List<string> list)
    {
        for(int i = 0; i < list.Count; i++)
        {
            list[i] = list[i].ToLower();
        }
    }

    public string GetWord()
    {
        string newWord = string.Empty;

        if(workingWords.Count != 0)
        {
            newWord = workingWords.Last();
            workingWords.Remove(newWord);
        }

        return newWord;
    }
}

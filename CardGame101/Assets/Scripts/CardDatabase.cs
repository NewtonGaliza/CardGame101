using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDatabase : MonoBehaviour
{
    public static List<Card> cardList = new List<Card>();

    private void Awake()
    {
        cardList.Add(new Card(0, "None", 0, 0, "None"));
        cardList.Add(new Card(1, "Human", 2, 1, "This is a humas"));
        cardList.Add(new Card(2, "Elf", 3, 3, "This is a Elf"));
        cardList.Add(new Card(3, "Dwarf", 4, 4, "This is a Dwarf"));
        cardList.Add(new Card(4, "Goblin", 1, 1, "This is a Globin"));
    }
}
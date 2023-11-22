using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
public class ChestDropController : MonoBehaviour
{
    public TextMeshProUGUI DisplayText;



    //wood chest
    [Header("Wood Chest")]
    int woodChestWeight = 666;
    [SerializeField] int uncommonWoodChestWeight = 500;
    [SerializeField] int commonWoodChestWeight = 125;
    [SerializeField] int rareWoodChestWeight = 31;
    [SerializeField] int epicWoodChestWeight = 8;
    [SerializeField] int legendaryWoodChestWeight = 2;
    //bronze chest
    [Header("Bronze Chest")]
    int bronzeChestWeight;
    [SerializeField] int uncommonBronzeChestWeight = 63;
    [SerializeField] int commonBronzeChestWeight = 250;
    [SerializeField] int rareBronzeChestWeight = 63;
    [SerializeField] int epicBronzeChestWeight = 16;
    [SerializeField] int legendaryBronzeChestWeight = 4;
    //silver chest
    [Header("Silver Chest")]
    int silverChestWeight;
    [SerializeField] int uncommonSilverChestWeight = 6;
    [SerializeField] int commonSilverChestWeight = 25;
    [SerializeField] int rareSilverChestWeight = 100;
    [SerializeField] int epicSilverChestWeight = 25;
    [SerializeField] int legendarySilverChestWeight = 6;
    //gold chest
    [Header("Gold Chest")]
    int goldChestWeight;
    [SerializeField] int uncommonGoldChestWeight = 3;
    [SerializeField] int commonGoldChestWeight = 3;
    [SerializeField] int rareGoldChestWeight = 13;
    [SerializeField] int epicGoldChestWeight = 50;
    [SerializeField] int legendaryGoldChestWeight = 13;
    //platinum chest
    [Header("Platinum Chest")]
    int platinumChestWeight;
    [SerializeField] int uncommonPlatinumChestWeight = 0;
    [SerializeField] int commonPlatinumChestWeight = 0;
    [SerializeField] int rarePlatinumChestWeight = 2;
    [SerializeField] int epicPlatinumChestWeight = 6;
    [SerializeField] int legendaryPlatinumChestWeight = 33;

    int chestValue;
    int maxWeight;
    public int ChestR;
    public int ChestQ;
    string msg;
    void Start()
    {
        woodChestWeight = uncommonWoodChestWeight + commonWoodChestWeight + rareWoodChestWeight + epicWoodChestWeight + legendaryWoodChestWeight;
        bronzeChestWeight = uncommonBronzeChestWeight + commonBronzeChestWeight + rareBronzeChestWeight + epicBronzeChestWeight + legendaryBronzeChestWeight;
        silverChestWeight = uncommonSilverChestWeight + commonSilverChestWeight + rareSilverChestWeight + epicSilverChestWeight + legendarySilverChestWeight;
        goldChestWeight = uncommonGoldChestWeight + commonGoldChestWeight + rareGoldChestWeight + epicGoldChestWeight + legendaryGoldChestWeight;
        platinumChestWeight = uncommonPlatinumChestWeight + commonPlatinumChestWeight + rarePlatinumChestWeight + epicPlatinumChestWeight + legendaryPlatinumChestWeight;
        maxWeight = woodChestWeight + bronzeChestWeight + silverChestWeight + goldChestWeight + platinumChestWeight;
    }
    private void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            DrawChest();
            ChestMessage();
        }
    }
    private void ChestMessage()
    {
        msg = "";
        if (ChestQ == 1)
        {
            msg = "Wood Chest...";
        }
        else if (ChestQ == 2)
        {
            msg = "Bronze Chest.";
        }
        else if (ChestQ == 3)
        {
            msg = "Silver Chest!";
        }
        else if (ChestQ == 4)
        {
            msg = "Gold Chest!!";
        }
        else if (ChestQ == 5)
        {
            msg = "Platinum Chest!!!";
        }
        else
        {

        }

        if (ChestR == 1)
        {
            msg = msg + "   Common Reward...";
        }
        else if (ChestR == 2)
        {
            msg = msg + "   Uncommon Reward.";
        }
        else if (ChestR == 3)
        {
            msg = msg + "   Rare Reward!";
        }
        else if (ChestR == 4)
        {
            msg = msg + "   Epic Reward!!";
        }
        else if (ChestR == 5)
        {
            msg = msg + "   Legendary Reward!!!";
        }
        else
        {

        }

        Debug.Log(msg);
    }
    private void DrawChest()
    {

        int rngzus = UnityEngine.Random.Range(0, maxWeight);

        if (rngzus >= 0 && rngzus < woodChestWeight)
        {
            ChestQ = 1;
            int rareNG = UnityEngine.Random.Range(0, woodChestWeight);
            if (rareNG >= 0 && rareNG <= commonWoodChestWeight) 
            {
                ChestR = 1;
            }
            if (rareNG >= commonWoodChestWeight && rareNG <= commonWoodChestWeight + uncommonWoodChestWeight)
            {
                ChestR = 2;
            }
            if (rareNG >= commonWoodChestWeight + uncommonWoodChestWeight && rareNG <= commonWoodChestWeight + uncommonWoodChestWeight + rareWoodChestWeight)
            {
                ChestR = 3;
            }
            if (rareNG >= commonWoodChestWeight + uncommonWoodChestWeight + rareWoodChestWeight && rareNG <= commonWoodChestWeight + uncommonWoodChestWeight + rareWoodChestWeight + epicWoodChestWeight)
            {
                ChestR = 4;
            }
            if (rareNG >= commonWoodChestWeight + uncommonWoodChestWeight + rareWoodChestWeight + epicWoodChestWeight && rareNG <= commonWoodChestWeight + uncommonWoodChestWeight + rareWoodChestWeight + epicWoodChestWeight + legendaryWoodChestWeight)
            {
                ChestR = 5;
            }
        }
        else if (rngzus >= woodChestWeight && rngzus < woodChestWeight + bronzeChestWeight)
        {
            ChestQ = 2;
            int rareNG = UnityEngine.Random.Range(0, bronzeChestWeight);
            if (rareNG >= 0 && rareNG <= commonBronzeChestWeight)
            {
                ChestR = 1;
            }
            else if (rareNG >= commonBronzeChestWeight && rareNG <= commonBronzeChestWeight + uncommonBronzeChestWeight)
            {
                ChestR = 2;
            }
            else if(rareNG >= commonBronzeChestWeight + uncommonBronzeChestWeight && rareNG <= commonBronzeChestWeight + uncommonBronzeChestWeight + rareBronzeChestWeight)
            {
                ChestR = 3;
            }
            else if (rareNG >= commonBronzeChestWeight + uncommonBronzeChestWeight + rareBronzeChestWeight && rareNG <= commonBronzeChestWeight + uncommonBronzeChestWeight + rareBronzeChestWeight + epicBronzeChestWeight)
            {
                ChestR = 4;
            }
            else if (rareNG >= commonBronzeChestWeight + uncommonBronzeChestWeight + rareBronzeChestWeight + epicBronzeChestWeight && rareNG <= commonBronzeChestWeight + uncommonBronzeChestWeight + rareBronzeChestWeight + epicBronzeChestWeight + legendaryBronzeChestWeight)
            {
                ChestR = 5;
            }
        }
        else if (rngzus >= woodChestWeight + bronzeChestWeight && rngzus < woodChestWeight + bronzeChestWeight + silverChestWeight)
        {
            ChestQ = 3;
            int rareNG = UnityEngine.Random.Range(0, silverChestWeight);
            if (rareNG >= woodChestWeight + bronzeChestWeight && rareNG < woodChestWeight + bronzeChestWeight + commonSilverChestWeight)
            {
                ChestR = 1;
            }
            else if (rareNG >= commonSilverChestWeight && rareNG <= commonSilverChestWeight + uncommonSilverChestWeight)
            {
                ChestR = 2;
            }
            else if (rareNG >= commonSilverChestWeight + uncommonSilverChestWeight && rareNG <= commonSilverChestWeight + uncommonSilverChestWeight + rareSilverChestWeight)
            {
                ChestR = 3;
            }
            else if (rareNG >= commonSilverChestWeight + uncommonSilverChestWeight + rareSilverChestWeight && rareNG <= commonSilverChestWeight + uncommonSilverChestWeight + rareSilverChestWeight + epicSilverChestWeight)
            {
                ChestR = 4;
            }
            else if (rareNG >= commonSilverChestWeight + uncommonSilverChestWeight + rareSilverChestWeight + epicSilverChestWeight && rareNG <= commonSilverChestWeight + uncommonSilverChestWeight + rareSilverChestWeight + epicSilverChestWeight + legendarySilverChestWeight)
            {
                ChestR = 5;
            }
        }
        else if (rngzus >= woodChestWeight + bronzeChestWeight + silverChestWeight && rngzus < woodChestWeight + bronzeChestWeight + silverChestWeight + goldChestWeight)
        {
            ChestQ = 4;
            int rareNG = UnityEngine.Random.Range(0, goldChestWeight);
            if (rareNG >= 0 && rareNG <= commonGoldChestWeight)
            {
                ChestR = 1;
            }
            else if (rareNG >= commonGoldChestWeight && rareNG <= commonGoldChestWeight + uncommonGoldChestWeight)
            {
                ChestR = 2;
            }
            else if (rareNG >= commonGoldChestWeight + uncommonGoldChestWeight && rareNG <= commonGoldChestWeight + uncommonGoldChestWeight + rareGoldChestWeight)
            {
                ChestR = 3;
            }
            else if (rareNG >= commonGoldChestWeight + uncommonGoldChestWeight + rareGoldChestWeight && rareNG <= commonGoldChestWeight + uncommonGoldChestWeight + rareGoldChestWeight + epicGoldChestWeight)
            {
                ChestR = 4;
            }
            else if (rareNG >= commonGoldChestWeight + uncommonGoldChestWeight + rareGoldChestWeight + epicGoldChestWeight && rareNG <= commonGoldChestWeight + uncommonGoldChestWeight + rareGoldChestWeight + epicGoldChestWeight + legendaryGoldChestWeight)
            {
                ChestR = 5;
            }
        }
        else if (rngzus >= woodChestWeight + bronzeChestWeight + silverChestWeight + goldChestWeight && rngzus < woodChestWeight + bronzeChestWeight + silverChestWeight + goldChestWeight + platinumChestWeight)
        {
            ChestQ = 5;
            int rareNG = UnityEngine.Random.Range(0, platinumChestWeight);
            if (rareNG >= 0 && rareNG <= commonPlatinumChestWeight)
            {
                ChestR = 1;
            }
            else if (rareNG >= commonPlatinumChestWeight && rareNG <= commonPlatinumChestWeight + uncommonPlatinumChestWeight)
            {
                ChestR = 2;
            }
            else if (rareNG >= commonPlatinumChestWeight + uncommonPlatinumChestWeight && rareNG <= commonPlatinumChestWeight + uncommonPlatinumChestWeight + rarePlatinumChestWeight)
            {
                ChestR = 3;
            }
            else if (rareNG >= commonPlatinumChestWeight + uncommonPlatinumChestWeight + rarePlatinumChestWeight && rareNG <= commonPlatinumChestWeight + uncommonPlatinumChestWeight + rarePlatinumChestWeight + epicPlatinumChestWeight)
            {
                ChestR = 4;
            }
            else if (rareNG >= commonPlatinumChestWeight + uncommonPlatinumChestWeight + rarePlatinumChestWeight + epicPlatinumChestWeight && rareNG <= commonPlatinumChestWeight + uncommonPlatinumChestWeight + rarePlatinumChestWeight + epicPlatinumChestWeight + legendaryPlatinumChestWeight)
            {
                ChestR = 5;
            }
           
        }
        
    }
}

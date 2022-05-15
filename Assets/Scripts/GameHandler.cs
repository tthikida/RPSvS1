﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using UnityEngine.UI;

public class GameHandler : MonoBehaviour
{
    [SerializeField] public int score = 5;
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] Transform gloveHome, newspaperHome, swordHome;
    [SerializeField] GameObject p2a1, p2a2, p2a3, p2b1, p2b2, p2b3, p2c1, p2c2, p2c3;


    private string P1a = null;
    private string P2a = null;
    private string P1b = null;
    private string P2b = null;
    private string P1c = null;
    private string P2c = null;

    string[] rdmDraw = new string[] { "BoxingGlove", "Newspaper", "Sword" };

    public void P1AChoice(string rpsChoice)
    {

        P1a = rpsChoice;
    }

    public void P2AChoice(string rpsChoice)
    {
        P2a = rpsChoice;
    }

    public void P1BChoice(string rpsChoice)
    {

        P1b = rpsChoice;
    }

    public void P2BChoice(string rpsChoice)
    {
        P2b = rpsChoice;
    }

    public void P1CChoice(string rpsChoice)
    {

        P1c = rpsChoice;
    }

    public void P2CChoice(string rpsChoice)
    {
        P2c = rpsChoice;
    }

    public void BeginBattleButtonPressed()
    {
        print("battle button pressed");
        Player2RandomCards();
        if (P1a == null || P2a == null) return;
        if (P1b == null || P2b == null) return;
        if (P1c == null || P2c == null) return;
        SlotABattle();
        SlotBBattle();
        SlotCBattle();
        UpdateScoreBoard();
        CheckScore();
    }

    private void Player2RandomCards()
    {
        float rdmNum1 = UnityEngine.Random.Range(0, 3);
        float rdmNum2 = UnityEngine.Random.Range(0, 3);
        float rdmNum3 = UnityEngine.Random.Range(0, 3);

        print("rando: " + rdmNum1);
        
        P2a = rdmDraw[Mathf.RoundToInt(rdmNum1)];
        P2b = rdmDraw[Mathf.RoundToInt(rdmNum2)];
        P2c = rdmDraw[Mathf.RoundToInt(rdmNum3)];

        if (rdmNum1 == 0){p2a1.SetActive(true);}
        if (rdmNum1 == 1) { p2a2.SetActive(true); }
        if (rdmNum1 == 2) { p2a3.SetActive(true); }

        if (rdmNum2 == 0) { p2b1.SetActive(true); }
        if (rdmNum2 == 1) { p2b2.SetActive(true); }
        if (rdmNum2 == 2) { p2b3.SetActive(true); }

        if (rdmNum3 == 0) { p2c1.SetActive(true); }
        if (rdmNum3 == 1) { p2c2.SetActive(true); }
        if (rdmNum3 == 2) { p2c3.SetActive(true); }


        print("p2a: " + P2a);
        print("p2b: " + P2b);
        print("p2c: " + P2c);
    }

    private void CheckScore()
    {
        if (score <= 0) { print("P2 WINS!!!"); }
        if (score >=10) { print("P1 WINS!!!"); }
    }

    private void SlotABattle()
    {
        if (P1a == P2a)
        {
            print("Tie game a");
        }
        if (P1a == "BoxingGlove" && P2a == "Sword")
        {
            print("player 1 wins a");
            score += 1;
        }
        if (P1a == "BoxingGlove" && P2a == "Newspaper")
        {
            print("player 1 loses a");
            score -= 1;
        }
        if (P1a == "Newspaper" && P2a == "BoxingGlove")
        {
            print("player 1 wins a");
            score += 1;
        }
        if (P1a == "Newspaper" && P2a == "Sword")
        {
            print("player 1 loses a");
            score -= 1;
        }
        if (P1a == "Sword" && P2a == "Newspaper")
        {
            print("player 1 wins a");
            score += 1;
        }
        if (P1a == "Sword" && P2a == "BoxingGlove")
        {
            print("player 1 loses a");
            score -= 1;
        }
        else
        {
            //print("slot a else statement");
        }
    }

    private void SlotBBattle()
    {
        if (P1b == P2b)
        {
            print("Tie game b");
        }
        if (P1b == "BoxingGlove" && P2b == "Sword")
        {
            print("player 1 wins b");
            score += 1;
        }
        if (P1b == "BoxingGlove" && P2b == "Newspaper")
        {
            print("player 1 loses b");
            score -= 1;
        }
        if (P1b == "Newspaper" && P2b == "BoxingGlove")
        {
            print("player 1 wins b");
            score += 1;
        }
        if (P1b == "Newspaper" && P2b == "Sword")
        {
            print("player 1 loses b");
            score -= 1;
        }
        if (P1b == "Sword" && P2b == "Newspaper")
        {
            print("player 1 wins b");
            score += 1;
        }
        if (P1b == "Sword" && P2b == "BoxingGlove")
        {
            print("player 1 loses b");
            score -= 1;
        }
        else
        {
            //print("slot b else statement");
        }
    }

    private void SlotCBattle()
    {
        if (P1c == P2c)
        {
            print("Tie game c");
        }
        if (P1c == "BoxingGlove" && P2c == "Sword")
        {
            print("player 1 wins c");
            score += 1;
        }
        if (P1c == "BoxingGlove" && P2c == "Newspaper")
        {
            print("player 1 loses c");
            score -= 1;
        }
        if (P1c == "Newspaper" && P2c == "BoxingGlove")
        {
            print("player 1 wins c");
            score += 1;
        }
        if (P1c == "Newspaper" && P2c == "Sword")
        {
            print("player 1 loses c");
            score -= 1;
        }
        if (P1c == "Sword" && P2c == "Newspaper")
        {
            print("player 1 wins c");
            score += 1;
        }
        if (P1c == "Sword" && P2c == "BoxingGlove")
        {
            print("player 1 loses c");
            score -= 1;
        }
        else
        {
            //print("slot c else statement");
        }
    }


    public void NextRound()
    {
        P1a = null;
        P2a = null;
        P1b = null;
        P2b = null;
        P1c = null;
        P2c = null;

        p2a1.SetActive(false);
        p2a2.SetActive(false);
        p2a3.SetActive(false);
        p2b1.SetActive(false);
        p2b2.SetActive(false);
        p2b3.SetActive(false);
        p2c1.SetActive(false);
        p2c2.SetActive(false);
        p2c3.SetActive(false);

        Glove[] gloves = FindObjectsOfType<Glove>();
        for(int i = 0; i< gloves.Length; i++)
        {
            gloves[i].transform.position = gloveHome.position;
        }
        Newspaper[] newspapers = FindObjectsOfType<Newspaper>();
        for (int i = 0; i < newspapers.Length; i++)
        {
            newspapers[i].transform.position = newspaperHome.position;
        }
        Sword[] swords = FindObjectsOfType<Sword>();
        for (int i = 0; i < swords.Length; i++)
        {
            swords[i].transform.position = swordHome.position;
        }

        UpdateScoreBoard();
    }

    public void ResetGame()
    {
        NextRound();
        score = 5;
        UpdateScoreBoard();
    }

    private void UpdateScoreBoard()
    {
        print("the score is: " + score);
        scoreText.text = score.ToString();
    }

}

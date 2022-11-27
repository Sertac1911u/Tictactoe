using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections;


public class GameManager : MonoBehaviour
{
    public static GameObject[] butonlar = new GameObject[9];

    
    private void Awake()
    {
        for (int i = 0; i < 9; i++)
        {
            butonlar[i] = GameObject.FindGameObjectsWithTag("Button")[i];
           
        }

    }

    public Game game = new Game(butonlar);




}





public class Game : MonoBehaviour
{

    public GameObject[] butonlar;

    public string text;
    public string winner;

    public int[] score = new int[2];

    public bool win=false;
    public int query = 0;


   
    public Game(GameObject[] btn)
    {
        butonlar = btn;
    }
    public void GameControl()
    {
        if (!win)
        {
            if (butonlar[0].GetComponentInChildren<TMP_Text>().text == butonlar[1].GetComponentInChildren<TMP_Text>().text &&
                butonlar[1].GetComponentInChildren<TMP_Text>().text == butonlar[2].GetComponentInChildren<TMP_Text>().text &&
                butonlar[0].GetComponentInChildren<TMP_Text>().text != "")
            {
                butonlar[0].GetComponent<Image>().color = new Color(255, 0, 0, 255);
                winner = butonlar[0].GetComponentInChildren<TMP_Text>().text;
                win = true;
            }
            if (butonlar[3].GetComponentInChildren<TMP_Text>().text == butonlar[4].GetComponentInChildren<TMP_Text>().text &&
                butonlar[4].GetComponentInChildren<TMP_Text>().text == butonlar[5].GetComponentInChildren<TMP_Text>().text &&
                butonlar[3].GetComponentInChildren<TMP_Text>().text != "")
            {
                
                winner = butonlar[3].GetComponentInChildren<TMP_Text>().text;
                win = true;
            }
            if (butonlar[6].GetComponentInChildren<TMP_Text>().text == butonlar[7].GetComponentInChildren<TMP_Text>().text &&
                butonlar[7].GetComponentInChildren<TMP_Text>().text == butonlar[8].GetComponentInChildren<TMP_Text>().text &&
                butonlar[6].GetComponentInChildren<TMP_Text>().text != "")
            {
                winner = butonlar[6].GetComponentInChildren<TMP_Text>().text;
                win = true;
            }
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (butonlar[0].GetComponentInChildren<TMP_Text>().text == butonlar[3].GetComponentInChildren<TMP_Text>().text &&
                butonlar[3].GetComponentInChildren<TMP_Text>().text == butonlar[6].GetComponentInChildren<TMP_Text>().text &&
                butonlar[0].GetComponentInChildren<TMP_Text>().text != "")
            {
                winner = butonlar[0].GetComponentInChildren<TMP_Text>().text;
                win = true;
            }
            if (butonlar[1].GetComponentInChildren<TMP_Text>().text == butonlar[4].GetComponentInChildren<TMP_Text>().text &&
                butonlar[4].GetComponentInChildren<TMP_Text>().text == butonlar[7].GetComponentInChildren<TMP_Text>().text &&
                butonlar[1].GetComponentInChildren<TMP_Text>().text != "")
            {
                winner = butonlar[1].GetComponentInChildren<TMP_Text>().text;
                win = true;
            }
            if (butonlar[2].GetComponentInChildren<TMP_Text>().text == butonlar[5].GetComponentInChildren<TMP_Text>().text &&
                butonlar[5].GetComponentInChildren<TMP_Text>().text == butonlar[8].GetComponentInChildren<TMP_Text>().text &&
                butonlar[2].GetComponentInChildren<TMP_Text>().text != "")
            {
                winner = butonlar[2].GetComponentInChildren<TMP_Text>().text;
                win = true;
            }
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (butonlar[2].GetComponentInChildren<TMP_Text>().text == butonlar[4].GetComponentInChildren<TMP_Text>().text &&
                butonlar[4].GetComponentInChildren<TMP_Text>().text == butonlar[6].GetComponentInChildren<TMP_Text>().text &&
                butonlar[2].GetComponentInChildren<TMP_Text>().text != "")
            {
                winner = butonlar[2].GetComponentInChildren<TMP_Text>().text;
                win = true;
            }
            if (butonlar[0].GetComponentInChildren<TMP_Text>().text == butonlar[4].GetComponentInChildren<TMP_Text>().text &&
                butonlar[4].GetComponentInChildren<TMP_Text>().text == butonlar[8].GetComponentInChildren<TMP_Text>().text &&
                butonlar[0].GetComponentInChildren<TMP_Text>().text != "")
            {
                winner = butonlar[0].GetComponentInChildren<TMP_Text>().text;
                win = true;
            }
            if (win)
            {
                foreach (GameObject btn in butonlar)
                {
                    btn.GetComponent<Button>().interactable = false;
                }
                GameObject.FindGameObjectWithTag("WinText").GetComponent<TMP_Text>().text = winner + " " + "Kazandý!!";
                if (winner == "X")
                    score[0] = score[0] + 1;
                else if (winner == "O")
                    score[1] = score[1] + 1;
                GameObject.FindGameObjectWithTag("ScoreText").GetComponent<TMP_Text>().text = score[0] + " - " + score[1];


                foreach (GameObject btn in butonlar)
                {
                    btn.GetComponent<Button>().interactable = true;
                    btn.GetComponentInChildren<TMP_Text>().text = "";
                }
                win = false;
            }
            
        }

    }
   
    public void GameCycle(string isimm)
    {
        GameObject buton = GameObject.Find(isimm);

        if (query == 0)
        {
            text = "X";
            query = 1;
            //Debug.Log("X e baastý");
            buton.GetComponentInChildren<TMP_Text>().text = text;
        }
        else if (query == 1)
        {
            text = "O";
            query = 0;
            //Debug.Log("O e baastý");
            buton.GetComponentInChildren<TMP_Text>().text = text;
        }
    }
}


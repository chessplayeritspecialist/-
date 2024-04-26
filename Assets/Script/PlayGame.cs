using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class PlayGame : MonoBehaviour
{
    public TMP_Text Text;
    public String Number;
    public int Summa;

    public int proverka = 0;

    public void Button_0_Click()
    {
        Number += "0";

        Text.SetText(Number);
    }

    public void Button_1_Click()
    {
        Number += "1";

        Text.SetText(Number);
    }

    public void Button_2_Click()
    {
        Number += "2";

        Text.SetText(Number);
    }

    public void Button_3_Click()
    {
        Number += "3";

        Text.SetText(Number);
    }

    public void Button_4_Click()
    {
        Number += "4";

        Text.SetText(Number);
    }

    public void Button_5_Click()
    {
        Number += "5";

        Text.SetText(Number);
    }

    public void Button_6_Click()
    {
        Number += "6";

        Text.SetText(Number);
    }

    public void Button_7_Click()
    {
        Number += "7";

        Text.SetText(Number);
    }

    public void Button_8_Click()
    {
        Number += "8";

        Text.SetText(Number);
    }

    public void Button_9_Click()
    {
        Number += "9";

        Text.SetText(Number);
    }

    public void Button_rovno_click()
    {
        switch (proverka) 
        { 
            case 1:
                Summa += Convert.ToInt32(Number);
              
                break;

            case 2:
                Summa -= Convert.ToInt32(Number);
                
                break;

            case 3:
                Summa *= Convert.ToInt32(Number);
                
                break;

            case 4:
                Summa /= Convert.ToInt32(Number);
                
                break;
        }
        Text.SetText(Summa.ToString());
        Number = "";
        Summa = 0;

    }

    public void Button_plus_click()
    {
        proverka = 1;
        Text.SetText("");
        Summa = Convert.ToInt32(Number);
        Number = "";
    }

    public void Button_minus_click()
    {
        proverka = 2;
        Text.SetText("");
        Summa = Convert.ToInt32(Number);
        Number = "";
    }

    public void Button_ymnojenie_click()
    {
        proverka = 3;
        Text.SetText("");
        Summa = Convert.ToInt32(Number);
        Number = "";
    }

    public void Button_delenie_click()
    {
        proverka = 4;
        Text.SetText("");
        Summa = Convert.ToInt32(Number);
        Number = "";
    }

    public void Button_clear_click()
    {
        Text.SetText("");
        Number = "";
        proverka = 0;
    }
}

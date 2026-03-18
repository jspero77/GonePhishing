using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UI_Controller : MonoBehaviour
{
    public GameObject email;
    public GameObject notes;
    public GameObject archive;
    public GameObject bar;
    public GameObject reply;
    public GameObject start;
    public GameObject day1;
    public GameObject intro;
    public GameObject intro1;
    public GameObject intro2;
    public GameObject intro3;
    public GameObject intro4;
    public GameObject intro5;
    public GameObject intro6;
    public GameObject intro7;
    public GameObject gameover;
    public int right = 0;


    public void Resett()
    {
        gameover.SetActive(false);
        bar.SetActive(false);
        email.SetActive(false);
        reply.SetActive(false);
        day1 .SetActive(true);
    }
    public void startGame()
    {
        day1.SetActive(false);
        bar.SetActive(true);
    }

    public void Intro1()
    {
        intro.SetActive(false);
        intro1.SetActive(true);
    }

    public void Intro2()
    {
        intro1.SetActive(false);
        intro2.SetActive(true);
    }
    public void Intro3()
    {
        intro2.SetActive(false);
        intro3.SetActive(true);
    }
    public void Intro4()
    {
        intro3.SetActive(false);
        intro4.SetActive(true);
    }
    public void Intro5()
    {
        intro4.SetActive(false);
        intro5.SetActive(true);
    }
    public void Day1()
    {
        start.SetActive(false);
        intro.SetActive(true);
    }
    public void Intro6()
    {
        intro5.SetActive(false);
        intro6.SetActive(true);
    }
    public void Intro7()
    {
        intro6.SetActive(false);
        intro7.SetActive(true);
    }

    public void Intro()
    {
        day1.SetActive(true);
        intro7.SetActive(false);
    }

    public void openEmail()
    {
        email.SetActive(true);
    }

    public void closeEmail()
    {
        email.SetActive(false);
    }
    public void closeResponses()
    {
        reply.SetActive(false);
    }

    public void openNotes()
    {
        notes.SetActive(true);
    }

    public void closeNotes()
    {
        notes.SetActive(false);
    }

    public void openArchive()
    {
        archive.SetActive(true);
    }

    public void closeArchive()
    {
        archive.SetActive(false);
    }
}

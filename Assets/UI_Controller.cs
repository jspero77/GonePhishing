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
    public GameObject win;
    public GameObject daytrack;
    public AudioSource click;
    public int right = 0;

    public void Clicks()
    {
        click.Play();
    }
    public void Resett()
    {
        gameover.SetActive(false);
        bar.SetActive(false);
        email.SetActive(false);
        reply.SetActive(false);
        win.SetActive(false);
        daytrack.SetActive(true);
        Clicks();
    }

    public void startGame()
    {
        day1.SetActive(false);
        daytrack.SetActive(true);
        Clicks();

    }

    public void getdasyaway()
    {
        daytrack.SetActive(false);
        bar.SetActive(true);
        email.SetActive(false);
        Clicks();
    }

    public void Intro1()
    {
        intro.SetActive(false);
        intro1.SetActive(true);
        Clicks();
    }

    public void Intro2()
    {
        intro1.SetActive(false);
        intro2.SetActive(true);
        Clicks();
    }
    public void Intro3()
    {
        intro2.SetActive(false);
        intro3.SetActive(true);
        Clicks();
    }
    public void Intro4()
    {
        intro3.SetActive(false);
        intro4.SetActive(true);
        Clicks();
    }
    public void Intro5()
    {
        intro4.SetActive(false);
        intro5.SetActive(true);
        Clicks();
    }
    public void Day1()
    {
        start.SetActive(false);
        intro.SetActive(true);
        Clicks();
    }
    public void Intro6()
    {
        intro5.SetActive(false);
        intro6.SetActive(true);
        Clicks();
    }
    public void Intro7()
    {
        intro6.SetActive(false);
        intro7.SetActive(true);
        Clicks();
    }

    public void Intro()
    {
        daytrack.SetActive(true);
        intro7.SetActive(false);
        Clicks();
    }

    public void openEmail()
    {
        email.SetActive(true);
        Clicks();
    }

    public void closeEmail()
    {
        email.SetActive(false);
        Clicks();
    }
    public void closeResponses()
    {
        reply.SetActive(false);
        Clicks();
    }

    public void openNotes()
    {
        notes.SetActive(true);
        Clicks();
    }

    public void closeNotes()
    {
        notes.SetActive(false);
        Clicks();
    }

    public void openArchive()
    {
        archive.SetActive(true);
        Clicks();
    }

    public void closeArchive()
    {
        archive.SetActive(false);
        Clicks();
    }
}

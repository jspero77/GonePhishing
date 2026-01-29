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

    public void openEmail()
    {
        email.SetActive(true);
    }

    public void closeEmail()
    {
        email.SetActive(false);
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

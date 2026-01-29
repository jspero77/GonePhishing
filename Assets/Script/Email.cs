
using System.Collections.Generic;
using TMPro;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Email : MonoBehaviour
{
    public TextMeshProUGUI text;
    public TextMeshProUGUI textInfo;
    public TextMeshProUGUI o1;
    public TextMeshProUGUI o2;
    public TextMeshProUGUI o3;
    public string greetings;
    public string part1;
    public string part2;
    public string part3;
    public string subject;
    public string Q1;
    public string phishes;
    public string signoff;
    public string froms;
    public string senderAddress;
    public EmailCollection emailCollectionGood;
    public EmailCollection emailCollectionBad;
    public EmailSequence sequence;
    public SenderDirectory directory;
    List<EmailData> list;
    public int emailNumber;
    public string playerName;
    public GameObject reply;
    public int score = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        list = new List<EmailData>();
        sequence.GetSequence(list);
        populateEmail(0);
    }
    /*
    // Update is called once per frame
    public void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            populateEmail(emailCollectionBad);
        }
        if (Input.GetMouseButtonDown(1))
        {
            populateEmail(emailCollectionGood);
        }
    }*/
    public void Update()
    {
        
    }

    public void accept()
    {
        if (phishes == "No")
        {
            score++;
        }
        reply.SetActive(true);
    }
    public void deny()
    {
        if (phishes != "No")
        {
            score++;
        }
        emailNumber++;
        if (emailNumber >= list.Count)
        {
            emailNumber = 0;

        }
        populateEmail(emailNumber);
    }
    public void Reply()
    {
        emailNumber++;
        if (emailNumber >= list.Count)
        {
            emailNumber = 0;

        }
        reply.SetActive(false);
        populateEmail(emailNumber);
    }


    public void populateEmail(int emailNumber)
    {

        this.emailNumber = emailNumber;

        var emailData = list[emailNumber];
        greetings = emailData.greetings[0];
        part1 = emailData.part1s[0];
        part2 = emailData.part2s[0];
        part3 = emailData.part3s[0];
        signoff = emailData.signoffs[0];
        subject = emailData.subjects[0];
        phishes = emailData.phishing[0];



        text.text = greetings;
        textInfo.text = subject;
        o1.text = part1;
        o2.text = part2;
        o3.text = part3;

    }
}

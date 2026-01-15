
using TMPro;
using UnityEngine;
using System.Collections.Generic;

public class Email : MonoBehaviour
{
    public TextMeshProUGUI text;
    public TextMeshProUGUI textInfo;
    public string greetings;
    public string part1;
    public string part2;
    public string part3;
    public string subject;
    public string Q1;
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

    public void acceptordeny()
    {
        emailNumber++;
        if (emailNumber >= list.Count)
        {
            emailNumber = 0;

        }
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


        
        text.text = greetings;
        textInfo.text = subject;

    }
}

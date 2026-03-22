
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class Email : MonoBehaviour
{
    public TextMeshProUGUI text;
    public TextMeshProUGUI textInfo;
    public TextMeshProUGUI o1;
    public TextMeshProUGUI o2;
    public TextMeshProUGUI o3;
    public TextMeshProUGUI error;
    public TextMeshProUGUI preview1;
    public TextMeshProUGUI preview2;
    public TextMeshProUGUI preview3;
    public TextMeshProUGUI preview4;
    public TextMeshProUGUI preview5;
    public TextMeshProUGUI preview6;
    public TextMeshProUGUI live;
    public string greetings;
    public string part1;
    public string part2;
    public string part3;
    public string subject;
    public string subject1;
    public string subject2;
    public string subject3;
    public string subject4;
    public string subject5;
    public string Q1;
    public string phishes;
    public string signoff;
    public string froms;
    public string senderAddress;
    public Button b1;
    public Button b2;
    public Button b3;
    public Button b4;
    public Button b5;
    public Button b6;
    public EmailCollection emailCollectionGood;
    public EmailCollection emailCollectionBad;
    public EmailSequence training;
    public EmailSequence intro;
    public EmailSequence firstright;
    public EmailSequence firstwrong;
    public EmailSequence day1gb;
    public EmailSequence day1gg;
    public SenderDirectory directory;
    List<EmailData> list;
    public int emailNumber;
    public string playerName;
    public GameObject reply;
    public GameObject wrong;
    public int score = 0;
    public int right = 0;
    public int step = 0;
    public int gully = 0;
    public int firstone = 0;
    public int button = 0;
    public int lives = 3;
    public GameObject archiver;
    public GameObject gamedead;
    public GameObject win;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        list = new List<EmailData>();
        training.GetSequence(list);
        populateEmail(0);
        populatePreview(0);
        emailNumber = 0;
        score = 0;
        button = 1;
        Buttons();
        preview3.text = null;
        preview4.text = null;
        preview5.text = null;
        preview6.text = null;
        gully = 0;
        firstone = 0;
        step = 0;
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
        if (phishes != "No")
        {
            right = 1;
        }
        else
        {
            right = 0;
        }
        reply.SetActive(true);
    }
    public void deny()
    {
        if (phishes == "No")
        {
            right = 2;
        }
        else
        {
            right = 0;
        }
        if (right > 0)
        {
            if (signoff == "g1")
            {
                gully++;
            }
            if (signoff == "s1")
            {
                firstone++;
            }
            if (right == 1)
            {

                error.text = "You have accepted an e-mail with the following red flags:" + "\n" + phishes + "\n" + "Do now allow this failure to repeat!";
                
            }
            else
            {
                error.text = "You have flagged a perfectly safe e-mail" + "\n" + "Do now allow this to happen again!";
            }
            lives--;
            live.text = "Lives: " + lives;
            if (lives == 0)
            {
                GameOver();
            }
            else
            {
                wrong.SetActive(true);
            }
        }
        else
        {
            nextEmail();
        }

    }

    public void GameOver()
    {
        list = new List<EmailData>();
        training.GetSequence(list);
        populateEmail(0);
        populatePreview(0);
        emailNumber = 0;
        score = 0;
        button = 1;
        Buttons();
        preview3.text = null;
        preview4.text = null;
        preview5.text = null;
        preview6.text = null;
        gully = 0;
        firstone = 0;
        step = 0;
        lives = 3;
        gamedead.SetActive(true);
        live.text = "Lives: " + lives;
    }
    public void Buttons()
    { 
        b1.image.color = Color.white;
        b2.image.color = Color.white;
        b3.image.color = Color.white;
        b4.image.color = Color.white;
        b5.image.color = Color.white;
        b6.image.color = Color.white;
        if (button == 1)
        {
            b1.image.color = new Color(0.8f, 0.8f, 0.8f);
        }
        if (button == 2)
        {
            b2.image.color = new Color(0.8f, 0.8f, 0.8f);
        }
        if (button == 3)
        {
            b3.image.color = new Color(0.8f, 0.8f, 0.8f);
        }
        if (button == 4)
        {
            b4.image.color = new Color(0.8f, 0.8f, 0.8f);
        }
        if (button == 5)
        {
            b5.image.color = new Color(0.8f, 0.8f, 0.8f);
        }
        if (button == 6)
        {
            b6.image.color = new Color(0.8f, 0.8f, 0.8f);
        }
    }

    public void Button1()
    {
        score = emailNumber;
        populateEmail(score);
        button = 1;
        Buttons();
    }
    public void Button2()
    {
        score = emailNumber+1;
        populateEmail(score);
        button = 2;
        Buttons();
    }
    public void Button3()
    {
        score = emailNumber+2;
        populateEmail(score);
        button = 3;
        Buttons();
    }
    public void Button4()
    {
        score = emailNumber+3;
        populateEmail(score);
        button = 4;
        Buttons();
    }
    public void Button5()
    {
        score = emailNumber+4;
        populateEmail(score);
        button = 5;
        Buttons();
    }
    public void Button6()
    {
        score = emailNumber+5;
        populateEmail(score);
        button = 6;
        Buttons();
    }

    public void nextEmail()
    {
        reply.SetActive(false);
        emailNumber++;
        score++;
        if (button >= 6)
        {
            list[emailNumber+4] = list[emailNumber +3];

        }
        if (button >= 5)
        {
            list[emailNumber + 3] = list[emailNumber + 2];
        }
        if (button >= 4)
        {
            list[emailNumber + 2] = list[emailNumber + 1];
        }
        if (button >= 3)
        {
            list[emailNumber + 1] = list[emailNumber];
        }
        if (button >= 2)
        {
            list[emailNumber] = list[emailNumber-1];
        }


        if (score >= list.Count)
        {
            score = Mathf.Min(score, list.Count-1);
            button--;
            Buttons();
            
        }


        if (emailNumber >= list.Count)
        {
            if (step == 0)
            {
                list = new List<EmailData>();
                intro.GetSequence(list);
                populateEmail(0);
                Button1();
            }
            else if (step == 1 && firstone == 0)
            {
                list = new List<EmailData>();
                firstright.GetSequence(list);
                populateEmail(0);
                Button1();
            }
            else if (step == 1 && firstone == 1)
            {
                list = new List<EmailData>();
                firstwrong.GetSequence(list);
                populateEmail(0);
                Button1();
            }
            else if (step == 2 && gully == 0)
            {
                list = new List<EmailData>();
                day1gg.GetSequence(list);
                populateEmail(0);
                Button1();
            }
            else if (step == 2 && gully == 1)
            {
                list = new List<EmailData>();
                day1gb.GetSequence(list);
                populateEmail(0);
                Button1();
            }
            else if (step == 3)
            {
                win.SetActive(true);
                Button1();
            }
                emailNumber = 0;
            score = 0;
            step++;


        }
        
        populateEmail(score);
        populatePreview(emailNumber);
        wrong.SetActive(false);
    }

    public void Reply()
    {
        archiver.GetComponent<Archive>().Arch(list[score].subjects[0], list[score].greetings[0]);

        if (right > 0)
        {
            
            if (right == 1)
            {
                error.text = "You have accepted an e-mail with the following red flags:"+"\n"+phishes+"\n"+"Do now allow this failure to repeat!";
            }
            else
            {
                error.text = "You have flagged a perfectly safe e-mail" + "\n" + "Do now allow this to happen again!";
            }
            lives--;
            if (lives == 0)
            {
                GameOver();
            }
            else 
            { 
                wrong.SetActive(true); 
            }

        }
        else
        {
            nextEmail();
        }
    }

    public void populatePreview(int emailNumber)
    {

        this.emailNumber = emailNumber;

        var emailData = list[emailNumber];
        subject = emailData.subjects[0];
        preview1.text = subject;


        if (emailNumber+1 < list.Count)
        {
            var emailData1 = list[emailNumber + 1];
            subject1 = emailData1.subjects[0];
            preview2.text = subject1;
            if (emailNumber+2 < list.Count)
            {

                var emailData2 = list[emailNumber + 2];
                subject2 = emailData2.subjects[0];
                preview3.text = subject2;

                if (emailNumber + 3 < list.Count)
                {
                    var emailData3 = list[emailNumber + 3];
                    subject3 = emailData3.subjects[0];
                    preview4.text = subject3;

                    if (emailNumber + 4 < list.Count)
                    {
                        var emailData4 = list[emailNumber + 4];
                        subject4 = emailData4.subjects[0];
                        preview5.text = subject4;

                        if (emailNumber + 5 < list.Count)
                        {
                            var emailData5 = list[emailNumber + 5];
                            subject5 = emailData5.subjects[0];


                            preview6.text = subject5;
                        }
                        else
                        {
                            preview6.text = null;
                        }

                    }
                    else
                    {
                        preview5.text = null;
                    }
                }
                else
                {
                    preview4.text = null;
                }
            }
            else
            {
                preview3.text = null;
            }
        }
        else
        {
            preview2.text = null;
        }
    }

    public void populateEmail(int pablo)
    {


        var emailData = list[pablo];
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

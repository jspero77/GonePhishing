using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Archive : MonoBehaviour
{

    public GameObject archive;
    public GameObject cur;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Arch(string a, string b)
    {
        cur = Instantiate(archive, this.gameObject.transform);
        cur.GetComponentInChildren<TextMeshProUGUI>().text = a;
        cur.GetComponentInChildren<TextMeshPro>().text = b;
    }

    // Update is called once per frame

}

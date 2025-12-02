using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmailManager : MonoBehaviour
{
    public GameObject[] slots;
    public GameObject newObjectPrefab;
    public KeyCode removeKey = KeyCode.E;

    public bool isEmailMoving = false;

    public GameObject emailbuttons;

    void Update()
    {
        if (Input.GetKeyDown(removeKey) && slots[0] != null)
        {
            RemoveTopSlot();
        }

    }

    public void RemoveTopSlot()
    {
        Destroy(slots[0]);
        slots[0] = null;

        for (int i = 0; i < slots.Length - 1; i++)
        {
            slots[i] = slots[i + 1];
        }

        Vector3 spawnPos = slots[5].transform.position + new Vector3(0, -93f, 0);

        slots[slots.Length - 1] = Instantiate(newObjectPrefab, spawnPos, Quaternion.identity, emailbuttons.transform);


        StartCoroutine(MoveUIUp());
    }

    IEnumerator MoveUIUp()
    {
        isEmailMoving = true;

        Vector3 start = emailbuttons.transform.localPosition;
        Vector3 end = start + new Vector3(0, 12.5f, 0);

        float duration = 0.5f;
        float t = 0f;

        while (t < duration)
        {
            t += Time.deltaTime;
            emailbuttons.transform.localPosition = Vector3.Lerp(start, end, t / duration);
            yield return null;

        }
    }

}


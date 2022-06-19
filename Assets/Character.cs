using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Character : MonoBehaviour
{

    public List<GameObject> AllCaps = new List<GameObject>();

    public TextMeshProUGUI CharacterName;


    public void SetName(string name)
    {
        CharacterName.text = name;  
    }
    public void SetCap(int index)
    {
        for (int i = 0; i < AllCaps.Count; i++)
        {
            if (i == index)
            {
                AllCaps[i].SetActive(true);
            }
            else
            {
                AllCaps[i].SetActive(false);
            }
        }
    }
    public void Rotate(float step)
    {
        transform.rotation *= Quaternion.Euler(0, step, 0);
    }

}

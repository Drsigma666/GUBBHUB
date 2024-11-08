using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class On_off : MonoBehaviour
{

    [SerializeField] GameObject Panel;
    [SerializeField] KeyCode[] keycodes;
         

    

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < keycodes.Length; i++)
        {
            if (Input.GetKeyDown(keycodes[i]))
            {
                Panel.SetActive(!Panel.activeSelf);
                break;
            }
        }
    }
}

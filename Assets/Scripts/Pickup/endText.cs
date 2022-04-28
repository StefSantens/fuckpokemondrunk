using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class endText : MonoBehaviour
{
    public static int on = 0;
    Text end;
    // Start is called before the first frame update
    void Start()
    {
        end = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (on == 1)
        {
            Debug.Log("you won");
            gameObject.SetActive(true);
            end.text = "You won";
        }
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealtBar : MonoBehaviour
{
    Slider Healtbar;

    // Start is called before the first frame update
    void Awake()
    {
        Healtbar = GetComponent<Slider>();
    }

    private void Start()
    {
        Healtbar.maxValue = 100;
        Healtbar.minValue = 0;
        Healtbar.value = 100;
        Healtbar.wholeNumbers = true; //tam sayýlý iþlem ya gibi biþey
        Healtbar.fillRect.GetComponent<Image>().color = Color.green;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("e"))
        {
            if (Healtbar.value > 0) 
            {
                Debug.LogWarning("-20 hp");
                
                 Healtbar.value -= 20;
            }
        }
        else if (Input.GetKeyDown("q"))
        {
            if (Healtbar.value < 100)
            {
                Debug.LogWarning("+20 hp");

                Healtbar.value += 20;
            }
        }


        if(Healtbar.value <= 100 && Healtbar.value >66)
        {
            Healtbar.fillRect.GetComponent<Image>().color = Color.green;
        }
        else if(Healtbar.value <= 66 && Healtbar.value > 33)
        {
            Healtbar.fillRect.GetComponent<Image>().color = Color.yellow;
        }
        else if (Healtbar.value <= 33 && Healtbar.value > 0)
        {
            Healtbar.fillRect.GetComponent<Image>().color = Color.red;
        }

        if (Healtbar.value <= 0)

        {
            Debug.LogWarning("GAME_OVER :D");
        }
    }
}

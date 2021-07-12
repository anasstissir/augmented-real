using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ARItemsSwitch : MonoBehaviour
{
    [SerializeField] private GameObject image1, image2, image3;

    private int step = 0;

    public GameObject nextButton;
    // Start is called before the first frame update
    void Start()
    {
        image2.SetActive(false);
        image3.SetActive(false);


    }

    public void NextObject()
    {
        switch (step)
        {
            case 0:
                image1.SetActive(false);
                image2.SetActive(true);
                image3.SetActive(false);
                step++;
                break;
            case 1:
                image1.SetActive(false);
                image2.SetActive(false);
                image3.SetActive(true);
                step++;
                nextButton.SetActive(false);
                break;
        }
    }

}

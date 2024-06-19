using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class foodVisibility : MonoBehaviour
{
    public GameObject[] food;
    public int currentIndex = 0;
    // Start is called before the first frame update
    void Start()
    {
        DesactiveAll();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            currentIndex++;
            DesactiveAll();
            if (currentIndex < food.Length)
            {
                ActivateByIndex(currentIndex);

            }
            else
            {
                currentIndex = 0;
                DesactiveAll();
                ActivateByIndex(currentIndex);
            }
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            currentIndex--;
            DesactiveAll();
            if (currentIndex > -1)
            {
                ActivateByIndex(currentIndex);

            }
            else
            {
                currentIndex = food.Length;
                DesactiveAll();
                ActivateByIndex(currentIndex);
            }
        }
    }

    void DesactiveAll()
    {
        for (int i = 0; i < food.Length; i++)
        {
            food[i].SetActive(false);
        }
    }

    void ActiveAll()
    {
        for (int i = 0; i < food.Length; i++)
        {
            food[i].SetActive(true);
        }
    }
    void ActivateByIndex(int index)
    {
        food[index].SetActive(true);
    }
    void DesactivateByIndex(int index)
    {
        food[index].SetActive(false);
    }
}

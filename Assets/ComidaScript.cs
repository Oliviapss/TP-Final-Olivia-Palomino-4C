using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;




public class ComidaScript : MonoBehaviour
{
    public GameObject[] food;
    public int Index = 0;

    void Start()
    {
        DeactivateAll();
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            ActivatePrevious();
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            ActivateNext();
        }
    }

    public void ActivateNext()
    {
        Index++;
        
        DeactivateAll();
       
        food[Index].SetActive(true);
    }

    public void ActivatePrevious()
    {
        Index--;
        
        DeactivateAll();
        
        food[Index].SetActive(true);
    }

    void DeactivateAll()
    {
        for (int i = 0; i < food.Length; i++)
        {
            food[i].SetActive(false);
        }
    }
}

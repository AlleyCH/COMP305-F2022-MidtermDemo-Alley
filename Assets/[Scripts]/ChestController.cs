using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestController : MonoBehaviour
{
    public GameObject chestClose, chestOpen;


    // Start is called before the first frame update
    void Start()
    {
        if (chestOpen)
            chestOpen.SetActive(false);
            chestClose.SetActive(true);
    }

    // Update is called once per frame
     void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
            Destroy(chestClose);
        // chestClose.SetActive(false);
        chestOpen.SetActive(true);
    }

    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    if (Input.GetKeyDown(KeyCode.E))
    //        Destroy(chestClose);
    //    //chestClose.SetActive(false);
    //    chestOpen.SetActive(true);
    //}
}

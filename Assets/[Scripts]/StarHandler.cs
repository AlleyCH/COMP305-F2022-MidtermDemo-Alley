using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarHandler : MonoBehaviour
{
    public GameObject myPrefab;
    public List<GameObject> stars = new List<GameObject>();
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb.GetComponent<Rigidbody2D>();        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.E))
        {

            Instantiate(myPrefab, new Vector3(-3.26f, 7.49f, -3.568f), Quaternion.identity);
            rb.AddForce(new Vector2(0f, 6f), ForceMode2D.Impulse);

            if (stars.Count > 5)
            
                Destroy(myPrefab);
            
        }

    }
    //private void OnTriggerExit2D(Collider2D other)
    //{

    //    if (Input.GetKeyDown(KeyCode.E))

    //        Instantiate(myPrefab, new Vector3(-3.26f, 7.49f, -3.568f), Quaternion.identity);


    //    if (stars.Count > 10)
    //    {
    //        Destroy(myPrefab);
    //    }
    //}
}

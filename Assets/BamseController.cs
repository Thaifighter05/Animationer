using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BamseController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxisRaw("Fire1") > 0)
        {
            GetComponent<Animator>().SetTrigger("Jump");
            GetComponent<Animator>().SetFloat("x", 3);

            GetComponent<Animator>().Play("Rotate");
        }
    }
}

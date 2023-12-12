using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class NinjaController : MonoBehaviour
{
    float speed = 5;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float moveY = Input.GetAxisRaw("Vertical");
        Vector2 movement2 = new Vector2(moveY, 0) * speed * Time.deltaTime;
        transform.Translate(movement2);

        float moveX = Input.GetAxisRaw("Horizontal");
        Vector2 movement = new Vector2(moveX, 0) * speed * Time.deltaTime;
        transform.Translate(movement);

        if (moveX < 0)
        {
            GetComponent<Animator>().Play("Ani4");
        }
        else if (moveX > 0)
        {
            GetComponent<Animator>().Play("Ani6");
        }

        if (moveY < 0)
        GetComponent<Animator>().Play("Ani5");

        else if (moveY > 0)
        GetComponent<Animator>().Play("Ani7");
        
    }
}

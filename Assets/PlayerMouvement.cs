using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMouvement : MonoBehaviour
{
    [Range(-2, 2)] public float value;
    public float speed;
    // Start is called before the first frame update
    Rigidbody rigid;
    public static int currentLevel;
    private Vector3 spawn;


    void Start()

    {
        
        spawn = transform.position;
        rigid = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = new Vector3(value, transform.position.y, transform.position.z);
        transform.position += Vector3.forward * speed * Time.deltaTime;
     
    }
    private void LateUpdate()
    {
        if (Input.GetButtonDown("Right"))
        {
            if (value == 2)
                return;
            value += 2;
        }
        if (Input.GetButtonDown("Left"))
        {
            if (value == -2)
                return;
            value -= 2;
        }
        
    }
    
    void OnCollisionEnter(Collision other)
    {
        if (other.transform.tag == "enemy")
        {
            die();
            ScoreTextScript.coinAmount = 0;

            Application.LoadLevel(currentLevel);


        }
        if (other.transform.tag == "coin")
        {
            ScoreTextScript.coinAmount += 1;

        }

    }
    void die()
    {
        transform.position = spawn;
    }
}

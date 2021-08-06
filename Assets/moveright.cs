using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveright : MonoBehaviour
{

    public float speed;
    // Start is called before the first frame update
    public GameObject player;
    public Vector3 spawn;
    void Start()
    {
        spawn = player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.forward * speed * Time.deltaTime;
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    private float speed = -12;

    private float deadLine = -10;

    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(this.speed * Time.deltaTime, 0, 0);

        if(transform.position.x < this.deadLine)
        {
            Destroy(gameObject);
        }

    }

    //�ۑ�
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "GroundTag" || other.gameObject.tag == "CubeTag")
        {
            GetComponent<AudioSource>().Play();
        }
    }


}

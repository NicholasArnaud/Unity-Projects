using UnityEngine;
using System.Collections;

public class PlayThatMusic : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<TankMovement>() != null)
        {
            GetComponent<AudioSource>().Play();
        }
    }
}

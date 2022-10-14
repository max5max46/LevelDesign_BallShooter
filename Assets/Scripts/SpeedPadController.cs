using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedPadController : MonoBehaviour
{
    public float SpeedMultipler;
    private GameObject Ball;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        Ball = other.gameObject;
        Ball.GetComponent<Rigidbody>().AddForce(Ball.GetComponent<Rigidbody>().velocity * SpeedMultipler , ForceMode.Impulse) ;
    }
}

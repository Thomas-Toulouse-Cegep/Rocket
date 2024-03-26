using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class Rocketscript : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidBody;
    [SerializeField] private float _speed = 1000;
    // Start is called before the first frame update
    void Start()
    {
        _rigidBody = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        GameObject camera = GameObject.Find("Main Camera");
        camera.transform.position = new Vector3(transform.position.x, transform.position.y + 4, transform.position.z - 10); 
        float spaceBar = Input.GetAxis("Jump");
        float deltaTime = Time.deltaTime;
        Vector3 force = new Vector3(0, spaceBar, 0) * _speed * Time.deltaTime;
     
        _rigidBody.AddRelativeForce(force,ForceMode.Impulse);
        _rigidBody.AddRelativeTorque(force,ForceMode.Impulse);
        
        // 
        
        
        

       //

    }
}

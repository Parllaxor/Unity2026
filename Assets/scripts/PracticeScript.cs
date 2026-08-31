using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    public string myName = "none";
    public float speed = 0;
    public float turnSpeed = 0;
    
    void Start()
    {
        Debug.Log("Hello, " + myName);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed);
    }
}

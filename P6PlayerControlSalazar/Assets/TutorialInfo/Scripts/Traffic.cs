using UnityEngine;

public class Traffic : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //,ove vehicle forward at a constant speed
        transform.Translate(Vector3.forward * Time.deltaTime * 20);
    }
}

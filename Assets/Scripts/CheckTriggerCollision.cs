using UnityEngine;

public class CheckTriggerCollision : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Capsule")
        {
            Debug.Log("Comienzo a chocar con el trigger");
        }
    }
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == "Capsule")
        {
            Debug.Log("Estoy chocandocon el trigger");
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Capsule")
        {
            Debug.Log("He dejado de chocar con el trigger");
            Destroy(this.gameObject);
        }

    }
}

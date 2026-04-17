using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject robot;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 0; i < 50; i++)
        {
            Instantiate(robot, new Vector3(0, 0, 0 + i * 10), Quaternion.identity);
            Instantiate(robot, new Vector3(5, 0, 0 + i * 10), Quaternion.identity);
            Instantiate(robot, new Vector3(-5, 0, 0 + i * 10), Quaternion.identity);


        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

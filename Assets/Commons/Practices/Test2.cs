using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {   int sum = 0;
        for (int i = 1; i <=10; i++)
        {
           sum += i;
                
        }
        Debug.Log(sum);




    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

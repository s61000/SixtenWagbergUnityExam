using UnityEngine;

public class BackAndForth : MonoBehaviour
{
    public float speed = 5f;         
    public float moveTime = 2f;      

    private float timer = 0f;
    private bool movingForward = true;

    void Update()
    {
        timer += Time.deltaTime;

       
        if (movingForward)
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
        else
        {
            transform.Translate(-Vector3.forward * speed * Time.deltaTime);
        }

       
        if (timer >= moveTime)
        {
            movingForward = !movingForward; 
            timer = 0f; 
        }
    }
}
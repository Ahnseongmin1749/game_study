using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    private Rigidbody enemyRb;
    private GameObject player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 lookDirection = (player.transform.position - transform.position).normalized;
           //enemyRb.AddForce((player.transform.position
           // - transform.position).normalized * speed);
        enemyRb.AddForce(lookDirection * speed);
           //Debug.Log("position °è»ê °ª" + lookDirection);
        if(transform.position.y < -10)
        {
            Destroy(gameObject);
        }

    }
    


}

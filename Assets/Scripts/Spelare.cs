using UnityEngine;

public class Spelare : MonoBehaviour
{
    public float moveSpeed = 5f;
    
    //Denna ska du spawna in i världen på studiemål 2:
    public GameObject thingToSpawn;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            
        }
        
        if (Input.GetKey(KeyCode.A))
        {

        }
        
        if (Input.GetKey(KeyCode.S))
        {

        }
        
        if (Input.GetKey(KeyCode.D))
        {

        }
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (!GameObject.Find("Canvas(Clone)"))
            {
                //Instansiera thingToSpawn på din egen position och rotation. 
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Fiende")
        {
            //Kalla på fiendens funktion "SetPoints(poäng)"
        }
    }
}

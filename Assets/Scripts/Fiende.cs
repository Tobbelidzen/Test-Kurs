using UnityEngine;
using UnityEngine.UIElements;

public class Fiende : MonoBehaviour
{
    private int points;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        points = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetPoints(int p)
    {
        points += p;
        point_Script.instance.SetPoints(1);
    }

}

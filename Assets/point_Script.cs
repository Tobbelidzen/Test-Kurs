using Unity.VisualScripting;
using UnityEngine;
using TMPro;

public class point_Script : MonoBehaviour
{
    public static point_Script instance { get; private set; }
    private int points = 0;

    void Start()
    {
        
    }
    private void Awake()
    {

        if (instance != null && instance != this)
        {
            Destroy(this);
        }
        else
        {
            instance = this;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetPoints(int p)
    {
        points += p;
        this.GetComponent<TMP_Text>().text = points.ToString();
    }
}

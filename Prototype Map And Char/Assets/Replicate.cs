using UnityEngine;
using System.Collections;

public class Replicate : MonoBehaviour
{
    public GameObject texture;
    public float x;
    public float y;
    public int xRep;
    public int yRep;
    public float xDistance;
    public float yDistance;
    // Use this for initialization
    void Start()
    {
        for (int x = 0; x < xRep; x++)
        {
            for (int y = 0; y < yRep; y++)
            {
                Instantiate(texture, new Vector3(x * xDistance, y * yDistance, 10), Quaternion.identity);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movePlayer : MonoBehaviour
{
    [SerializeField]
    private RectTransform player;

    private float leftBounds = -5.5f;
    private float rightBounds = 157f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.A) && player.position.x > leftBounds)
        {
            player.position -= new Vector3(.025f, 0, 0);
        }
        else if (Input.GetKey(KeyCode.D) && player.position.x < rightBounds)
        {
            player.position += new Vector3(.025f, 0, 0);
        }
    }
}

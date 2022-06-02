using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BoxDetecter : MonoBehaviour
{

    public string LvlName;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "toy")
        {
            SceneManager.LoadScene(LvlName);
        }
    }

    public ArrayList ColliderTest(string tag)
    {
        ArrayList colliderVector = new ArrayList();

        if (tag.Equals("toy"))
        {
            colliderVector.Add(true);
        }
        return colliderVector;
    }
}

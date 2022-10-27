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
        if (collider.gameObject.tag == "toy16")
        {
            Game_Score.instance.score -= 5;
            Game_Score.instance.UpdateScoreText();
            SceneManager.LoadScene(LvlName);
        }

        if (collider.gameObject.tag == "toy18")
        {
            Game_Score.instance.score += 10;
            Game_Score.instance.UpdateScoreText();
            SceneManager.LoadScene(LvlName);
        }

        if (collider.gameObject.tag == "toy20")
        {
            Game_Score.instance.score -= 5;
            Game_Score.instance.UpdateScoreText();
            SceneManager.LoadScene(LvlName);
        }

        if (collider.gameObject.tag == "toy26")
        {
            Game_Score.instance.score += 10;
            Game_Score.instance.UpdateScoreText();
            SceneManager.LoadScene(LvlName);
        }

        if (collider.gameObject.tag == "toy28")
        {
            Game_Score.instance.score -= 5;
            Game_Score.instance.UpdateScoreText();
            SceneManager.LoadScene(LvlName);
        }

        if (collider.gameObject.tag == "toy30")
        {
            Game_Score.instance.score -= 5;
            Game_Score.instance.UpdateScoreText();
            SceneManager.LoadScene(LvlName);
        }

        if (collider.gameObject.tag == "toy31")
        {
            Game_Score.instance.score -= 5;
            Game_Score.instance.UpdateScoreText();
            SceneManager.LoadScene(LvlName);
        }

        if (collider.gameObject.tag == "toy32")
        {
            Game_Score.instance.score -= 5;
            Game_Score.instance.UpdateScoreText();
            SceneManager.LoadScene(LvlName);
        }

        if (collider.gameObject.tag == "toy33")
        {
            Game_Score.instance.score += 10;
            Game_Score.instance.UpdateScoreText();
            SceneManager.LoadScene(LvlName);
        }
    }

    public ArrayList ColliderTest(string tag)
    {
        ArrayList colliderVector = new ArrayList();

        if (tag.Equals("toy16") || tag.Equals("toy18") || tag.Equals("toy20"))
        {
            colliderVector.Add(true);
        }
        return colliderVector;
    }
}

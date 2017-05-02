
using UnityEngine;
using UnityEngine.UI;

public class CoinCount : MonoBehaviour
{

    public int score = 0;
    public Text scoreText;
  //  public string coinTagString;
  //  public string badCoinTagString;


    void Start()
    {

    }

    void OnCollisionEnter(Collision col)
    {

        Debug.Log("Collision" + col.gameObject.name);

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Coin")
        {
            score = score + 1;
        }

        else if (other.tag == "BadCoin" && score > 0)

        {
            
                score = score - 1;
            
        }
        Debug.Log("Triggered " + score + " " + other.gameObject.name);

        scoreText.text = "Score: " + score;

        Destroy(other.gameObject);

    }
}

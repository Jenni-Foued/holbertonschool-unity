using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    private float horizontalInput;
    private float verticalInput;

    private Rigidbody rb;

    public float speed = 1f;

    private int score = 0;

    public int health = 5;

    public Text scoreText;

    public Text healthText;

    public Image winLoseBG;

    public Text winLoseText;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        if(Input.GetButton("Cancel"))
        {
            SceneManager.LoadScene("menu");
        }
        if (health == 0)
        {
            Lose();
            StartCoroutine(LoadScene(3));
        }    
    }

    // FixedUpdate
    void FixedUpdate()
    {
        if (verticalInput == 1)
        {
            rb.AddForce(Vector3.forward * speed, ForceMode.VelocityChange);
        }

        if (verticalInput == -1)
        {
            rb.AddForce(Vector3.back * speed, ForceMode.VelocityChange);
        }

        if (horizontalInput == 1)
        {
            rb.AddForce(Vector3.right * speed, ForceMode.VelocityChange);
        }

        if (horizontalInput == -1)
        {
            rb.AddForce(Vector3.left * speed, ForceMode.VelocityChange);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Pickup"))
        {    
            score++;
            SetScoreText();
            Destroy(other.gameObject);
        }

        if (other.CompareTag("Trap"))
        {    
            health--;
            SetHealthText();
        }

        if (other.CompareTag("Goal"))
        {    
            Win();
            StartCoroutine(LoadScene(3));
        }
    }

    // Updates player's score
    void SetScoreText()
    {
        scoreText.text = "Score: " + score.ToString();
    }

    // Updates player's health
    void SetHealthText()
    {
        healthText.text = "Health: " + health.ToString();
    }

    void Win()
    {
        winLoseBG.color = new Color32(0,255,0,255);
        winLoseText.color = new Color32(0,0,0,255);
        winLoseText.text = "You Win!";
        winLoseBG.gameObject.SetActive(true);
    }

    void Lose()
    {
        winLoseBG.color = new Color32(255,0,0,255);
        winLoseText.color = new Color32(255,255,255,255);
        winLoseText.text = "Game Over!";
        winLoseBG.gameObject.SetActive(true);
    }

    IEnumerator LoadScene(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        SceneManager.LoadScene("Maze");
        score = 0;
        health = 5;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Threading;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    public PlayerMovement movement;
    private Rigidbody rb;
    public float forwardForce = 500f;
    public float sidewaysForce = 120f;
    public Text loseText;
    [SerializeField] private AudioClip m_CoinSound;
    [SerializeField] private AudioClip m_DeathSound;
    private AudioSource m_AudioSource;
    public Text countText;
    private int count = 0;
    public Text lifeCount;
    private int lifeCounter = 5;
    [SerializeField] private Transform player;
    [SerializeField] private Transform respawnpoint;



    void Start()
    {
        rb = GetComponent<Rigidbody>();
        loseText.text = "";
        m_AudioSource = GetComponent<AudioSource>();
        count = count;
        lifeCounter = lifeCounter;
        SetCountText();
        SetLifeCount();
    }
    void SetCountText()
    {
        // stig teljari
        countText.text = count.ToString();
        // ef player er buin að safna pening
        if (count >= 10)
        {
            // next scene birtist og vinnur
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

    }

    void SetLifeCount()
    {
        // líf teljari
        lifeCount.text = lifeCounter.ToString();
        // ef player er með 0 líf
        if (lifeCounter <= 0)
        {
            // next scene birtist og tapar
            SceneManager.LoadScene("creditsLost");
        }

    }

    void FixedUpdate()
    {
        // Ef ýtt er á upp örvatakkann eða w     
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey("w"))
        {
            // Fer áfram
            rb.AddForce(0, 0, forwardForce * Time.fixedDeltaTime, ForceMode.VelocityChange);
        }

        // Ef ýtt er á niður örvatakkann eða s
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey("s"))
        {
            // Fer aftan
            rb.AddForce(0, 0, -forwardForce * Time.fixedDeltaTime, ForceMode.VelocityChange);
        }

        // Ef ýtt er á hægri örvatakkann eða d
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey("d"))
        {
            // Fer til hægri
            rb.AddForce(sidewaysForce * Time.fixedDeltaTime, 0, 0, ForceMode.VelocityChange);
        }

        // Ef ýtt er á vinstri örvatakkann eða a
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey("a"))
        {
            // Fer til vinstri
            rb.AddForce(-sidewaysForce * Time.fixedDeltaTime, 0, 0, ForceMode.VelocityChange);
        }

        //  Ef player dettur
        if (rb.position.y < -1f)
        {
            // Kemur hljóð
            m_AudioSource.clip = m_DeathSound;
            m_AudioSource.Play();
            // Birtist texta
            loseText.gameObject.SetActive(true);
            loseText.text = "-1 líf";
            // Respawn á respawnPoint
            player.transform.position = respawnpoint.transform.position;
            Physics.SyncTransforms();
        }

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("LifeCoin"))// Ef hitt á LifeCoin tag
        {
            //hverfur lifecoin
            other.gameObject.SetActive(false);
            // Kemur hljóð
            m_AudioSource.clip = m_CoinSound;
            m_AudioSource.Play();
            // færð líf
            lifeCounter = lifeCounter + 1;
            SetLifeCount();
        }
        if (other.gameObject.CompareTag("Coin"))// Ef hitt á Coin tag
        {
            //hverfur coin
            other.gameObject.SetActive(false);
            // Kemur hljóð
            m_AudioSource.clip = m_CoinSound;
            m_AudioSource.Play();
            // færð stig
            count = count + 1;
            SetCountText();
        }
        if (other.gameObject.CompareTag("Enemy"))// Ef hitt á Enemy tag
        {
            // Kemur hljóð
            m_AudioSource.clip = m_DeathSound;
            m_AudioSource.Play();
            // missir líf
            lifeCounter = lifeCounter - 1;
            SetLifeCount();
            // Respawn á respawnPoint
            player.transform.position = respawnpoint.transform.position;
            Physics.SyncTransforms();
        }
        if (other.gameObject.CompareTag("Obstacle"))// Ef hitt á Obstacle tag (bomba)
        {
            // Kemur hljóð
            m_AudioSource.clip = m_DeathSound;
            m_AudioSource.Play();
            // missir líf
            lifeCounter = lifeCounter - 1;
            SetLifeCount();
            // Respawn á respawnPoint
            player.transform.position = respawnpoint.transform.position;
            Physics.SyncTransforms();
        }
        if (other.gameObject.CompareTag("Water"))// Ef hitt á Water tag
        {
            // Kemur hljóð
            m_AudioSource.clip = m_DeathSound;
            m_AudioSource.Play();
            // missir líf
            lifeCounter = lifeCounter - 1;
            SetLifeCount();
            // Respawn á respawnPoint
            player.transform.position = respawnpoint.transform.position;
            Physics.SyncTransforms();
        }
    }
}

using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private TextMeshProUGUI gameOverText;
    
    [SerializeField] private Transform camera;
    [SerializeField] private Transform doodler;

    private int yCamera, yDoodler, maxScore = 0;
    [SerializeField] private int yPositionDeath;
    void Start()
    {
        gameOverText.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void LateUpdate()
    {
        yDoodler = (int)doodler.position.y;
        yCamera = (int)camera.position.y;

        if (yDoodler < (yCamera - yPositionDeath))
        {
            gameOverText.gameObject.SetActive(true);

            if (Input.GetKeyUp(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
            else if (Input.GetKeyUp(KeyCode.Q))
            {
                Application.Quit();
                Debug.Log("Application quit");
            }

        //Time.timeScale = 0f;
        }

        if (maxScore < yDoodler)
        {
            maxScore = yDoodler;
            scoreText.text = maxScore.ToString();
        }
    }
}

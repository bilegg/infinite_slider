using UnityEngine.UI;
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class DeathScreen : MonoBehaviour
{
    public Text score;
    public Transform player;
    public Text youReached;
    public Text goodJob;
    public Animator anim;
    private PlayerCollision playerScript;
    private Text textComponent;
    private IEnumerator coroutine;
    private bool hasPlayed = false;

    // Start is called before the first frame update
    void Start()
    {
        playerScript = player.GetComponent<PlayerCollision>();
    }

    // Update is called once per frame
    void Update()
    {
        if(playerScript.hasColided || player.transform.position.y <= -1)
        {
            score.enabled = false;
            coroutine = resetLevel(3.144f);
            StartCoroutine(coroutine);
            youReached.text = "You reached " + score.text + " points !";
            youReached.enabled = true;
            goodJob.enabled = true;
            anim.enabled = true;
            GetComponent<UpdateHighscore>().update();
        }

        if(hasPlayed == false && playerScript.hasColided)
        {
            hasPlayed = true;
        }

        if (hasPlayed == false && player.transform.position.y <= -1)
        {
            hasPlayed = true;
        }
    }

    private IEnumerator resetLevel(float time)
    {
        yield return new WaitForSeconds(time);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

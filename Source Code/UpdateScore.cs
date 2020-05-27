using UnityEngine.UI;
using UnityEngine;

public class UpdateScore : MonoBehaviour
{
    public Transform player;
    public Text score;
    // Update is called once per frame
    void Update()
    {
        if(!player.GetComponent<PlayerCollision>().hasColided && player.transform.position.y > -1) score.text = ((int)player.position.z).ToString();
    }
}

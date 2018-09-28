
using UnityEngine;
using UnityEngine.SceneManagement;

public class KeyCounter : MonoBehaviour {

    public int NumberOfKeys;
    


    private void Start()
    {
        NumberOfKeys = 0;
    }

    private void LateUpdate()
    {
        if (NumberOfKeys == 3)
        {
            SceneManager.LoadScene("3DgameLevel 2");
        }
        if(NumberOfKeys < 0 )
        {
            NumberOfKeys = 0;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if ( collision.gameObject.tag == "key")
        {
            NumberOfKeys++;
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.tag == "Enemy")
        {
            NumberOfKeys--;
        }
        
    }
}

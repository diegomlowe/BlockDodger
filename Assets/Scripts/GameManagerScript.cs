using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerScript : MonoBehaviour {

    public float slowness = 10f;

	public void EndGame()
    {

        StartCoroutine(ResartLevel());

    }

    public IEnumerator gotHit()
    {

        Time.timeScale = 1 / slowness;

        Time.fixedDeltaTime = Time.fixedDeltaTime / slowness;

        yield return new WaitForSeconds(1f / slowness);

        Time.timeScale = 1;

        Time.fixedDeltaTime = Time.fixedDeltaTime * slowness;

        FindObjectOfType<PlayerScript>().menosScore(100);

    }

    IEnumerator ResartLevel()
    {


        Time.timeScale = 1 / slowness;

        Time.fixedDeltaTime = Time.fixedDeltaTime / slowness;

        yield return new WaitForSeconds(1f / slowness);

        Time.timeScale = 1;

        Time.fixedDeltaTime = Time.fixedDeltaTime * slowness;


        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }

    public IEnumerator slowly()
    {

        Time.timeScale = 1 / slowness;

        Time.fixedDeltaTime = Time.fixedDeltaTime / slowness;

        yield return new WaitForSeconds(1f / slowness);

        Time.timeScale = 1;

        Time.fixedDeltaTime = Time.fixedDeltaTime * slowness;

    }

}

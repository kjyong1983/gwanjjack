using UnityEngine;
using System.Collections;

public class CoffinCoverBreak : MonoBehaviour {

    public bool gameStart = false;
    //Rigidbody2D rb;
    Rigidbody rb;
    Vector3 randomVector;

	void Start () {
        rb = gameObject.GetComponent<Rigidbody>();
        randomVector = new Vector3(Random.Range(-5, 5), Random.Range(0, 5), Random.Range(-5, 5));
        gameStart = true;// 이 부분을 true로 바꿔야 함
    }

    void Update () {
        if (gameStart)
        {
            rb.AddExplosionForce(300f, gameObject.transform.position + randomVector, 100f, 30f);
            //Debug.DrawRay(gameObject.transform.position + randomVector, Vector3.up, Color.red, 10f);
            gameStart = false;
            StartCoroutine(Destroy());
            //Debug.Break();

        }
	}

    IEnumerator Destroy()
    {
        yield return new WaitForSeconds(5);
        Destroy(gameObject);
        yield break;
    }


}
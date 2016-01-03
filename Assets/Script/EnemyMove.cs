using UnityEngine;
using System.Collections;

public class EnemyMove : MonoBehaviour {

    public float speen = 4;

    private float timer = 0;
    private float dir_x = 0;
    private float dir_z = 0;
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        if (timer > 4 )
        {
            dir_x = Random.Range(-1, 1f);
            dir_z = Random.Range(-1, 1f);
            timer = 0;
        }
        //float dir = Random.Range(-1, 1f);
        transform.Translate(new Vector3(dir_x, 0, dir_z)*speen*Time.deltaTime);

	
	}
}

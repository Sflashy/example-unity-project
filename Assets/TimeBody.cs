using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeBody : MonoBehaviour
{

    public bool isRewinding = false;
    public GameObject playerclone;
    List<Vector2> positions = new List<Vector2>();
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.PageUp))
        StartCoroutine(Rewind());
    }

    void FixedUpdate(){
        Record();
    }
IEnumerator Rewind()
{
        Instantiate(playerclone);
        for(int i = 0; i < positions.Count; i++){
            playerclone.transform.position = new Vector2(positions[i].x, positions[i].y);
            yield return new WaitForSeconds(0.01f);
            ///Debug.Log(playerclone.transform.position);
        }
        yield return null;
}
    public void Record() {
        positions.Add(transform.position);
    }
}

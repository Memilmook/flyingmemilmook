using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakePipe : MonoBehaviour
{
    public GameObject pipe; //���ӿ�����Ʈ�� �޴´�.
    public float timeDiff;
    float timer = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > timeDiff + Random.Range(1f, 4f))
        {
            GameObject newPipe = Instantiate(pipe);
            newPipe.transform.position = new Vector3(0.9f, Random.Range(-4f, 1.3f), 0f);
            timer = 0;
            Destroy(newPipe, 7f);
        }

    }
}

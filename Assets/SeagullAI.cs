using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeagullAI : MonoBehaviour
{
    public SeagullCharacter seagullCharacter;
    public float yawVelocity = 0f;
    public float forwardAcceleration = 0f;
    public bool apply = false;


    // Start is called before the first frame update
    void Start()
    {
      StartCoroutine(HandleState());
    }

    IEnumerator HandleState() {
      float r = Random.Range(0f,1f);
      if (r < 0.4) {
        seagullCharacter.yawVelocity = 0;
        seagullCharacter.forwardAcceleration = 1;

        yield return new WaitForSeconds(5);
      }
      else if (r < 0.8) {
        seagullCharacter.yawVelocity = 1;
        seagullCharacter.forwardAcceleration = 1;

        yield return new WaitForSeconds(2);
      }
      else {
        // Stop
        seagullCharacter.yawVelocity = 0;
        seagullCharacter.forwardAcceleration = 0;

        yield return new WaitForSeconds(5);
      }


      StartCoroutine(HandleState());
    }

    // Update is called once per frame
    void Update()
    {


    }
}

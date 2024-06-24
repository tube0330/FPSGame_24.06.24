using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Unity.VisualScripting.Member;

public class LightOnOff : MonoBehaviour
{
    public Light StairLight;
    public AudioSource source;
    public AudioClip clip;
    void Start()
    {

    }

    /*is Trigger 했을 때 통과 하면서 충돌 감지하는 함수
    스스로 호출하기 때문에 콜백 함수라고 함*/
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            StairLight.enabled = true;
            source.PlayOneShot(clip, 1.0f);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            StairLight.enabled = false;
            source.PlayOneShot(clip, 1.0f);
        }
    }
    void Update()
    {

    }
}

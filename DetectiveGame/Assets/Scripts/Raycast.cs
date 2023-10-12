using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour
{
    //플레이어 프리팹
    public GameObject Player;
    private Transform tr;
    private LineRenderer line;

    //광선에 충돌한 게임오브젝트의 정보를 받아올 변수
    private RaycastHit hit;
    private RaycastHit hitInfo; // 충돌체 정보 저장.

   
    // 아이템 레이어에만 반응하도록 레이어 마스크를 설정.
    [SerializeField]
    private LayerMask layerMask;

    public AudioSource policevoice;
    public AudioClip pv;
    public AudioSource playervoice;
    public AudioClip voice1;
    public AudioClip voice2;
    public AudioClip voice3;
    public AudioClip voice4;
    public AudioSource attacker1voice;
    public AudioClip attacker1_Q1;
    public AudioClip attacker1_Q2;
    public AudioSource attacker2voice;
    public AudioClip attacker2_Q1;
    public AudioClip attacker2_Q2;
    public AudioSource attacker3voice;
    public AudioClip attacker3_Q1;
    public AudioClip attacker3_Q2;
    public AudioSource attacker4voice;
    public AudioClip attacker4_Q1;
    public AudioClip attacker4_Q2;

    public GameObject Attacker1;
    public GameObject Attacker2;
    public GameObject Attacker3;
    public GameObject Attacker4;

    public GameObject Evidence1;
    public GameObject Evidence2;
    public GameObject Evidence3;
    public GameObject Evidence4;

    public GameObject kakaoWindow;
    public GameObject basicWindow;

    public GameObject Police;
    public GameObject Fail;
    public GameObject Succ;

    void Start()
    {

        //컴포넌트 할당
        tr = GetComponent<Transform>();
        line = GetComponent<LineRenderer>();
   
        line.useWorldSpace = false;
        //초기에 비활성화함
        line.enabled = false;
        //라인의 시작폭과 종료폭 설정
        line.SetWidth(0.01f, 0.01f);
    }

    void Update()
    {
        //광선을 미리 생성
        Ray ray = new Ray(tr.position + (Vector3.up * 0.02f), tr.forward);

        //광선이 눈에 보이게 설정
        Debug.DrawRay(ray.origin, ray.direction * 100, Color.blue);


        //A버튼을 눌렀을 때
        if (OVRInput.GetDown(OVRInput.Button.One))
        {
            //Line Renderer의 첫 번째 위치 설정
            line.SetPosition(1, tr.InverseTransformPoint(ray.origin));

            //어떤 물체에 광선이 맞았을 때의 위치를 Line Renderer의 끝점으로 설정
            if (Physics.Raycast(ray, out hit, 100.0f))
            {
                Debug.Log(hit.transform.tag);
                line.SetPosition(1, tr.InverseTransformPoint(hit.point));


                //레이저가 tag가 달린 오브젝트에 맞았을 때 실행
                //첫번째 증거 - 피해자 등에 박혀있는 칼
                if (hit.transform.tag == "OkBtn")
                {
                    hit.transform.parent.gameObject.SetActive(false);
                    if (hit.transform.parent.name == "VictimDescription")
                    {
                        policevoice.clip = pv;
                        policevoice.Play();
                    }
                }
                if (hit.transform.tag == "Evidence1")
                {
                    Evidence1.SetActive(true);
                    playervoice.clip = voice1;
                    playervoice.volume = 0.2f;
                    playervoice.Play();
                }
                if (hit.transform.tag == "Evidence2")
                {
                    Evidence2.SetActive(true);
                    playervoice.clip = voice2;
                    playervoice.volume = 0.2f;
                    playervoice.Play();
                }
                if (hit.transform.tag == "Evidence3")
                {
                    Evidence3.SetActive(true);
                    playervoice.clip = voice3;
                    playervoice.volume = 0.2f;
                    playervoice.Play();
                }
                if (hit.transform.tag == "Evidence4")
                {
                    Evidence4.SetActive(true);
                    playervoice.clip = voice4;
                    playervoice.volume = 1.0f;
                    playervoice.Play();
                }
                if (hit.transform.tag == "Attacker1")
                {
                    Attacker1.SetActive(true);
                }
                if (hit.transform.tag == "Attacker2")
                {
                    Attacker2.SetActive(true);
                }
                if (hit.transform.tag == "Attacker3")
                {
                    Attacker3.SetActive(true);
                }
                if (hit.transform.tag == "Attacker4")
                {
                    Attacker4.SetActive(true);
                }
                if (hit.transform.tag == "Kakaotalk")
                {
                    basicWindow.SetActive(false);
                    kakaoWindow.SetActive(true);
                }
                if (hit.transform.tag == "Police")
                {
                    Police.SetActive(true);
                }
                if (hit.transform.tag == "choice1")
                {
                    Fail.SetActive(true);
                    Police.SetActive(false);
                }
                if (hit.transform.tag == "choice2")
                {
                    Succ.SetActive(true);
                    Police.SetActive(false);
                }
                if (hit.transform.tag == "choice3")
                {
                    Fail.SetActive(true);
                    Police.SetActive(false);
                }
                if (hit.transform.tag == "choice4")
                {
                    Fail.SetActive(true);
                     Police.SetActive(false);
                }
                if (hit.transform.tag == "Question1")
                {
                    if (hit.transform.parent.name == "Attackerinfo1")
                    {
                        attacker1voice.clip = attacker1_Q1;
                        attacker1voice.Play();
                    }
                    if (hit.transform.parent.name == "Attackerinfo2")
                    {
                        attacker2voice.clip = attacker2_Q1;
                        attacker2voice.Play();
                    }
                    if (hit.transform.parent.name == "Attackerinfo3")
                    {
                        attacker3voice.clip = attacker3_Q1;
                        attacker3voice.Play();
                    }
                    if (hit.transform.parent.name == "Attackerinfo4")
                    {
                        attacker4voice.clip = attacker4_Q1;
                        attacker4voice.Play();
                    }
                }
                if (hit.transform.tag == "Question2")
                {
                    if (hit.transform.parent.name == "Attackerinfo1")
                    {
                        attacker1voice.clip = attacker1_Q2;
                        attacker1voice.Play();
                    }
                    if (hit.transform.parent.name == "Attackerinfo2")
                    {
                        attacker2voice.clip = attacker2_Q2;
                        attacker2voice.Play();
                    }
                    if (hit.transform.parent.name == "Attackerinfo3")
                    {
                        attacker3voice.clip = attacker3_Q2;
                        attacker3voice.Play();
                    }
                    if (hit.transform.parent.name == "Attackerinfo4")
                    {
                        attacker4voice.clip = attacker4_Q2;
                        attacker4voice.Play();
                    }
                }
                
            }
            else
            {
                line.SetPosition(1, tr.InverseTransformPoint(ray.GetPoint(100.0f)));
            }
            //광선을 일정 시간동안 표시하는 코루틴 함수 호출
            //StartCoroutine(this.ShowLaserBeam());
            line.enabled = true;
        }

        if (OVRInput.GetUp(OVRInput.Button.One))
        {

            line.enabled = false;
        }



    }

  

}

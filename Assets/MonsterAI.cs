using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MonsterAI : MonoBehaviour {

    [Header("Monster Attributes")]      //增加一个小标题
    public int hp;
    [Range(0,100)]      //hpMax可以变为滑竿控制
    public int hpMax = 100;

    [Header("Audio Sources")]
    public AudioSource asHit;       //受伤音效
    public AudioSource asDie;       //死亡音效

    [Space(15)]
    public ParticleSystem bloodEFX;
    public Text hpText;
    public Slider hpSlider;

    private Animator anim;
    private Collider col;
    private Collider atkSphereEnemy;
    private GameObject AI;

	void Start () {
        hp = hpMax;
        anim = gameObject.GetComponent<Animator>();
        col = gameObject.GetComponent<CapsuleCollider>();
        atkSphereEnemy = gameObject.GetComponentInChildren<SphereCollider>();
        AI = gameObject.transform.Find("AI").gameObject;

    }

	void Update () {
        hp = Mathf.Clamp(hp, 0, 100);       //控制hp数值在0到100之间

        hpText.text = hp + "/" + hpMax;
        hpSlider.value = (float)hp / (float)hpMax;

        if (hp <= 0)
        {
            DieStart();
        }
	}

    public void PlayBloodEFX()
    {
        bloodEFX.Play();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "AtkSphere")
        {
            //让血喷向摄像机位置
            Vector3 lookDir = Camera.main.transform.position - transform.position;
            bloodEFX.transform.rotation = Quaternion.LookRotation(lookDir);

            PlayBloodEFX();
            hp -= 20;
            anim.SetTrigger("hit");     //怪物受到攻击

            if (hp > 0)
            {
                asHit.Play();
            }
            else
            {
                asDie.Play();
                AI.SetActive(false);
            }
        }

    }

    private void DieStart()
    {
        //Destroy(gameObject);
        anim.SetTrigger("die");
        col.enabled = false;
    }

    public void DieTween()
    {
        iTweenEvent.GetEvent(gameObject, "DieTween").Play();
    }

    public void DieEnd()
    {
        Destroy(gameObject, 2.0f);
    }

    public void AtkStartEnemy()
    {
        atkSphereEnemy.enabled = true;
    }

    public void AtkStopEnemy()
    {
        atkSphereEnemy.enabled = false;
    }
}

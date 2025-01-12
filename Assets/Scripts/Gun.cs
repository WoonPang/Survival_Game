using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public string gunName;  // �� �̸�
    public float range; // ���� �Ÿ�
    public float accuracy;  // ��Ȯ��
    public float fireRate;  // ����ӵ�
    public float reloadTime;    // ������ �ӵ�

    public int damage;  // �� ������

    public int reloadBullletCount;  // �Ѿ� ������ ����
    public int currentBulletCount;  // ���� ź������ �����ִ� �Ѿ� ����
    public int maxBulletCount;  // �ִ� ���� ���� �Ѿ� ����
    public int carryBulletCount;    // ���� ���� �Ѿ� ����

    public float retroActionForce;  // �ݵ� ����
    public float retroActionFineSightForce; // �����ؽ� �ݵ� ����

    public Vector3 fineSightOriginPos;
    public Animator anim;
    public ParticleSystem muzzleFlash;  // �ѱ� ȭ�� ��ƼŬ

    public AudioClip fire_Sound;    // �� �߻� �Ҹ�
}

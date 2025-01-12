using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    // 필요 컴포넌트
    [SerializeField]
    private GunController theGunController;
    private Gun currentGun;

    // 필요시 HUD 호출, 불필요시 HUD 비활성화
    [SerializeField]
    private GameObject go_BulletHUD;

    // 총알 개수 텍스트에 반영
    [SerializeField]
    private Text[] text_Bullet;

    void Update()
    {
        CheckBullet();
    }

    private void CheckBullet()
    {
        currentGun = theGunController.GetGun();
        text_Bullet[0].text = currentGun.carryBulletCount.ToString();
        text_Bullet[1].text = currentGun.reloadBullletCount.ToString();
        text_Bullet[2].text = currentGun.currentBulletCount.ToString();
    }
}

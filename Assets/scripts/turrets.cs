using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turrets : MonoBehaviour
{
    public GameObject player;
    public GameObject turret;

    public float turretrange;
    public float bulletspeed;

    public Transform firepoint;

    public float firerate;


    //prefabs
    public GameObject turretbullet;
    public bool canshoot;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(shootcooldown());
    }

    // Update is called once per frame
    void Update()
    {
        float distanceToCoin = Vector3.Distance(player.transform.position, turret.transform.position);

        if(distanceToCoin < turretrange)
        {
            Quaternion rotation = Quaternion.LookRotation(player.transform.position - transform.position, transform.TransformDirection(Vector3.up));
            transform.rotation = new Quaternion(0, 0, rotation.z, rotation.w);
            canshoot = true;
        }
        else
        {
            canshoot = false;
        }

    }

    public IEnumerator shootcooldown()
    {
        yield return new WaitForSecondsRealtime(firerate);
        //shoot();
        
        if(canshoot == true)
        {
            shoot();
        }

        StartCoroutine(shootcooldown());
    }

    public void shoot()
    {
        GameObject bullet = Instantiate(turretbullet, firepoint.transform.position, firepoint.transform.rotation);
        Rigidbody2D rb2 = bullet.GetComponent<Rigidbody2D>();
        rb2.AddForce(firepoint.up * bulletspeed, ForceMode2D.Impulse);
    }
}

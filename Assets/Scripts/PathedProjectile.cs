﻿using UnityEngine;

public class PathedProjectile : MonoBehaviour, ITakeDamage
{
    private Transform _targetDestination;
    private float _speed;

    //public GameObject DestroyEffect;
    //public int PointsToGivePlayer;

    public void Initalize(Transform destination, float speed)
    {
        _targetDestination = destination;
        _speed = speed;
    }

    public void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, _targetDestination.position, Time.deltaTime * _speed);

        var distanceSquared = (_targetDestination.transform.position - transform.position).sqrMagnitude;

        if(distanceSquared > .01f * .01f)
            return;

        /*if (DestroyEffect != null)
            Instantiate(DestroyEffect, transform.position, transform.rotation);*/

        Destroy(gameObject);
    }

    public void TakeDamage(int damage, GameObject instigator)
    {
        /*if (DestroyEffect != null)
            Instantiate(DestroyEffect, transform.position, transform.rotation);*/

        Destroy(gameObject);

        //var projectile = instigator.GetComponent<Projectile>();
       /* if (projectile != null && projectile.Owner.GetComponent<Player>() != null && PointsToGivePlayer != 0)
        {
            GameManager.Instance.AddPoints(PointsToGivePlayer);
            FloatingText.Show();
        }*/
    }
}
    



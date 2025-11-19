using UnityEngine;

public class LightningPojectile : MonoBehaviour
{
    public float speed = 20f;
    public GameObject lightningPrefab;
    public Transform firePoint;
    public float attackRange = 10f;
    public float attackCoolDown = 2f;
    private Transform player;
    private float nextAttackTime = 0f;
    private bool lightningActive = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }
    public void Initialize(Transform target)
    {
        transform.Translate(Vector3.forward * Time.deltaTime);
    }
    // Update is called once per frame
    void Update()
    {
        Vector3 direction = (player.position - transform.position).normalized;
        transform.position += direction * speed * Time.deltaTime;
        if (player == null) return;
        float distance = Vector3.Distance(transform.position, player.transform.position);

        if (distance < attackRange && Time.time >= nextAttackTime)
        {
            Firelightning();
            nextAttackTime = Time.time + attackCoolDown;
        }
    }
        void Firelightning()
        {
            Instantiate(lightningPrefab, firePoint.position, firePoint.rotation);
        // making the lightning hit the character and disapear when hitthing the player
        GameObject lightning = Instantiate(lightningPrefab, firePoint.position, firePoint.rotation);
        lightningActive = true;
        Invoke(nameof(ResetLightningFlag), 2f);
        }
    void ResetLightningFlag()
    {
        lightningActive = false;
        Debug.Log("Game Over!");
    }
}

    

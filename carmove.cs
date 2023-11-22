using System.Collections;
using UnityEngine;

public class carmove : MonoBehaviour
{
    private float rot_speed = 120.0f;
    private float normalSpeed = 1.3f;
    private float boostSpeed = 3.0f;
    private float boostDuration = 2.0f;
    private float slowSpeed = 0.5f;
    private float slowDuration = 2.0f;
    private bool isBoosted = false;
    private bool isPooped = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (isBoosted)
        {
            boostDuration -= Time.deltaTime;
            if (boostDuration <= 0.0f)
            {
                ResetBoost();
            }
        }
        else if (isPooped)
        {
            slowDuration -= Time.deltaTime;
            if (slowDuration <= 0.0f)
            {
                ResetPoop();
            }
        }

        this.transform.Translate(Vector3.right * GetMoveSpeed() * Time.deltaTime);

        float degrees_per_frame = rot_speed * Time.deltaTime;
        float tank_angle = Input.GetAxis("Horizontal");
        this.transform.Rotate(0.0f, tank_angle * degrees_per_frame, 0.0f);

        if (Input.GetKey(KeyCode.DownArrow))
            this.transform.Translate(Vector3.left * 2.2f * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("boostitem"))
        {
            ApplyBoost();
            Destroy(other.gameObject);
        }
        else if (other.CompareTag("poopitem"))
        {
            ApplySlowDown();
            Destroy(other.gameObject);
        }
    }

    private void ApplyBoost()
    {
        if (!isBoosted)
        {
            isBoosted = true;
            GetComponent<Rigidbody>().velocity = transform.forward * boostSpeed;
        }
        else
        {
            // 이미 부스트 중이라면 부스트 지속 시간을 연장
            boostDuration += 3.0f;
        }
    }

    private void ApplySlowDown()
    {
        if (!isPooped)
        {
            isPooped = true;
            GetComponent<Rigidbody>().velocity = transform.forward * slowSpeed;
        }
        else
        {
            // 이미 똥 아이템을 먹었다면 똥 아이템 지속 시간을 연장
            slowDuration += 3.0f;
        }
    }

    private float GetMoveSpeed()
    {
        return isBoosted ? boostSpeed : (isPooped ? slowSpeed : normalSpeed);
    }

    private void ResetBoost()
    {
        isBoosted = false;
        GetComponent<Rigidbody>().velocity = transform.forward * normalSpeed;
        boostDuration = 3.0f;
    }

    private void ResetPoop()
    {
        isPooped = false;
        GetComponent<Rigidbody>().velocity = transform.forward * normalSpeed;
        slowDuration = 3.0f;
    }
}

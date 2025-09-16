using UnityEngine;

public class LS_CharacterType3 : BaseCharacter
{
    private void Update()
    {
        Audio();

        Move(speed * Time.deltaTime);
    }

    public override void Move(float speed)
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(speed, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(-speed, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Rotate(0f, 0f, speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Rotate(0f, 0f, -speed);
        }
    }
}

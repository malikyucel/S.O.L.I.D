using UnityEngine;

public class LS_CharacterType1 : BaseCharacter
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
            transform.Translate(speed, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-speed, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0f, speed, 0f);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0f, -speed, 0f);
        }
    }
}

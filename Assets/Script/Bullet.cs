using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 5f; // Tốc độ di chuyển của viên đạn
    // Giá trị y tối đa trước khi viên đạn bị destroy

    void Update()
    {
        // Di chuyển viên đạn lên trên
        transform.Translate(Vector3.up * speed * Time.deltaTime);

        // Kiểm tra nếu viên đạn vượt quá giá trị y tối đa

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
         if (collision.gameObject.CompareTag("BotEnemy"))
        {
            Debug.Log("viên đạn đã va chạm với game object có nhãn BotEnemy");
            Destroy(gameObject);
            Debug.Log("đã xóa vật thể này");
        }

    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}

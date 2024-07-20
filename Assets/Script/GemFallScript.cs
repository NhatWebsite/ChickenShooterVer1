using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemFallScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //play âm thanh từ component đó
        
        Debug.Log("Phát hiện va chạm giữa máy bay và vật thể !");
        Debug.Log("đang xử lý va chạm...");
        if (collision.gameObject.CompareTag("BotEnemy"))
        {
            Debug.Log("vật thể đã va chạm với game object có nhãn BotEnemy");
            Destroy(gameObject);
            Debug.Log("đã xóa máy bay này ");
        }
      


    }
}

using UnityEngine;

    public class CleansingTheWorldFrom : MonoBehaviour
    {
        public string tagObjForDestroy;


        AudioManager audioManager;
        

        private void Awake()
        {
            //audioManager = GameObject.FindObjectOfType("Audio").GetComponent<AudioManager>();
            audioManager = GameObject.FindObjectOfType<AudioManager>();

                    }

        private void Start()
        {
            if (tagObjForDestroy == string.Empty || tagObjForDestroy == null)
            {
                tagObjForDestroy = Tag.Food;
            }
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.CompareTag(tagObjForDestroy))
            {
                Destroy(collision.gameObject);
                audioManager.PlaySFX(audioManager.Spawn);
            }
            
        }
    }

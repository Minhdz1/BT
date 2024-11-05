using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PipeGenerator : MonoBehaviour
{
    public GameObject PipePrefab;
    public bool enableGeneratorPipe;
   private float m_Scountdown ;
    [SerializeField] private float m_timeDuration;
    private void Awake()
    {
        m_Scountdown = 1f;
        enableGeneratorPipe = false;
    }

    void Update()
    {
       
        if (enableGeneratorPipe == true)
        {
            m_Scountdown -= Time.deltaTime;
            if (m_Scountdown < 0)
            {
                GameObject tmp = Instantiate( PipePrefab, new Vector3(-2f, Random.Range(-10f, -8f), 0), Quaternion.identity);

                m_Scountdown = m_timeDuration;
                Destroy(tmp, 10f);
            }
        }
        
    }
   
}

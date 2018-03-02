using System.Collections;
using System.Collections.Generic;
using UnityEngine;


using UnityEngine.Events;


namespace GoneHome
{
    public class Goal : MonoBehaviour
    {
        public UnityEvent onTriggered;

        void onTriggerEnter(Collider other)
        {
            if (other.name == "Player")
            {
                onTriggered.Invoke();
            }
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
        public class PlayerMovement1 : MonoBehaviour
    {
        private CharacterController _controller;
        public int Speed;

        void Start()
        {
            _controller = GetComponent<CharacterController>();
        }

        void Update()
        {
            Vector3 move = new Vector3(Input.GetAxis("Horizontal"),0 , Input.GetAxis("Vertical"));
            _controller.Move(move * Time.deltaTime * Speed);
        
    }

    }
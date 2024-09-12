using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assembly_CSharp
{
    public class PlayerMovement
    {
        public void Jump(float jumpforse, Rigidbody rb)
        {
            rb.AddForce(Vector3.up * jumpforse);
        }

        public void Move(float moveforse, Rigidbody rb, Vector3 direction)
        {
            rb.velocity += direction * moveforse;
        }
        
        public void Rotate(float angle, Rigidbody rb)
        {

        }
    }
}

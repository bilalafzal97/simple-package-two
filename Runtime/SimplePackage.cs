using UnityEngine;

namespace simple_package_two.Runtime
{
    public class SimplePackage
    {
        public static string SayHelloTo(string name)
        {
            string sayHello = "Hello " + name;

            Debug.Log(sayHello);
            
            return sayHello;
        }
    }
}
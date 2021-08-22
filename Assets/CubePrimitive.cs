using UnityEngine;

// INHERITANCE
public class CubePrimitive : Primitive
{
    // Start is called before the first frame update
    void Start()
    {
        // INHERITANCE
        base.InitPrimitive();
    }
    
    // POLYMORPHISM
    protected override void PrimitiveClicked(){
        Debug.Log("[CubePrimitive] I was clicked : " + this.primitiveName);
    }

}

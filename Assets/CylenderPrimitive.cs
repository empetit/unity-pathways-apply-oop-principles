using UnityEngine;

// INHERITANCE
public class CylenderPrimitive : Primitive
{
    // Start is called before the first frame update
    void Start()
    {
        // INHERITANCE
        base.InitPrimitive();
    }
    
    // POLYMORPHISM
    public override void PrimitiveClicked(){
        Debug.Log("[CylenderPrimitive] I was clicked : " + this.primitiveName);
        
        var color =  Random.ColorHSV();

        // always blue-ish
        color.b = 255;
        
        this.SetColor( color );
    }
}

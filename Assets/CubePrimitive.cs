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
    public override void PrimitiveClicked(){
        Debug.Log("[CubePrimitive] I was clicked : " + this.primitiveName);

        var color =  Random.ColorHSV();
        
        // always green-ish
        color.g = 255;
        
        this.SetColor( color );
    }

}

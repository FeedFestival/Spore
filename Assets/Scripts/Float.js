var floatup;
var stopVelocity;
var rigBody;
public var object;

function Start(){
Physics.gravity = Vector3(0, -0.05, 0);
   	
    stopVelocity = Vector3(0,0,0);
    rigBody = rigidbody;
}
function Update(){
	//Debug.Log("-" + rigidbody.velocity );
	//rigidbody.velocity = constantVelocity;
	Debug.Log(floatup);
    if(Input.GetKeyDown(KeyCode.A)) {
        floatingup();
        floatup = true;
        } else {
       		 floatup = false;
        }
}
function floatingup(){
    rigidbody.AddForce(0,100,0);
    
    
    if (floatup == false){
    	yield WaitForSeconds(2);
    	//rigidbody.velocity = stopVelocity;
    }
    
    
}
using UnityEngine;

public class Manager : MonoBehaviour {

    [Header("Basic Settings")]

    public GameObject fish;
    public int numberOfFish = 20; // At the beggining
    public Vector3 goal;
    public Vector3 swimmingBounds = new Vector3(4.0f, 4.0f, 4.0f);
    public GameObject[] fishList;
  

    [Header("Specific Settings")]

    [Range(0.0f, 5.0f)]
    public float maxSpeed;  
    [Range(0.0f, 5.0f)]
    public float minSpeed;         
    [Range(0.0f, 10.0f)]
    public float distanceFromNeighbour; 
    [Range(0.0f, 3.0f)]
    public float avoidanceDistance; 
    [Range(0.0f, 7.0f)]
    public float speedOfRotation;   
    public bool randomGoal;   

    private float timeCounter = 0;
    private float speed;
    private float width;
    private float height;

    void Start() {

        speed = 5;
        width = 2;
        height = 2;


        fishList = new GameObject[numberOfFish];
        
        for (int i = 0; i < numberOfFish; ++i) {

            Vector3 pos = this.transform.position + new Vector3(Random.Range(-swimmingBounds.x, swimmingBounds.x),
                                                                Random.Range(0, swimmingBounds.x),
                                                                Random.Range(-swimmingBounds.x, swimmingBounds.x)); // Generating positions for fish
            fishList[i] = (GameObject)Instantiate(fish, pos, Quaternion.identity);
            fishList[i].GetComponent<Flock>().manager = this;
        }

        goal = this.transform.position;
    }

    void Update() {

        if(randomGoal){
        // Update to random goal
        if (Random.Range(0.0f, 100.0f) < 5.0f) {
            goal = this.transform.position + new Vector3(Random.Range(-swimmingBounds.x, swimmingBounds.x),
                                                            Random.Range(-swimmingBounds.x, swimmingBounds.x),
                                                            Random.Range(-swimmingBounds.x, swimmingBounds.x));
        }}
        else //Update goal, where the manager is
        {  

        timeCounter += Time.deltaTime*speed;
        float x = Mathf.Cos(timeCounter)*width;
        float y = Mathf.Sin(timeCounter)*height;
        float z = 0;
        goal = new Vector3(x,y,z);

           // goal = this.transform.position;
        }
    }
}

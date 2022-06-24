using UnityEngine;

public class Flock : MonoBehaviour {

    public Manager manager;
    float initialSpeed;
    bool foundBound = false;

    void Start() {
        initialSpeed = Random.Range(manager.minSpeed, manager.maxSpeed);
    }

    void Update() {

        Bounds bounds = new Bounds(manager.transform.position, manager.swimmingBounds*2.0f); //bounds in tank
        RaycastHit hit = new RaycastHit();
        Vector3 direction = manager.transform.position- transform.position;// to the center

        if (!bounds.Contains(transform.position))
        {
            foundBound = true;
        }
        else if(Physics.Raycast(transform.position, this.transform.forward * 10.0f, out hit)||Physics.Raycast(transform.position, this.transform.forward * (-10.0f), out hit)) {

            foundBound = true;
            direction = Vector3.Reflect(this.transform.forward, hit.normal); //reflecting vector
        } else {

            foundBound = false;
        }

        if (foundBound) {
            
            // turn 
            transform.rotation = Quaternion.Slerp(transform.rotation,
                                                  Quaternion.LookRotation(direction),
                                                  manager.speedOfRotation * Time.deltaTime);
        } else {

            // rules of the flock
            if (Random.Range(0.0f, 100.0f) < 30.0f) {
                FishBehaviour();
            }

            // speed
            if (Random.Range(0.0f, 100.0f) < 20.0f) {

                initialSpeed = Random.Range(manager.minSpeed, manager.maxSpeed);
            }

        }

        transform.Translate(0.0f, 0.0f, Time.deltaTime * initialSpeed);
    }

    void FishBehaviour() {

        GameObject[] flock;
        flock = manager.fishList;

        Vector3 averageCentre = new Vector3(0, 0, 0);
        Vector3 averageAvoidance = new Vector3(0, 0, 0);
        float groupNeighbourSpeed = 0.01f;
        float distanceFromNeighbour;
        int groupNeighbourSize = 0;

        foreach (GameObject f in flock) {

            if (f != this.gameObject) {

                distanceFromNeighbour = Vector3.Distance(f.transform.position, this.transform.position);
                if (distanceFromNeighbour<=manager.distanceFromNeighbour) { //grouping into neighbours

                    averageCentre += f.transform.position;
                    groupNeighbourSize++;

                    if (distanceFromNeighbour< manager.avoidanceDistance) { //avoiding

                        averageAvoidance = averageAvoidance+ (this.transform.position - f.transform.position);
                    }

                    Flock anotherFlock = f.GetComponent<Flock>();
                    groupNeighbourSpeed = groupNeighbourSpeed + anotherFlock.initialSpeed;
                }
            }
        }

        if (groupNeighbourSize > 0) {

            averageCentre = averageCentre / groupNeighbourSize + (manager.goal -this.transform.position);
            initialSpeed = groupNeighbourSpeed/ groupNeighbourSize; 

            Vector3 direction = (averageCentre + averageAvoidance)- transform.position; //setting direction

            if (direction != Vector3.zero) { // maybe already facing the right position
                transform.rotation = Quaternion.Slerp(transform.rotation,
                                                      Quaternion.LookRotation(direction),
                                                      Time.deltaTime *manager.speedOfRotation );
            }
        }
    }
}

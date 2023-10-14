# Drone Administration

**Drone Administration** is a project based on C# allowing RS485 communication in order to control and simulate a fleet of up to 40 drones for disaster response and observation. It monitors drone status, supports mission planning, and offers control over individual drones. It provides essential information like battery status, location, and mission planning with GPS routes. The software ensures easy, stress-free operation during disaster response situations. It also offers a map simulation of the drone and the drone positions and uses gRPC for communication with virtually simulated drone processes/threads.
<br/> <br/>
# Project Goals:
- [x] Operational Concept(GUI)
- [x] Analysis of Firefighting Strategies
- [x] Simulation of Deployments
- [x] Advanced Deployment Concepts(agriculture, environmental protection, non-military applications)
- [x] Hardware-Oriented Aspects(RS485 interfaces, sensor integration, inter-drone communication, and communication with the ground station)
<br/> <br/>
# Snippets
<img src="https://i.ibb.co/yfQfZJk/dronaAd2.png" title = "screenshot"> <br/> <br/> <img src="https://i.ibb.co/KGmhBV4/droneAd.png" title = "UI Program">
<br/> <br/>
# Feature List:
- [x] Manage a drone fleet of up to 40 drones
- [x] Keep a close watch on individual drone status, including battery, readiness, load, GPS coordinates, takeoff, landing, and other vital information through Real-time Monitoring
- [x] Send commands to individual drones or groups, facilitating emergency responses
- [x] Access photos and videos from observation drones
- [x] Intuitive GUI designed for ease of use, even in high-pressure disaster response scenarios
- [x] Simulate a virtual drone Simulation using a distributed communication system for realistic operation and testing purposes.
<br/> <br/>
# Testing Unit:
GUI Testing Path: 03_Phase02\Rami\DroneControl_Gesamt\DroneControl_Frontend\DroneControl_Frontend.sln
<br/> <br/>
LOGIC: 
The test is a console application. The test is a little tricky, because you only have to change some variables and observe the behavior of the simulation and different data.
A general form for testing was later added, to make it clearer.
<br/> <br/>
path: DroneContrl_Gesamt/phase 02 salomon/DroneControl_LogiC.sln

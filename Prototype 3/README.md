# [Project name: HomeCraft XR]

## Testing Plan for Interactive Prototype 3

This project is a traditional interior design and room layout planning tool.  

Using immersive 3D visualization, users can place, rotate, and throw furniture in real-world scale environments.  
The prototype integrates gesture-based interaction and controller interaction to enhance spatial awareness and design efficiency.

---

## Testing Objective

From the concept, the main assumption that requires validation is whether gesture-based furniture manipulation (grabbing, rotating, throwing) feels natural and intuitive for users.  
Additionally, it is important to test if real-time collision feedback effectively prevents incorrect object placements and increases user confidence.  
This test aims to discover how easily users can complete layout tasks, and whether visual and haptic feedback improve interaction accuracy.

---

## Testing Methodologies

This testing plan uses a combination of **Think-Aloud Protocol**, **Observation**, and **Post-task Interviews** to evaluate a Unity-based XR prototype.  
Participants will verbalize their thoughts while performing set tasks, while the facilitator observes behavior, records performance metrics, and collects qualitative feedback.

---

## Prototype Description / Requirements

The prototype was designed to test core spatial interaction concepts.  
It allows users to grab and move furniture, throwing objects using hand gestures.  
The scene also supports collision detection and visual feedback when objects overlap.

---

## Data Collection Method

During the testing process, I will:

- Observe participants’ actions and note difficulties or confusion points.  
- Record task completion time, number of errors, and number of attempts.  
- Use a post-task questionnaire with Likert-scale ratings (1–5) for usability, comfort, and realism.  
- Conduct short interviews to gather qualitative feedback about intuitiveness and immersion.  
- Save system logs (CSV export) that record object collisions, material changes, and environment toggles.

---

## Testing Setup

Testing will be conducted in a classroom using a **Meta Quest headset**.  

Each participant will be given **10–15 minutes** of hands-on time to complete the test tasks.  

**Required equipment:**
- Laptop with Unity prototype  
- Notebook for observation  
- Printed questionnaire  

**Participants:** 5 classmates (diverse familiarity with XR preferred).  
The facilitator will reset the scene between sessions to ensure consistent conditions.

---

## Testing Process (Including Schedule/Time)

### 1. Introduction & Consent (30 seconds)
- Explain the purpose of the test and confirm voluntary participation.  
- Briefly introduce the system (e.g., “You’ll use gestures to grab, move, and throw furniture”).

---

### 2. Demonstration & Familiarization (1 minute)
Allow participants to freely explore the environment for 1 minute to get comfortable.

---

### 3. Task 0 – Warm Up
**Task:** Grab a cube.

---

### 4. Task 1 – Upright the Fallen Chair (1.5 minutes)
**Instruction (Facilitator):**  
“You’ll see a chair that has fallen over on the floor. Please pick it up and place it upright.”

**Observation focus:**
- How easily the user can locate and grab the chair.  
- Whether rotation feels natural when reorienting the object.  
- How precisely the user places it upright without excessive adjustment.

---

### 5. Task 2 – Move the Bean Bag into the Room (1 minute)
**Instruction (Facilitator):**  
“Next to the chair, there’s a bean bag. Please move the bean bag into the bedroom and place it wherever you think looks good.”

**Observation focus:**
- The user’s understanding of object movement and navigation.  
- Whether they can accurately position large, soft-shaped furniture.  
- How comfortable the grab and release interactions feel.

---

### 6. Task 3 – Relocate the Colorful Vase (30 seconds)
**Instruction (Facilitator):**  
“Please walk into the bathroom. On the sink, there’s a colorful round vase. Pick it up and move it to the living room, then place it next to the light blue vase near the TV.”

**Observation focus:**
- User’s spatial awareness and object transport over distance.  
- The naturalness of walking or teleporting while holding an object.  
- Accuracy when placing the vase near another item.

---

### 7. Task 4 – Dispose of One Vase (1 minute)
**Instruction (Facilitator):**  
“Now, take one of the two vases and throw it into the trash bin next to the TV.”

**Observation focus:**
- How users interpret the throwing motion in XR (gesture tracking).  
- Whether collision detection and feedback feel realistic.  
- The user’s confidence and satisfaction with the throw interaction.

---

### 8. Post-task Interview & Questionnaire (2 minutes)
**Ask:**
- “Which task felt easiest or most natural to you?”  
- “Was there any task that felt awkward or difficult to control?”

Participants then complete a short usability questionnaire (1–5 scale).

---

### 9. Debrief (30 seconds)
Thank participants and explain how their feedback will be used to improve the prototype.

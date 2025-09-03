# Design Evaluation 1 Report
## Testing Plan for Interactive Prototype 1

This project is a traditional interior design and room layout planning application but implemented in XR.  
It allows users to place, scale, and rotate furniture in a real-world scale immersive environment.  
By adding real-time material switching, collision feedback, and environment lighting changes, it enhances both immersion and efficiency in spatial planning.

---

## Testing Objective

From my concept, I identified that the naturalness and usability of gesture-based furniture manipulation (grabbing, rotating, scaling) and collision feedback are assumptions that need validation.  

This test aims to discover whether users can intuitively understand and comfortably use these interactions, and whether collision feedback improves placement accuracy and confidence.

---

## Testing Methodologies

This testing plan will use a combination of **Think-Aloud protocol**, **structured observation**, and **short post-task interviews** to evaluate a Unity-based digital prototype.

---

## Prototype Description / Requirements

The prototype was designed to provide core interactions needed to evaluate my objectives.  

- Allows users to grab, rotate, and scale furniture  
- Switch materials  
- Receive collision feedback when objects overlap  
- Toggle between day/night environments  

Although not functionally complete, the prototype appears sufficiently complete for testing these interactions.

---

## Data Collection Method

During the testing process, I will observe participants while they complete tasks and ask them to think aloud.  
The entire process will have audio and video recordings as evidence.

---

## Testing Setup

The setup requires a laptop running the prototype and observation sheets.  

**Testing process (with schedule/time):**

1. Explain Prototype (30 seconds)  
2. Try to move (30 seconds)  
3. Drag and put exercise (2 mins)  
4. Question Time (2 mins)  

---

## Testing and Transcript Summary

### Transcript 1 – Tester: Sijian Xin
- **Q:** During your interaction, did you feel the lens sensitivity was too high?  
- **A:** No, it feels acceptable to me. The view moved smoothly and did not cause any discomfort.  
- **Q:** Was the prototype convenient to use and easy to understand?  
- **A:** Yes, it was clear enough, but I think additional on-screen hints or guidance would make it even easier for new users to get started.  
- **Q:** Do you have any suggestions for improvement?  
- **A:** I would suggest adding more types of furniture models, so users have greater variety to experiment with. Also, a button guide or visual instruction panel would help reduce confusion during first use.  

### Transcript 2 – Tester: Sean
- **Q:** Did you find the lens sensitivity too high?  
- **A:** No, the sensitivity felt acceptable and didn’t interfere with interaction.  
- **Q:** Was it convenient to use and easy to understand?  
- **A:** Yes, it was straightforward, I could pick it up quickly without much explanation.  
- **Q:** What improvements would you recommend?  
- **A:** I think it would be useful to add a backpack function, so users can collect, store, and later place furniture items back into the scene. This would give more flexibility and make the interaction closer to real room planning.  

### Transcript 3 – Tester: Zhun Li
- **Q:** Did the lens sensitivity feel too high?  
- **A:** No, it was actually very easy to use. The camera control felt natural.  
- **Q:** Was the prototype convenient and understandable?  
- **A:** Yes, it was simple and intuitive. I didn’t face difficulties in understanding the controls.  
- **Q:** What are your suggestions for improvement?  
- **A:** I think adding the ability to adjust the size of objects would be very helpful. Sometimes the furniture didn’t match the scale of the room, and resizing would make placement more accurate.  

### Transcript 4 – Tester: Trent Ng
- **Q:** Did you feel the lens sensitivity was too high?  
- **A:** No, it was usable and smooth. The interaction felt comfortable.  
- **Q:** Was the prototype convenient and easy to understand?  
- **A:** Yes, it was very easy to understand, I didn’t struggle with the interface.  
- **Q:** What suggestions would you make for improvement?  
- **A:** It could be more improved by making more controls to adjust the objects.  

### Transcript 5 – Tester: Tutor Ben
- **Q:** Did the lens sensitivity feel too high?  
- **A:** There’s not a big problem. It worked fine and didn’t disturb me.  
- **Q:** Was the prototype convenient and easy to understand?  
- **A:** Yes, it was very easy to understand. I could operate it with little difficulty.  
- **Q:** Do you have any improvement suggestions?  
- **A:** I would recommend adding texture or material editing functionality, so users can customize furniture more flexibly. This would make the experience feel more realistic.  

---

## Analysis & Conclusion

### Lens Sensitivity
All participants considered the lens sensitivity acceptable, with no significant usability issues. The interaction felt smooth and manageable.

### Ease of Use & Comprehension
Most participants found the system easy to use and understand, though some suggested adding additional hints or guides to further reduce the learning curve.

### Key Improvement Suggestions
1. **Furniture Assets**  
   - Several users noted that the current furniture options are limited and suggested adding more models for placement and testing.  

2. **Operation Guidance**  
   - Some users requested a button/interaction guide to assist first-time users.  

3. **Feature Expansion**  
   - Add a “backpack” function to store and retrieve furniture, enabling more flexible interactions.  
   - Provide more detailed object adjustment controls for each item, such as scaling and rotation.  
   - Introduce texture or material editing options when users select furniture, allowing for customization.  

### Conclusion
Overall, the prototype performed well in core interactions (grabbing, placing, rotating) and general usability, allowing users to quickly understand and complete tasks.  
However, improvements are needed in terms of content variety (number of furniture models) and feature expansion (backpack, scaling, texture editing).  
Future iterations should focus on enhancing user freedom and customization, while adding clear guidance to improve the onboarding experience.

---

## AI Statement

In this assignment, apart from using AI tools to assist with syntax corrections in C# files, all design concepts, interaction approaches, prototype implementation, and testing procedures are entirely original and independently completed by me.  
The use of AI was strictly limited to grammar checking and code refinement, without contributing to any creative decisions or core content generation.

---
## References

The Unity project also uses assets sourced externally:

- TV Stand model: [TurboSquid - TV Stand C4D Free](https://www.turbosquid.com/3d-models/tv-stand-c4d-free/1103887)  
- House model: [TurboSquid - 3D House](https://www.turbosquid.com/3d-models/3d-house-1628048)  

These assets were imported into Unity and are referenced in the project.  

---

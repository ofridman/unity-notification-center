# unity-notification-center

Notification Center allows for easy and powerful messaging between objects in Unity. 

An object can register as an observer and receive notifications of a certain type when they occur. 
When that notification type is posted elsewhere, all objects that registered as an observer for that notification type will receive a message that it has occurred, 
along with the associated data.

This system allows for objects to communicate their status and events with one another, 
without having to directly reference each object that receives the notification. An object can simply post an event when it occurs, 
and any interested party can register to receive notification when it happens.

Using a notification center will allow for dynamic and flexible coding practices. 

For example, a pinball game:

Can have a bumper that posts a notification when the ball collides with it. 
An object that keeps track of score can register to receive a notification when this event occurs, 
and increment the score accordingly without having to communicate directly with or keep track of the bumper. 
Another object can play a sound when it receives notification of a bumper impact. 
Another object can display a particle effect when it receives notification of a bumper impact. 
Other features can be added to respond to this event later on without having to modify the existing objects, 
because they independently choose to receive and act on the notification event.

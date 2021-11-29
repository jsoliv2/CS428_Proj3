# CS428_Proj3
This is the repository for my 3rd project in CS 428

## Build Instructions
- To build the Unity project, you need to use Unity version 2019.4.28f1 and VRTK version 4.
- You must install the latest version of Blender (2.93+) in order to have certain models imported into the project.
- You must also have build support for Android on Unity and have Developer Mode enabled on the Quest to run the app on it.
- Make sure that you have switched platforms to Android by clicking the "Switch Platform" button in File/Build Settings and that the minimum API level is Android 4.4 Kitkat (API Level 19) in Edit/Project Settings/Player/Other Settings.
- Before building the project to the Quest, make sure to enable CameraRigs.UnityXR and disable CameraRigs.SpatialSimulator in the scene heirarchy for each scene.
- From there, you can connect the Quest to your computer, make sure Unity has it selected, and finally build and run the project.
- You may need to allow the Quest to trust your computer and allow access to files.
- Once finished, the apk will be saved to your computer and the Quest, and the app will automatically run on the Quest.
- The built app can be found in the Apps menu under Unknown Sources, but if it doesn't show up, you may need to delete other apps to make room.
